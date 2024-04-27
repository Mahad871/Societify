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
            string email = email1.Text;
            string memberName = name.Text;
            string rollNo = rollnum.Text;
            string password = password1.Text;
            string Phonenum= phonenum.Text;



            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(memberName) ||
                string.IsNullOrEmpty(rollNo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            

            if (!ValidateEmail(email))
            {
                MessageBox.Show("Invalid email address.");
                return;
            }
            if(!ValidateRollNumber(rollNo))
            {
                MessageBox.Show("Invalid Roll Number (must be of the form 21I-XXXX).");
                return;
            }
            if (!ValidatePassword(password))
            {
                MessageBox.Show("Invalid Password (must be at least 7 characters long).");
                return;
            }
            if (!ValidatePhoneNo(Phonenum))
            {
                MessageBox.Show("Invalid Phone Number (must be 11 characters long) and Format (03xxxxxxxxx).");
                return;
            }


            if (CheckUserExistsEmail(email))
            {
                MessageBox.Show("User with this Email already exists.");
                return;
            }
            if (CheckUserExistsRollNo(rollNo))
            {
                MessageBox.Show("User with this Roll Number already exists.");
                return;
            }
            if (CheckUserExistsPhoneNo(Phonenum))
            {
                MessageBox.Show("User with this Phone no already exists.");
                return;
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();


                    string sqlInsertUser = @"
                INSERT INTO Users (Email, MemberName, RollNo, Password, Role,PhoneNumber)
                OUTPUT INSERTED.UserID
                VALUES (@Email, @MemberName, @RollNo, @Password, @Role,@PhoneNumber);";

                    using (SqlCommand commandInsertUser = new SqlCommand(sqlInsertUser, connection, transaction))
                    {
                        commandInsertUser.Parameters.AddWithValue("@Email", email);
                        commandInsertUser.Parameters.AddWithValue("@MemberName", memberName);
                        commandInsertUser.Parameters.AddWithValue("@RollNo", rollNo);
                        commandInsertUser.Parameters.AddWithValue("@Password", password);
                        commandInsertUser.Parameters.AddWithValue("@Role", "President");
                        commandInsertUser.Parameters.AddWithValue("@PhoneNumber", Phonenum);

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

        private void phonenum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
