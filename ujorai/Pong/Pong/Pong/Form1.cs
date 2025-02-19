namespace Pong
{
    public partial class Form1 : Form
    {
        List<PictureBox> labdak = new List<PictureBox>();
        List<int> labdavX = new List<int>();
        List<int> labdavY = new List<int>();

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 20;
        }

        private void uto_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.4)
            {
                PictureBox labda = new PictureBox();
                int vx = rnd.Next(-5, 6);
                int vy = rnd.Next(2, 6);
                labda.Location = new Point(ClientRectangle.Width / 2, 0);
                labda.Size = new Size(25, 25);
                labda.Image = Image.FromFile(@"D:\KKrisztian\KKrisztian\ujorai\kepek\transparentball.png");
                labda.SizeMode = PictureBoxSizeMode.StretchImage;
                labdak.Add(labda);
                labdavX.Add(vx);
                labdavY.Add(vy);
                Controls.Add(labda);
            }

            for (int i = 0; i < labdak.Count; i++)
            {
                int newLeft = labdak[i].Left + labdavX[i];
                int newTop = labdak[i].Top + labdavY[i];
                if (newLeft < 0)
                {
                    labdavX[i] *= -1;
                }
                else if (newTop < 0)
                {
                    labdavY[i] *= -1;
                }
                else if (newLeft + labdak[i].Width > ClientRectangle.Width)
                {
                    labdavX[i] *= -1;
                }
                else
                {
                    labdak[i].Top = newTop;
                    labdak[i].Left = newLeft;
                }
            }
            int k = 0;
            while (k < labdak.Count)
            {
                if (labdak[k].Top > ClientRectangle.Height)
                {
                    Controls.Remove(labdak[k]);
                    labdak.RemoveAt(k);
                    labdavX.RemoveAt(k);
                    labdavY.RemoveAt(k);
                }
                else
                {
                    k++;
                }
            }

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (uto.Left > 10)
                {
                    uto.Left -= 10;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if ( uto.Left+uto.Width+10 < ClientRectangle.Width)
                {
                    uto.Left += 10;
                }
            }
        }
    }
}
