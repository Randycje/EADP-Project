using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace SingaporeFlorist.DAL
{
    public class Product
    {
        DalConn dbConn = new DalConn();
        private String errMsg;
        private string _name, _description, _unitPrice, _image;
        private int _stock, _ProductID;

        public Product(int aProductID, string aName, string aDescription, string aunitPrice, int aStock, string aImage)
        {
            _name = aName;
            _description = aDescription;
            _unitPrice = aunitPrice;
            _stock = aStock;
            _ProductID = aProductID;
            _image = aImage;
        }
        public Product()
        {
            this._name = null;
            this._description = null;
            this._unitPrice = null;
            this._stock = 0;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string unitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public int productID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        public string image
        {
            get { return _image; }
            set { _image = value; }
        }

        public int InsertProduct(string Name, string Description, string Unitp, int Stock, string Image)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Product(name, description, unitPrice, stock, image)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@Name, @Description, @Unitp, @Stock, @Image)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@Name", Name);
                sqlCmd.Parameters.AddWithValue("@Description", Description);
                sqlCmd.Parameters.AddWithValue("@Unitp", Unitp);
                sqlCmd.Parameters.AddWithValue("@Stock", Stock);
                sqlCmd.Parameters.AddWithValue("@Image", Image);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public DataSet GetProductDetails()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet accountsData;

            SqlConnection conn = dbConn.GetConnection();
            accountsData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM Product");
            //sql.AppendLine("INNER JOIN author a ON a.id = b.authorId");
            //sql.AppendLine("INNER JOIN publisher p ON p.id = b.publisherId");
            //sql.AppendLine("LEFT OUTER JOIN images i ON i.id = b.bookCoverId");
            //sql.AppendLine("WHERE id = @osepId");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(accountsData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return accountsData;
        }

        public int deleteProduct(string name)
        {

            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;


            sql = new StringBuilder();
            sql.AppendLine("DELETE FROM Product");
            sql.AppendLine(" ");
            sql.AppendLine("WHERE name=@name");
            SqlConnection conn = dbConn.GetConnection();
            try
            {
                conn.Open();
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@name", name);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public int productUpdate(string name, string description, string unitPrice, int stock)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;


            sql = new StringBuilder();
            sql.AppendLine("UPDATE Account");
            sql.AppendLine(" ");
            sql.AppendLine("SET name = @name AND description = @description AND unitPrice=@unitPrice AND stock=@stock");
            sql.AppendLine(" ");
            //sql.AppendLine("WHERE name=@name");
            SqlConnection conn = dbConn.GetConnection();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@name", name);
                sqlCmd.Parameters.AddWithValue("@description", description);
                sqlCmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                sqlCmd.Parameters.AddWithValue("@stock", stock);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}