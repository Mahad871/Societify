namespace SeProject
{
    partial class BuyTickets
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
            button1 = new Button();
            eventsComboBox = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            TicketsGrid = new DataGridView();
            label2 = new Label();
            databaseGeneratedAttributeBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TicketsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SocietyCombobox
            // 
            SocietyCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SocietyCombobox.FormattingEnabled = true;
            SocietyCombobox.Location = new Point(231, 18);
            SocietyCombobox.Name = "SocietyCombobox";
            SocietyCombobox.Size = new Size(356, 28);
            SocietyCombobox.TabIndex = 4;
            SocietyCombobox.SelectedIndexChanged += SocietyCombobox_SelectedIndexChanged_1;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(46, 27);
            back.Name = "back";
            back.Size = new Size(165, 40);
            back.TabIndex = 11;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // backgroundWorker1
            // 
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(eventsComboBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(SocietyCombobox);
            panel2.Controls.Add(TicketsGrid);
            panel2.Location = new Point(46, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 549);
            panel2.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(549, 495);
            button1.Name = "button1";
            button1.Size = new Size(165, 40);
            button1.TabIndex = 14;
            button1.Text = "BUY TICKET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // eventsComboBox
            // 
            eventsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventsComboBox.FormattingEnabled = true;
            eventsComboBox.Location = new Point(835, 18);
            eventsComboBox.Name = "eventsComboBox";
            eventsComboBox.Size = new Size(356, 28);
            eventsComboBox.TabIndex = 17;
            eventsComboBox.SelectedIndexChanged += eventsComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(643, 12);
            label5.Name = "label5";
            label5.Size = new Size(165, 37);
            label5.TabIndex = 16;
            label5.Text = "Select Event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 9);
            label3.Name = "label3";
            label3.Size = new Size(186, 37);
            label3.TabIndex = 14;
            label3.Text = "Select Society";
            // TicketsGrid
            // 
            TicketsGrid.BackgroundColor = Color.Honeydew;
            TicketsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketsGrid.Location = new Point(21, 52);
            TicketsGrid.Name = "TicketsGrid";
            TicketsGrid.RowHeadersWidth = 51;
            TicketsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TicketsGrid.Size = new Size(1218, 419);
            TicketsGrid.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(612, 30);
            label2.Name = "label2";
            label2.Size = new Size(162, 37);
            label2.TabIndex = 13;
            label2.Text = "Buy Tickets";
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            databaseGeneratedAttributeBindingSource.CurrentChanged += databaseGeneratedAttributeBindingSource_CurrentChanged;
            // 
            // BuyTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 654);
            Controls.Add(back);
            Controls.Add(panel2);
            Controls.Add(label2);
            Name = "BuyTickets";
            Text = "BuyTickets";
            Load += BuyTickets_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TicketsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SocietyCombobox;
        private Button back;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private DataGridView TicketsGrid;
        private Label label2;
        private BindingSource databaseGeneratedAttributeBindingSource;
        private Label label3;
        private Label label5;
        private ComboBox eventsComboBox;
        private Button button1;
    }
}