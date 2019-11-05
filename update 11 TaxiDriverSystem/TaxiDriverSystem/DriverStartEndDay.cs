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
    public partial class DriverStartEndDay : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        SQLWebServiceReference3.WebService1SoapClient client = null;
        public DriverStartEndDay()
        {
            InitializeComponent();
            client = new SQLWebServiceReference3.WebService1SoapClient();
        }

        private void DriverStartEndDay_Load(object sender, EventArgs e)
        {
            SearchBar();
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            DateTime StartDate = DateTime.Now;
            string Date = StartDate.ToString();
            int DID = Convert.ToInt32(cmbDID.SelectedValue);
            
            lblMessage.Text=client.InsertStartDay(Date, DID).ToString();
            btnStartTime.Enabled =false ;

        }

        void SearchBar()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select D_ID,Name from Driver", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);
            cmbDID.DataSource = dt;
            cmbDID.DisplayMember = "Name";
            cmbDID.ValueMember = "D_ID";
            cmbDID.Enabled = true;


        }

        private void btnEndTime_Click(object sender, EventArgs e)
        {
            DateTime EndDate = DateTime.Now;
            string Date = EndDate.ToString();
            int DID = Convert.ToInt32(cmbDID.SelectedValue);

            lblMessage.Text = client.InsertEndDay(Date, DID).ToString();
        }

        private void btnJourney_Click(object sender, EventArgs e)
        {
            DriverStartEndJourney login = new DriverStartEndJourney();
            login.ShowDialog();
        }
    }
}
