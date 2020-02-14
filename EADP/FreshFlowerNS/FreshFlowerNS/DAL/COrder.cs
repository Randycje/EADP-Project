using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SingaporeFlorist.DAL
{
    public class COrder
    {
        private string _corderDesc, errMsg, _coPrice;
        private DateTime _coDate;
        private int _coQuantity;
        DalConn dbConn = new DalConn();

        public COrder(string ncorderDesc, DateTime ncoDate, int ncoQuantity, string ncoPrice)
        {
            _corderDesc = ncorderDesc;
            _coDate = ncoDate;
            _coQuantity = ncoQuantity;
            _coPrice = ncoPrice;
        }

        public COrder()
        {

        }

        public string coDesc
        {
            get { return _corderDesc; }
            set { _corderDesc = value; }
        }

        public DateTime coDate
        {
            get { return _coDate; }
            set { _coDate = value; }
        }

        public int coQuantity
        {
            get { return _coQuantity; }
            set { _coQuantity = value; }
        }

        public string coPrice
        {
            get { return _coPrice; }
            set { _coPrice = value; }
        }

        public int InsertCOrder(string coDesc, int productID, string cname, string cprice, DateTime coDate)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO COrder(corderDesc, corderQuantity, CompanyName, corderPrice, corderDate)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@coDesc, @coQuantity, @cname, @cprice, @coDate)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@coDesc", coDesc);
                sqlCmd.Parameters.AddWithValue("@coQuantity", productID);
                sqlCmd.Parameters.AddWithValue("@cname", cname);
                sqlCmd.Parameters.AddWithValue("@cprice", cprice);
                sqlCmd.Parameters.AddWithValue("@coDate", coDate);
                
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

        public DataSet GetCOrdersDetail()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet corderData;

            SqlConnection conn = dbConn.GetConnection();
            corderData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM COrder");
            
            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(corderData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return corderData;
        }
    }
}