using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WordGuessingGame
{
    public partial class Form1 : Form
    {
        string[] word = { "أخطبوط", "سمكة القرش", "سلطعون", "منارة", "صياد", "غواص", "سلحفاة", "حوت", "سمكة البهلوان" };
        int cur = 0;
        int mistakes = 0;
        int score = 0;
        Dictionary<string, string> photoOf;
        public Form1()
        {
            InitializeComponent();
            photoOf = new Dictionary<string, string>();
            for (int i = 0; i < word.Length; i++)
            {
                photoOf.Add(word[i], $"{i + 1}.png");
            }
            pointsLabel.Text = ToArabicNumber(score.ToString());
            ResetLabel();
            ResetImage();
        }

        private void ResetImage()
        {
            pictureBox2.Image = Image.FromFile($"images\\{photoOf[word[cur]]}");
            pictureBox1.Image = Image.FromFile($"images\\phase1.png");
        }

        private void ResetLabel()
        {
            var words = word[cur].Split(' ');
            label1.Text = new string('-', words[0].Length);
            if (words.Length > 1)
            {
                label1.Text += " ";
                label1.Text += new string('-', words[1].Length);
            }
        }

        private void ResetKeyboard()
        {
            foreach (Button bt in panel1.Controls)
            {
                bt.ForeColor = Color.Navy;
                bt.BackColor = Color.WhiteSmoke;
                bt.Enabled = true;
            }
        }

        private string ToArabicNumber(string input)
        {
            return input.Replace('0', '\u06f0')
                    .Replace('1', '\u06f1')
                    .Replace('2', '\u06f2')
                    .Replace('3', '\u06f3')
                    .Replace('4', '\u06f4')
                    .Replace('5', '\u06f5')
                    .Replace('6', '\u06f6')
                    .Replace('7', '\u06f7')
                    .Replace('8', '\u06f8')
                    .Replace('9', '\u06f9');
        }

        private void Victory()
        {
            MessageBox.Show("أحسنت!", "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            cur = (cur + 1) % word.Length;
            score++;
            pointsLabel.Text = ToArabicNumber(score.ToString());
            ResetKeyboard();
            ResetLabel();
            ResetImage();
        }

        private void Loss()
        {
            MessageBox.Show("أخطأت! لكن حاول فى الكلمات الأخرى.", "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            cur = (cur + 1) % word.Length;
            score = Math.Max(score - 1, 0);
            pointsLabel.Text = ToArabicNumber(score.ToString());
            mistakes = 0;
            ResetKeyboard();
            ResetLabel();
            ResetImage();
        }

        private void DisableKey(Button key)
        {
            key.BackColor = Color.Gray;
            key.ForeColor = Color.FromArgb(224, 224, 224);
            key.Enabled = false;
        }

        private void PlayClickSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Click On.wav");
            simpleSound.Play();
        }

        private void Keyboard_Click(object sender, EventArgs e)
        {
            //PlayClickSound();
            var senderButton = sender as Button;
            DisableKey(senderButton);
            bool found = false;
            var labelText = label1.Text.ToArray();
            for (int i = 0; i < word[cur].Length; i++)
            {
                if (word[cur][i] == senderButton.Text[0] && labelText[i] == '-')
                {
                    labelText[i] = word[cur][i];
                    found = true;
                }
            }
            if (!found)
            {
                mistakes++;
                if (mistakes >= 6)
                {
                    Loss();
                    return;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile($"images\\phase{mistakes + 1}.png");
                }
            }
            else
            {
                label1.Text = new string(labelText.ToArray());
                if (!label1.Text.Contains('-'))
                {
                    Victory();
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer background = new SoundPlayer(@"underwater-waves-5983.wav");
            background.PlayLooping();
        }
    }
}
