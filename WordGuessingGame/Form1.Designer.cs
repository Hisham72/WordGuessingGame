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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            circularButton1 = new CircularButton();
            circularButton2 = new CircularButton();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SlateBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Simplified Arabic Fixed", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(434, 462);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(556, 46);
            label1.TabIndex = 1;
            label1.Text = "----";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(434, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(556, 307);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // circularButton1
            // 
            circularButton1.Anchor = AnchorStyles.None;
            circularButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            circularButton1.BackColor = Color.White;
            circularButton1.FlatAppearance.BorderSize = 0;
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.Font = new Font("Moga_Magdy Soleman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            circularButton1.ForeColor = Color.Black;
            circularButton1.Location = new Point(946, 601);
            circularButton1.Name = "circularButton1";
            circularButton1.RightToLeft = RightToLeft.No;
            circularButton1.Size = new Size(44, 49);
            circularButton1.TabIndex = 0;
            circularButton1.Text = "أ";
            circularButton1.UseVisualStyleBackColor = false;
            circularButton1.Click += Keyboard_Click;
            // 
            // circularButton2
            // 
            circularButton2.Anchor = AnchorStyles.None;
            circularButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            circularButton2.BackColor = Color.White;
            circularButton2.FlatAppearance.BorderSize = 0;
            circularButton2.FlatStyle = FlatStyle.Flat;
            circularButton2.Font = new Font("Moga_Magdy Soleman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            circularButton2.ForeColor = Color.Black;
            circularButton2.Location = new Point(882, 601);
            circularButton2.Name = "circularButton2";
            circularButton2.RightToLeft = RightToLeft.No;
            circularButton2.Size = new Size(44, 49);
            circularButton2.TabIndex = 3;
            circularButton2.Text = "ب";
            circularButton2.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.White;
            button2.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(659, 648);
            button2.Name = "button2";
            button2.Size = new Size(56, 56);
            button2.TabIndex = 5;
            button2.Text = "ب";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Moga_Magdy Soleman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(510, 722);
            button1.Name = "button1";
            button1.Size = new Size(55, 55);
            button1.TabIndex = 4;
            button1.Text = "أ";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1350, 759);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(circularButton2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(circularButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "خمن الكلمة";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CircularButton circularButton1;
        private CircularButton circularButton2;
        private Button button2;
        private Button button1;
    }
}
