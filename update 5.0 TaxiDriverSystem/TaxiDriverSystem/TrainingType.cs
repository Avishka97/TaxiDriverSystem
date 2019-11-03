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
    public partial class TrainingType : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public TrainingType()
        {
            InitializeComponent();
        }

       
        void GetDriverID()
        {
            int TID = 1;

            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select max (T_ID) from Training", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            TID = Convert.ToInt32(dt.Rows[0]["Column1"].ToString()) + TID;
            txtTID.Text = TID.ToString();
        }

        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Training", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            dataGridView1.DataSource = dt;
        }

        private void TrainingType_Load(object sender, EventArgs e)
        {
            PopulateGridview();
            GetDriverID();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GetDriverID();
            txtTType.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string TrainingType = txtTType.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("INSERT INTO Training(Type) VALUES('" + TrainingType + "')");
            MessageBox.Show("Training Type is Added");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            txtTType.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txtTID.Text = Convert.ToString(selectedRow.Cells["T_ID"].Value);
                txtTType.Text = Convert.ToString(selectedRow.Cells["Type"].Value);



            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int TID= Convert.ToInt32(txtTID.Text);

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("DELETE from Training where T_ID = " + TID + "");
            MessageBox.Show("Training Type is Deleted");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            txtTType.Text = "";



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int TID = Convert.ToInt32(txtTID.Text);
            string TrainingType = txtTType.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("UPDATE Training set Type ='" + TrainingType + "' where T_ID = " + TID + "");
            MessageBox.Show("Training Type is Updated");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();

            txtTType.Text = "";
        }
    }
}
