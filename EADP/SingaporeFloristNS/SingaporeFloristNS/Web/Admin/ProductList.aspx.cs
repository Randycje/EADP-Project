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
        DALStocks stocks = new DALStocks();
        POrders po = new POrders();

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
            gvProduct.DataSource = stocks.GetAllStocks();
            gvProduct.DataBind();
        }

        protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedrow = gvProduct.SelectedIndex;
            GridViewRow row = gvProduct.Rows[selectedrow];

            po.InsertPOrder(row.Cells[1].Text, Convert.ToInt32(row.Cells[0].Text), DateTime.Now, row.Cells[3].Text);

            Response.Redirect("POrdersList.aspx");
        }
    }
}