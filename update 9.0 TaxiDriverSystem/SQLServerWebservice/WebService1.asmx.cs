using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

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
            Status = "Insert Day Start Time";
            Database.CloseConnection();


            return Status;

        }
        [WebMethod]
        public string InsertJourneyEnd(string date, int DID)
        {

            Connection_Query Database = new Connection_Query();
            Database.OpenObject();
            Database.OpenConnection();
            Database.ExecuteQueries("UPDATE Journey set EndTime ='" + date + "' where D_ID = " + DID + "");
            Status = "Insert Day End Time";
            Database.CloseConnection();


            return Status;
        }

    }
}
