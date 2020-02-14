using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FreshFlowerNS
{
    public partial class SupplierOrder : System.Web.UI.Page
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

            string strCommandText = "SELECT o.corderID, o.corderDesc, o.corderDate, o.corderStatus, c.CompanyName FROM COrder o ";
            strCommandText += " INNER JOIN Company c ON c.CompanyName = o.CompanyName ";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            grdOrders.DataSource = dt;
            grdOrders.DataBind();
        }

        protected void grdOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowID = (int)this.grdOrders.SelectedDataKey.Value;
            Response.Redirect("InsertDelivery.aspx?id=" + rowID);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText1 = "SELECT o.*, c.CompanyName FROM Orders o ";
            strCommandText1 += "JOIN Company c ON c.orderID = c.orderID ";
            strCommandText1 += " WHERE orderItem=@item ";
            SqlCommand cmd = new SqlCommand(strCommandText1, myConnect);

            cmd.Parameters.Add("@item", SqlDbType.VarChar);
            cmd.Parameters["@item"].Value = tbSearch.Text;

            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            grdOrders.DataSource = dt;
            grdOrders.DataBind();

        }
    }
}