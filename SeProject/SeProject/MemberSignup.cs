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
using System.Xml.Linq;
using static SeProject.constants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SeProject
{
    public partial class MemberSignup : Form
    {
        public MemberSignup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rollno = rollnum1.Text;
            string email = email1.Text;
            string memberName = member1.Text;
            string password = passwd1.Text; // Consider hashing the password
            int newUserId;
            // Validate input
            if (string.IsNullOrWhiteSpace(rollno) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(memberName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, insert the new admin user into the Users table
                    string sqlInsertUser = "INSERT INTO Users (Email, MemberName, Password, RollNo,Role) OUTPUT INSERTED.UserID VALUES (@Email, @MemberName, @Password, @RollNo,@Role);";

                    using (SqlCommand commandInsertUser = new SqlCommand(sqlInsertUser, connection))
                    {
                        commandInsertUser.Parameters.AddWithValue("@Email", email);
                        commandInsertUser.Parameters.AddWithValue("@MemberName", memberName);
                        commandInsertUser.Parameters.AddWithValue("@Password", password);
                        commandInsertUser.Parameters.AddWithValue("@RollNo", rollno);
                        commandInsertUser.Parameters.AddWithValue("@Role", "Member");
                        // Execute and get the inserted user's ID
                        newUserId = (int)commandInsertUser.ExecuteScalar();

                        // Now, insert a reference to this user in the Admins table
                        
                    }
                }

                MessageBox.Show($"Member signup successful! \nUserID: {newUserId}\nPassword: {password}", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide the current form
                Form1 homePage = new Form1();
                homePage.Show(); // Show the homepage
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to signup. Error: {ex.Message}");
            }
        }
    }
}
