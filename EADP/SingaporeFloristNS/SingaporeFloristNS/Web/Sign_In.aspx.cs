using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace FreshFlowers.Web
{

    public partial class Sign_In : System.Web.UI.Page
    {
        AccountClass Account = new AccountClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text.ToLower();
            string password = tb_Password.Text;

            string check = Account.check(name, password);

            if (check == "User" || check == "Admin")
            {
                Session["Current_Logged"] = tb_Name.Text;

                if (check == "Admin")
                {
                    Response.Redirect("~/Web/Admin/ProductList.aspx");
                }
                else
                {
                    Response.Redirect("~/Web/Account/Dashboard.aspx");
                }
            }
        }
        protected void btn_Back_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }
    }
}