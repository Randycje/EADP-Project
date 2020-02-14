using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SingaporeFlorist.DAL
{
    public class DalConn
    {
        public SqlConnection GetConnection()
        {
            SqlConnection dbConn;
            string connString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;

            dbConn = new SqlConnection(connString);

            return dbConn;
        }
    }
}