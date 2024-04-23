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
    public partial class ManageEvents : Form
    {
        string presidentName;
        string presidentID;
        int selectedSocietyID = -1;
        private bool isEditing = false;
        private int editingEventsID = -1;
        public ManageEvents(string name, string id)
        {
            InitializeComponent();
            this.presidentName = name;
            this.presidentID = id;
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
        private void ManageEvents_Load(object sender, EventArgs e)
        {
            string query = "SELECT SocietyID, Name FROM Societies WHERE PresidentUserID = @PresidentUserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

        private void LoadEvents()
        {
            SocietyItem selectedSociety = (SocietyItem)SocietyCombobox.SelectedItem;
            selectedSocietyID = selectedSociety.SocietyID;
            string query = @"SELECT EventID, SocietyID, CreatedByUserID, Name, Description, EventDate, Location
                FROM Events
                WHERE CreatedByUserID = @CreatedByUserID AND SocietyID = @SocietyID
                ORDER BY EventDate DESC";

            DataTable eventsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreatedByUserID", Convert.ToInt32(presidentID));
                        if (selectedSocietyID != -1)
                        {
                            command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            adapter.Fill(eventsTable);
                        }
                    }
                }

                EventsGrid.DataSource = eventsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load events: " + ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string eventName = title.Text;
            string eventDescription = this.desscreption.Text;
            DateTime eventDate = this.dateTimePicker1.Value;
            string eventLocation = this.venueTextBox.Text;

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

            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(eventDescription) || string.IsNullOrWhiteSpace(eventLocation))
            {
                MessageBox.Show("Event name, description, and location cannot be empty.");
                return;
            }

            if (isEditing)
            {
                string updateQuery = @"UPDATE Events 
                        SET Name = @Name, 
                            Description = @Description, 
                            EventDate = @EventDate,
                            Location = @Location,
                            SocietyID=@selectedSocietyID,
                            CreatedByUserID=@CreatedByUserID
                        WHERE EventID = @EventID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Name", eventName);
                            command.Parameters.AddWithValue("@Description", eventDescription);
                            command.Parameters.AddWithValue("@EventDate", eventDate);
                            command.Parameters.AddWithValue("@Location", eventLocation);
                            command.Parameters.AddWithValue("@EventID", editingEventsID);
                            command.Parameters.AddWithValue("@selectedSocietyID", selectedSocietyID);
                            command.Parameters.AddWithValue("@CreatedByUserID", Convert.ToInt32(presidentID));

                            connection.Open();
                            command.ExecuteNonQuery();
                            isEditing = false;
                        }
                    }

                    LoadEvents();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update event: " + ex.Message + editingEventsID.ToString());
                }
            }
            else
            {
                string query = @"INSERT INTO Events (SocietyID, CreatedByUserID, Name, Description, EventDate, Location) 
                    VALUES (@SocietyID, @CreatedByUserID, @Name, @Description, @EventDate, @Location)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);
                            command.Parameters.AddWithValue("@CreatedByUserID", Convert.ToInt32(presidentID));
                            command.Parameters.AddWithValue("@Name", eventName);
                            command.Parameters.AddWithValue("@Description", eventDescription);
                            command.Parameters.AddWithValue("@EventDate", eventDate);
                            command.Parameters.AddWithValue("@Location", eventLocation);

                            connection.Open();
                            command.ExecuteNonQuery();
                            LoadEvents();
                            ResetForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add event: " + ex.Message);
                }
            }
        }

        private void titles_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            PresidentLogin presidentLogin = new PresidentLogin(presidentName, presidentID);
            presidentLogin.Show();
            this.Close();
        }

        private void SocietyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void ResetForm()
        {
            title.Text = string.Empty;
            desscreption.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            venueTextBox.Text = string.Empty;
            EventsGrid.ClearSelection();
        }

        private void desscreption_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (EventsGrid.SelectedRows.Count > 0)
            {
                int selectedEventID = Convert.ToInt32(EventsGrid.SelectedRows[0].Cells["EventID"].Value);

                string query = "DELETE FROM Events WHERE EventID = @EventID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EventID", selectedEventID);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    LoadEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete event: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to delete.");
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (EventsGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = EventsGrid.SelectedRows[0];

                title.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                desscreption.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["EventDate"].Value);
                venueTextBox.Text = Convert.ToString(selectedRow.Cells["Location"].Value);

                int societyID = Convert.ToInt32(selectedRow.Cells["SocietyID"].Value);
                isEditing = true;
                editingEventsID = Convert.ToInt32(selectedRow.Cells["EventID"].Value);
            }
            else
            {
                MessageBox.Show("Please select an event to edit.");
            }
        }

      
    }
}
