using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Data
{
    public class SecurityDAO
    {
        public bool FindByUser(UserModel user)
        {
            // use try catch
            string username = user.Username;
            string password = user.Password;

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "';", conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            conn.Close();

            if (reader.HasRows)
                return true;
            else
                return false;

        }
    }

    

}