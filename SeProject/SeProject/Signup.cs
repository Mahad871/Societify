using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeProject.constants;

namespace SeProject
{
    public partial class Signup : Form

    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {

            string rollno = textBox1.Text;
            string email = Email.Text;
            string memberName = name.Text;
            string password = Password.Text;
            int newUserId;

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


                    string sqlInsertUser = "INSERT INTO Users (Email, MemberName, Password, RollNo) OUTPUT INSERTED.UserID VALUES (@Email, @MemberName, @Password, @RollNo);";

                    using (SqlCommand commandInsertUser = new SqlCommand(sqlInsertUser, connection))
                    {
                        commandInsertUser.Parameters.AddWithValue("@Email", email);
                        commandInsertUser.Parameters.AddWithValue("@MemberName", memberName);
                        commandInsertUser.Parameters.AddWithValue("@Password", password);
                        commandInsertUser.Parameters.AddWithValue("@RollNo", rollno);

                        newUserId = (int)commandInsertUser.ExecuteScalar();


                        string sqlInsertAdmin = "INSERT INTO Admins (UserID) VALUES (@UserID);";
                        using (SqlCommand commandInsertAdmin = new SqlCommand(sqlInsertAdmin, connection))
                        {
                            commandInsertAdmin.Parameters.AddWithValue("@UserID", newUserId);
                            commandInsertAdmin.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show($"Admin signup successful! \nUserID: {newUserId}\nPassword: {password}", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 homePage = new Form1();
                homePage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to signup. Error: {ex.Message}");
            }
        }

        private void Email_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
