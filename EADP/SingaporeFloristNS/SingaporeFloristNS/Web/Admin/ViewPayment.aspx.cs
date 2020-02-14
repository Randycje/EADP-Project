using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace SingaporeFloristNS
{
    public partial class ViewPayment : System.Web.UI.Page
    {
        PaymentNS pay = new PaymentNS();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblAmount.Text = Request.QueryString["PaymentAmount"];
                lblInvoiceID.Text = Request.QueryString["Id"];
            }
        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            string bankNumber = tbbankNumber.Text;
            //string paymentDate = tbpaymentDate.Text;
            string ExpiryDate = tbExpiry.Text;
            string CVC = tbCVC.Text;
            string paymentAmount = lblAmount.Text;
            int InvoiceID = Convert.ToInt32(lblInvoiceID.Text);

            pay.InsertPayment(bankNumber, CVC, ExpiryDate, DateTime.Now, paymentAmount, InvoiceID);
            Response.Write("<script>alert('Payment Successful')</script>");
            Response.Redirect("Thankyou.aspx");
        }
       

    }
}