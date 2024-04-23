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
            back = new Button();
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
            label1.Location = new Point(721, 135);
            label1.Name = "label1";
            label1.Size = new Size(291, 37);
            label1.TabIndex = 1;
            label1.Text = "Member Registration";
            // 
            // email1
            // 
            email1.Location = new Point(721, 241);
            email1.Margin = new Padding(3, 4, 3, 4);
            email1.Name = "email1";
            email1.PlaceholderText = "Enter Email";
            email1.Size = new Size(234, 27);
            email1.TabIndex = 2;
            // 
            // member1
            // 
            member1.Location = new Point(721, 311);
            member1.Margin = new Padding(3, 4, 3, 4);
            member1.Name = "member1";
            member1.PlaceholderText = "Enter Member Name";
            member1.Size = new Size(234, 27);
            member1.TabIndex = 3;
            // 
            // rollnum1
            // 
            rollnum1.Location = new Point(721, 381);
            rollnum1.Margin = new Padding(3, 4, 3, 4);
            rollnum1.Name = "rollnum1";
            rollnum1.PlaceholderText = "Enter Roll Number";
            rollnum1.Size = new Size(234, 27);
            rollnum1.TabIndex = 4;
            // 
            // passwd1
            // 
            passwd1.Location = new Point(721, 452);
            passwd1.Margin = new Padding(3, 4, 3, 4);
            passwd1.Name = "passwd1";
            passwd1.PlaceholderText = "Enter Password";
            passwd1.Size = new Size(234, 27);
            passwd1.TabIndex = 5;
            passwd1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(779, 540);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 41);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(490, 49);
            back.Name = "back";
            back.Size = new Size(165, 40);
            back.TabIndex = 9;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // MemberSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1179, 709);
            Controls.Add(back);
            Controls.Add(button1);
            Controls.Add(passwd1);
            Controls.Add(rollnum1);
            Controls.Add(member1);
            Controls.Add(email1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button back;
    }
}