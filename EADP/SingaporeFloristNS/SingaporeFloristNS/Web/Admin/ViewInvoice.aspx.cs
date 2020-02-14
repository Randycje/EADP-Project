using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;
using SingaporeFloristNS.DAL;
using System.Text;

namespace SingaporeFloristNS.Web.Admin
{
    public partial class ViewInvoice : System.Web.UI.Page
    {
        DalInvoice inv = new DalInvoice();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome | " + Session["Current_Logged"].ToString().ToUpper() + "!";
            bind();
        }

        protected void bind()
        {
            gv_Invoice.DataSource = inv.getAllInvoice();
            gv_Invoice.DataBind();
        }

        protected void gv_Invoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gv_Invoice.SelectedRow;
            StringBuilder page = new StringBuilder();
            page.Append("ViewPayment.aspx?id=");
            page.Append(row.Cells[0].Text);
            page.Append("&PaymentAmount=");
            page.Append(row.Cells[2].Text);
            Response.Redirect(page.ToString());
        }

        protected void btnLogout_OnClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Web/Sign_In.aspx");
        }
    }
}