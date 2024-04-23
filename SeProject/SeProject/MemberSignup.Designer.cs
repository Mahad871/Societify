namespace SeProject
{
    partial class MemberSignup
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
            member1 = new TextBox();
            rollnum1 = new TextBox();
            passwd1 = new TextBox();
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
            label1.Location = new Point(637, 50);
            label1.Name = "label1";
            label1.Size = new Size(220, 30);
            label1.TabIndex = 1;
            label1.Text = "Member Registration";
            // 
            // email1
            // 
            email1.Location = new Point(637, 130);
            email1.Name = "email1";
            email1.PlaceholderText = "Enter Email";
            email1.Size = new Size(205, 23);
            email1.TabIndex = 2;
            // 
            // member1
            // 
            member1.Location = new Point(637, 182);
            member1.Name = "member1";
            member1.PlaceholderText = "Enter Member Name";
            member1.Size = new Size(205, 23);
            member1.TabIndex = 3;
            // 
            // rollnum1
            // 
            rollnum1.Location = new Point(637, 235);
            rollnum1.Name = "rollnum1";
            rollnum1.PlaceholderText = "Enter Roll Number";
            rollnum1.Size = new Size(205, 23);
            rollnum1.TabIndex = 4;
            // 
            // passwd1
            // 
            passwd1.Location = new Point(637, 288);
            passwd1.Name = "passwd1";
            passwd1.PlaceholderText = "Enter Password";
            passwd1.Size = new Size(205, 23);
            passwd1.TabIndex = 5;
            passwd1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(688, 354);
            button1.Name = "button1";
            button1.Size = new Size(104, 31);
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
            linkLabel1.Location = new Point(864, 467);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 21);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back To HomePage";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MemberSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1032, 532);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(passwd1);
            Controls.Add(rollnum1);
            Controls.Add(member1);
            Controls.Add(email1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MemberSignup";
            Text = "MemberSignup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox email1;
        private TextBox member1;
        private TextBox rollnum1;
        private TextBox passwd1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}