using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace FreshFlowers.DAL
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