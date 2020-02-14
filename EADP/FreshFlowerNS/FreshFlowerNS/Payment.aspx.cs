using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FreshFlowerNS.BLL;

namespace FreshFlowerNS
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
                BindPayment();
        }

        private void BindPayment()
        {
            Payments payment = new Payments();
            DataSet ds;
            ds = payment.GetALLPayment();
            gvViewPayment.DataSource = ds;
            gvViewPayment.DataBind();
        }
    }
}