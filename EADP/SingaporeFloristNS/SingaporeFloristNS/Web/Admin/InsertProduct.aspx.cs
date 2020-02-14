using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace FreshFlowers.Web.Admin
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        Product prod = new Product();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome | " + Session["Current_Logged"].ToString().ToUpper() + "!";
        }
        protected void btnLogout_OnClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Web/Sign_In.aspx");
        }
        protected void btnInsert_OnClick(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string description = tbDescription.Text;
            string unitPrice = tbUnitPrice.Text;
            string stock = tbStocks.Text;
            string fileName = "";

            if (imageUpload.HasFile)
            {
                fileName = imageUpload.FileName;
                string filePath = "~/Web/Admin/ProductImages/" + imageUpload.FileName;
                imageUpload.SaveAs(Server.MapPath(filePath));
            }

            prod.InsertProduct(name, description, unitPrice, Convert.ToInt32(stock), imageUpload.ToString());
            Response.Write("<script>alert('Product Added.')</script>");
            Response.Redirect("~/Web/Admin/ProductList.aspx");
        }
        protected void btnBack_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Web/Admin/ProductList.aspx");
        }
    }
}