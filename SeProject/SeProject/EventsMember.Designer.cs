namespace SeProject
{
    partial class EventsMember
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
            Eventsgrid = new DataGridView();
            label2 = new Label();
            databaseGeneratedAttributeBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Eventsgrid).BeginInit();
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
            back.Location = new Point(58, 28);
            back.Name = "back";
            back.Size = new Size(165, 40);
            back.TabIndex = 8;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(SocietyCombobox);
            panel2.Controls.Add(Eventsgrid);
            panel2.Location = new Point(58, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 549);
            panel2.TabIndex = 9;
            // 
            // Eventsgrid
            // 
            Eventsgrid.BackgroundColor = Color.Honeydew;
            Eventsgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Eventsgrid.Location = new Point(20, 52);
            Eventsgrid.Name = "Eventsgrid";
            Eventsgrid.RowHeadersWidth = 51;
            Eventsgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Eventsgrid.Size = new Size(1218, 490);
            Eventsgrid.TabIndex = 0;
            Eventsgrid.CellContentClick += Eventsgrid_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(624, 31);
            label2.Name = "label2";
            label2.Size = new Size(100, 37);
            label2.TabIndex = 10;
            label2.Text = "Events";
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            // 
            // EventsMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 657);
            Controls.Add(back);
            Controls.Add(panel2);
            Controls.Add(label2);
            Name = "EventsMember";
            Text = "EventsMember";
            Load += EventsMember_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Eventsgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SocietyCombobox;
        private Button back;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private DataGridView Eventsgrid;
        private Label label2;
        private BindingSource databaseGeneratedAttributeBindingSource;
    }
}