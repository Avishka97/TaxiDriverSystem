using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerWebservice
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public string Status;
        public int DID;
        string ConnectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string InsertStartDay(string date , int DID)
        {

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("INSERT INTO Day(StratTime, D_ID) VALUES('" + date + "', " + DID + ")");
            Status = "Insert Day Start Time";
            Database.CloseConnection();

            
            return Status;

        }
        [WebMethod]
        public string InsertEndDay(string date, int DID)
        {

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("UPDATE Day set EndTime ='" + date + "' where D_ID = "+DID+"");
            Status = "Insert Day End Time";
            Database.CloseConnection();


            return Status;
        }

        [WebMethod]
        public string InsertJourneyStart(string date, int DID)
        {

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("INSERT INTO Journey(StartTime, D_ID) VALUES('" + date + "', " + DID + ")");
            Status = "Insert Journey Start Time";
            Database.CloseConnection();


            return Status;

        }
        [WebMethod]
        public string InsertJourneyEnd(string date, int DID)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand("DriverEndJourney", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@END_DATE", date);
                sqlCmd.Parameters.AddWithValue("@J_ID", DID);
                sqlCmd.ExecuteNonQuery();
                Status = "Insert Journey End Time";
                con.Close();


                return Status;
            }
        }

        [WebMethod]
        public int JourneyID(string date, int D_ID)
        {
            

            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select J_ID from Journey where D_ID=" + D_ID + " and StartTime ='" + date + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            DataRow row1 = dt.Rows[dt.Rows.Count - 1];
            DID = Convert.ToInt32(dt.Rows[0]["J_ID"].ToString());

            return DID;


        }

    }
}
