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
using static SeProject.constants;


namespace SeProject
{
    public partial class Login : Form
    {  

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
            string selectedRole = RoleDropDown.Text.ToString();
            string membername;
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
                    else if (selectedRole == "President")
                    {
                        sql += " AND Role = @Role";
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userid);
                        command.Parameters.AddWithValue("@Password", password); // Consider using hashed passwords
                        if (selectedRole == "President")
                        {
                            command.Parameters.AddWithValue("@Role", selectedRole);
                        }
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            string sql1 = "SELECT MemberName FROM Users WHERE UserID=@UserID AND Password=@Password";
                            // Login successful
                            
                            using (SqlCommand command1 = new SqlCommand(sql1, connection))

                            {
                                command1.Parameters.AddWithValue("@UserID", userid);
                                command1.Parameters.AddWithValue("@Password", password);
                                var result = command1.ExecuteScalar();
                                membername = result?.ToString();
                            }
                                //MessageBox.Show($"Login Successful as {selectedRole}");
                                if (selectedRole == "Admin")
                            {
                                AdminHomepage adminLogin = new AdminHomepage(membername);
                                adminLogin.Show();
                                this.Hide();
                            }
                            else if (selectedRole == "President")
                            {
                                // Assuming PresidentLogin is the form you want to show for presidents
                                PresidentLogin presidentLogin = new PresidentLogin(membername, userid); //chnage later to president id
                                presidentLogin.Show();
                                this.Hide();
                            }


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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
