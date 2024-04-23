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
    public partial class VerifyTicket : Form
    {

        string memberName;
        string memberID;
        int selectedSocietyID = -1;
        int selectedEventID = -1;
        SocietyItem selectedSociety;
        public VerifyTicket(string name, string id)
        {
            InitializeComponent();
            memberName = name;
            memberID = id;
        }
        public class EventsItemm
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
            SocietyItem selectedSocietyy = (SocietyItem)SocietyCombobox.SelectedItem;
            selectedSociety = selectedSociety;
            selectedSocietyID = selectedSocietyy.SocietyID;

            string query = @"
                SELECT EventID, Name
                FROM Events
                WHERE SocietyID = @SocietyID
                ORDER BY EventDate DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (selectedSocietyID != -1)
                        {
                            command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                eventsComboBox.Items.Clear();

                                while (reader.Read())
                                {

                                    eventsComboBox.Items.Add(new EventsItemm
                                    {
                                        EventID = reader.GetInt32(0),
                                        Name = reader.GetString(1)
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
        private void back_Click(object sender, EventArgs e)
        {
            MemberHomePage memberHomePage = new MemberHomePage(memberName, memberID);
            memberHomePage.Show();
            this.Hide();
        }

        private void VerifyTicket_Load(object sender, EventArgs e)
        {
            string query = @"
                SELECT s.SocietyID, s.Name 
                FROM Societies s
                INNER JOIN Memberships m ON s.SocietyID = m.SocietyID
                WHERE m.UserID = @UserID ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", memberID);

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
        private bool CheckTicket(int ticketID)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Tickets
                WHERE TicketID = @TicketID AND EventID=@EventID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketID", ticketID);
                        command.Parameters.AddWithValue("@EventID", selectedEventID);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check ticket: " + ex.Message);
                return false;
            }
        }

        private bool CheckTicketStatus(int ticketID)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Tickets
                WHERE TicketID = @TicketID AND EventID=@EventID AND TicketStatus='Paid'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketID", ticketID);
                        command.Parameters.AddWithValue("@EventID", selectedEventID);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check ticket: " + ex.Message);
                return false;
            }
        }

        private bool CheckTicketUSED(int ticketID)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Tickets
                WHERE TicketID = @TicketID AND EventID=@EventID AND TicketStatus='Used'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketID", ticketID);
                        command.Parameters.AddWithValue("@EventID", selectedEventID);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check ticket: " + ex.Message);
                return false;
            }
        }
        private void ChangeTicketStatus(int ticketID)
        {
            string query = @"
                UPDATE Tickets
                SET TicketStatus = 'Used'
                WHERE TicketID = @TicketID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TicketID", ticketID);

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change ticket status: " + ex.Message);
            }
        }

        private void SocietyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventsItemm item = (EventsItemm)eventsComboBox.SelectedItem;
            selectedEventID = item.EventID;
        }

        private void verify_Click(object sender, EventArgs e)
        {
            if (selectedEventID == -1)
            {
                MessageBox.Show("Please Select an Event");
                return;
            }
            if (selectedSocietyID == -1)
            {
                MessageBox.Show("Please Select a Society");
                return;
            }
            int ticketID;
            if (!int.TryParse(tickedIdBox.Text, out ticketID))
            {
                MessageBox.Show("Please enter a valid ticket ID");
                return;
            }

            if (CheckTicket(ticketID))
            {
                if (CheckTicketStatus(ticketID))
                {
                    ChangeTicketStatus(ticketID);
                    MessageBox.Show("Ticket Verified! This is a Valid Ticket.");


                }
                else
                {
                    if (CheckTicketUSED(ticketID))
                    {
                        MessageBox.Show("Ticket Already Used.");

                    }
                    else
                    {
                        MessageBox.Show("Ticket Not Bought.");

                    }

                }
            }
            else
            {
                MessageBox.Show("Ticket Does not Exist.");
            }


            // Rest of the code...
        }
    }






}
