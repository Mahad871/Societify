using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static SeProject.constants;


public class Validator
{
    public bool ValidateEmail(string email)
    {
        // Check if email is null or empty
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }

        // Check if email contains '@'
        if (!email.Contains("@"))
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

        return true;
    }

    public bool ValidatePassword(string password)
    {
        // Check if password is null or empty
        if (string.IsNullOrEmpty(password))
        {
            return false;
        }

        // Check if password length is greater than 6
        if (password.Length <= 6)
        {
            return false;
        }

        return true;
    }

    private bool IsValidDomain(string domain)
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

    public bool CheckUserExistsRollNo(string rollNo)
    {
        // Create a connection string to connect to the database

        // Create a SQL query to check if the user exists
        string query = "SELECT COUNT(*) FROM user WHERE RollNo = @RollNo";

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

    public bool CheckUserExistsEmail(string mail)
    {
        // Create a connection string to connect to the database

        // Create a SQL query to check if the user exists
        string query = "SELECT COUNT(*) FROM user WHERE Email = @Email";

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

    public bool CheckSocietyExistsName(string name)
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
