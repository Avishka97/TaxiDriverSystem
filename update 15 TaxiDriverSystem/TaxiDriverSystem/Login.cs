using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;

namespace TaxiDriverSystem
{

    public partial class Login : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public static int DriverID;
        public static string Drivername;
        SQLWebServiceReference5.WebService1SoapClient client = null;
        public Login()
        {
            InitializeComponent();
            client = new SQLWebServiceReference5.WebService1SoapClient();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String username = txt_Username.Text;
            String Password = txt_Password.Text;
            if ( cmbrole.Text == "Admin")
            {
                Connection_Query Database = new Connection_Query();
                Database.Login(username, Password);
                txt_Password.Text = "";
                txt_Username.Text = "";
                                
            }
            else
            {
                string status = client.driverLogin(username, Password).ToString();
                if (status == "Login Succesfully")
                {
                    MessageBox.Show("Successfully loged in");
                    DriverID = client.DriverID(username, Password);
                    GetDriverID(DriverID);
                    //after successful it will redirect  to next page .  
                    drivermainpanel route = new drivermainpanel();
                    route.Show();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                     txt_Password.Text = "";
                    txt_Username.Text = "";
                }

            }
           
        }

        public string GetDriverID(int D_ID)
        {
           

            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from Driver where D_ID=@D_ID", con);
            cmd.Parameters.AddWithValue("@D_ID", D_ID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            Drivername = dt.Rows[0]["Name"].ToString();
            return Drivername;
        }
    }
}
