using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;

namespace FreshFlowerNS
{
    public partial class Delivery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                bindGridView();
            }
        }

        protected void bindGridView()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "SELECT d.* , CompanyAddress FROM Delivery d ";
            strCommandText += " JOIN Company c ON c.CompanyName = d.CompanyName; ";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            gvDelivery.DataSource = dt;
            gvDelivery.DataBind();
        }

        protected void gvDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvDelivery.SelectedRow;
            StringBuilder page = new StringBuilder();
            page.Append("CreateInvoice.aspx?id=");
            page.Append(row.Cells[1].Text);
            page.Append("&DeliveryDate=");
            page.Append(row.Cells[2].Text);
            page.Append("&DeliveryStatus=");
            page.Append(row.Cells[3].Text);

            Response.Redirect(page.ToString());
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCO.aspx");
        }
    }
}