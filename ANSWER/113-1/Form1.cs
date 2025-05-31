namespace _113_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clac_Click(object sender, EventArgs e)
        {
            output.Text = GetNum(input.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            output.Text = "";
        }

        private String GetNum(String input)
        {
            String[] numbers_up = input.Split(',');
            int len = numbers_up.Length;
            String[] numbers_down = new String[len];
            for(int i = 0; i < len; i++)
            {
                numbers_down[i] = "1";
            }
            Array.Reverse(numbers_up);

            for(int i = 0; i < len - 1; i++)
            {
                String temp = numbers_up[i];
                numbers_up[i] = numbers_down[i];
                numbers_down[i] = temp;

                numbers_up[i + 1] = (int.Parse(numbers_up[i]) + int.Parse(numbers_down[i]) * int.Parse(numbers_up[i + 1])).ToString();
                numbers_down[i + 1] = numbers_down[i];
            }

            
            int up = int.Parse(numbers_up[len - 1]);
            int down = int.Parse(numbers_down[len - 1]);
            int gcd = GCD(up,down);
            return $"{up / gcd}/{down / gcd}";


        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
