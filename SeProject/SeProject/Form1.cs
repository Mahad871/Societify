namespace SeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show(); // Optionally, use ShowDialog() if you want a modal form
            this.Hide(); // Hide the current form
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MemberSignup memberSignup  =new MemberSignup();
            memberSignup.Show();
            this.Hide();
        }
    }
}
