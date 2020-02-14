using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FreshFlowers.DAL
{
    public class POrders
    {
        private string _porderDesc, _user;
        private DateTime _pDate;
        private int purcQuantity;
        DalConn dbConn = new DalConn();
        private String errMsg;
        Boolean approved = true;

        public POrders(string aporderDesc, DateTime aporderDate, string auser)
        {
            _porderDesc = aporderDesc;
            _pDate = aporderDate;
            _user = auser;
        }
        public POrders()
        {
            this._pDate = DateTime.Now;
            this._porderDesc = null;
        }

        public string porderDesc
        {
            get { return _porderDesc; }
            set { _porderDesc = value; }
        }

        public DateTime porderDate
        {
            get { return _pDate; }
            set { _pDate = value; }
        }

        public string user
        {
            get { return _user; }
            set { _user = value; }
        }

        public int InsertPOrder(string porderDesc, int porderQuantity, DateTime porderDate, string poprice)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO PurchaseOrder(purcOrderDesc, purcOrderQuantity, purcOrderDate, purcOrderPrice)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@porderDesc, @porderQuantity, @porderDate, @porderPrice)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@porderDesc", porderDesc);
                sqlCmd.Parameters.AddWithValue("@porderQuantity", porderQuantity);
                sqlCmd.Parameters.AddWithValue("@porderDate", porderDate);
                sqlCmd.Parameters.AddWithValue("@porderPrice", poprice);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public DataSet GetPOrdersDetail()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet porderData;

            SqlConnection conn = dbConn.GetConnection();
            porderData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM PurchaseOrder");
            //sql.AppendLine("FROM PurchaseOrder");
            //sql.AppendLine("INNER JOIN author a ON a.id = b.authorId");
            //sql.AppendLine("INNER JOIN publisher p ON p.id = b.publisherId");
            //sql.AppendLine("LEFT OUTER JOIN images i ON i.id = b.bookCoverId");
            //sql.AppendLine("WHERE id = @osepId");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(porderData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return porderData;
        }

        public int deletePOrder(int id)
        {

            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;


            sql = new StringBuilder();
            sql.AppendLine("DELETE FROM purchaseOrder");
            sql.AppendLine(" ");
            sql.AppendLine("WHERE purcOrderID=@id");
            SqlConnection conn = dbConn.GetConnection();
            try
            {
                conn.Open();
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@id", id);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public int porderUpdate(DateTime date, int id)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;


            sql = new StringBuilder();
            sql.AppendLine("UPDATE purchaseOrder");
            sql.AppendLine(" ");
            sql.AppendLine("SET purcOrderDate=@date");
            sql.AppendLine(" ");
            sql.AppendLine("WHERE purcOrderID=@id");
            SqlConnection conn = dbConn.GetConnection();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@date", date);
                sqlCmd.Parameters.AddWithValue("@id", id);
                //sqlCmd.Parameters.AddWithValue("@status", status);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;

        }

        public int InsertPOrderv2(string porderDesc, int porderQuantity, DateTime porderDate)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO PurchaseOrder(purcOrderDesc, purcOrderQuantity, purcOrderDate)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@porderDesc, @porderQuantity, @porderDate)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@porderDesc", porderDesc);
                sqlCmd.Parameters.AddWithValue("@porderQuantity", porderQuantity);
                sqlCmd.Parameters.AddWithValue("@porderDate", porderDate);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}