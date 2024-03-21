namespace SeProject
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            name = new TextBox();
            Password = new TextBox();
            signupbtn = new Button();
            Email = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.societify;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 532);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(621, 57);
            label1.Name = "label1";
            label1.Size = new Size(245, 31);
            label1.TabIndex = 2;
            label1.Text = "Admin Registration";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 140);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter UserID";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(621, 235);
            name.Name = "name";
            name.PlaceholderText = "Enter Admin Name";
            name.Size = new Size(245, 23);
            name.TabIndex = 5;
            name.TextChanged += name_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(621, 285);
            Password.Name = "Password";
            Password.PlaceholderText = "Enter Password";
            Password.Size = new Size(245, 23);
            Password.TabIndex = 6;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.Firebrick;
            signupbtn.ForeColor = SystemColors.ButtonFace;
            signupbtn.Location = new Point(687, 354);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(104, 31);
            signupbtn.TabIndex = 7;
            signupbtn.Text = "Sign Up";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // Email
            // 
            Email.Location = new Point(621, 189);
            Email.Name = "Email";
            Email.PlaceholderText = "Enter Your Email";
            Email.Size = new Size(245, 23);
            Email.TabIndex = 8;
            Email.TextChanged += Email_TextChanged_1;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1032, 532);
            Controls.Add(Email);
            Controls.Add(signupbtn);
            Controls.Add(Password);
            Controls.Add(name);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox name;
        private TextBox Password;
        private Button signupbtn;
        private TextBox Email;
    }
}