using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplication
{
    // Authentication class
    public class authenticate
    {
        /* By having a dedicated User class, it becomes easier to extend and modify user-related properties 
        * or methods in the future without directly affecting the authentication logic. 
        * This modularity enhances code maintainability. */
        public class User
        {
            public string Username { get; set; } // User's username property
            public byte[] Image { get; set; } // User's image property (binary data)
            public string DateOfBirth { get; set; }
            public string Email { get; set; }


        }

        /* The DatabaseManager class is responsible for handling database operations, including user authentication. 
        * This is a good practice in software design, as it allows for better organization and maintainability. */
        public class DatabaseManager
        {
            // Method to authenticate user
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            /*The RetrieveUserInformation method encapsulates the logic for querying the database and retrieving user information based on the provided username and password. 
            * This method is private, meaning it is intended to be used only within the DatabaseManager class. */

            private static User RetrieveUserInformation(string username, string password)
            {

                // Using statement ensures proper disposal of resources
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
                {
                    sqlCon.Open(); // Open SQL connection

                    string loginQuery = "SELECT COUNT(1) FROM UserInfo WHERE userName=@Username AND password=@Password";
                    string infoQuery = "SELECT * FROM UserInfo WHERE userName=@Username AND password=@Password";


                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        using (SqlCommand infoCmd = new SqlCommand(infoQuery, sqlCon))
                        {
                            loginCmd.CommandType = CommandType.Text;
                            infoCmd.CommandType = CommandType.Text;

                            loginCmd.Parameters.AddWithValue("@Username", username);
                            loginCmd.Parameters.AddWithValue("@Password", password);
                            infoCmd.Parameters.AddWithValue("@Username", username);
                            infoCmd.Parameters.AddWithValue("@Password", password);

                            int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                            if (count == 1)
                            {
                                using (SqlDataReader reader = infoCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        return new User { Username = username };
                                    }
                                }
                            }
                            return null; // Return null if no user is found with the specified username and password
                        }
                    }
                }
            }
        }

    }
}
