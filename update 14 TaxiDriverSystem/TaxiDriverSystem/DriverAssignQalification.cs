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
    public partial class DriverAssignQalification : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public DriverAssignQalification()
        {
            InitializeComponent();
        }

        private void DriverAssignQalification_Load(object sender, EventArgs e)
        {
            DriverSearchBar();
            QualificationSearchBar();
            PopulateGridview();
        }

        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RelationshipQualification", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        void DriverSearchBar()
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

            cmbD_ID.DataSource = dt;
            cmbD_ID.DisplayMember = "Name";
            cmbD_ID.ValueMember = "D_ID";

        }
        void QualificationSearchBar()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Q_ID,Name from Qualification", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            cmbQID.DataSource = dt;
            cmbQID.DisplayMember = "Name";
            cmbQID.ValueMember = "Q_ID";

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("DriverQualificationInsertOrEdit", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvRow.Cells["txtRQ_ID"].Value == DBNull.Value)//insert

                    sqlCmd.Parameters.AddWithValue("@RQ_ID", 0);

                else//update

                    sqlCmd.Parameters.AddWithValue("@RQ_ID", Convert.ToInt32(dgvRow.Cells["txtRQ_ID"].Value));

                sqlCmd.Parameters.AddWithValue("@D_ID", Convert.ToInt32(dgvRow.Cells["cmbD_ID"].Value == DBNull.Value ? "0" : dgvRow.Cells["cmbD_ID"].Value.ToString()));
                sqlCmd.Parameters.AddWithValue("@Q_ID", Convert.ToInt32(dgvRow.Cells["cmbQID"].Value == DBNull.Value ? "0" : dgvRow.Cells["cmbQID"].Value.ToString()));
                sqlCmd.ExecuteNonQuery();
                DriverSearchBar();
                QualificationSearchBar();
                PopulateGridview();

            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells["txtRQ_ID"].Value != DBNull.Value)
                {
                    if (MessageBox.Show("Are You Sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            con.Open();
                            SqlCommand sqlCmd = new SqlCommand("DriverQualificationDelete", con);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@RQ_ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells["txtRQ_ID"].Value));
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                    else
                        e.Cancel = true;
                }

                else
                    e.Cancel = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
