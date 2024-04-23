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
            LoadAnnouncements();
        }

        private void LoadAnnouncements()
        {
            string query = @"
            SELECT AnnouncementID, SocietyID, Title, Content, DatePosted
            FROM Announcements
            WHERE PostedByUserID = @PostedByUserID
            ORDER BY DatePosted DESC";

            DataTable announcementsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PostedByUserID", Convert.ToInt32(presidentID));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            adapter.Fill(announcementsTable);
                        }
                    }
                }

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
            string announcementContent = announcements.Text;
            string title = titles.Text;
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
                string updateQuery = @"
            UPDATE Announcements 
            SET Title = @Title, 
                Content = @Content, 
                SocietyID = @SocietyID,
                DatePosted = GETDATE()
            WHERE AnnouncementID = @AnnouncementID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Content", announcementContent);
                            command.Parameters.AddWithValue("@SocietyID", selectedSocietyID);
                            command.Parameters.AddWithValue("@AnnouncementID", editingAnnouncementID);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    ResetForm();
                    LoadAnnouncements();
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
                            command.Parameters.AddWithValue("@PostedByUserID", Convert.ToInt32(presidentID));
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Content", announcementContent);

                            connection.Open();
                            command.ExecuteNonQuery();
                            ResetForm();
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
            titles.Clear();
            announcements.Clear();
            SocietyCombobox.SelectedIndex = -1;

            isEditing = false;
            editingAnnouncementID = -1;

            add.Text = "Add Announcement";
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
            if (announcemntsgrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = announcemntsgrid.SelectedRows[0].Index;
                if (selectedRowIndex != -1)
                {
                    int announcementID = Convert.ToInt32(announcemntsgrid.Rows[selectedRowIndex].Cells["AnnouncementID"].Value);

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
                                    LoadAnnouncements();
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
                int societyIDToSelect = Convert.ToInt32(selectedRow.Cells["SocietyID"].Value);

                titles.Text = title;
                announcements.Text = content;

                foreach (var item in SocietyCombobox.Items)
                {
                    SocietyItem societyItem = item as SocietyItem;
                    if (societyItem != null && societyItem.SocietyID == societyIDToSelect)
                    {
                        SocietyCombobox.SelectedItem = societyItem;
                        break;
                    }
                }

                add.Text = "Save Announcement";
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Please select an announcement to edit.");
            }
        }

    }
}
