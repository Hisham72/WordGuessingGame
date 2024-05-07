namespace WordGuessingGame
{
    public partial class Form1 : Form
    {
        string word = "أرنب";
        int mistakes = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = new string('-', word.Length);
        }

        private void Reset()
        {
            label1.Text = new string('-', word.Length);
            pictureBox1.Image = Image.FromFile($"images\\phase1.png");
            mistakes = 0;
            /*foreach (var c in this.Controls)
            {
                if (c is Button)
                {
                    (c as Button).BackColor = Color.DarkTurquoise;
                    (c as Button).ForeColor = Color.Black;
                    (c as Button).Enabled = true;
                }
            }*/
            circularButton1.BackColor = Color.DarkTurquoise;
            circularButton1.ForeColor = Color.Black;
        }

        private void Keyboard_Click(object sender, EventArgs e)
        {
            bool found = false;
            var labelText = label1.Text.Reverse().ToArray();
            var senderButton = sender as Button;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == senderButton.Text[0] && labelText[i] == '-')
                {
                    labelText[i] = word[i];
                    found = true;
                }
            }
            if (!found)
            {
                mistakes++;
                if (mistakes >= 6)
                {
                    MessageBox.Show("انتهت اللعبة!\nحاول من جديد.");
                    Reset();
                    return;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile($"images\\phase{mistakes + 1}.png");
                }
            }
            else
            {
                label1.Text = new string(labelText.Reverse().ToArray());
            }
            senderButton.BackColor = Color.Gray;
            senderButton.ForeColor = Color.FromArgb(224, 224, 224);
            //senderButton.Enabled = false;
        }
    }
}
