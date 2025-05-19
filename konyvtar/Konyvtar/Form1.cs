namespace Konyvtar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KKujkonyv_Click(object sender, EventArgs e)
        {
            // Ha a lista �res, akkor 1000 az els� azonos�t�
            if (KKListbox.Items.Count == 0)
            {
                KKazon.Text = "1000";
            }
            else // az eddigi legnagyobbn�l eggyel nagyobbat
            {
                int ujazon = 1001;
                for (int i = 0; i < KKListbox.Items.Count; i++)
                {
                    string azonSzoveg = KKListbox.Items[i].ToString().Substring(1, 4);
                    int azon = int.Parse(azonSzoveg);
                    if (azon >= ujazon)
                    {
                        ujazon = azon + 1;
                    }
                }
                KKazon.Text = ujazon.ToString();
            }
            KKFelvesz.Enabled = true;
            KKszer.Text = "";
            KKname.Text = "";
            KKev.Text = "";
        }

        private void KKFelvesz_Click(object sender, EventArgs e)
        {
            if (KKszer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Add meg a szerz�t!");
            }
            else if (KKname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Add meg a c�met!");
            }
            else
            {
                try
                {

                    int kiad = int.Parse(KKev.Text);
                    string konyv = $"[{KKazon.Text}] - {KKszer.Text} - {KKname.Text} - {KKev.Text}";
                    KKListbox.Items.Add(konyv);
                    KKFelvesz.Enabled = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Adj meg helyes kiad�si �vet!");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kil�p�nk a programb�l (de m�g l�tezik a form)
            StreamWriter sw = new StreamWriter(@"..\..\..\konyvek.txt");
            for (int i = 0; i < KKListbox.Items.Count; i++)
            {
                string pontos = KKListbox.Items[i].ToString().Replace(" - ", ";");
                sw.WriteLine(pontos);
            }

            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Indul a program
            try
            {


                StreamReader sr = new StreamReader(@"..\..\..\konyvek.txt");

                string sor = sr.ReadLine();
                while (sor != null)
                {
                    string vonalas = sor.Replace(";", " - ");
                    KKListbox.Items.Add(vonalas);
                    sor = sr.ReadLine();
                }

                sr.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("A k�nyvek f�jl nem olvashat�");
            }
            try
            {


                StreamReader or = new StreamReader(@"..\..\..\olvasok.txt");

                string soor = or.ReadLine();
                while (soor != null)
                {
                    string olvasok = soor.Replace(";", " - ");
                    OOListBox.Items.Add(olvasok);
                    soor = or.ReadLine();
                }

                or.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Az olvas�k f�jl nem olvashat�");
            }
        }

        private void KKListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KKListbox.SelectedIndex == -1)
            {
                KKTorol.Enabled = false;
                KKSzerkeszt.Enabled = false;
            }
            else
            {
                KKTorol.Enabled = true;
                KKSzerkeszt.Enabled = true;
            }
        }

        private void KKTorol_Click(object sender, EventArgs e)
        {
            KKListbox.Items.RemoveAt(KKListbox.SelectedIndex);

        }

        private void KKSzerkeszt_Click(object sender, EventArgs e)
        {
            string[] sorFeld = KKListbox.Items[KKListbox.SelectedIndex].ToString().Split(" - ");
            KKazon.Text = sorFeld[0].Substring(1, 4);
            KKszer.Text = sorFeld[1];
            KKname.Text = sorFeld[2];
            KKev.Text = sorFeld[3];
            KKModosit.Enabled = true;
        }

        private void KKModosit_Click(object sender, EventArgs e)
        {
            if (KKszer.Text.Trim() == "")
            {
                MessageBox.Show("A szerz� nincs megadva");
            }
            else if (KKname.Text.Trim() == "")
            {
                MessageBox.Show("A c�m nem lehet �res");
            }
            else
            {
                try
                {
                    int ev = int.Parse(KKev.Text);
                    string sor = $"[{KKazon.Text}] - {KKszer.Text} - {KKname.Text} - {KKev.Text}";
                    KKListbox.Items[KKListbox.SelectedIndex] = sor;
                    KKModosit.Enabled = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hib�s �vsz�m");
                }
            }
        }

        private void OOUjOlv_Click(object sender, EventArgs e)
        {
            if (OOListBox.Items.Count == 0)
            {
                OOAzonsito.Text = "1000";
            }
            else
            {
                int azonosit = 1000;
                for (int i = 0; i < OOListBox.Items.Count; i++)
                {
                    string azonossz = OOListBox.Items[i].ToString().Substring(1, 4);
                    int azo = int.Parse(azonossz);
                    if (azo >= azonosit)
                    {
                        azonosit += 1;
                    }
                }
                OOAzonsito.Text = azonosit.ToString();
            }
            OOFelvesz.Enabled = true;
            OONev.Text = "";
            OOCim.Text = "";
            OOEletkor.Text = "";
        }

        private void OOFelvesz_Click(object sender, EventArgs e)
        {
            if (OONev.Text.Trim().Length == 0)
            {
                MessageBox.Show("Add meg a neved!");
            }
            else if (OOCim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Add meg a c�med!");
            }
            else
            {
                try
                {

                    int kiad = int.Parse(OOEletkor.Text);
                    string olvaso = $"[{OOAzonsito.Text}] - {OONev.Text} - {OOCim.Text} - {OOEletkor.Text}";
                    OOListBox.Items.Add(olvaso);
                    OOFelvesz.Enabled = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Adj meg helyes �letkort!");
                }
            }
        }

        private void OOModosit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
