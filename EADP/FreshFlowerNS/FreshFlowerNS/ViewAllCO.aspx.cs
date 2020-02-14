using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreshFlowerNS.DAL;
using SingaporeFlorist.DAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FreshFlowerNS
{
    public partial class ViewAllCO : System.Web.UI.Page
    {
        COrder co = new COrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
        }

        protected void bind()
        {
            gv_CO.DataSource = co.GetCOrdersDetail();
            gv_CO.DataBind();
        }

        protected void btn_PO_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllPO.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText1 = "SELECT o.*, c.CompanyName FROM COrder o ";
            strCommandText1 += "JOIN Company c ON c.CompanyName = o.CompanyName ";
            strCommandText1 += " WHERE  corderDesc =@desc";
            SqlCommand cmd = new SqlCommand(strCommandText1, myConnect);

            cmd.Parameters.Add("@desc", SqlDbType.VarChar);
            cmd.Parameters["@desc"].Value = tbSearch.Text;

            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            gv_CO.DataSource = dt;
            gv_CO.DataBind();
        }

        protected void gv_CO_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowID = (int)this.gv_CO.SelectedDataKey.Value;
            Response.Redirect("InsertDelivery.aspx?id=" + rowID);
        }

        protected void btn_delivery_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delivery.aspx");
        }
    }
}