using System.Security.Cryptography.Xml;

namespace lapforditosjatek
{
    public partial class Form1 : Form
    {

        Button[,] lapocskak;
        public Form1()
        {
            InitializeComponent();
        }

        private void szinford(Button B)
        {
            if (B.BackColor == Color.Green)
            {
                B.BackColor = Color.Yellow;
            }
            else
            {
                B.BackColor = Color.Green;
            }
        }
        private void lapok(object sender, EventArgs e)
        {
            int xx = -1, yy = -1;
            for (int x = 0; x < lapocskak.GetLength(0); x++)
            {
                for (int y = 0; y < lapocskak.GetLength(1); y++)
                {
                    if (lapocskak[y, x] == (sender as Button))
                    {
                        xx = x;
                        yy = y;
                        
                    }
                }
            }

            if (xx > 0)
            {
                szinford(lapocskak[yy, xx - 1]);
            }
            if (xx < 3)
            {
                szinford(lapocskak[yy, xx + 1]);
            }
            if (yy > 0)
            {
                szinford(lapocskak[yy-1, xx]);
            }
            if (yy < 3)
            {
                szinford(lapocskak[yy +1 , xx]);
            }
            


            
        }

        private void ujjatek_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int xx, yy;
            for (int x = 0; x < lapocskak.GetLength(0); x++)
            {
                for (int y = 0; y < lapocskak.GetLength(1); y++)
                {
                    xx = x;
                    yy = y;
                    lapocskak[yy, xx].BackColor = Color.Green;
                }
            }

            for (int i = 0; i <= 7; i++)
            {
                xx = rnd.Next(0, 4);
                yy = rnd.Next(0, 4);
                lapok(lapocskak[yy,xx],EventArgs.Empty);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lapocskak = new Button[4, 4] { { button1, button2, button3, button4 }, { button5, button6, button7, button8 }, { button9, button10, button11, button12 }, { button13, button14, button15, button16 } };

        }
    }
}
