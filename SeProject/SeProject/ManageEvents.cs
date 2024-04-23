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

        private void LoadEvents()
        {
            SocietyItem selectedSociety = (SocietyItem)SocietyCombobox.SelectedItem;
            selectedSocietyID = selectedSociety.SocietyID;
            string query = @"
            SELECT EventID, SocietyID, CreatedByUserID, Name, Description, EventDate, Location
            FROM Events
            WHERE CreatedByUserID = @CreatedByUserID AND SocietyID = @SocietyID
            ORDER BY EventDate DESC"; // Gets the latest events at the top

            DataTable eventsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use the presidentID to filter the events
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

                // Assuming 'EventsGrid' is the name of your DataGridView
                EventsGrid.DataSource = eventsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load events: " + ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string eventName = title.Text; // Assuming 'title' is a TextBox for event name
            string eventDescription = this.desscreption.Text; // Assuming 'description' is a TextBox for event description
            DateTime eventDate = this.dateTimePicker1.Value; // Assuming 'datePicker' is a DateTimePicker for event date
            string eventLocation = this.venueTextBox.Text; // Assuming 'location' is a TextBox for event location

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
                // Logic to update the existing event
                string updateQuery = @"
                    UPDATE Events 
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
                            // Add parameters for update
                            command.Parameters.AddWithValue("@Name", eventName);
                            command.Parameters.AddWithValue("@Description", eventDescription);
                            command.Parameters.AddWithValue("@EventDate", eventDate);
                            command.Parameters.AddWithValue("@Location", eventLocation);
                            command.Parameters.AddWithValue("@EventID", editingEventsID);
                            command.Parameters.AddWithValue("@selectedSocietyID", selectedSocietyID);
                            command.Parameters.AddWithValue("@CreatedByUserID", Convert.ToInt32(presidentID)); // Assuming presidentID is the CreatedByUserID


                            connection.Open();
                            command.ExecuteNonQuery();
                            isEditing = false; // Reset the editing flag
                        }
                    }

                    
                    LoadEvents(); // Refresh the grid
                    ResetForm(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update event: " + ex.Message + editingEventsID.ToString());
                }
            }
            else
            {
                string query = @"
                INSERT INTO Events (SocietyID, CreatedByUserID, Name, Description, EventDate, Location) 
                VALUES (@SocietyID, @CreatedByUserID, @Name, @Description, @EventDate, @Location)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);
                            command.Parameters.AddWithValue("@CreatedByUserID", Convert.ToInt32(presidentID)); // Assuming presidentID is the CreatedByUserID
                            command.Parameters.AddWithValue("@Name", eventName);
                            command.Parameters.AddWithValue("@Description", eventDescription);
                            command.Parameters.AddWithValue("@EventDate", eventDate);
                            command.Parameters.AddWithValue("@Location", eventLocation);

                            connection.Open();
                            command.ExecuteNonQuery();
                            /* MessageBox.Show("Event added successfully!");*/
                            LoadEvents(); // Refresh the grid
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
            LoadEvents();
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
            // Assuming 'title', 'description', and 'location' are TextBoxes for event details
            // and 'datePicker' is a DateTimePicker for event date
            title.Text = string.Empty;
            desscreption.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            venueTextBox.Text = string.Empty;

            // If you want to reset the selected item in the SocietyCombobox
            //SocietyCombobox.SelectedIndex = -1;

            // If you have a DataGridView and you want to clear the selection
            EventsGrid.ClearSelection();
        }
        private void desscreption_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            // Assuming 'EventsGrid' is your DataGridView and it has a primary key column
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

                    // Refresh the grid
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
            // Assuming 'EventsGrid' is your DataGridView and it has columns for event details
            if (EventsGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = EventsGrid.SelectedRows[0];

                title.Text = Convert.ToString(selectedRow.Cells["Name"].Value); // Assuming 'Name' is the column name for event name
                desscreption.Text = Convert.ToString(selectedRow.Cells["Description"].Value); // Assuming 'Description' is the column name for event description
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["EventDate"].Value); // Assuming 'EventDate' is the column name for event date
                venueTextBox.Text = Convert.ToString(selectedRow.Cells["Location"].Value); // Assuming 'Location' is the column name for event location

                // If you want to select the society in the SocietyCombobox
                int societyID = Convert.ToInt32(selectedRow.Cells["SocietyID"].Value); // Assuming 'SocietyID' is the column name for society ID
                //SocietyCombobox.SelectedItem = SocietyCombobox.Items.Cast<SocietyItem>().FirstOrDefault(item => item.SocietyID == societyID);

                // Set the editing flag and store the event ID
                isEditing = true;
                editingEventsID = Convert.ToInt32(selectedRow.Cells["EventID"].Value); // Assuming 'EventID' is the column name for event ID
            }
            else
            {
                MessageBox.Show("Please select an event to edit.");
            }
        }
    }
}
