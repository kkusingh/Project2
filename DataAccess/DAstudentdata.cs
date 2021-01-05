using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Principal;

namespace DataAccess
{
    public class DAstudentdata
    {



        public static DataSet GetstudentdatausingDBwithconfig()
        {

            DataTable dt = new DataTable();
            DataSet dsGetstudentdatareport = new DataSet();

            SqlConnection cnn;



            var connectionstring = ConfigurationManager.ConnectionStrings["studentdataconnection_test"].ConnectionString;

              //var connectionstring = "Data Source=DESKTOP-FGA4NVE;Initial Catalog =master; Integrated Security=SSPI;";
            cnn = new SqlConnection(connectionstring);

            String sql = null;

            sql = "Select * from studentdata";

            cnn.Open();

            SqlCommand command;
            command = new SqlCommand(sql, cnn);

            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            dt.Load(dataReader);
            dsGetstudentdatareport.Tables.Add(dt);

            return dsGetstudentdatareport;

        }
    }
}

