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
            string userid = userid1.Text;
            string password = password1.Text;
            string selectedRole = RoleDropDown.Text.ToString();
            string membername;


            if (string.IsNullOrWhiteSpace(userid) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(selectedRole))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT COUNT(1) FROM Users WHERE UserID=@UserID AND Password=@Password";
                    if (selectedRole == "Admin")
                    {

                        sql += " AND UserID IN (SELECT UserID FROM Admins)";
                    }
                    else if (selectedRole == "President")
                    {
                        sql += " AND Role = @Role";
                    }
                    else if (selectedRole == "Member")
                    {
                        sql += " AND Role = @Role";
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userid);
                        command.Parameters.AddWithValue("@Password", password);
                        if (selectedRole == "President")
                        {
                            command.Parameters.AddWithValue("@Role", selectedRole);
                        }
                        if (selectedRole == "Member")
                        {
                            command.Parameters.AddWithValue("@Role", selectedRole);

                        }
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            string sql1 = "SELECT MemberName FROM Users WHERE UserID=@UserID AND Password=@Password";


                            using (SqlCommand command1 = new SqlCommand(sql1, connection))

                            {
                                command1.Parameters.AddWithValue("@UserID", userid);
                                command1.Parameters.AddWithValue("@Password", password);
                                var result = command1.ExecuteScalar();
                                membername = result?.ToString();
                            }

                            if (selectedRole == "Admin")
                            {
                                AdminHomepage adminLogin = new AdminHomepage(membername);
                                adminLogin.Show();
                                this.Hide();
                            }
                            else if (selectedRole == "President")
                            {

                                PresidentLogin presidentLogin = new PresidentLogin(membername, userid);
                                presidentLogin.Show();
                                this.Hide();
                            }
                            else if (selectedRole == "Member")
                            {
                                MemberHomePage memberLogin = new MemberHomePage(membername, userid);
                                memberLogin.Show();
                                this.Hide();

                            }


                        }
                        else
                        {

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

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password1.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
