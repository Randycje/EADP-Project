using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace FreshFlowers.Web
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        AccountClass Account = new AccountClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_OnClick(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Now;
            string username = "test";
            string name = tbName.Text;
            string password = tbPass.Text;
            string email = tbEmail.Text;
            string conPass = tbconPass.Text;

            if (password == conPass)
            {
                Account.InsertAccount(username, name, email, password, "User");
                //Email.SendRegister(tbEmail.ToString(), emailBody);

                Response.Redirect("~/Web/Sign_In.aspx");
            }
            else
            {
                Response.Write("<script>alert('Password Does Not Match.')</script>");
            }
        }
    }
}