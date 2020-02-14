using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SingaporeFloristNS.BLL;

namespace SingaporeFloristNS.Web.Admin
{
    public partial class SupplierOrder : System.Web.UI.Page
    {
        BllOrders bll = new BllOrders();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome | " + Session["Current_Logged"].ToString().ToUpper() + "!";
            lblAdmin.Text = Session["Current_Logged"].ToString();
            gvOrder.DataSource = bll.getAllOrders();
            gvOrder.DataBind();
        }

        protected void btnLogout_OnClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Web/Sign_In.aspx");
        }
    }
}