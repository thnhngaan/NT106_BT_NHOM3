using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace NT106_2._2
{
    internal class Modify
    { public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
         
        public List<Users> Accounts(string query)
        {
            List<Users> Account = new List<Users>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Account.Add(new Users(dataReader.GetString(0),dataReader.GetString(1),dataReader.GetString(2),dataReader.GetString(3),dataReader.GetString(4)));
                }

                sqlConnection.Close();
            }
            return Account; 
        }
        public void Command(string query )
        {
            using (SqlConnection sqlConnection= Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        // Kiểm tra login: so sánh password nhập với hash trong DB
        public bool CheckLogin(string username, string password)
        {
            string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHash = result.ToString();
                        return hashpassword.VerifyPassword(storedHash, password);
                    }
                    else
                    {
                        return false; // user không tồn tại
                    }
                }
            }
        }
    }
}

