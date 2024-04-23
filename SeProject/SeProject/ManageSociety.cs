using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ManageSociety : Form
    {
        string presidentName;
        string presidentID;
        bool isUpdate = false;
        int updateSocietyID;
        public ManageSociety(string name, string id)
        {
            InitializeComponent();
            presidentName = name;
            presidentID = id;
            DisplaySocieties();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManageSociety_Load(object sender, EventArgs e)
        {

        }

        private void Descreption_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Update_Button_Click(object sender, EventArgs e)
        {
           
            string name = SocietyName.Text;
            string bio = Bio.Text;
            string description = Descreption.Text;
            int presidentUserID = Convert.ToInt32(presidentID);
            int SocietyID;

            
            if (isUpdate)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    string query = @"
         UPDATE Societies
         SET Name = @Name, Bio = @Bio, Description = @Description
         WHERE SocietyID = @SocietyID";

                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Bio", bio);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@SocietyID", updateSocietyID);

                        
                        connection.Open();

                        
                        command.ExecuteNonQuery();

                        
                        connection.Close();
                    }

                    isUpdate = false;
                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    string query = @"
 INSERT INTO Societies (Name, Bio, Description, PresidentUserID)
    VALUES (@Name, @Bio, @Description, @PresidentUserID);
    SELECT CAST(scope_identity() AS int);"; 


                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Bio", bio);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@PresidentUserID", presidentUserID);

                       
                        connection.Open();

                        ;
                        SocietyID = (int)command.ExecuteScalar();
                       
                        connection.Close();
                    }
                }

                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Memberships (UserID, SocietyID, Role) VALUES (@UserID, @SocietyID, @Role)";

                    using (SqlCommand command = new SqlCommand(query, connection1))
                    {
                        command.Parameters.AddWithValue("@UserID", presidentUserID);
                        command.Parameters.AddWithValue("@SocietyID", SocietyID);
                        command.Parameters.AddWithValue("@Role", "President");

                        connection1.Open();

                        command.ExecuteNonQuery();
                    }
                }

                
                MessageBox.Show("Society added successfully!");
            }

            
            SocietyName.Text = "";
            Bio.Text = "";
            Descreption.Text = "";
            DisplaySocieties();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PresidentLogin presidentLogin = new PresidentLogin(presidentName, presidentID);
            presidentLogin.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void DisplaySocieties()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "SELECT * FROM Societies";

                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    connection.Open();

                   
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear(); 

                        
                        dataGridView1.Columns.Add("SocietyID", "Society ID");
                        dataGridView1.Columns.Add("Name", "Name");
                        dataGridView1.Columns.Add("Bio", "Bio");
                        dataGridView1.Columns.Add("Description", "Description");

                        
                        while (reader.Read())
                        {
                            
                            int societyID = (int)reader["SocietyID"];
                            string name = (string)reader["Name"];
                            string bio = (string)reader["Bio"];
                            string description = (string)reader["Description"];
                            int pid = (int)reader["PresidentUserID"];

                            int presidentID;
                            bool isValid = int.TryParse(this.presidentID, out presidentID);
                            if (isValid)
                            {
                                if (pid == presidentID)
                                {
                                    dataGridView1.Rows.Add(societyID, name, bio, description);

                                }
                            }
                        }
                    }

                    
                    connection.Close();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            isUpdate = true;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "SELECT * FROM Societies";

                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    connection.Open();

                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {


                        
                        while (reader.Read())
                        {
                           
                            int societyID = (int)reader["SocietyID"];
                            string name = (string)reader["Name"];
                            string bio = (string)reader["Bio"];
                            string description = (string)reader["Description"];
                            int pid = (int)reader["PresidentUserID"];
                            //updateSocietyID = societyID;
                            int societyIDToUpdate;
                            bool isValid = int.TryParse(delete_update.Text, out societyIDToUpdate);

                            if (isValid)
                            {
                                if (societyID == societyIDToUpdate)
                                {
                                    SocietyName.Text = name;
                                    Bio.Text = bio;
                                    Descreption.Text = description;
                                    updateSocietyID = societyID;


                                    break;

                                }

                            }
                            else
                            {
                                MessageBox.Show("Invalid input. Please enter a valid Society ID.");
                            }

                        }
                    }

                   
                    connection.Close();
                }


            }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int societyIDToDelete;
                bool isValid = int.TryParse(delete_update.Text, out societyIDToDelete);
                
                DeleteSocityFromMemberships(societyIDToDelete);
                string query = "DELETE FROM Societies WHERE SocietyID = @SocietyID";

                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@SocietyID", societyIDToDelete);

                   
                    connection.Open();

                    
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Society Does not Exist");

                    }
                    else
                    {
                        MessageBox.Show("Society deleted successfully!");

                    }
                    
                    connection.Close();
                }
            }

            
            DisplaySocieties();

        }

        void DeleteSocityFromMemberships(int societyID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

               
                string query = "DELETE FROM Memberships WHERE SocietyID = @SocietyID";

                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@SocietyID", societyID);

                    
                    connection.Open();

                   
                    command.ExecuteNonQuery();

                   
                    connection.Close();
                }
            }

            
        }


    }

}
