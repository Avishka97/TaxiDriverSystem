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
    public partial class DriverAssignSession : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        public DriverAssignSession()
        {
            InitializeComponent();
        }

        private void DriverAssignSession_Load(object sender, EventArgs e)
        {
           
            DriverSearchBar();
            SessionSearchBar();
            PopulateGridview();
        }


        void PopulateGridview()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RelationshipTrainingSession", con);
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

            cmbDriverID.DataSource = dt;
            cmbDriverID.DisplayMember = "Name";
            cmbDriverID.ValueMember = "D_ID";

        }
        void SessionSearchBar()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select TS_ID,SessionName from TrainingSession", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            cmbSessionID.DataSource = dt;
            cmbSessionID.DisplayMember = "SessionName";
            cmbSessionID.ValueMember = "TS_ID";

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                SqlCommand sqlCmd = new SqlCommand("AllocationDriverToSessionAddorEit", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (dgvRow.Cells["txtRTID"].Value == DBNull.Value)//insert
                
                        sqlCmd.Parameters.AddWithValue("@RT_ID", 0);
                
                else//update
                
                        sqlCmd.Parameters.AddWithValue("@RT_ID", Convert.ToInt32(dgvRow.Cells["txtRTID"].Value));
                    sqlCmd.Parameters.AddWithValue("@TS_ID", Convert.ToInt32(dgvRow.Cells["cmbSessionID"].Value==DBNull.Value ? "0" : dgvRow.Cells["cmbSessionID"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@D_ID", Convert.ToInt32(dgvRow.Cells["cmbDriverID"].Value == DBNull.Value ? "0" : dgvRow.Cells["cmbDriverID"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@Remark",dgvRow.Cells["txtRemark"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRemark"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    DriverSearchBar();
                    SessionSearchBar();
                    PopulateGridview();
                
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells["txtRTID"].Value != DBNull.Value)
                {
                    if (MessageBox.Show("Are You Sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            con.Open();
                            SqlCommand sqlCmd = new SqlCommand("AllocationDriverToSessionDelete", con);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@RT_ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells["txtRTID"].Value));
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
