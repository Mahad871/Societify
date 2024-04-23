namespace SeProject
{
    partial class AdminHomepage
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
            adminlabel = new Label();
            registerbtn = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
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
            // adminlabel
            // 
            adminlabel.AutoSize = true;
            adminlabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminlabel.Location = new Point(752, 45);
            adminlabel.Name = "adminlabel";
            adminlabel.Size = new Size(235, 37);
            adminlabel.TabIndex = 2;
            adminlabel.Text = "Welcome Admin ";
            adminlabel.TextAlign = ContentAlignment.TopCenter;
            adminlabel.Click += adminlabel_Click;
            // 
            // registerbtn
            // 
            registerbtn.BackColor = Color.PaleGreen;
            registerbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbtn.ForeColor = SystemColors.ButtonFace;
            registerbtn.Location = new Point(744, 225);
            registerbtn.Margin = new Padding(3, 4, 3, 4);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(215, 53);
            registerbtn.TabIndex = 3;
            registerbtn.Text = "Register President";
            registerbtn.UseVisualStyleBackColor = false;
            registerbtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(821, 119);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(1048, 587);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 28);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1179, 709);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(registerbtn);
            Controls.Add(adminlabel);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminHomepage";
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label adminlabel;
        private Button registerbtn;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}