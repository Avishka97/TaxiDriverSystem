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
    public partial class Qalification : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public Qalification()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQID.Text = "";
            cmbQtype.Text = "";
            txtName.Text = "";
            dateTimePickerExpireDate.Text = "";
            GetDriverID();
        }

        private void txtQID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string QType = cmbQtype.Text;
            string QName = txtName.Text;
            string Date = dateTimePickerExpireDate.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("INSERT INTO Qualification(Type, Name, ExpireDate) VALUES('" + QType + "', '" + QName + "','" + Date + "')");
            MessageBox.Show("Qualification is Added");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            txtQID.Text = "";
            cmbQtype.Text = "";
            txtName.Text = "";
            dateTimePickerExpireDate.Text = "";

        }
        void GetDriverID()
        {
            int QID = 1;

            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select max (Q_ID) from Qualification", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            QID = Convert.ToInt32(dt.Rows[0]["Column1"].ToString()) + QID;
            txtQID.Text = QID.ToString();
        }

        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Qualification", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            dataGridView1.DataSource = dt;
        }

        private void Qalification_Load(object sender, EventArgs e)
        {
            GetDriverID();
            PopulateGridview();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int QID = Convert.ToInt32(txtQID.Text);
            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("DELETE from Qualification where Q_ID = " + QID + "");
            MessageBox.Show("Qualification is Deleted");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();
            
            cmbQtype.Text = "";
            txtName.Text = "";
            dateTimePickerExpireDate.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txtQID.Text = Convert.ToString(selectedRow.Cells["Q_ID"].Value);
                cmbQtype.Text = Convert.ToString(selectedRow.Cells["Type"].Value);
                txtName.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                dateTimePickerExpireDate.Text = Convert.ToString(selectedRow.Cells["ExpireDate"].Value);
                


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int Q_ID = Convert.ToInt32(txtQID.Text);
            string QType = cmbQtype.Text;
            string QName = txtName.Text;
            string Date = dateTimePickerExpireDate.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("UPDATE Qualification set Type ='" + QType + "', Name = '" + QName + "', ExpireDate = '" + Date + "' where Q_ID = " + Q_ID + "");
            MessageBox.Show("Driver is Updated");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            cmbQtype.Text = "";
            txtName.Text = "";
            dateTimePickerExpireDate.Text = "";

        }
    }
}
