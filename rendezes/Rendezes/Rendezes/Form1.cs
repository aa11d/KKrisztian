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

        void Csere(int i, int j)
        {
            Button ment = tomb[i];
            tomb[i] = tomb[j];
            tomb[j] = ment;
            tomb[i].BringToFront();
            tomb[j].BringToFront();
            int ileft = tomb[i].Left;
            int jleft = tomb[j].Left;
            while (Math.Abs(ileft - tomb[j].Left) > 10)
            {
                if (ileft < jleft)
                {
                    tomb[i].Left += 10;
                    tomb[j].Left -= 10;
                }
                else
                {
                    tomb[i].Left -= 10;
                    tomb[j].Left += 10;
                }
                Refresh();
                Thread.Sleep(100);
            }
            tomb[i].Left = jleft;
            tomb[j].Left = ileft;
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
                        Csere(mutato, mutato + 1);
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            for (int honnan = 0; honnan <= 10; honnan++)
            {
                int minind = honnan;
                tomb[minind].BackColor = Color.Green;
                for (int i = honnan + 1; i < 12; i++)
                {
                    tomb[i].BackColor = Color.Red;
                    if (tomb[i].Text.CompareTo(tomb[minind].Text) < tomb[minind].Text.CompareTo(tomb[i].Text))
                    {
                        tomb[minind].BackColor = Color.Gray;
                        minind = i;
                        tomb[i].BackColor = Color.Green;
                    }
                    Refresh();
                    Thread.Sleep(100);
                    if ( i != minind )
                    {
                        tomb[i].BackColor = Color.Gray;
                    }
                    
                }

                Csere(honnan, minind);
            }
        }

        private void KozvCsere_Click(object sender, EventArgs e)
        {

        }

        private void BeszR_Click(object sender, EventArgs e)
        {
            
        }
    }
}
