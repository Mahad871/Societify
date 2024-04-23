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
            ManageEventsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.societify;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 709);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(750, 57);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 1;
            label1.Text = "Welcome President";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pname
            // 
            pname.AutoSize = true;
            pname.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pname.Location = new Point(826, 127);
            pname.Name = "pname";
            pname.Size = new Size(83, 32);
            pname.TabIndex = 2;
            pname.Text = "label2";
            pname.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(1054, 621);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 28);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ManageSocietiesButton
            // 
            ManageSocietiesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageSocietiesButton.Location = new Point(750, 201);
            ManageSocietiesButton.Name = "ManageSocietiesButton";
            ManageSocietiesButton.Size = new Size(210, 57);
            ManageSocietiesButton.TabIndex = 4;
            ManageSocietiesButton.Text = "Manage Societies";
            ManageSocietiesButton.UseVisualStyleBackColor = true;
            ManageSocietiesButton.Click += ManageSocietiesButton_Click;
            // 
            // ManageMember
            // 
            ManageMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageMember.Location = new Point(750, 303);
            ManageMember.Name = "ManageMember";
            ManageMember.Size = new Size(210, 57);
            ManageMember.TabIndex = 5;
            ManageMember.Text = "Manage Members";
            ManageMember.UseVisualStyleBackColor = true;
            ManageMember.Click += ManageMember_Click;
            // 
            // manageAnnouncement
            // 
            manageAnnouncement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageAnnouncement.Location = new Point(750, 412);
            manageAnnouncement.Margin = new Padding(3, 4, 3, 4);
            manageAnnouncement.Name = "manageAnnouncement";
            manageAnnouncement.Size = new Size(210, 57);
            manageAnnouncement.TabIndex = 6;
            manageAnnouncement.Text = "Manage Announcement";
            manageAnnouncement.UseVisualStyleBackColor = true;
            manageAnnouncement.Click += manageAnnouncement_Click;
            // 
            // ManageEventsButton
            // 
            ManageEventsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageEventsButton.Location = new Point(750, 508);
            ManageEventsButton.Margin = new Padding(3, 4, 3, 4);
            ManageEventsButton.Name = "ManageEventsButton";
            ManageEventsButton.Size = new Size(210, 57);
            ManageEventsButton.TabIndex = 7;
            ManageEventsButton.Text = "Manage Events";
            ManageEventsButton.UseVisualStyleBackColor = true;
            ManageEventsButton.Click += ManageEventsButton_Click;
            // 
            // PresidentLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1179, 709);
            Controls.Add(ManageEventsButton);
            Controls.Add(manageAnnouncement);
            Controls.Add(ManageMember);
            Controls.Add(ManageSocietiesButton);
            Controls.Add(linkLabel1);
            Controls.Add(pname);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button ManageEventsButton;
    }
}