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
    public partial class ExpireQualificationandTraining : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public ExpireQualificationandTraining()
        {
            InitializeComponent();
        }

        private void ExpireQualificationandTraining_Load(object sender, EventArgs e)
        {
            PopulateGridview();
            PopulateGridview1();
        }
        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "DECLARE @SearchDate DATETIME SET @SearchDate = GETDATE() SELECT * FROM View_DriverexpireQualification WHERE [Expire Date] BETWEEN @SearchDate AND  DATEADD(DAY,30,@SearchDate) ORDER BY [Expire Date]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            dataGridView1.DataSource = dt;
            ;
        }
        void PopulateGridview1()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "DECLARE @SearchDate DATETIME SET @SearchDate = GETDATE() SELECT * FROM View_DriverExpiringTraining WHERE [Expire Date] BETWEEN @SearchDate AND  DATEADD(DAY,30,@SearchDate) ORDER BY [Expire Date]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            dataGridView2.DataSource = dt;
            ;
        }
    }
}
