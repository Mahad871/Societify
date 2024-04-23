using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeProject.constants;

namespace SeProject
{
    public partial class RegisterPresident : Form
    {
        string nme;
        public RegisterPresident(string name)
        {
            InitializeComponent();
            nme = name;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminHomepage adminLogin = new AdminHomepage(nme);
            adminLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = email1.Text; // Assuming you have a TextBox named email1 for email
            string memberName = name.Text; // Assuming you have a TextBox named name for member name
            string rollNo = rollnum.Text; // Assuming you have a TextBox named rollnum for roll number
            string password = password1.Text; // Assuming you have a TextBox named password1 for password

            // connectionString should be your actual connection string
            //string connectionString = MahadConnectionString;

            // Check if any of the inputs are null or empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(memberName) ||
                string.IsNullOrEmpty(rollNo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Insert the president into the Users table
                    string sqlInsertUser = @"
                INSERT INTO Users (Email, MemberName, RollNo, Password, Role)
                OUTPUT INSERTED.UserID
                VALUES (@Email, @MemberName, @RollNo, @Password, @Role);";

                    using (SqlCommand commandInsertUser = new SqlCommand(sqlInsertUser, connection, transaction))
                    {
                        commandInsertUser.Parameters.AddWithValue("@Email", email);
                        commandInsertUser.Parameters.AddWithValue("@MemberName", memberName);
                        commandInsertUser.Parameters.AddWithValue("@RollNo", rollNo);
                        commandInsertUser.Parameters.AddWithValue("@Password", password); // Remember to hash the password
                        commandInsertUser.Parameters.AddWithValue("@Role", "President");

                        object result = commandInsertUser.ExecuteScalar();
                        if (result != null)
                        {
                            int newUserId = Convert.ToInt32(result);
                            transaction.Commit();
                            MessageBox.Show($"President signup successful! \nUserID: {newUserId}\nPassword: {password}", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to register president. The user ID could not be retrieved.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to register president. Error: {ex.Message}");
            }
        }

        private void RegisterPresident_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
