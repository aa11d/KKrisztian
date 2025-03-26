namespace Rendezes
{
    public partial class Form1 : Form
    {
        Button[] tomb;
        Button m1, m2;
        int h1, h2;
        int v1, v2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tomb = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12 };
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                tomb[i].Text = rnd.Next(100, 1000).ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int csere = 0;
            int ossz = 0;
            for (int meddig = 11; meddig >= 0; meddig--)
            {
                for (int mutato = 0; mutato < meddig; mutato++)
                {
                    ossz++;
                    if (tomb[mutato].Text.CompareTo(tomb[mutato + 1].Text) > 0)
                    {
                        Button ment = tomb[mutato];
                        tomb[mutato] = tomb[mutato + 1];
                        tomb[mutato + 1] = ment;
                        csere++;
                        h1 = tomb[mutato + 1].Left;
                        v1 = tomb[mutato].Left;
                        m1 = tomb[mutato];
                        h2 = tomb[mutato].Left;
                        v2 = tomb[mutato + 1].Left;
                        m2 = tomb[mutato + 1];
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( m1 != null )
            {
                m1.Left += (h1 - v1) / 10;
                if ( Math.Abs(m1.Left - v1) < 15)
                {
                    m1.Left = v1;
                    m1 = null;
                }
            }
            if (m2 != null)
            {
                m2.Left += (h2 - v2) / 10;
                if (Math.Abs(m2.Left - v2) < 15)
                {
                    m2.Left = v2;
                    m2 = null;
                }
            }
        }
    }
}
