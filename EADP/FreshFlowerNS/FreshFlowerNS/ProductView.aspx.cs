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
        Products prod = new Products();

        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
        }

        protected void bind()
        {
            gvProduct.DataSource = prod.GetAllProduct();
            gvProduct.DataBind();
        }
        protected void btnNewProd_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnPO_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllPO.aspx");
        }
    }
}