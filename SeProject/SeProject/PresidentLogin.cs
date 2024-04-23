using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static SeProject.constants;


namespace SeProject
{
    public partial class PresidentLogin : Form
    {
        string presidentName;
        string presidentID;

        public PresidentLogin(string name, string id)
        {
            InitializeComponent();
            presidentName = name;
            pname.Text = presidentName;
            presidentID = id;
        }

        private void PresidentLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ManageSocietiesButton_Click(object sender, EventArgs e)
        {
            ManageSociety manageSociety = new ManageSociety(presidentName, presidentID);
            manageSociety.Show();
            this.Hide();
        }

        private void ManageMember_Click(object sender, EventArgs e)
        {
            ManageMembers manageSociety = new ManageMembers(presidentName, presidentID);
            manageSociety.Show();
            this.Hide();
        }

        private void manageAnnouncement_Click(object sender, EventArgs e)
        {
            ManageAnnouncement manageSociety = new ManageAnnouncement(presidentName, presidentID);
            manageSociety.Show();
            this.Hide();
        }

        private void ManageEventsButton_Click(object sender, EventArgs e)
        {
            ManageEvents manageSociety = new ManageEvents(presidentName, presidentID);
            manageSociety.Show();
            this.Hide();
        }
    }
}
