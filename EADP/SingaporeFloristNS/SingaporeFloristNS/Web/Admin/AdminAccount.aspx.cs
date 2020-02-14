using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace FreshFlowers.Web.Admin
{
    public partial class AdminAccount : System.Web.UI.Page
    {
        AccountClass Account = new AccountClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome | " + Session["Current_Logged"].ToString().ToUpper() + "!";
            bind();
        }
        protected void bind()
        {
            gvUser.DataSource = Account.GetAccountDetails();
            gvUser.DataBind();
        }
        protected void btnLogout_OnClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Web/Sign_In.aspx");
        }
        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}