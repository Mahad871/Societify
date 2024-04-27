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



        private void button1_Click(object sender, EventArgs e)
        {
            string rollno = rollnum1.Text;
            string email = email1.Text;
            string memberName = member1.Text;
            string password = passwd1.Text;
            string number = phnum.Text;
            int newUserId;

            if (string.IsNullOrWhiteSpace(rollno) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(memberName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            

            if (!ValidateEmail(email))
            {
                bool a=ValidateEmail(email);
                Console.WriteLine(a);
                MessageBox.Show("Invalid email address.");
                return;
            }
            if(!ValidateName(memberName))
            {
                MessageBox.Show("Invalid Name .");
                return;
            }
            if (!ValidateRollNumber(rollno))
            {
                MessageBox.Show("Invalid Roll Number (must be of the form 21I-XXXX).");
                return;
            }
            if (!ValidatePassword(password))
            {
                MessageBox.Show("Invalid Password (must be at least 7 characters long).");
                return;
            }
            if (!ValidatePhoneNo(number))
            {
                MessageBox.Show("Invalid Phone Number (must be 11 characters long) and Format (03xxxxxxxxx).");
                return;
            }

            
            if (CheckUserExistsEmail(email))
            {
                MessageBox.Show("User with this Email already exists.");
                return;
            }
            if (CheckUserExistsRollNo(rollno))
            {
                MessageBox.Show("User with this Roll Number already exists.");
                return;
            }
            if (CheckUserExistsPhoneNo(number))
            {
                MessageBox.Show("User with this Phone no already exists.");
                return;
            }




            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string sqlInsertUser = "INSERT INTO Users (Email, MemberName, Password, RollNo,Role,PhoneNumber) OUTPUT INSERTED.UserID VALUES (@Email, @MemberName, @Password, @RollNo,@Role,@PhoneNumber);";

                    using (SqlCommand commandInsertUser = new SqlCommand(sqlInsertUser, connection))
                    {
                        commandInsertUser.Parameters.AddWithValue("@Email", email);
                        commandInsertUser.Parameters.AddWithValue("@MemberName", memberName);
                        commandInsertUser.Parameters.AddWithValue("@Password", password);
                        commandInsertUser.Parameters.AddWithValue("@RollNo", rollno);
                        commandInsertUser.Parameters.AddWithValue("@PhoneNumber", number);
                        commandInsertUser.Parameters.AddWithValue("@Role", "Member");

                        newUserId = (int)commandInsertUser.ExecuteScalar();



                    }
                }

                MessageBox.Show($"Member signup successful! \nUserID: {newUserId}\nPassword: {password}", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 homePage = new Form1();
                homePage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to signup. Error: {ex.Message}");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
