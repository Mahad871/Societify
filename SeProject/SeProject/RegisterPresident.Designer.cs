namespace SeProject
{
    partial class RegisterPresident
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            email1 = new TextBox();
            name = new TextBox();
            rollnum = new TextBox();
            password1 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.societify;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(650, 39);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 1;
            label1.Text = "Register President";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // email1
            // 
            email1.Location = new Point(650, 112);
            email1.Name = "email1";
            email1.PlaceholderText = "Enter Email";
            email1.Size = new Size(190, 23);
            email1.TabIndex = 2;
            // 
            // name
            // 
            name.Location = new Point(650, 160);
            name.Name = "name";
            name.PlaceholderText = "Enter President Name";
            name.Size = new Size(190, 23);
            name.TabIndex = 3;
            // 
            // rollnum
            // 
            rollnum.Location = new Point(650, 208);
            rollnum.Name = "rollnum";
            rollnum.PlaceholderText = "Enter Roll Number";
            rollnum.Size = new Size(190, 23);
            rollnum.TabIndex = 4;
            // 
            // password1
            // 
            password1.Location = new Point(650, 260);
            password1.Name = "password1";
            password1.PlaceholderText = "Enter Password";
            password1.Size = new Size(190, 23);
            password1.TabIndex = 5;
            password1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(683, 323);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(887, 455);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(133, 21);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // RegisterPresident
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1032, 532);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(password1);
            Controls.Add(rollnum);
            Controls.Add(name);
            Controls.Add(email1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegisterPresident";
            Text = "RegisterPresident";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox email1;
        private TextBox name;
        private TextBox rollnum;
        private TextBox password1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}