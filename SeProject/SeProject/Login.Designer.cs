namespace SeProject
{
    partial class Login
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
            RoleDropDown = new ComboBox();
            label2 = new Label();
            userid1 = new TextBox();
            password1 = new TextBox();
            loginbtn = new Button();
            back = new Button();
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
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(689, 63);
            label1.Name = "label1";
            label1.Size = new Size(123, 47);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // RoleDropDown
            // 
            RoleDropDown.CausesValidation = false;
            RoleDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleDropDown.FormattingEnabled = true;
            RoleDropDown.Items.AddRange(new object[] { "Admin", "Member", "President" });
            RoleDropDown.Location = new Point(689, 159);
            RoleDropDown.Name = "RoleDropDown";
            RoleDropDown.Size = new Size(121, 23);
            RoleDropDown.Sorted = true;
            RoleDropDown.TabIndex = 2;
            RoleDropDown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 136);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 3;
            label2.Text = "Role:";
            // 
            // userid1
            // 
            userid1.Location = new Point(637, 217);
            userid1.Name = "userid1";
            userid1.PlaceholderText = "Enter UserID";
            userid1.Size = new Size(222, 23);
            userid1.TabIndex = 4;
            userid1.TextChanged += userid_TextChanged;
            // 
            // password1
            // 
            password1.Location = new Point(637, 266);
            password1.Name = "password1";
            password1.PlaceholderText = "Enter Password";
            password1.Size = new Size(222, 23);
            password1.TabIndex = 5;
            password1.UseSystemPasswordChar = true;
            password1.TextChanged += password_TextChanged;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.PaleGreen;
            loginbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = SystemColors.ActiveCaptionText;
            loginbtn.Location = new Point(689, 332);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(121, 44);
            loginbtn.TabIndex = 6;
            loginbtn.Text = "Log In";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(438, 32);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(144, 30);
            back.TabIndex = 7;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1032, 532);
            Controls.Add(back);
            Controls.Add(loginbtn);
            Controls.Add(password1);
            Controls.Add(userid1);
            Controls.Add(label2);
            Controls.Add(RoleDropDown);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "    Log in    ";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox RoleDropDown;
        private Label label2;
        private TextBox userid1;
        private TextBox password1;
        private Button loginbtn;
        private Button back;
    }
}