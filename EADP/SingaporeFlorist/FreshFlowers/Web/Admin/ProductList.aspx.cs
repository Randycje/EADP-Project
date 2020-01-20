using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace FreshFlowers.Web.Admin
{
    public partial class ProductList : System.Web.UI.Page
    {
        Product prod = new Product();

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
            gvProduct.DataSource = prod.GetProductDetails();
            gvProduct.DataBind();
        }
        protected void btnNewProd_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Web/Admin/InsertProduct.aspx");
        }
    }
}