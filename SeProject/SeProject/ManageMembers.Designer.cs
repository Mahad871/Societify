namespace SeProject
{
    partial class ManageMembers
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
            role = new Panel();
            label3 = new Label();
            RoleDropDown = new ComboBox();
            SocietyCombobox = new ComboBox();
            Add_Update_Button = new Button();
            MemberRollNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BackButton = new Button();
            panel2 = new Panel();
            Delete = new Button();
            EnterSId = new TextBox();
            EnterUid = new TextBox();
            dataGridView1 = new DataGridView();
            role.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // role
            // 
            role.BackColor = SystemColors.Info;
            role.BorderStyle = BorderStyle.FixedSingle;
            role.Controls.Add(label3);
            role.Controls.Add(RoleDropDown);
            role.Controls.Add(SocietyCombobox);
            role.Controls.Add(Add_Update_Button);
            role.Controls.Add(MemberRollNo);
            role.Controls.Add(label2);
            role.Location = new Point(63, 93);
            role.Name = "role";
            role.Size = new Size(413, 522);
            role.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 255);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 11;
            label3.Text = "Role:";
            // 
            // RoleDropDown
            // 
            RoleDropDown.CausesValidation = false;
            RoleDropDown.FormattingEnabled = true;
            RoleDropDown.Items.AddRange(new object[] { "Member" });
            RoleDropDown.Location = new Point(85, 251);
            RoleDropDown.Margin = new Padding(3, 4, 3, 4);
            RoleDropDown.Name = "RoleDropDown";
            RoleDropDown.Size = new Size(300, 28);
            RoleDropDown.Sorted = true;
            RoleDropDown.TabIndex = 10;
            RoleDropDown.Text = "select Role";
            RoleDropDown.SelectedIndexChanged += RoleDropDown_SelectedIndexChanged;
            // 
            // SocietyCombobox
            // 
            SocietyCombobox.FormattingEnabled = true;
            SocietyCombobox.Items.AddRange(new object[] { "Select Society" });
            SocietyCombobox.Location = new Point(27, 172);
            SocietyCombobox.Name = "SocietyCombobox";
            SocietyCombobox.Size = new Size(356, 28);
            SocietyCombobox.TabIndex = 9;
            SocietyCombobox.Text = "Select Society";
            SocietyCombobox.SelectedIndexChanged += SocietyComboBox_SelectedIndexChanged;
            // 
            // Add_Update_Button
            // 
            Add_Update_Button.BackColor = SystemColors.GradientActiveCaption;
            Add_Update_Button.FlatStyle = FlatStyle.Flat;
            Add_Update_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Update_Button.Location = new Point(105, 439);
            Add_Update_Button.Name = "Add_Update_Button";
            Add_Update_Button.Size = new Size(169, 45);
            Add_Update_Button.TabIndex = 8;
            Add_Update_Button.Text = "Add";
            Add_Update_Button.UseVisualStyleBackColor = false;
            Add_Update_Button.Click += Add_Update_Button_Click;
            // 
            // MemberRollNo
            // 
            MemberRollNo.AccessibleName = "";
            MemberRollNo.Location = new Point(27, 119);
            MemberRollNo.Name = "MemberRollNo";
            MemberRollNo.PlaceholderText = "Member Roll no";
            MemberRollNo.Size = new Size(356, 27);
            MemberRollNo.TabIndex = 6;
            MemberRollNo.TextChanged += Name_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 29);
            label2.Name = "label2";
            label2.Size = new Size(186, 38);
            label2.TabIndex = 5;
            label2.Text = "Add Member";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 44);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 6;
            label1.Text = "Manage Members";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(63, 41);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(165, 40);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(EnterSId);
            panel2.Controls.Add(EnterUid);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(509, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 522);
            panel2.TabIndex = 8;
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.GradientActiveCaption;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(576, 467);
            Delete.Name = "Delete";
            Delete.Size = new Size(169, 45);
            Delete.TabIndex = 12;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // EnterSId
            // 
            EnterSId.Location = new Point(296, 476);
            EnterSId.Name = "EnterSId";
            EnterSId.PlaceholderText = "Enter Society ID";
            EnterSId.Size = new Size(236, 27);
            EnterSId.TabIndex = 3;
            // 
            // EnterUid
            // 
            EnterUid.Location = new Point(18, 476);
            EnterUid.Name = "EnterUid";
            EnterUid.PlaceholderText = "Enter User ID";
            EnterUid.Size = new Size(263, 27);
            EnterUid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(759, 415);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ManageMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 657);
            Controls.Add(role);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Controls.Add(panel2);
            Name = "ManageMembers";
            Text = "ManageMembers";
            Load += ManageMembers_Load;
            role.ResumeLayout(false);
            role.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel role;
        private Button Add_Update_Button;
        private TextBox MemberRollNo;
        private Label label2;
        private Label label1;
        private Button BackButton;
        private Panel panel2;
        private ComboBox SocietyCombobox;
        private Label label3;
        private ComboBox RoleDropDown;
        private DataGridView dataGridView1;
        private TextBox EnterUid;
        private Button Delete;
        private TextBox EnterSId;
    }
}