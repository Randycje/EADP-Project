using SingaporeFlorist.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FreshFlowerNS.DAL
{
    public class Orders
    {
        private String errMsg;
        DalConn dbConn = new DalConn();

        public DataSet AllOrders()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ds;

            SqlConnection conn = dbConn.GetConnection();
            ds = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Orders ");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }

            return ds;

        }
    }
}