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
using static SeProject.ManageMembers;
using static SeProject.constants;
using Microsoft.VisualBasic.ApplicationServices;

namespace SeProject
{
    public partial class ManageAnnouncement : Form
    {
        string presidentName;
        string presidentID;
        int selectedSocietyID = -1;
        private bool isEditing = false;
        private int editingAnnouncementID = -1;

        public ManageAnnouncement(string presidentName, string presidentID)
        {
            InitializeComponent();
            this.presidentName = presidentName;
            this.presidentID = presidentID;
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

        private void ManageAnnouncement_Load(object sender, EventArgs e)
        {
            // Adjust the query to select societies where the current president is presiding
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
            LoadAnnouncements();
        }

        private void LoadAnnouncements()
        {
            string query = @"
        SELECT AnnouncementID, SocietyID, Title, Content, DatePosted
        FROM Announcements
        WHERE PostedByUserID = @PostedByUserID
        ORDER BY DatePosted DESC";// Gets the latest announcements at the top

            DataTable announcementsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use the presidentID to filter the announcements
                        command.Parameters.AddWithValue("@PostedByUserID", Convert.ToInt32(presidentID));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            adapter.Fill(announcementsTable);
                        }
                    }
                }

                // Assuming 'announcementsGrid' is the name of your DataGridView
                announcemntsgrid.DataSource = announcementsTable;
                CustomizeGridView(announcemntsgrid);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load announcements: " + ex.Message);
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            PresidentLogin presidentLogin = new PresidentLogin(presidentName, presidentID);
            presidentLogin.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {

            string announcementContent = announcements.Text; // Assuming 'announcements' is a TextBox for announcement content
            string title = titles.Text; // Assuming 'titles' is a TextBox for the title
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

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(announcementContent))
            {
                MessageBox.Show("Title and announcement content cannot be empty.");
                return;
            }

            if (isEditing)
            {
                // Logic to update the existing announcement
                string updateQuery = @"
        UPDATE Announcements 
        SET Title = @Title, 
            Content = @Content, 
            SocietyID = @SocietyID,
            DatePosted = GETDATE()  -- Use GETDATE() to set the current date and time
        WHERE AnnouncementID = @AnnouncementID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Add parameters for update
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Content", announcementContent);
                            command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);
                            command.Parameters.AddWithValue("@AnnouncementID", editingAnnouncementID);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    // Reset the form
                    ResetForm();
                    LoadAnnouncements(); // Refresh the grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update announcement: " + ex.Message);
                }
            }
            else
            {
                string query = @"
        INSERT INTO Announcements (SocietyID, PostedByUserID, Title, Content) 
        VALUES (@SocietyID, @PostedByUserID, @Title, @Content)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);
                            command.Parameters.AddWithValue("@PostedByUserID", Convert.ToInt32(presidentID)); // Assuming presidentID is the PostedByUserID
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Content", announcementContent);

                            connection.Open();
                            command.ExecuteNonQuery();
                            /* MessageBox.Show("Announcement added successfully!");*/
                            LoadAnnouncements();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add announcement: " + ex.Message);
                }
            }
        }

        private void ResetForm()
        {
            // Reset the form fields
            titles.Clear();
            announcements.Clear();
            SocietyCombobox.SelectedIndex = -1;

            // Reset flags
            isEditing = false;
            editingAnnouncementID = -1;

            // Change the button text back to "Add Announcement"
            add.Text = "Add Announcement";
        }

        private void CustomizeGridView(DataGridView gridView)
        {
            // Basic visual customization
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font(gridView.Font, FontStyle.Bold);

            gridView.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            gridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating rows style
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Grid lines
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.GridColor = Color.LightGray;

            // Adjust row heights
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Hide scroll bars if not needed
            gridView.ScrollBars = ScrollBars.Both;

            // Improve the appearance of the selection
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.MultiSelect = false;

            // Read-only mode to prevent direct editing in the grid view
            gridView.ReadOnly = true;

            // Set the AutoSizeColumnsMode to Fill to ensure that columns fill the grid width
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void SocietyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void announcement_TextChanged(object sender, EventArgs e)
        {

        }

        private void announcemntsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (announcemntsgrid.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView's SelectionMode is set to FullRowSelect
                int selectedRowIndex = announcemntsgrid.SelectedRows[0].Index;
                if (selectedRowIndex != -1)
                {
                    // Get the AnnouncementID of the selected row
                    int announcementID = Convert.ToInt32(announcemntsgrid.Rows[selectedRowIndex].Cells["AnnouncementID"].Value);

                    // Prepare SQL DELETE query
                    string query = "DELETE FROM Announcements WHERE AnnouncementID = @AnnouncementID";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@AnnouncementID", announcementID);

                                connection.Open();
                                int result = command.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    //MessageBox.Show("Announcement deleted successfully.");
                                    LoadAnnouncements(); // Refresh the DataGridView
                                }
                                else
                                {
                                    MessageBox.Show("The announcement could not be deleted.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete announcement: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an announcement to delete.");
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (announcemntsgrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = announcemntsgrid.SelectedRows[0];

                editingAnnouncementID = Convert.ToInt32(selectedRow.Cells["AnnouncementID"].Value);
                string title = Convert.ToString(selectedRow.Cells["Title"].Value);
                string content = Convert.ToString(selectedRow.Cells["Content"].Value);
                int societyIDToSelect = Convert.ToInt32(selectedRow.Cells["SocietyID"].Value); // Assuming SocietyID column exists

                // Set the announcement content and title in the textboxes
                titles.Text = title;
                announcements.Text = content;

                // Find and set the correct society in the combobox
                foreach (var item in SocietyCombobox.Items)
                {
                    SocietyItem societyItem = item as SocietyItem;
                    if (societyItem != null && societyItem.SocietyID == societyIDToSelect)
                    {
                        SocietyCombobox.SelectedItem = societyItem;
                        break;
                    }
                }

                // Change button text to indicate that it will save changes, not add a new announcement
                add.Text = "Save Announcement"; // Assuming the button is named addAnnouncementButton
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Please select an announcement to edit.");
            }
        }

    }
}
