namespace _108_1
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private float balance = 0;
        private int tmp = 0;

        private void cocacola_Click(object sender, EventArgs e) {
            if (balance >= 35) {
                result.Text += (tmp != 0 ? "�A" : "") + "�e�XCola";
                tmp++;
                balance -= 35;
                balanceText.Text = balance.ToString("F1");
            }
        }

        private void pepsi_Click(object sender, EventArgs e) {
            if (balance >= 30) {
                result.Text += (tmp != 0 ? "�A" : "") + "�e�XPEPSI";
                tmp++;
                balance -= 30;
                balanceText.Text = balance.ToString("F1");
            }
        }

        private void dietcoke_Click(object sender, EventArgs e) {
            if (balance >= 30) {
                result.Text += (tmp != 0 ? "�A" : "") + "�e�XDiet Coke";
                tmp++;
                balance -= 30;
                balanceText.Text = balance.ToString("F1");
            }
        }

        private void dietpepsi_Click(object sender, EventArgs e) {
            if (balance >= 25) {
                result.Text += (tmp != 0 ? "�A" : "") + "�e�Xdiet PEPSI";
                tmp++;
                balance -= 25;
                balanceText.Text = balance.ToString("F1");
            }
        }

        private void refund_Click(object sender, EventArgs e) {
            if(balance == 0) {
                result.Text = "";
            } else {
                result.Text += $" �h��{balance.ToString("F0")}��";
                tmp = 0;
                balance = 0;
                balanceText.Text = balance.ToString("F1");
            }
        }

        private void deposit_Click(object sender, EventArgs e) {
            if (five.Checked) {
                balance += 5;
            } else if (ten.Checked) {
                balance += 10;
            } else if (fifty.Checked) {
                balance += 50;
            }

            balanceText.Text = balance.ToString("F1");
        }
    }
}
