namespace SeProject
{
    partial class ManageSociety
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
            label1 = new Label();
            panel1 = new Panel();
            Bio = new TextBox();
            Add_Update_Button = new Button();
            Descreption = new TextBox();
            SocietyName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            DeleteButton = new Button();
            UpdateButton = new Button();
            delete_update = new TextBox();
            dataGridView1 = new DataGridView();
            BackButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 30);
            label1.Name = "label1";
            label1.Size = new Size(184, 30);
            label1.TabIndex = 2;
            label1.Text = "Manage Societies";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Bio);
            panel1.Controls.Add(Add_Update_Button);
            panel1.Controls.Add(Descreption);
            panel1.Controls.Add(SocietyName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(20, 68);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 392);
            panel1.TabIndex = 3;
            // 
            // Bio
            // 
            Bio.Location = new Point(24, 122);
            Bio.Margin = new Padding(3, 2, 3, 2);
            Bio.Multiline = true;
            Bio.Name = "Bio";
            Bio.PlaceholderText = "Bio";
            Bio.Size = new Size(312, 48);
            Bio.TabIndex = 9;
            // 
            // Add_Update_Button
            // 
            Add_Update_Button.BackColor = SystemColors.GradientActiveCaption;
            Add_Update_Button.FlatStyle = FlatStyle.Flat;
            Add_Update_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Update_Button.Location = new Point(92, 329);
            Add_Update_Button.Margin = new Padding(3, 2, 3, 2);
            Add_Update_Button.Name = "Add_Update_Button";
            Add_Update_Button.Size = new Size(148, 34);
            Add_Update_Button.TabIndex = 8;
            Add_Update_Button.Text = "Add/Update";
            Add_Update_Button.UseVisualStyleBackColor = false;
            Add_Update_Button.Click += Add_Update_Button_Click;
            // 
            // Descreption
            // 
            Descreption.Location = new Point(24, 188);
            Descreption.Margin = new Padding(3, 2, 3, 2);
            Descreption.Multiline = true;
            Descreption.Name = "Descreption";
            Descreption.PlaceholderText = "Description";
            Descreption.Size = new Size(312, 122);
            Descreption.TabIndex = 7;
            Descreption.TextChanged += Descreption_TextChanged;
            // 
            // SocietyName
            // 
            SocietyName.AccessibleName = "";
            SocietyName.Location = new Point(24, 89);
            SocietyName.Margin = new Padding(3, 2, 3, 2);
            SocietyName.Name = "SocietyName";
            SocietyName.PlaceholderText = "Society Name";
            SocietyName.Size = new Size(312, 23);
            SocietyName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 22);
            label2.Name = "label2";
            label2.Size = new Size(225, 30);
            label2.TabIndex = 5;
            label2.Text = "Add / Update Society";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(UpdateButton);
            panel2.Controls.Add(delete_update);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(410, 68);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 392);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.GradientActiveCaption;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(532, 346);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(148, 34);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.GradientActiveCaption;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(377, 346);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(148, 34);
            UpdateButton.TabIndex = 10;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // delete_update
            // 
            delete_update.Location = new Point(19, 353);
            delete_update.Margin = new Padding(3, 2, 3, 2);
            delete_update.Name = "delete_update";
            delete_update.PlaceholderText = "Enter society ID";
            delete_update.Size = new Size(344, 23);
            delete_update.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 22);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(661, 304);
            dataGridView1.TabIndex = 1;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(20, 28);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 30);
            BackButton.TabIndex = 5;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ManageSociety
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1135, 476);
            Controls.Add(BackButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageSociety";
            Text = "ManageSociety";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private TextBox SocietyName;
        private TextBox Descreption;
        private Button Add_Update_Button;
        private TextBox Bio;
        private Button BackButton;
        private DataGridView dataGridView1;
        private Button DeleteButton;
        private Button UpdateButton;
        private TextBox delete_update;
    }
}