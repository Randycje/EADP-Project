﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowers.DAL;

namespace FreshFlowers.Web.Account
{
    public partial class ProductCatalog : System.Web.UI.Page
    {
        DALStocks prod = new DALStocks();

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
            gvProduct.DataSource = prod.GetAllStocks();
            gvProduct.DataBind();
        }
    }
}