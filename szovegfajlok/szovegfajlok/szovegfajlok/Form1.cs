using System.Security;

namespace szovegfajlok
{
    public partial class Form1 : Form
    {
        string teljesSzoveg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Szia", "Üzenet", MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileUtvonal = textBox1.Text;
            string fileUt2 = @"..\..\..\" + textBox1.Text;
            //teljesSzoveg = File.ReadAllText(fileUtvonal);
            //textBox2.Text = teljesSzoveg;

            StreamReader sr = new StreamReader(fileUtvonal);

            List<string> sorok = new List<string>();
            string sor = sr.ReadLine();
            while( sor != null )
            {
                if( sor.Trim() != "")
                    sorok.Add( sor.Trim() );
                sor = sr.ReadLine();
            }
            sr.Close();
            textBox2.Lines = sorok.ToArray();

            string[] nev = new string[sorok.Count];
            string[] datum = new string[sorok.Count];
            string[] varos = new string[sorok.Count];
            int[] pontszam = new int[sorok.Count];

            for ( int i = 0; i < sorok.Count; i++ )
            {
                string[] darabolva = sorok[i].Split(';');
                nev[i] = darabolva[0];
                datum[i] = darabolva[1];
                varos[i] = darabolva[2];
                pontszam[i] = int.Parse(darabolva[3]);
            }

            int maxPont = pontszam.Max();
            int kivolt = Array.IndexOf(pontszam, maxPont);

            string sor1 = "\r\nLegnagyobb pontszám: " + maxPont;
            textBox2.AppendText(sor1);
            string sor2 = "A legtöbb pontot adta " + nev[kivolt] + " aki itt lakik: " + varos[kivolt];
            textBox2.AppendText(sor2);
        }
    }
}
