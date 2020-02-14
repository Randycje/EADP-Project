using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace FreshFlowers.Web.Admin
{
    public partial class POrdersList : System.Web.UI.Page
    {
        POrders purcOrder = new POrders();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome | " + Session["Current_Logged"].ToString().ToUpper() + "!";
            bind();
        }
        protected void btnLogout_OnClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Web/Sign_In.aspx");
        }

        protected void bind()
        {
            poGrid.DataSource = purcOrder.GetPOrdersDetail();
            poGrid.DataBind();
        }

        protected void btn_NewPO_Onclick(object sender, EventArgs e)
        {
            Response.Redirect("~/Web/Admin/AddPOrder.aspx");
        }
    }
}