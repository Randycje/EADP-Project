using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using SingaporeFlorist.DAL;

namespace FreshFlowerNS.DAL
{
    public class Invoice
    {
        private string connStr = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;
        DalConn db = new DalConn();
        private string _invoiceDate, _CompanyName;
        private int _invoiceAmount, _DeliveryID, _corderID, _DeliveryFee;

        public Invoice(string aInvoiceDate, int aInvoiceAmount, string aCompanyName, int aDeliveryID, int acorderID, int aDeliveryFee)
        {
            _invoiceAmount = aInvoiceAmount;
            _invoiceDate = aInvoiceDate;
            _CompanyName = aCompanyName;
            _DeliveryID = aDeliveryID;
            _corderID = acorderID;
            _DeliveryFee = aDeliveryFee;

        }

        public Invoice()
        {
            this._invoiceAmount = 0;
            this._invoiceDate = null;
            this._CompanyName = null;
            this._DeliveryID = 0;
            this._corderID = 0;
            this._DeliveryFee = 0;
        }

        public int invoiceAmount
        {
            get { return _invoiceAmount; }
            set { _invoiceAmount = value; }
        }

        public string invoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        public int DeliveryID
        {
            get { return _DeliveryID; }
            set { _DeliveryID = value; }
        }

        public int corderID
        {
            get { return _corderID; }
            set { _corderID = value; }
        }

        public int DeliveryFee
        {
            get { return _DeliveryFee; }
            set { _DeliveryFee = value; }
        }

        private String errMsg;

        public DataSet AllInvoice()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet invoiceData;

            SqlConnection conn = db.GetConnection();
            invoiceData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT InvoiceID, InvoiceDate, InvoiceAmount FROM Invoice ");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(invoiceData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return invoiceData;
        }
        public int CreateInvoice(int invoiceAmount, string invoiceDate, string CompanyName, int DeliveryFee)
        {
            int output = 0;
            string queryStr = "INSERT INTO Invoice(invoiceAmount, invoiceDate, CompanyName, DeliveryFee)" +
                              "VALUES(@invoiceAmount, @invoiceDate, @CompanyName, @DeliveryFee)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceAmount", invoiceAmount);
                    cmd.Parameters.AddWithValue("@invoiceDate", invoiceDate);
                    cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                    cmd.Parameters.AddWithValue("@DeliveryFee", DeliveryFee);

                    output += cmd.ExecuteNonQuery();
                }
            }
            return output;
        }
    }
}