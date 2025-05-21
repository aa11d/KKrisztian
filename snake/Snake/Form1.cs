namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<PictureBox> snake;
        Point irany;
        Image[] kepek = new Image[6]; //fejek, test, alma

        void AlmaUjHely()
        {
            Random rnd = new Random();
            bool jo = false; // van már jó hely
            int x = 0, y = 0;
            while (!jo)
            {
                 x = rnd.Next(0, 20) * 64;
                 y = rnd.Next(0, 10) * 64;
                int i = 0;
                jo = true;
                while (i<snake.Count && jo)
                {
                    if (snake[i].Location.X == x || snake[i].Location.Y == y)
                    {
                        jo = false;
                    }
                    i++;
                }
            }
            pbAlma.Location = new Point(x,y);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kepek[0] = Image.FromFile(@"..\..\..\fel.png");
            kepek[1] = Image.FromFile(@"..\..\..\jobb.png");
            kepek[2] = Image.FromFile(@"..\..\..\le.png");
            kepek[3] = Image.FromFile(@"..\..\..\bal.png");
            kepek[4] = Image.FromFile(@"..\..\..\test.png");
            pbAlma.Image = Image.FromFile(@"..\..\..\alma.png");
            pbAlma.SizeMode = PictureBoxSizeMode.StretchImage;
            
            snake = new List<PictureBox>();
            irany = new Point(0, -64);
            snake.Add(pbFej);
            pbFej.Location = new Point(10 * 64, 5 * 64); //közép, mert 20*10-es a pálya
            pbFej.Image = kepek[0]; //fejfel
            pbFej.SizeMode = PictureBoxSizeMode.StretchImage;
            AlmaUjHely();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && irany.X != 64)
            {
                irany = new Point(-64, 0);
                pbFej.Image = kepek[3];
            }
            else if (e.KeyCode == Keys.Right && irany.X != -64)
            {
                irany = new Point(64, 0);
                pbFej.Image = kepek[1];
            }
            else if (e.KeyCode == Keys.Up && irany.Y != 64)
            {
                irany = new Point(0, -64);
                pbFej.Image = kepek[0];
            }
            else if (e.KeyCode == Keys.Down && irany.Y != -64)
            {
                irany = new Point(0, 64);
                pbFej.Image = kepek[2];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int elozoX = pbFej.Location.X;
            int elozoY = pbFej.Location.Y;
            pbFej.Location = new Point( pbFej.Location.X + irany.X, pbFej.Location.Y + irany.Y );
            for (int i = 1; i < snake.Count; i++)
            {
                int x = snake[i].Location.X;
                int y = snake[i].Location.Y;
                snake[i].Location = new Point(elozoX, elozoY);
                elozoX = x;
                elozoY = y;
            }

            if (pbFej.Location.X < 0)
            {
                pbFej.Location = new Point(1280, pbFej.Location.Y);
            }
            if (pbFej.Location.Y < 0)
            {
                pbFej.Location = new Point(pbFej.Location.X, 640);
            }
            if (pbFej.Location.X > 1280)
            {
                pbFej.Location = new Point(0, pbFej.Location.Y);
            }
            if (pbFej.Location.Y > 640)
            {
                pbFej.Location = new Point(pbFej.Location.X, 0);
            }
            if (pbFej.Location.X == pbAlma.Location.X && pbFej.Location.Y == pbAlma.Location.Y)
            {
                AlmaUjHely();
                PictureBox uj = new PictureBox();
                uj.Location = new Point(elozoX, elozoY);
                uj.Size = new Size(64, 64);
                uj.Image = kepek[4];
                uj.SizeMode = PictureBoxSizeMode.StretchImage;
                snake.Add(uj);
                Controls.Add(uj);
            }
        }
    }
}
