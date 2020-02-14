using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FreshFlowers.DAL
{
    public class PaymentNS
    {

        private String errMsg;
        DalConn dbConn = new DalConn();
        private string _bankNumber, _paymentDate, _paymentAmount, _ExpiryDate, _CVC;
        private int _InvoiceID, _paymentID;

        public PaymentNS(int apaymentID, string abankNumber, string aExpiryDate, string aCVC, string apaymentDate, string apaymentAmount, int aInvoiceID)
        {
            _bankNumber = abankNumber;
            _ExpiryDate = aExpiryDate;
            _CVC = aCVC;
            _paymentDate = apaymentDate;
            _paymentAmount = apaymentAmount;
            _InvoiceID = aInvoiceID;
            _paymentID = apaymentID;
        }

        public PaymentNS()
        {
            this._bankNumber = null;
            this._ExpiryDate = null;
            this._CVC = null;
            this._paymentDate = null;
            this._paymentAmount = null;
            this._InvoiceID = 0;
        }


        public string bankNumber
        {
            get { return _bankNumber; }
            set { _bankNumber = value; }
        }

        public string ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }

        public string CVC
        {
            get { return _CVC; }
            set { _CVC = value; }
        }

        public string paymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }
        public string paymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }
        public int InvoiceID
        {
            get { return _InvoiceID; }
            set { _InvoiceID = value; }
        }
        public int paymentID
        {
            get { return _paymentID; }
            set { _paymentID = value; }
        }

        public DataSet AllPayment()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ds;

            SqlConnection conn = dbConn.GetConnection();
            ds = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Payment ");

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

        public DataSet SelectPayment(int paymentID)
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ds;

            SqlConnection conn = dbConn.GetConnection();
            ds = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT p.*, i.InvoiceAmount, i.InvoiceDate FROM Payment p");
            sql.AppendLine("INNER JOIN Invoice i on i.InvoiceID = p.InvoiceID");
            sql.AppendLine("WHERE p.InvoiceID = @paraID");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("paraID", paymentID);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }

            return ds;
        }

        public int InsertPayment(string bankNumber, string CVC , string ExpiryDate,  DateTime paymentDate, string paymentAmount, int InvoiceID)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Payment(bankNumber, CVC, ExpiryDate, paymentDate, paymentAmount, InvoiceID)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@bankNumber,@ExpiryDate, @CVC, @paymentDate, @paymentAmount, @InvoiceID)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@bankNumber", bankNumber);
                sqlCmd.Parameters.AddWithValue("@CVC", CVC);
                sqlCmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                sqlCmd.Parameters.AddWithValue("@paymentDate", paymentDate);
                sqlCmd.Parameters.AddWithValue("@paymentAmount", paymentAmount);
                sqlCmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);

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