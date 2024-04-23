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
using static SeProject.ManageTicketsScreen;
using static SeProject.constants;

namespace SeProject
{
    public partial class BuyTickets : Form
    {

        string memberName;
        string memberID;
        int selectedSocietyID = -1;
        int selectedEventID = -1;
        SocietyItem selectedSociety;


        public BuyTickets(string name, string id)
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
        private void BuyTickets_Load(object sender, EventArgs e)
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

        private void LoadTickets()
        {
            EventsItemm selectedEvent = (EventsItemm)eventsComboBox.SelectedItem;
            selectedEventID = selectedEvent.EventID;
            if (selectedSocietyID != -1 && selectedEventID != -1)
            {
                string query = @"SELECT TicketID, EventID, UserID, IssueDate, TicketStatus
                    FROM Tickets
                    WHERE EventID = @EventID AND TicketStatus = 'New'";
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
                    CustomizeGridView(TicketsGrid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load tickets: " + ex.Message);
                }
            }
        }


        private void CustomizeGridView(DataGridView gridView)
        {
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font(gridView.Font, FontStyle.Bold);

            gridView.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            gridView.DefaultCellStyle.SelectionForeColor = Color.White;

            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.GridColor = Color.LightGray;

            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            gridView.ScrollBars = ScrollBars.Both;

            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.MultiSelect = false;

            gridView.ReadOnly = true;

            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //private void SocietyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("chnages");
        //    LoadEvents();
        //}

        private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TicketsGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = TicketsGrid.SelectedRows[0].Index;
                int ticketID = Convert.ToInt32(TicketsGrid.Rows[selectedRowIndex].Cells["TicketID"].Value);

                string updateQuery = @"UPDATE Tickets SET TicketStatus = 'Paid' WHERE TicketID = @TicketID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@TicketID", ticketID);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Ticket Bought Successfully.");
                                LoadTickets();

                            }
                            else
                            {
                                MessageBox.Show("Failed to update ticket status.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update ticket status: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket from the gridview.");
            }

        }

        private void SocietyCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show("chnages");
            LoadEvents();
        }

        private void databaseGeneratedAttributeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }


}
