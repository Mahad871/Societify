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
    public partial class EventsMember : Form
    {


        string memberName;
        string memberID;
        SocietyItem selectedSociety;
        public EventsMember(string name, string id)
        {
            InitializeComponent();
            memberName = name;
            memberID = id;
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
        private void EventsMember_Load(object sender, EventArgs e)
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
                    // Add the presidentID parameter to the command
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


        private void LoadAnnouncements()
        {
            string query = @"
            SELECT Name, Description, EventDate, Location as Venue
            FROM Events
            WHERE SocietyID = @SocietyID
            ORDER BY EventDate DESC";// Gets the latest announcements at the top

            DataTable announcementsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        command.Parameters.AddWithValue("@SocietyID", selectedSociety.SocietyID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            adapter.Fill(announcementsTable);
                        }
                    }
                }

                // Assuming 'announcementsGrid' is the name of your DataGridView
                Eventsgrid.DataSource = announcementsTable;
                CustomizeGridView(Eventsgrid);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load announcements: " + ex.Message);
            }
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





        private void back_Click(object sender, EventArgs e)
        {
            MemberHomePage memberHomePage = new MemberHomePage(memberName, memberID);
            memberHomePage.Show();
            this.Hide();
        }

        private void Eventsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SocietyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSociety = (SocietyItem)SocietyCombobox.SelectedItem;
            LoadAnnouncements();
        }
    }
}
