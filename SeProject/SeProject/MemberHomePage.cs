using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeProject
{
    public partial class MemberHomePage : Form
    {

        string memberName;
        string memberID;


        public MemberHomePage(string name, string id)
        {
            InitializeComponent();
            memberName = name;
            memberID = id;
            pname.Text = memberName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MemberHomePage_Load(object sender, EventArgs e)
        {

        }

        private void AnnouncementsButton_Click(object sender, EventArgs e)
        {
            AnnouncementsMember page = new AnnouncementsMember(memberName, memberID);
            page.Show();
            this.Hide();
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            EventsMember page = new EventsMember(memberName, memberID);
            page.Show();
            this.Hide();
        }

        private void buyTicketsButton_Click(object sender, EventArgs e)
        {
            BuyTickets page = new BuyTickets(memberName, memberID);
            page.Show();
            this.Hide();
        }

        private void VerifyTicketsButton_Click(object sender, EventArgs e)
        {
            VerifyTicket page = new VerifyTicket(memberName, memberID);
            page.Show();
            this.Hide();
        }
    }
}
