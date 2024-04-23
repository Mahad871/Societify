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
    public partial class AnnouncementsMember : Form
    {
        string memberName;
        string MemberID;
        SocietyItem selectedSociety;
        public AnnouncementsMember(string name, string id)
        {
            InitializeComponent();
            memberName = name;
            MemberID = id;
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

        private void AnnouncementsMember_Load(object sender, EventArgs e)
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
                    command.Parameters.AddWithValue("@UserID", MemberID);

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
                SELECT Title, Content, DatePosted
                FROM Announcements
                WHERE SocietyID = @SocietyID
                ORDER BY DatePosted DESC";

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

                announcemntsgrid.DataSource = announcementsTable;
                CustomizeGridView(announcemntsgrid);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load announcements: " + ex.Message);
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

        private void back_Click(object sender, EventArgs e)
        {
            MemberHomePage memberHomePage = new MemberHomePage(memberName, MemberID);
            memberHomePage.Show();
            this.Hide();
        }

        private void SocietyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSociety = (SocietyItem)SocietyCombobox.SelectedItem;

            LoadAnnouncements();
        }
    }
}
