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
    public partial class DriverSearch : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public DriverSearch()
        {
            InitializeComponent();
        }

        private void DriverSearch_Load(object sender, EventArgs e)
        {
            
            SearchBar();
            cmbSearch_SelectedIndexChanged(null,null);
            PopulateGridview();
        }
        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from View_DriverQualificationandTraining", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            dataGridView1.DataSource = dt;
        }

        public DataTable ViewGrid(string Query_)
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            return dt;
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
            cmbSearch.DataSource = dt;
            cmbSearch.DisplayMember = "Name";
            cmbSearch.ValueMember = "D_ID";
            cmbSearch.Enabled = true;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SearchBar();
            PopulateGridview();
            
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmbSearch.SelectedValue.ToString(),out val);
            string query = "select * from View_DriverQualificationandTraining where [Driver No] =" + val + "";
            DataTable GridView = ViewGrid(query);
            dataGridView1.DataSource = GridView;
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
          

        }
    }
}
