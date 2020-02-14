using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using FreshFlowerNS.DAL;

namespace FreshFlowerNS
{
    public partial class CreateInvoice : System.Web.UI.Page
    {
        DAL.Invoice dataLayer = new DAL.Invoice();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblDeliveryDate.Text = Request.QueryString["DeliveryDate"];
                lblStatus.Text = Request.QueryString["DeliveryStatus"];
            }

            Bind();

            string strConnectionString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "SELECT co.corderID, c.CompanyName, c.CompanyAddress FROM Delivery d ";
            strCommandText += "JOIN Company c ON c.CompanyName = d.CompanyName";
            strCommandText += " JOIN COrder co ON co.corderID = d.corderID";

            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblCompany.Text = reader["CompanyName"].ToString();
                lblBillAdd.Text = reader["CompanyAddress"].ToString();
            }

            reader.Close();
            myConnect.Close();
        }

        protected void Bind()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "SELECT corderID, corderDesc, corderPrice, corderQuantity FROM COrder WHERE corderID = @id";

            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters["id"].Value = Request.QueryString["Id"];
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            grdOrders.DataSource = dt;
            grdOrders.DataBind();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string CompanyName = lblCompany.Text;
            string InvoiceDate = tbInvoiceDate.Text;
            string InvoiceAmount = tbTotalPrice.Text;
            string DeliveryFee = tbFee.Text;

            dataLayer.CreateInvoice(Convert.ToInt32(InvoiceAmount), InvoiceDate, CompanyName, Convert.ToInt32(DeliveryFee));
            Response.Redirect("ThankYou.aspx");
        }

        decimal price=0 ;
        int qty =0;
        decimal sum = 0;
        protected void grdOrders_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                price += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "corderPrice"));
                qty += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "corderQuantity"));
                sum = price * qty;
            }
            lblSubtotalPrice.Text = sum.ToString();
        }

        protected void btnInvoice_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delivery.aspx");
        }
    }
}