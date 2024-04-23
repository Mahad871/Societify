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
    public partial class AdminHomepage : Form
    {
        public AdminHomepage(string adminName)
        {
            InitializeComponent();
            label1.Text += adminName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPresident registerPresident=new RegisterPresident(label1.Text);
            registerPresident.Show();
            this.Hide();

        }

        private void adminlabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
