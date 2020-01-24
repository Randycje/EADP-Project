using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SingaporeFlorist.BLL;

namespace SingaporeFlorist
{
    public partial class Index : System.Web.UI.Page
    {
        Stock stocks = new Stock();

        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
        }

        protected void bind()
        {
            gvProduct.DataSource = stocks.getAllStocks();
            gvProduct.DataBind();
        }
    }
}