namespace SeProject
{
    partial class ManageAnnouncement
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            SocietyCombobox = new ComboBox();
            add = new Button();
            announcements = new TextBox();
            titles = new TextBox();
            label1 = new Label();
            back = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            editbutton = new Button();
            deletebutton = new Button();
            announcemntsgrid = new DataGridView();
            label2 = new Label();
            databaseGeneratedAttributeBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)announcemntsgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(SocietyCombobox);
            panel1.Controls.Add(add);
            panel1.Controls.Add(announcements);
            panel1.Controls.Add(titles);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 70);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 392);
            panel1.TabIndex = 0;
            // 
            // SocietyCombobox
            // 
            SocietyCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SocietyCombobox.FormattingEnabled = true;
            SocietyCombobox.Location = new Point(24, 129);
            SocietyCombobox.Margin = new Padding(3, 2, 3, 2);
            SocietyCombobox.Name = "SocietyCombobox";
            SocietyCombobox.Size = new Size(312, 23);
            SocietyCombobox.TabIndex = 4;
            SocietyCombobox.SelectedIndexChanged += SocietyCombobox_SelectedIndexChanged;
            // 
            // add
            // 
            add.BackColor = SystemColors.GradientActiveCaption;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(104, 319);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.Size = new Size(148, 34);
            add.TabIndex = 3;
            add.Text = "Add Announcement";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // announcements
            // 
            announcements.Location = new Point(24, 168);
            announcements.Multiline = true;
            announcements.Name = "announcements";
            announcements.PlaceholderText = "Add Announcement Content";
            announcements.Size = new Size(312, 122);
            announcements.TabIndex = 2;
            announcements.TextChanged += announcement_TextChanged;
            // 
            // titles
            // 
            titles.Location = new Point(24, 89);
            titles.Margin = new Padding(3, 2, 3, 2);
            titles.Name = "titles";
            titles.PlaceholderText = "Announcement Title";
            titles.Size = new Size(312, 23);
            titles.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 19);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 0;
            label1.Text = "Add Announcement";
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(55, 31);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(144, 30);
            back.TabIndex = 1;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(editbutton);
            panel2.Controls.Add(deletebutton);
            panel2.Controls.Add(announcemntsgrid);
            panel2.Location = new Point(455, 70);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 392);
            panel2.TabIndex = 2;
            // 
            // editbutton
            // 
            editbutton.BackColor = SystemColors.GradientActiveCaption;
            editbutton.FlatStyle = FlatStyle.Flat;
            editbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbutton.Location = new Point(16, 350);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(148, 34);
            editbutton.TabIndex = 2;
            editbutton.Text = "Edit";
            editbutton.UseVisualStyleBackColor = false;
            editbutton.Click += editbutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.BackColor = SystemColors.GradientActiveCaption;
            deletebutton.FlatStyle = FlatStyle.Flat;
            deletebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebutton.Location = new Point(532, 350);
            deletebutton.Margin = new Padding(3, 2, 3, 2);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(148, 34);
            deletebutton.TabIndex = 1;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // announcemntsgrid
            // 
            announcemntsgrid.BackgroundColor = Color.Honeydew;
            announcemntsgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            announcemntsgrid.Location = new Point(16, 22);
            announcemntsgrid.Margin = new Padding(3, 2, 3, 2);
            announcemntsgrid.Name = "announcemntsgrid";
            announcemntsgrid.RowHeadersWidth = 51;
            announcemntsgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            announcemntsgrid.Size = new Size(664, 311);
            announcemntsgrid.TabIndex = 0;
            announcemntsgrid.CellContentClick += announcemntsgrid_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(495, 33);
            label2.Name = "label2";
            label2.Size = new Size(259, 30);
            label2.TabIndex = 3;
            label2.Text = "Manage Announcements";
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            // 
            // ManageAnnouncement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1196, 493);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(back);
            Controls.Add(panel1);
            Name = "ManageAnnouncement";
            Text = "ManageAnnouncement";
            Load += ManageAnnouncement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)announcemntsgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button back;
        private Label label1;
        private TextBox titles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox announcements;
        private Button add;
        private Panel panel2;
        private Label label2;
        private BindingSource databaseGeneratedAttributeBindingSource;
        private DataGridView announcemntsgrid;
        private ComboBox SocietyCombobox;
        private Button deletebutton;
        private Button editbutton;
    }
}