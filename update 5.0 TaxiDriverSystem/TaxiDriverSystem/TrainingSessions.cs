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
    public partial class TrainingSessions : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public TrainingSessions()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSName.Text = "";
            date.Text = "";
            txtVenue.Text = "";
            expiredate.Text = "";
            txtRemark.Text = "";

           
            GetDriverID();
            SearchBar();
        }
        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TrainingSession", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            dataGridView1.DataSource = dt;
        }


        void GetDriverID()
        {
            int SID = 1;

            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select max (TS_ID) from TrainingSession", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            SID = Convert.ToInt32(dt.Rows[0]["Column1"].ToString()) + SID;
            txtSID.Text = SID.ToString();
        }


        void SearchBar()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select T_ID,Type from Training", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);
            cmbTType.DataSource = dt;
            cmbTType.DisplayMember = "Type";
            cmbTType.ValueMember = "T_ID";
            cmbTType.Enabled = true;


        }


       

        private void TrainingSessions_Load(object sender, EventArgs e)
        {
            PopulateGridview();
            GetDriverID();
            SearchBar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string SName = txtSName.Text;
            int TType = Convert.ToInt32(cmbTType.SelectedValue);
            string SDate = date.Text;
            string Venue = txtVenue.Text;
            string EDate = expiredate.Text;
            string Remark = txtRemark.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("INSERT INTO TrainingSession(SessionName, DateTime, Venue, ExpireDate, Remark, T_ID) VALUES('" + SName + "', '" + SDate + "','" + Venue + "','" + EDate + "','" + Remark + "'," + TType + ")");
            MessageBox.Show("Training Session is Added");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();
            SearchBar();

            txtSName.Text = "";
            date.Text = "";
            txtVenue.Text = "";
            expiredate.Text = "";
            txtRemark.Text = "";
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txtSID.Text = Convert.ToString(selectedRow.Cells["TS_ID"].Value);
                txtSName.Text = Convert.ToString(selectedRow.Cells["SessionName"].Value);
                cmbTType.Text = Convert.ToString(selectedRow.Cells["T_ID"].Value);
                date.Text = Convert.ToString(selectedRow.Cells["DateTime"].Value);
                txtVenue.Text = Convert.ToString(selectedRow.Cells["Venue"].Value);
                expiredate.Text = Convert.ToString(selectedRow.Cells["ExpireDate"].Value);
                txtRemark.Text = Convert.ToString(selectedRow.Cells["Remark"].Value);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int TSID = Convert.ToInt32(txtSID.Text);
            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("DELETE from TrainingSession where TS_ID = " + TSID + "");
            MessageBox.Show("Training Session is Deleted");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();
            SearchBar();

            txtSName.Text = "";
            date.Text = "";
            txtVenue.Text = "";
            expiredate.Text = "";
            txtRemark.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int TSID = Convert.ToInt32(txtSID.Text);
            string SName = txtSName.Text;
            int TType = Convert.ToInt32(cmbTType.SelectedValue);
            string SDate = date.Text;
            string Venue = txtVenue.Text;
            string EDate = expiredate.Text;
            string Remark = txtRemark.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("UPDATE TrainingSession set SessionName ='" + SName + "', DateTime ='" + SDate + "', Venue = '" + Venue + "', ExpireDate = '" + EDate + "', Remark = '" + Remark + "', T_ID =" + TType + " where TS_ID = " + TSID + "");
            MessageBox.Show("Training Session is Updated");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();
            SearchBar();

            txtSName.Text = "";
            date.Text = "";
            txtVenue.Text = "";
            expiredate.Text = "";
            txtRemark.Text = "";

        }
    }
}
