namespace Labda
{
    public partial class Form1 : Form
    {
        int vx, vy;
        int pontball = 0;
        int pontjobb = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            vx = rnd.Next(5, 11);
            if (rnd.NextDouble() < 0.5)
            {
                vx *= -1;
            }
            vy = rnd.Next(-5, 6);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int balfent = labda1.Top + vy;
            int balbal = labda1.Left + vx;
            int jobblent = balfent + labda1.Height;
            int jobbjobb = balbal + labda1.Width;

            if (balbal < 0 || jobbjobb > ClientRectangle.Width)
            {
                vx = -vx;
            }
            else
            {
                labda1.Left = balbal;
            }
            if (balfent < 0 || jobblent > ClientRectangle.Height)
            {
                vy = -vy;
            }
            else
            {
                labda1.Top = balfent;
            }
            if (labda1.Left + labda1.Width >= baseballbat2.Left && labda1.Top >= baseballbat2.Top && labda1.Top + labda1.Height <= baseballbat2.Top + baseballbat2.Height)
            {
                vx = -vx;
            }
        }

        private void baseballbat1_Click(object sender, EventArgs e)
        {

        }

        private void baseballbat2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (baseballbat2.Top > 10)
                {
                    baseballbat2.Top -= 10;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (baseballbat2.Top + baseballbat2.Height + 10 < ClientRectangle.Height)
                {
                    baseballbat2.Top += 10;
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
