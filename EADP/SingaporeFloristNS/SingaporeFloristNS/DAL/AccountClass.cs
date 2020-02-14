using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace FreshFlowers.DAL
{
    public class AccountClass
    {
        DalConn dbConn = new DalConn();
        private String errMsg;
        private string _Username, _Name, _Email, _Password, _Title, _Role = "";
        private int _User_ID;
        //private DateTime _Recent_Login, _Creation_Date, _DateofBirth;

        public AccountClass(int aUser_ID, string aUsername, string aName, string aEmail, string aPassword, string aTitle)
        {
            _Username = aUsername;
            _Name = aName;
            _User_ID = aUser_ID;
            _Email = aEmail;
            _Password = aPassword;
            _Title = aTitle;
        }

        public AccountClass()
        {
            this._Name = null;
            this._User_ID = 0;
            this._Email = null;
            this._Password = null;
            this._Title = null;
            //this._Transaction_Creation_Date = null;
            //this._Course_ID = null;
            //this._Course_Fee = null;
            //this._Transaction_Admin_Comment = null;
        }

        public AccountClass(string Name, string Password, string Email, string Role)
        { // Used for Index.aspx
            _Name = Name.ToLower();
            _Password = Password;
            _Email = Email.ToLower();
            _Role = Role.ToLower();
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int User_ID
        {
            get { return _User_ID; }
            set { _User_ID = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }


        //Functions
        public int InsertAccount(string Username, string Name, string Email, string Password, string Title)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;

            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Account(Username, Name, Email, Password, Title)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@Username, @Name, @Email, @Password, @Title)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@Username", Username);
                sqlCmd.Parameters.AddWithValue("@Name", Name);
                sqlCmd.Parameters.AddWithValue("@Email", Email);
                sqlCmd.Parameters.AddWithValue("@Password", Password);
                sqlCmd.Parameters.AddWithValue("@Title", Title);
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

        public DataSet GetAccountDetails()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet accountsData;

            SqlConnection conn = dbConn.GetConnection();
            accountsData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM Account");
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

        public int deleteAccount(string name)
        {

            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;


            sql = new StringBuilder();
            sql.AppendLine("DELETE FROM Account");
            sql.AppendLine(" ");
            sql.AppendLine("WHERE Name=@name");
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

        public int AccountUpdate(string username, string email, string password)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;


            sql = new StringBuilder();
            sql.AppendLine("UPDATE Account");
            sql.AppendLine(" ");
            sql.AppendLine("SET Username=@username, Email=@email, Password=@password");
            sql.AppendLine(" ");
            sql.AppendLine("WHERE id=@id");
            SqlConnection conn = dbConn.GetConnection();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@username", username);
                sqlCmd.Parameters.AddWithValue("@email", email);
                sqlCmd.Parameters.AddWithValue("@password", password);
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

        public string check(string Name, string Password)
        {
            string output = "none";
            string queryStr = "SELECT * FROM Account WHERE Name = @Name and Password = @Password";


            // Opening SQL connection
            using (SqlConnection conn = dbConn.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name.ToLower());
                    cmd.Parameters.AddWithValue("@Password", Password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            output = reader["Title"].ToString();
                            AccountClass Acc = new AccountClass();
                        }
                    }
                }
            }
            return output;
        }
    }
}