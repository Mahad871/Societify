namespace SeProject
{
    partial class VerifyTicket
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
            tickedIdBox = new TextBox();
            verify = new Button();
            eventsComboBox = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            databaseGeneratedAttributeBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SocietyCombobox
            // 
            SocietyCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SocietyCombobox.FormattingEnabled = true;
            SocietyCombobox.Location = new Point(235, 81);
            SocietyCombobox.Name = "SocietyCombobox";
            SocietyCombobox.Size = new Size(356, 28);
            SocietyCombobox.TabIndex = 4;
            SocietyCombobox.SelectedIndexChanged += SocietyCombobox_SelectedIndexChanged;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(52, 26);
            back.Name = "back";
            back.Size = new Size(165, 40);
            back.TabIndex = 14;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(tickedIdBox);
            panel2.Controls.Add(verify);
            panel2.Controls.Add(eventsComboBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(SocietyCombobox);
            panel2.Location = new Point(52, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 549);
            panel2.TabIndex = 15;
            // 
            // tickedIdBox
            // 
            tickedIdBox.Location = new Point(316, 258);
            tickedIdBox.Name = "tickedIdBox";
            tickedIdBox.PlaceholderText = "Enter Ticket ID to verify";
            tickedIdBox.Size = new Size(349, 27);
            tickedIdBox.TabIndex = 18;
            // 
            // verify
            // 
            verify.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verify.Location = new Point(739, 251);
            verify.Name = "verify";
            verify.Size = new Size(165, 40);
            verify.TabIndex = 14;
            verify.Text = "VERIFY TICKET";
            verify.UseVisualStyleBackColor = true;
            verify.Click += verify_Click;
            // 
            // eventsComboBox
            // 
            eventsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventsComboBox.FormattingEnabled = true;
            eventsComboBox.Location = new Point(835, 78);
            eventsComboBox.Name = "eventsComboBox";
            eventsComboBox.Size = new Size(356, 28);
            eventsComboBox.TabIndex = 17;
            eventsComboBox.SelectedIndexChanged += eventsComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(643, 72);
            label5.Name = "label5";
            label5.Size = new Size(165, 37);
            label5.TabIndex = 16;
            label5.Text = "Select Event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 72);
            label3.Name = "label3";
            label3.Size = new Size(186, 37);
            label3.TabIndex = 14;
            label3.Text = "Select Society";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 29);
            label2.Name = "label2";
            label2.Size = new Size(190, 37);
            label2.TabIndex = 16;
            label2.Text = "Verify Tickets";
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            // 
            // VerifyTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 653);
            Controls.Add(back);
            Controls.Add(panel2);
            Controls.Add(label2);
            Name = "VerifyTicket";
            Text = "VerifyTicket";
            Load += VerifyTicket_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SocietyCombobox;
        private Button back;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private TextBox tickedIdBox;
        private Button verify;
        private ComboBox eventsComboBox;
        private Label label5;
        private Label label3;
        private Label label2;
        private BindingSource databaseGeneratedAttributeBindingSource;
    }
}