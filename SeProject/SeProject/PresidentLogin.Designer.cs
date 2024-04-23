namespace SeProject
{
    partial class PresidentLogin
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
            pname = new Label();
            linkLabel1 = new LinkLabel();
            ManageSocietiesButton = new Button();
            ManageMember = new Button();
            manageAnnouncement = new Button();
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
            label1.Location = new Point(656, 43);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 1;
            label1.Text = "Welcome President";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pname
            // 
            pname.AutoSize = true;
            pname.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pname.Location = new Point(723, 95);
            pname.Name = "pname";
            pname.Size = new Size(65, 25);
            pname.TabIndex = 2;
            pname.Text = "label2";
            pname.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(922, 466);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 21);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ManageSocietiesButton
            // 
            ManageSocietiesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageSocietiesButton.Location = new Point(656, 151);
            ManageSocietiesButton.Margin = new Padding(3, 2, 3, 2);
            ManageSocietiesButton.Name = "ManageSocietiesButton";
            ManageSocietiesButton.Size = new Size(184, 43);
            ManageSocietiesButton.TabIndex = 4;
            ManageSocietiesButton.Text = "Manage Societies";
            ManageSocietiesButton.UseVisualStyleBackColor = true;
            ManageSocietiesButton.Click += ManageSocietiesButton_Click;
            // 
            // ManageMember
            // 
            ManageMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageMember.Location = new Point(656, 227);
            ManageMember.Margin = new Padding(3, 2, 3, 2);
            ManageMember.Name = "ManageMember";
            ManageMember.Size = new Size(184, 43);
            ManageMember.TabIndex = 5;
            ManageMember.Text = "Manage Members";
            ManageMember.UseVisualStyleBackColor = true;
            ManageMember.Click += ManageMember_Click;
            // 
            // manageAnnouncement
            // 
            manageAnnouncement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageAnnouncement.Location = new Point(656, 309);
            manageAnnouncement.Name = "manageAnnouncement";
            manageAnnouncement.Size = new Size(184, 43);
            manageAnnouncement.TabIndex = 6;
            manageAnnouncement.Text = "Manage Announcement";
            manageAnnouncement.UseVisualStyleBackColor = true;
            manageAnnouncement.Click += manageAnnouncement_Click;
            // 
            // PresidentLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1032, 532);
            Controls.Add(manageAnnouncement);
            Controls.Add(ManageMember);
            Controls.Add(ManageSocietiesButton);
            Controls.Add(linkLabel1);
            Controls.Add(pname);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PresidentLogin";
            Text = "PresidentLogin";
            Load += PresidentLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label pname;
        private LinkLabel linkLabel1;
        private Button ManageSocietiesButton;
        private Button ManageMember;
        private Button manageAnnouncement;
    }
}