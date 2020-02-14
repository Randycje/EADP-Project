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
    public class Delivery
    {
        DalConn db = new DalConn();

        private String _DeliveryDate, _DeliveryStatus, _CompanyName;
        private int _DeliveryID, _corderID;

        public Delivery(int aDeliveryID, string aDeliveryDate, string aDeliveryStatus,  string aCompanyName, int acorderID)
        {
            _DeliveryDate = aDeliveryDate;
            _DeliveryStatus = aDeliveryStatus;
            _CompanyName = aCompanyName;
            _corderID = acorderID;
            _DeliveryID = aDeliveryID;

        }

        public Delivery()
        {
            this._DeliveryDate = null;
            this._DeliveryStatus = null;
            this._CompanyName = null;
            this._corderID = 0;
        }

        public string DeliveryDate
        {
            get { return _DeliveryDate; }
            set { _DeliveryDate = value; }
        }

        public string DeliveryStatus
        {
            get { return _DeliveryStatus; }
            set { _DeliveryStatus = value; }
        }

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        public int corderID
        {
            get { return _corderID; }
            set { _corderID = value; }
        }

        public int DeliveryID
        {
            get { return _DeliveryID; }
            set { _DeliveryID = value; }
        }

        private String errMsg;

        public DataSet AllDelivery()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet deliveryData;

            SqlConnection conn = db.GetConnection();
            deliveryData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Delivery ");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(deliveryData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return deliveryData;
        }

        public int InsertDelivery(string DeliveryDate, string DeliveryStatus, int corderID, string CompanyName)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Delivery (DeliveryDate, DeliveryStatus, corderID, CompanyName)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@DeliveryDate, @DeliveryStatus, @corderID, @CompanyName)");
            SqlConnection conn = db.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@DeliveryDate", DeliveryDate);
                sqlCmd.Parameters.AddWithValue("@DeliveryStatus", DeliveryStatus);
                sqlCmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                sqlCmd.Parameters.AddWithValue("@corderID", corderID);
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

        /*public DataSet GetDelivery()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet deliveryData;

            SqlConnection conn = dbcon.GetConnection();
            deliveryData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Delivery");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(deliveryData);
            }
            catch(Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return deliveryData;
        }*/
    }
}