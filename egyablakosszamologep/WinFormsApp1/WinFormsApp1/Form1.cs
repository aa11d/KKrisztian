namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool elsoSzam;
        float bal, jobb;
        char muvelet;

        private void MuvKatt(object sender, EventArgs e)
        {
            bool hiba = false;
           float ered = 0;

            char muv = (sender as Button).Text[0];

            if ( elsoSzam ) // az elsõ szám után ütöttek mûveleti jelet
            {
                switch ( muv )
                {
                    case '=':
                        listBox1.Items.Add( textBox1.Text + "=" + textBox1.Text );
                        textBox1.Text = "0";
                        muvelet = '=';
                        elsoSzam = true;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        bal = float.Parse( textBox1.Text );
                        muvelet = muv;
                        listBox1.Items.Add(textBox1.Text + " " + muvelet.ToString() + " " );
                        elsoSzam = false;
                        textBox1.Text = "0";
                        break;
                }
            }
            else // a második szám után ütöttek mûveleti jelet
            {
                jobb = float.Parse( textBox1.Text );
                switch (muvelet)
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
                        if (jobb != 0)
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
                    listBox1.Items[listBox1.Items.Count - 1] += " " + textBox1.Text + " = " + ered.ToString();
                    if (muv == '=')
                    {
                        muvelet = '=';
                        elsoSzam = true;
                        textBox1.Text = "0";
                    }
                    else
                    {
                        muvelet = muv;
                        bal = ered;
                        textBox1.Text = "0";
                        elsoSzam = false;
                        listBox1.Items.Add( bal.ToString() + " " + muvelet.ToString() );
                    }
                }
                else
                {
                    listBox1.Items[listBox1.Items.Count - 1] += " " + textBox1.Text + " HIBA! ";
                    muvelet = '=';
                    textBox1.Text = "0";
                    elsoSzam = true;
                }

                
            }





            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elsoSzam = true;
            bal = 0;
            jobb = 0;
            muvelet = '=';
        }

        private void SzamKatt(object sender, EventArgs e)
        {
            char szam = (sender as Button).Text[0];
            if (textBox1.Text == "0")
            {
                textBox1.Text = szam.ToString();
            }
            else
            {
                textBox1.Text += szam.ToString();
            }
        }

        private void DelKatt(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
    }
}
