using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SingaporeFlorist.DAL;

namespace SingaporeFlorist
{
    public partial class ViewAllPO : System.Web.UI.Page
    {
        DALFreshFLowers prod = new DALFreshFLowers();
        COrder co = new COrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
        }

        protected void bind()
        {
            gv_PO.DataSource = prod.GetAllPOrders();
            gv_PO.DataBind();
        }

        protected void gv_PO_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedrow = gv_PO.SelectedIndex;
            GridViewRow row = gv_PO.Rows[selectedrow];

            co.InsertCOrder(row.Cells[1].Text, Convert.ToInt32(row.Cells[0].Text), "SingaporeFlorist", row.Cells[3].Text, DateTime.Now);

            Response.Redirect("ViewAllCO.aspx");
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductView.aspx");
        }
        protected void btn_Co_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCO.aspx");
        }
    }
}