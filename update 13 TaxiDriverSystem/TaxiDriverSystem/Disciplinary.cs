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
    public partial class Disciplinary : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public Disciplinary()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PopulateGridview();
            GetDriverID();
            SearchBar();
            cmbdisciplinaryRecord.Text = "";
        }
        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RelationshipDiscipline", con);
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
            SqlCommand cmd = new SqlCommand("select max (RDis_ID) from RelationshipDiscipline", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            DID = Convert.ToInt32(dt.Rows[0]["Column1"].ToString()) + DID;
            txtRID.Text = DID.ToString();
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

        private void Disciplinary_Load(object sender, EventArgs e)
        {
            PopulateGridview();
            GetDriverID();
            SearchBar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int DID = Convert.ToInt32(cmbDriver.SelectedValue);
            string Discipline = cmbdisciplinaryRecord.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("INSERT INTO RelationshipDiscipline(D_ID, Discipline) VALUES(" + DID + ", '" + Discipline + "')");
            MessageBox.Show("Disciplinary record is Added");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();
            SearchBar();
            cmbdisciplinaryRecord.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int RDID = Convert.ToInt32(txtRID.Text);
            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("DELETE from RelationshipDiscipline where RDis_ID = " + RDID + "");
            MessageBox.Show("Disciplinary record is Deleted");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();
            SearchBar();
            cmbdisciplinaryRecord.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int RDID = Convert.ToInt32(txtRID.Text);
            int DID = Convert.ToInt32(cmbDriver.SelectedValue);
            string Discipline = cmbdisciplinaryRecord.Text;

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("UPDATE RelationshipDiscipline set D_ID =" + DID + ", Discipline ='" + Discipline + "' where RDis_ID = " + RDID + "");
            MessageBox.Show("Disciplinary record is Updated");
            Database.CloseConnection();

            PopulateGridview();
            GetDriverID();
            SearchBar();
            cmbdisciplinaryRecord.Text = "";



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txtRID.Text = Convert.ToString(selectedRow.Cells["RDis_ID"].Value);
                cmbDriver.Text = Convert.ToString(selectedRow.Cells["D_ID"].Value);
                cmbdisciplinaryRecord.Text = Convert.ToString(selectedRow.Cells["Discipline"].Value);
               


            }
        }

        private void lblAddDriver_Click(object sender, EventArgs e)
        {

        }
    }
}
