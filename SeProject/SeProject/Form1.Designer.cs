namespace SeProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            button1 = new Button();
            signup = new Button();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            imageList3 = new ImageList(components);
            imageList4 = new ImageList(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "best-university-societies.jpeg");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "best-university-societies.jpeg");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.best_university_societies;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 534);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(672, 382);
            button1.Name = "button1";
            button1.Size = new Size(129, 48);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signup
            // 
            signup.BackColor = Color.Firebrick;
            signup.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup.ForeColor = SystemColors.ButtonFace;
            signup.Location = new Point(672, 466);
            signup.Name = "signup";
            signup.Size = new Size(129, 48);
            signup.TabIndex = 3;
            signup.Text = "Sign Up";
            signup.UseVisualStyleBackColor = false;
            signup.Click += button2_Click;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageSize = new Size(16, 16);
            imageList3.TransparentColor = Color.Transparent;
            // 
            // imageList4
            // 
            imageList4.ColorDepth = ColorDepth.Depth32Bit;
            imageList4.ImageSize = new Size(16, 16);
            imageList4.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.societify;
            pictureBox2.Location = new Point(275, -48);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(920, 611);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1032, 532);
            Controls.Add(signup);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button signup;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private ImageList imageList3;
        private ImageList imageList4;
        private PictureBox pictureBox2;
    }
}
