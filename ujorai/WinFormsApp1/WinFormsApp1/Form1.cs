namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        PictureBox[,] kepek = new PictureBox[6, 8];
        int szamlalo = 1;
        int[,] deltax = new int[6, 8];
        int[,] deltay = new int[6, 8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Igen_Click(object sender, EventArgs e)
        {
            szamlalo++;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < kepek.GetLength(0); x++)
            {
                for (int y = 0; y < kepek.GetLength(1); y++)
                {
                    kepek[x, y].Left += deltax[x, y];
                    kepek[x, y].Top += deltay[x, y];
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int x = 0; x < kepek.GetLength(0); x++)
                {
                    for (int y = 0; y < kepek.GetLength(1); y++)
                    {
                        kepek[x, y] = new PictureBox();
                        kepek[x, y].Location = new Point(50 + 55 * x, 50 + 55 * y);
                        kepek[x, y].Size = new Size(50, 50);
                        kepek[x, y].Image = Image.FromFile(@"D:\KKrisztian\KKrisztian\ujorai\kepek\papyrus.png");
                        kepek[x,y].SizeMode = PictureBoxSizeMode.StretchImage;
                        kepek[x, y].Name = "Sans" + x.ToString() + "_" + y.ToString();
                        Controls.Add(kepek[x, y]);
                        
                        deltax[x, y] = rnd.Next(-5, 6);
                        deltay[x, y] = rnd.Next(-5, 6);
                }
                }
            

        }
    }
}
