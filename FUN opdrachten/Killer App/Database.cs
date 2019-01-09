using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Killer_App
{
    class Database
    {
        
        private string connectionString;
        
        private SqlConnection conn;

        public Database()
        {
            connectionString = GetConnectionString();
            conn = new SqlConnection(connectionString);
        }

        private string GetConnectionString()
        {
            string databaseString = Directory.GetCurrentDirectory();
            int index = databaseString.IndexOf("\\bin\\Debug");
            if (index > 0)
            {
                databaseString = databaseString.Substring(0, index);
            }
            databaseString = Path.Combine(databaseString, "KillerDatabaseV.mdf");
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databaseString + ";Integrated Security=True";
            return connectionString;
        }

        internal void AddAccount(string Username, string Password, string FirstName, string LastName, string Gender)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO dbo.AccountTable (Username, Password, FirstName, LastName, Gender) " +
                    "VALUES (@username,@password,@firstname,@lastname,@gender)";
                SqlCommand cmd = new SqlCommand(query, this.conn);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                //cmd.Parameters.AddWithValue("@DateOfBirth", date);
                var result = cmd.ExecuteScalar();

                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                Console.WriteLine(exc.Message);
            }

            finally
            {
                conn.Close();
            }
            
        }
        internal bool AccountCheck(string username, string password)
        {
            try
            {
                conn.Open();
                string query = "SELECT Username, Password FROM dbo.AccountTable WHERE Username = '" + username + "' AND Password = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, this.conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                Console.WriteLine(exc.Message);
                return false;
            }

            finally
            {
                conn.Close();
            }
        }
        
    }
}
