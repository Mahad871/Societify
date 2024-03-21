using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeProject
{
    public partial class Login : Form
    {
        string connectionString = @"Server=LAPTOP-K1O0L2VM\SQLEXPRESS;Database=seproject;Integrated Security=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string userid = userid1.Text; // Assuming the TextBox for userID is named useridTextBox
            string password = password1.Text; // Assuming the TextBox for password is named passwordTextBox
            string selectedRole=comboBox1.Text.ToString();

            // Replace with your actual connection string
            //string connectionString = @"Server=YOUR_SERVER_NAME;Database=seproject;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL command to select the user with the given userID and password
                    string sql = "SELECT COUNT(1) FROM Users WHERE UserID=@UserID AND Password=@Password";
                    if (selectedRole == "Admin")
                    {
                        // Extend SQL to check if the user is an admin
                        sql += " AND UserID IN (SELECT UserID FROM Admins)";
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userid);
                        command.Parameters.AddWithValue("@Password", password); // Consider using hashed passwords

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            // Login successful
                            MessageBox.Show($"Login Successful as {selectedRole}");
                            // Navigate to another form if login is successful
                            // MainForm mainForm = new MainForm();
                            // mainForm.Show();
                            // this.Hide();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Login Failed. Please check your UserID, Password, and Role.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
            }
        }


        private void userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
