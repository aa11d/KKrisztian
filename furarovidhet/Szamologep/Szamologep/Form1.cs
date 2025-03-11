namespace Szamologep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BalSzamokKatt(object sender, EventArgs e)
        {
            char szam = (sender as Button).Text[0];
            if (balSzovegDoboz.Text == "0")
            {
                balSzovegDoboz.Text = szam.ToString();
            }
            else
            {
                balSzovegDoboz.Text += szam.ToString();
            }
        }

        private void balDelGomb_Click(object sender, EventArgs e)
        {
            balSzovegDoboz.Text = balSzovegDoboz.Text.Substring(0, balSzovegDoboz.Text.Length - 1);
            if (balSzovegDoboz.Text == "")
            {
                balSzovegDoboz.Text = "0";
            }
        }

        private void jobbSzamKatt(object sender, EventArgs e)
        {
            char szam = (sender as Button).Text[0];
            if (jobbSzovegDoboz.Text == "0")
            {
                jobbSzovegDoboz.Text = szam.ToString();
            }
            else
            {
                jobbSzovegDoboz.Text += szam.ToString();
            }
        }

        private void jobbDelGomb_Click(object sender, EventArgs e)
        {
            {
                jobbSzovegDoboz.Text = jobbSzovegDoboz.Text.Substring(0, jobbSzovegDoboz.Text.Length - 1);
                if (jobbSzovegDoboz.Text == "")
                {
                    jobbSzovegDoboz.Text = "0";
                }
            }
        }

        private void MuveletKatt(object sender, EventArgs e)
        {
            int bal = int.Parse(balSzovegDoboz.Text);
            int jobb = int.Parse(jobbSzovegDoboz.Text);
            bool hiba = false; // nincs hiba
            int ered = 0;

            char muv = (sender as Button).Text[0];
            switch ( muv )
            {
                case '+':
                    ered = bal + jobb;
                break;
                case '-':
                    ered = bal - jobb;
                    break;
                case '*':
                    ered = bal * jobb;
                    break;
                case '/':
                    if ( jobb != 0 )
                    {
                        ered = bal / jobb;
                    }
                    else
                    {
                        hiba = true;
                    }
                    break;
            }
            if ( !hiba )
            {
                balSzovegDoboz.Text = ered.ToString();
                jobbSzovegDoboz.Text = "0";
            }
            else
            {
                MessageBox.Show("Ne ossz nullával");
            }
        }
    }
}
