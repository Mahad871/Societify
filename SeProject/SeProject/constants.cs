using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeProject
{
    internal class constants
    {
        public static string MahadConnectionString = @"Server=LAPTOP-LA4CMMH4;Database=seproject;Integrated Security=True;";
        public static string AhmadConnectionString = @"Server=LAPTOP-K1O0L2VM\SQLEXPRESS;Database=seproject;Integrated Security=True;";

        public static string connectionString = AhmadConnectionString;

        public static bool ValidateEmail(string email)
        {
            // Check if email is null or empty
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            // Check if email contains '@'
            /* if (!email.Contains("@"))
             {
                 return false;
             }

             // Split email into local part and domain part
             string[] parts = email.Split('@');
             string localPart = parts[0];
             string domainPart = parts[1];

             // Check if local part length is greater than 1
             if (localPart.Length <= 1)
             {
                 return false;
             }

             // Check if domain part is a valid domain
             if (!IsValidDomain(domainPart))
             {
                 return false;
             }

             // Check if there is at least one character between '@' and '.'
             int atIndex = email.IndexOf('@');
             int dotIndex = email.IndexOf('.');
             if (dotIndex - atIndex <= 1)
             {
                 return false;
             }

             string[] partss = domainPart.Split('.');

             string pattern = @"^[a-zA-Z]+$";
             if (!Regex.IsMatch(partss[0], pattern))
             {
                 return false;
             }



             return true;*/
            
            string pattern = @"^[a-zA-Z0-9]+[a-zA-Z0-9._'-]*@[a-zA-Z0-9]+([-.][a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";
            // Use Regex.IsMatch to validate the email against the pattern
            return Regex.IsMatch(email, pattern);
        }

        public static bool ValidatePassword(string password)
        {
            // Check if password is null or empty
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Check if password length is greater than 6
            if (password.Length < 7)
            {
                return false;
            }

            return true;
        }
        public static bool ValidateName(string name)
        {
            // Regular expression for matching only alphabetic characters and spaces
            if (name.Length < 4)
            {
                return false;
            }

            string pattern = @"^[a-zA-Z\s]+$";

            // Check if name is null or empty
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            // Use Regex.IsMatch to validate the name against the pattern
            return Regex.IsMatch(name, pattern);
        }

        public static bool ValidateRollNumber(string rollNumber)
        {
            // Regex pattern to match the format XXY-XXXX
            string pattern = @"^\d\d[ILKPF]-\d{4}$";
            // Use Regex.IsMatch to validate the roll number against the pattern
            return Regex.IsMatch(rollNumber, pattern);
        }

        public static bool ValidatePhoneNo(string password)
        {
            // Check if password is null or empty
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Check if password length is greater than 6
            if (password.Length == 11 && password[0] == '0' && password[1] == '3')
            {
                return true;
            }

            return false;
        }

        private static bool IsValidDomain(string domain)
        {
            // Check if domain is null or empty
            if (string.IsNullOrEmpty(domain))
            {
                return false;
            }

            // Check if domain contains only letters, numbers, hyphens, and dots
            string pattern = @"^[a-zA-Z0-9\-\.]+$";
            if (!Regex.IsMatch(domain, pattern))
            {
                return false;
            }

            // Check if domain has at least one dot
            if (!domain.Contains("."))
            {
                return false;
            }

            return true;
        }

        public static bool CheckUserExistsRollNo(string rollNo)
        {
            // Create a connection string to connect to the database

            // Create a SQL query to check if the user exists
            string query = "SELECT COUNT(*) FROM Users WHERE RollNo = @RollNo";

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the userID parameter to the command
                    command.Parameters.AddWithValue("@RollNo", rollNo);

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if the count is greater than 0
                    if (count > 0)
                    {
                        return true; // User exists
                    }
                    else
                    {
                        return false; // User does not exist
                    }
                }
            }
        }

        public static bool CheckUserExistsPhoneNo(string phone)
        {
            // Create a connection string to connect to the database

            // Create a SQL query to check if the user exists
            string query = "SELECT COUNT(*) FROM Users WHERE PhoneNumber = @PhoneNumber";

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the userID parameter to the command
                    command.Parameters.AddWithValue("@PhoneNumber", phone);

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if the count is greater than 0
                    if (count > 0)
                    {
                        return true; // User exists
                    }
                    else
                    {
                        return false; // User does not exist
                    }
                }
            }
        }

        public static bool CheckUserExistsEmail(string mail)
        {
            // Create a connection string to connect to the database

            // Create a SQL query to check if the user exists
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the userID parameter to the command
                    command.Parameters.AddWithValue("@Email", mail);

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if the count is greater than 0
                    if (count > 0)
                    {
                        return true; // User exists
                    }
                    else
                    {
                        return false; // User does not exist
                    }
                }
            }
        }

        public static bool CheckSocietyExistsName(string name)
        {
            // Create a connection string to connect to the database

            // Create a SQL query to check if the user exists
            string query = "SELECT COUNT(*) FROM Societies WHERE Name = @Name";

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the userID parameter to the command
                    command.Parameters.AddWithValue("@Name", name);

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if the count is greater than 0
                    if (count > 0)
                    {
                        return true; // User exists
                    }
                    else
                    {
                        return false; // User does not exist
                    }
                }
            }
        }
    }


}
