namespace SeProject
{
    partial class MemberHomePage
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
            TicketsButton = new Button();
            EventsButton = new Button();
            AnnouncementsButton = new Button();
            pname = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.societify;
            pictureBox1.Location = new Point(-6, -49);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 709);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TicketsButton
            // 
            TicketsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TicketsButton.Location = new Point(785, 442);
            TicketsButton.Margin = new Padding(3, 4, 3, 4);
            TicketsButton.Name = "TicketsButton";
            TicketsButton.Size = new Size(210, 57);
            TicketsButton.TabIndex = 11;
            TicketsButton.Text = "Tickets";
            TicketsButton.UseVisualStyleBackColor = true;
            // 
            // EventsButton
            // 
            EventsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventsButton.Location = new Point(785, 333);
            EventsButton.Name = "EventsButton";
            EventsButton.Size = new Size(210, 57);
            EventsButton.TabIndex = 10;
            EventsButton.Text = "Events";
            EventsButton.UseVisualStyleBackColor = true;
            EventsButton.Click += EventsButton_Click;
            // 
            // AnnouncementsButton
            // 
            AnnouncementsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnnouncementsButton.Location = new Point(785, 231);
            AnnouncementsButton.Name = "AnnouncementsButton";
            AnnouncementsButton.Size = new Size(210, 57);
            AnnouncementsButton.TabIndex = 9;
            AnnouncementsButton.Text = "Announcements";
            AnnouncementsButton.UseVisualStyleBackColor = true;
            AnnouncementsButton.Click += AnnouncementsButton_Click;
            // 
            // pname
            // 
            pname.AutoSize = true;
            pname.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pname.Location = new Point(861, 146);
            pname.Name = "pname";
            pname.Size = new Size(83, 32);
            pname.TabIndex = 8;
            pname.Text = "label2";
            pname.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(785, 87);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 7;
            label1.Text = "Welcome member";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(1111, 555);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 28);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MemberHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 633);
            Controls.Add(linkLabel1);
            Controls.Add(TicketsButton);
            Controls.Add(EventsButton);
            Controls.Add(AnnouncementsButton);
            Controls.Add(pname);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MemberHomePage";
            Text = "MemberHomePage";
            Load += MemberHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button TicketsButton;
        private Button EventsButton;
        private Button AnnouncementsButton;
        private Label pname;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}