namespace _107_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Paint += new PaintEventHandler(DrawLine);
        }
        private void DrawLine(object sender, PaintEventArgs e) {
            Pen blackPen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(blackPen, 68, 355, 650, 355);
            e.Graphics.DrawLine(blackPen, 68, 405, 650, 405);
            e.Graphics.DrawLine(blackPen, 199, 510, 199, 44);
            e.Graphics.DrawLine(blackPen, 249, 510, 249, 44);
        }


        private bool[][] states = new bool[6][]
        {
            new bool[6] { true, false, false, false, false ,true },
            new bool[6] { true, false, false, false, true, false },
            new bool[6] { true, false, false, true, false ,false },
            new bool[6] { false, false, true, true, false ,false },
            new bool[6] { false, true, false, true, false ,false },
            new bool[6] { true, false, false, true, false ,false },
        };

        private int state = 0;

        private void Form1_Load(object sender, EventArgs e) {
            

            R1.Visible = false;
            A1.Visible = false;
            G1.Visible = false;
            R2.Visible = false;
            A2.Visible = false;
            G2.Visible = false;
        }
        private void ON_Click(object sender, EventArgs e) {
            state = 0;
            R1.Visible = states[state][0];
            A1.Visible = states[state][1];
            G1.Visible = states[state][2];
            R2.Visible = states[state][3];
            A2.Visible = states[state][4];
            G2.Visible = states[state][5];
        }

        private void OFF_Click(object sender, EventArgs e) {
            R1.Visible = false;
            A1.Visible = false;
            G1.Visible = false;
            R2.Visible = false;
            A2.Visible = false;
            G2.Visible = false;
        }

        private void SWITCH_Click(object sender, EventArgs e) {
            state++;
            if (state >= 6) state = 0;
            R1.Visible = states[state][0];
            A1.Visible = states[state][1];
            G1.Visible = states[state][2];
            R2.Visible = states[state][3];
            A2.Visible = states[state][4];
            G2.Visible = states[state][5];
        }
    }
}
