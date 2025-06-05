namespace _105_1
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private char[] baseChars = "0123456789ABCDEFGHIJ".ToCharArray();

        private void clear_Click(object sender, EventArgs e) {
            number.Text = "";
            baseNumber.Text = "";
            result.Text = "";
        }

        private void converte_Click(object sender, EventArgs e) {
            result.Text = "";
            int num = int.Parse(number.Text);
            int baseNum = int.Parse(baseNumber.Text);

            while (num != 0) {
                int remainder = num % baseNum;
                if (remainder < 0) {
                    remainder += -baseNum;
                    num = num / baseNum + 1;
                } else {
                    num /= baseNum;
                }
                result.Text = baseChars[remainder] + result.Text;
            }
        }
    }
}
