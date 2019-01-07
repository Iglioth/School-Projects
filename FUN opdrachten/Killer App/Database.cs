using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Killer_App
{
    class Database
    {
        
        private static string connectionString;
        
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
            databaseString = Path.Combine(databaseString, "DeurenDatabase.mdf");
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databaseString + ";Integrated Security=True";
            return connectionString;
        }

        public void AddAccount(string Username, string Password, DateTime date, string FirstName, string LastName, string Gender)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO dbo.AccountTable (Username, Password, First_Name, Last_Name, Gender, Date_Of_Birth) VALUES (@username,@password,@firstname,@lastname,@gender,@date)";
                SqlCommand cmd = new SqlCommand(query, this.conn);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@First_Name", FirstName);
                cmd.Parameters.AddWithValue("@Last_Name", LastName);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Date_Of_Birth", date);
                var result = cmd.ExecuteScalar();

                using (SqlDataReader reader = new cmd.ExecuteReader())
                {

                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            
        }

        
    }
}
