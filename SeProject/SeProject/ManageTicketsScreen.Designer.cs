namespace SeProject
{
    partial class ManageTicketsScreen
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
            deletebutton = new Button();
            TicketsGrid = new DataGridView();
            back = new Button();
            panel1 = new Panel();
            noOfTicketsText = new TextBox();
            label4 = new Label();
            eventsComboBox = new ComboBox();
            label3 = new Label();
            SocietyCombobox = new ComboBox();
            generateButton = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TicketsGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(548, 24);
            label2.Name = "label2";
            label2.Size = new Size(218, 37);
            label2.TabIndex = 11;
            label2.Text = "Manage Tickets";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(deletebutton);
            panel2.Controls.Add(TicketsGrid);
            panel2.Location = new Point(502, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 557);
            panel2.TabIndex = 10;
            // 
            // deletebutton
            // 
            deletebutton.BackColor = SystemColors.GradientActiveCaption;
            deletebutton.FlatStyle = FlatStyle.Flat;
            deletebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebutton.Location = new Point(313, 473);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(169, 45);
            deletebutton.TabIndex = 1;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // TicketsGrid
            // 
            TicketsGrid.BackgroundColor = Color.Honeydew;
            TicketsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketsGrid.Location = new Point(18, 29);
            TicketsGrid.Name = "TicketsGrid";
            TicketsGrid.RowHeadersWidth = 51;
            TicketsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TicketsGrid.Size = new Size(759, 415);
            TicketsGrid.TabIndex = 0;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(45, 21);
            back.Name = "back";
            back.Size = new Size(165, 40);
            back.TabIndex = 9;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(noOfTicketsText);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(eventsComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SocietyCombobox);
            panel1.Controls.Add(generateButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(45, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 557);
            panel1.TabIndex = 8;
            // 
            // noOfTicketsText
            // 
            noOfTicketsText.Location = new Point(27, 368);
            noOfTicketsText.Name = "noOfTicketsText";
            noOfTicketsText.PlaceholderText = "Enter no of tickets to generate";
            noOfTicketsText.Size = new Size(356, 27);
            noOfTicketsText.TabIndex = 14;
            noOfTicketsText.TextChanged += noOfTicketsText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 244);
            label4.Name = "label4";
            label4.Size = new Size(165, 37);
            label4.TabIndex = 13;
            label4.Text = "Select Event";
            // 
            // eventsComboBox
            // 
            eventsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventsComboBox.FormattingEnabled = true;
            eventsComboBox.Location = new Point(27, 296);
            eventsComboBox.Name = "eventsComboBox";
            eventsComboBox.Size = new Size(356, 28);
            eventsComboBox.TabIndex = 12;
            eventsComboBox.SelectedIndexChanged += eventsComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 136);
            label3.Name = "label3";
            label3.Size = new Size(186, 37);
            label3.TabIndex = 7;
            label3.Text = "Select Society";
            // 
            // SocietyCombobox
            // 
            SocietyCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SocietyCombobox.FormattingEnabled = true;
            SocietyCombobox.Location = new Point(27, 186);
            SocietyCombobox.Name = "SocietyCombobox";
            SocietyCombobox.Size = new Size(356, 28);
            SocietyCombobox.TabIndex = 4;
            SocietyCombobox.SelectedIndexChanged += SocietyCombobox_SelectedIndexChanged;
            // 
            // generateButton
            // 
            generateButton.BackColor = SystemColors.GradientActiveCaption;
            generateButton.FlatStyle = FlatStyle.Flat;
            generateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateButton.Location = new Point(108, 473);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(169, 45);
            generateButton.TabIndex = 3;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 38);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 0;
            label1.Text = "Generate Tickets";
            // 
            // ManageTicketsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 645);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(back);
            Controls.Add(panel1);
            Name = "ManageTicketsScreen";
            Text = "ManageTicketsScreen";
            Load += ManageTicketsScreen_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TicketsGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Button deletebutton;
        private DataGridView TicketsGrid;
        private Button back;
        private Panel panel1;
        private Label label3;
        private ComboBox SocietyCombobox;
        private Button generateButton;
        private Label label1;
        private TextBox noOfTicketsText;
        private Label label4;
        private ComboBox eventsComboBox;
    }
}