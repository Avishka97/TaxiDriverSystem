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
using LiveCharts;

namespace TaxiDriverSystem
{
    public partial class Predict : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        SQLWebServiceReference5.WebService1SoapClient client = null;
        public Predict()
        {
            InitializeComponent();
            client = new SQLWebServiceReference5.WebService1SoapClient();
        }

        private void Predict_Load(object sender, EventArgs e)
        {
            SearchBar();
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
            cmbDriver.DataSource = dt;
            cmbDriver.DisplayMember = "Name";
            cmbDriver.ValueMember = "D_ID";
            cmbDriver.Enabled = true;


        }

        private void cmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmbDriver.SelectedValue.ToString(), out val);
            if (val > 0)
            {
                DriverChart();
            }

        }

        void DriverChart()
        {
            int val;
            Int32.TryParse(cmbDriver.SelectedValue.ToString(), out val);
            chart1.Series["PerDay"].YValueMembers = "Hourswork_PerDay";

          
            chart1.Series["PerWeek"].YValueMembers = "Hourswork_PerWeek";

            chart1.DataSource = client.HoursWorkPredict(val);;
            chart1.DataBind();
        }
        

    }
}
