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
using static SeProject.SocietyModel;

namespace SeProject
{
    public partial class ManageMembers : Form
    {
        string presidentName;
        string presidentID;
        List<SocietyModel> societylist = [];


        int selectedSocietyID = -1;
        public ManageMembers(string presidentName, string presidentID)
        {
            InitializeComponent();
            this.presidentName = presidentName;
            this.presidentID = presidentID;
            getSocitiesForCurrentPresident();
            DisplayMembers();
        }

        public class SocietyItem
        {
            public int SocietyID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; 
            }
        }

        private void ManageMembers_Load(object sender, EventArgs e)
        {
            string query = "SELECT SocietyID, Name FROM Societies WHERE PresidentUserID = @PresidentUserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the presidentID parameter to the command
                    command.Parameters.AddWithValue("@PresidentUserID", presidentID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        SocietyCombobox.Items.Clear();

                        while (reader.Read())
                        {
                            SocietyCombobox.Items.Add(new SocietyItem
                            {
                                SocietyID = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
            }

            SocietyCombobox.DisplayMember = "Name";
            SocietyCombobox.ValueMember = "SocietyID";
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void SocietyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Role_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Update_Button_Click(object sender, EventArgs e)
        {
            string rollNo = MemberRollNo.Text;
            int userId = GetUserIdByRollNo(rollNo);

            if (SocietyCombobox.SelectedItem != null)
            {
                var selectedSociety = (SocietyItem)SocietyCombobox.SelectedItem;
                selectedSocietyID = selectedSociety.SocietyID;
            }
            else
            {
                MessageBox.Show("Please select a society");
                return;
            }

            if (userId == -1)
            {
                MessageBox.Show("User not found with the given roll number");
                return;
            }
            else if (selectedSocietyID == -1)
            {
                MessageBox.Show("Please select a society");
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Memberships (UserID, SocietyID, Role) VALUES (@UserID, @SocietyID, @Role)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);
                        command.Parameters.AddWithValue("@Role", RoleDropDown.Text);

                        connection.Open();

                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Member added successfully!");
                    DisplayMembers();

                }
            }
        }
        private int GetUserIdByRollNo(string rollNo)
        {
            int userId = -1; 

            string query = "SELECT UserID FROM Users WHERE RollNo = @RollNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RollNo", rollNo);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userId = reader.GetInt32(0);
                }

                reader.Close();
            }

            return userId;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            PresidentLogin presidentLogin = new PresidentLogin(presidentName, presidentID);
            presidentLogin.Show();
            this.Close();
        }

        string getUserName(int userID)
        {
            string query = "SELECT MemberName FROM Users WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetString(0);
                }

                reader.Close();
            }
            return "";
        }
        void DisplayMembers()
        {

            string query = "SELECT * FROM Memberships";
            getSocitiesForCurrentPresident();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                dataGridView1.Columns.Add("UserID", "User ID");
                dataGridView1.Columns.Add("MemberName", "Member Name");
                dataGridView1.Columns.Add("Role", "Role");
                dataGridView1.Columns.Add("SocietyName", "Society Name");
                dataGridView1.Columns.Add("SocietyID", "Society ID");


                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    int userID = (int)reader["UserID"];
                    int societyID = (int)reader["SocietyID"];
                    string role = (string)reader["Role"];

                    foreach (SocietyModel item in societylist)
                    {
                        if (item.SocietyID == societyID)
                        {
                            string userName = getUserName(userID);

                            dataGridView1.Rows.Add(userID, userName, role, item.Name,item.SocietyID);

                        }
                    }


                }

                reader.Close();
            }
        }

        List<SocietyModel> getSocitiesForCurrentPresident()
        {
            string query = "SELECT * FROM Societies";
            societylist.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    SocietyModel society = new SocietyModel();
                    society.SocietyID = (int)reader["SocietyID"];
                    society.Name = (string)reader["Name"];
                    society.Bio = (string)reader["Bio"];
                    society.Description = (string)reader["Description"];
                    society.PresidentID = (int)reader["PresidentUserID"];
                    int currentPresidentID = Convert.ToInt32(presidentID);
                    if (society.PresidentID == currentPresidentID)
                    {
                        societylist.Add(society);

                    }
                }

                reader.Close();
                connection.Close();
                return societylist;
            }


        }

        private void RoleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string checkRoleQuery = "SELECT Role FROM Memberships WHERE UserID = @UserID AND SocietyID = @SocietyID";
            string deleteQuery = "DELETE FROM Memberships WHERE UserID = @UserID AND SocietyID = @SocietyID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // First, check the role of the user
                using (SqlCommand checkRoleCommand = new SqlCommand(checkRoleQuery, connection))
                {
                    checkRoleCommand.Parameters.AddWithValue("@UserID", EnterUid.Text);
                    checkRoleCommand.Parameters.AddWithValue("@SocietyID", EnterSId.Text);

                    object roleObj = checkRoleCommand.ExecuteScalar();
                    if (roleObj != null && roleObj.ToString() == "President")
                    {
                        MessageBox.Show("Cannot delete a President of the society.");
                        return; // Exit the method without deleting
                    }
                }

                // If the role is not President, proceed with the deletion
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserID", EnterUid.Text);
                    deleteCommand.Parameters.AddWithValue("@SocietyID", EnterSId.Text);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No member found with the given UserID and SocietyID");
                    }
                    else
                    {
                        MessageBox.Show("Member deleted successfully!");
                        DisplayMembers(); // Ensure this method updates your display to show the member has been deleted
                    }
                }

                connection.Close();
            }
        }

    }
}
