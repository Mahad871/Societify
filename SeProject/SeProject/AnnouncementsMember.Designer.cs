namespace SeProject
{
    partial class AnnouncementsMember
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
            SocietyCombobox = new ComboBox();
            back = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            announcemntsgrid = new DataGridView();
            label2 = new Label();
            databaseGeneratedAttributeBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)announcemntsgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SocietyCombobox
            // 
            SocietyCombobox.FormattingEnabled = true;
            SocietyCombobox.Location = new Point(473, 18);
            SocietyCombobox.Name = "SocietyCombobox";
            SocietyCombobox.Size = new Size(356, 28);
            SocietyCombobox.TabIndex = 4;
            SocietyCombobox.Text = "Select Society";
            SocietyCombobox.SelectedIndexChanged += SocietyCombobox_SelectedIndexChanged;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(36, 31);
            back.Name = "back";
            back.Size = new Size(165, 40);
            back.TabIndex = 5;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(SocietyCombobox);
            panel2.Controls.Add(announcemntsgrid);
            panel2.Location = new Point(36, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 549);
            panel2.TabIndex = 6;
            // 
            // announcemntsgrid
            // 
            announcemntsgrid.BackgroundColor = Color.Honeydew;
            announcemntsgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            announcemntsgrid.Location = new Point(20, 52);
            announcemntsgrid.Name = "announcemntsgrid";
            announcemntsgrid.RowHeadersWidth = 51;
            announcemntsgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            announcemntsgrid.Size = new Size(1218, 490);
            announcemntsgrid.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(602, 34);
            label2.Name = "label2";
            label2.Size = new Size(224, 37);
            label2.TabIndex = 7;
            label2.Text = "Announcements";
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            // 
            // AnnouncementsMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 637);
            Controls.Add(back);
            Controls.Add(panel2);
            Controls.Add(label2);
            Name = "AnnouncementsMember";
            Text = "AnnouncementsMember";
            Load += AnnouncementsMember_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)announcemntsgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox SocietyCombobox;
        private Button back;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private DataGridView announcemntsgrid;
        private Label label2;
        private BindingSource databaseGeneratedAttributeBindingSource;
    }
}