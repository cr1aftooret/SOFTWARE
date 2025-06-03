using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace _110_2
{
    public partial class Form1 : Form
    {

        private int numberCount = 0;
        private int letterCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            length.Text = "";
            strength.Text = "";
        }

        private void len_Click(object sender, EventArgs e) {
            if (CheckLength(sender, e)) { 
                String inputText = input.Text;
                numberCount = Regex.Matches(inputText, "[0-9]").Count;
                letterCount = Regex.Matches(inputText, "[a-z]").Count;
                length.Text = $"{letterCount},{numberCount}";
            }
        }

        private void judge_Click(object sender, EventArgs e)
        {
            len_Click(sender, e);
            String inputText = input.Text;
            if (inputText.Length >= 12 && numberCount  != 0 && letterCount != 0 && letterCount > numberCount) {
                strength.Text = "strong";
            } else if (inputText.Length >= 8 && inputText.Length < 12) {
                strength.Text = "weak";
            } else if (numberCount + letterCount > 1) {
                strength.Text = "weak";
            } else if (letterCount < numberCount) {
                strength.Text = "weak";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            length.Text = "";
            strength.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckLength(object sender, EventArgs e)
        {
            if (input.Text.Length > 20)
            {
                MessageBox.Show("重新輸入");
                clear_Click(sender, e);
                return false;
            }
            else if (input.Text.Length < 8)
            {
                MessageBox.Show("重新輸入");
                clear_Click(sender, e);
                return false;
            }
            return true;
        }
    }
}
