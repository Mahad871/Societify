namespace SeProject
{
    partial class ManageEvents
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
            label2 = new Label();
            panel2 = new Panel();
            editbutton = new Button();
            deletebutton = new Button();
            EventsGrid = new DataGridView();
            back = new Button();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            venueTextBox = new TextBox();
            SocietyCombobox = new ComboBox();
            save = new Button();
            desscreption = new TextBox();
            title = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EventsGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(550, 51);
            label2.Name = "label2";
            label2.Size = new Size(211, 37);
            label2.TabIndex = 7;
            label2.Text = "Manage Events";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(editbutton);
            panel2.Controls.Add(deletebutton);
            panel2.Controls.Add(EventsGrid);
            panel2.Location = new Point(504, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 557);
            panel2.TabIndex = 6;
            // 
            // editbutton
            // 
            editbutton.BackColor = SystemColors.GradientActiveCaption;
            editbutton.FlatStyle = FlatStyle.Flat;
            editbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbutton.Location = new Point(18, 467);
            editbutton.Margin = new Padding(3, 4, 3, 4);
            editbutton.Name = "editbutton";
            editbutton.Size = new Size(169, 45);
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
            deletebutton.Location = new Point(608, 467);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(169, 45);
            deletebutton.TabIndex = 1;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // EventsGrid
            // 
            EventsGrid.BackgroundColor = Color.Honeydew;
            EventsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventsGrid.Location = new Point(18, 29);
            EventsGrid.Name = "EventsGrid";
            EventsGrid.RowHeadersWidth = 51;
            EventsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EventsGrid.Size = new Size(759, 415);
            EventsGrid.TabIndex = 0;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(47, 48);
            back.Name = "back";
            back.Size = new Size(165, 40);
            back.TabIndex = 5;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(venueTextBox);
            panel1.Controls.Add(SocietyCombobox);
            panel1.Controls.Add(save);
            panel1.Controls.Add(desscreption);
            panel1.Controls.Add(title);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(47, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 557);
            panel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 417);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // venueTextBox
            // 
            venueTextBox.Location = new Point(27, 363);
            venueTextBox.Name = "venueTextBox";
            venueTextBox.PlaceholderText = "Venue";
            venueTextBox.Size = new Size(356, 27);
            venueTextBox.TabIndex = 5;
            // 
            // SocietyCombobox
            // 
            SocietyCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SocietyCombobox.FormattingEnabled = true;
            SocietyCombobox.Location = new Point(27, 172);
            SocietyCombobox.Name = "SocietyCombobox";
            SocietyCombobox.Size = new Size(356, 28);
            SocietyCombobox.TabIndex = 4;
            SocietyCombobox.SelectedIndexChanged += SocietyCombobox_SelectedIndexChanged;
            // 
            // save
            // 
            save.BackColor = SystemColors.GradientActiveCaption;
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.Location = new Point(91, 493);
            save.Name = "save";
            save.Size = new Size(169, 45);
            save.TabIndex = 3;
            save.Text = "save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // desscreption
            // 
            desscreption.Location = new Point(27, 224);
            desscreption.Margin = new Padding(3, 4, 3, 4);
            desscreption.Multiline = true;
            desscreption.Name = "desscreption";
            desscreption.PlaceholderText = "Add Event Description";
            desscreption.Size = new Size(356, 108);
            desscreption.TabIndex = 2;
            desscreption.TextChanged += desscreption_TextChanged;
            // 
            // title
            // 
            title.Location = new Point(27, 119);
            title.Name = "title";
            title.PlaceholderText = "Event Title";
            title.Size = new Size(356, 27);
            title.TabIndex = 1;
            title.TextChanged += titles_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 41);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Event";
            // 
            // ManageEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 669);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(back);
            Controls.Add(panel1);
            Name = "ManageEvents";
            Text = "ManageEvents";
            Load += ManageEvents_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EventsGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Button editbutton;
        private Button deletebutton;
        private DataGridView EventsGrid;
        private Button back;
        private Panel panel1;
        private ComboBox SocietyCombobox;
        private Button save;
        private TextBox desscreption;
        private TextBox title;
        private Label label1;
        private TextBox venueTextBox;
        private DateTimePicker dateTimePicker1;
    }
}