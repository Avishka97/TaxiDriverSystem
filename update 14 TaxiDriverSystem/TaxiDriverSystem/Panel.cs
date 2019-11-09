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
    
    public partial class Panel : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public Panel()
        {
            InitializeComponent();
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P)", chartpoint.Y, chartpoint.Participation);

        private void Panel_Load(object sender, EventArgs e)
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
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand sqlCmd = new SqlCommand("AccidentPIEChart", con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@D_ID", val);
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt); 

            chart1.Series["Driver"].XValueMember = "Type";
            chart1.Series["Driver"].YValueMembers = "Accidents";
            chart1.DataSource = dt;
            chart1.DataBind();
        }
     
    }
}
