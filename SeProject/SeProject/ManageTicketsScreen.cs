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


namespace SeProject
{
    public partial class ManageTicketsScreen : Form
    {
        string presidentName;
        string presidentID;
        int selectedSocietyID = -1;
        int selectedEventID = -1;

        public ManageTicketsScreen(string name, string id)
        {
            InitializeComponent();
            this.presidentName = name;
            this.presidentID = id;
        }

        public class EventsItem
        {
            public int EventID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
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

        private void LoadEvents()
        {
            SocietyItem selectedSociety = (SocietyItem)SocietyCombobox.SelectedItem;
            selectedSocietyID = selectedSociety.SocietyID;
            string query = @"SELECT EventID, SocietyID, CreatedByUserID, Name, Description, EventDate, Location
                FROM Events
                WHERE CreatedByUserID = @CreatedByUserID AND SocietyID = @SocietyID
                ORDER BY EventDate DESC";



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

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                eventsComboBox.Items.Clear();

                                while (reader.Read())
                                {
                                    eventsComboBox.Items.Add(new EventsItem
                                    {
                                        EventID = reader.GetInt32(0),
                                        Name = reader.GetString(3)
                                    });
                                }
                            }
                        }


                    }
                }

                eventsComboBox.DisplayMember = "Name";
                eventsComboBox.ValueMember = "EventID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load events: " + ex.Message);
            }
        }
        private void ManageTicketsScreen_Load(object sender, EventArgs e)
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
        private void LoadTickets()
        {
            EventsItem selectedEvent = (EventsItem)eventsComboBox.SelectedItem;
            selectedEventID = selectedEvent.EventID;
            if (selectedSocietyID != -1 && selectedEventID != -1)
            {
                string query = @"SELECT TicketID, EventID, UserID, IssueDate, TicketStatus
                    FROM Tickets
                    WHERE EventID = @EventID";
                DataTable ticketsTable = new DataTable();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EventID", selectedEventID);

                            connection.Open();



                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(ticketsTable);
                            }
                        }
                    }
                    TicketsGrid.DataSource = ticketsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load tickets: " + ex.Message);
                }
            }
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

        private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (TicketsGrid.SelectedRows.Count > 0)
            {
                int selectedticketID = Convert.ToInt32(TicketsGrid.SelectedRows[0].Cells["TicketID"].Value);

                string query = "DELETE FROM Tickets WHERE TicketID = @TicketID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TicketID", selectedticketID);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete Ticket: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an Ticket to delete.");
            }
            LoadTickets();

        }





        private void generateButton_Click(object sender, EventArgs e)
        {
            if (selectedEventID == -1)
            {
                MessageBox.Show("Please select an event.");
                return;
            }

            string noOfTicketsTextInput = noOfTicketsText.Text;
            int noOfTickets;

            if (string.IsNullOrEmpty(noOfTicketsTextInput) || !int.TryParse(noOfTicketsTextInput, out noOfTickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    for (int i = 0; i < noOfTickets; i++)
                    {
                        using (SqlCommand command = new SqlCommand("INSERT INTO Tickets (EventID, TicketStatus) VALUES (@EventID, @TicketStatus)", connection))
                        {
                            command.Parameters.AddWithValue("@EventID", selectedEventID);
                            command.Parameters.AddWithValue("@TicketStatus", "New");

                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Tickets generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate tickets: " + ex.Message);
            }
            LoadTickets();
            ResetForm();
            // Use the noOfTickets variable for further processing
        }


        private void noOfTicketsText_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetForm()
        {
            // Clear the selected society and event
            SocietyCombobox.SelectedIndex = -1;
            eventsComboBox.SelectedIndex = -1;

            // Clear the tickets grid

            // Clear the number of tickets text box
            noOfTicketsText.Text = string.Empty;
        }
    }




}
