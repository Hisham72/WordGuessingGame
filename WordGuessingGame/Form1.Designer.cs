namespace WordGuessingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            circularButton1 = new CircularButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // circularButton1
            // 
            circularButton1.Anchor = AnchorStyles.None;
            circularButton1.BackColor = Color.DarkTurquoise;
            circularButton1.FlatAppearance.BorderSize = 0;
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.Font = new Font("Simplified Arabic Fixed", 35F, FontStyle.Regular, GraphicsUnit.Point);
            circularButton1.ForeColor = Color.Black;
            circularButton1.Location = new Point(956, 582);
            circularButton1.MaximumSize = new Size(46, 45);
            circularButton1.Name = "circularButton1";
            circularButton1.RightToLeft = RightToLeft.No;
            circularButton1.Size = new Size(46, 45);
            circularButton1.TabIndex = 0;
            circularButton1.Text = "أ";
            circularButton1.UseVisualStyleBackColor = false;
            circularButton1.Click += Keyboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Simplified Arabic Fixed", 99.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(557, 355);
            label1.Name = "label1";
            label1.Size = new Size(387, 158);
            label1.TabIndex = 1;
            label1.Text = "----";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1444, 881);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(circularButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "خمن الكلمة";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularButton circularButton1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
