using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using SingaporeFlorist.DAL;

namespace FreshFlowerNS
{
    public partial class InsertDelivery : System.Web.UI.Page
    {
        DAL.Delivery del = new DAL.Delivery();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int rowID = int.Parse(Request.QueryString["Id"]);
                lblorderID.Text = rowID.ToString();
            }

            bind();

            string strConnectionString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "SELECT d.DeliveryDate, d.DeliveryStatus, d.corderID,  d.CompanyName, c.CompanyAddress FROM Delivery d ";
            strCommandText += " JOIN Company c ON c.CompanyName = d.CompanyName ";
            strCommandText += " JOIN COrder o ON o.corderID = d.corderID";

            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblCompany.Text = reader["CompanyName"].ToString();
                lblAddress.Text = reader["CompanyAddress"].ToString();
                lblStatus.Text = reader["DeliveryStatus"].ToString();
            }

            reader.Close();
            myConnect.Close();
        }

        protected void bind()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["FreshFlowers"].ConnectionString;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "SELECT corderDesc, corderPrice, corderQuantity FROM COrder WHERE corderID = @id" ;

            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
            cmd.Parameters["id"].Value = lblorderID.Text;
            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            gvOrders.DataSource = dt;
            gvOrders.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            int corderID = Convert.ToInt32(lblorderID.Text);
            string DeliveryDate = tbDate.Text;
            string DeliveryStatus = lblStatus.Text;
            string CompanyName = lblCompany.Text;

            del.InsertDelivery(DeliveryDate, DeliveryStatus, corderID, CompanyName);
            Response.Redirect("Delivery.aspx");
        }

        protected void btn_co_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCO.aspx");
        }
    }
}