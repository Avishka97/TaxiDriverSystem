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
    public partial class Driver : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
       
        public Driver()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateGridview();
            GetDriverID();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDID.Text = "";
            txtDName.Text = "";
            txtDTelNo.Text = "";
            txtDNic.Text = "";
            txtDEmail.Text = "";
            txtDAddress.Text = "";
            txtDLNo.Text = "";
            GetDriverID();

        }

        private void drivertel1_TextChanged(object sender, EventArgs e)
        {
            if(txtDTelNo.Text.Length > 11)
            {
                txtDTelNo.ForeColor = Color.Red;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string DName = txtDName.Text;
            string DTelno = txtDTelNo.Text;
            string DNic = txtDNic.Text;
            string DEmail = txtDEmail.Text;
            string DAddress = txtDAddress.Text;
            string DLNo = txtDLNo.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("INSERT INTO Driver(Name, Telno, NIC, Email, Address, DL_NO) VALUES('" + DName + "', '" + DTelno + "','" + DNic + "','" + DEmail + "','" + DAddress + "','" + DLNo + "')");
            MessageBox.Show("Driver is Added");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            txtDName.Text = "";
            txtDTelNo.Text = "";
            txtDNic.Text = "";
            txtDEmail.Text = "";
            txtDAddress.Text = "";
            txtDLNo.Text = "";
        }


        //void SearchBar()
        //{
        //    con = new SqlConnection(ConnectionString);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select D_ID,Name from Driver", con);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    con.Close();

        //    DataRow row = dt.NewRow();
        //    row[0] = 0;
        //    row[1] = "Please select";
        //    dt.Rows.InsertAt(row, 0);
        //    comboDriverSearch.DataSource = dt;
        //    comboDriverSearch.DisplayMember = "Name";
        //    comboDriverSearch.ValueMember = "D_ID";
        //    comboDriverSearch.Enabled = true;


        //}

        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Driver", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            dataGridView1.DataSource = dt;
        }


        void GetDriverID()
        {
            int DID = 1;

            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select max (D_ID) from Driver", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            DID = Convert.ToInt32(dt.Rows[0]["Column1"].ToString()) + DID;
            txtDID.Text = DID.ToString();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int DID = Convert.ToInt32(txtDID.Text);
            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("DELETE from Driver where D_ID = " + DID + "");
            MessageBox.Show("Driver is Deleted");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            txtDName.Text = "";
            txtDTelNo.Text = "";
            txtDNic.Text = "";
            txtDEmail.Text = "";
            txtDAddress.Text = "";
            txtDLNo.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txtDID.Text = Convert.ToString(selectedRow.Cells["D_ID"].Value);
                txtDName.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                txtDTelNo.Text = Convert.ToString(selectedRow.Cells["Telno"].Value);
                txtDNic.Text = Convert.ToString(selectedRow.Cells["NIC"].Value);
                txtDEmail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                txtDAddress.Text = Convert.ToString(selectedRow.Cells["Address"].Value);
                txtDLNo.Text = Convert.ToString(selectedRow.Cells["DL_NO"].Value);


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int D_ID = Convert.ToInt32(txtDID.Text);
            string DName = txtDName.Text;
            string DTelno = txtDTelNo.Text;
            string DNic = txtDNic.Text;
            string DEmail = txtDEmail.Text;
            string DAddress = txtDAddress.Text;
            string DLNo = txtDLNo.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("UPDATE Driver set Name ='"+ DName +"', Telno ='"+ DTelno + "', NIC = '"+ DNic + "', Email = '"+ DEmail + "', Address = '"+ DAddress + "', DL_NO ='"+ DLNo + "' where D_ID = " + D_ID + "");
            MessageBox.Show("Driver is Updated");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            txtDName.Text = "";
            txtDTelNo.Text = "";
            txtDNic.Text = "";
            txtDEmail.Text = "";
            txtDAddress.Text = "";
            txtDLNo.Text = "";
        }

        private void comboDriverSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAddDriver_Click(object sender, EventArgs e)
        {

        }
    }
}
