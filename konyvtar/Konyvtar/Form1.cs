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
            // Ha a lista üres, akkor 1000 az elsõ azonosító
            if (KKListbox.Items.Count == 0)
            {
                KKazon.Text = "1000";
            }
            else // az eddigi legnagyobbnál eggyel nagyobbat
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
                MessageBox.Show("Add meg a szerzõt!");
            }
            else if (KKname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Add meg a címet!");
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
                    MessageBox.Show("Adj meg helyes kiadási évet!");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kilépünk a programból (de még létezik a form)
            StreamWriter sw = new StreamWriter(@"..\..\..\konyvek.txt");
            for (int i = 0; i < KKListbox.Items.Count; i++)
            {
                string pontos = KKListbox.Items[i].ToString().Replace(" - ", ";");
                sw.WriteLine(pontos);
            }

            sw.Close();


            StreamWriter so = new StreamWriter(@"..\..\..\olvasok.txt");
            for (int i = 0; i < OOListBox.Items.Count; i++)
            {
                string pontosss = OOListBox.Items[i].ToString().Replace(" - ", ";");
                so.WriteLine(pontosss);
            }

            so.Close();



            StreamWriter sk = new StreamWriter(@"..\..\..\kolcsonzesek.txt");
            for (int i = 0; i < kzkListBox.Items.Count; i++)
            {
                // string pontossssssss = kzkListBox.Items[i].ToString().Replace(" - ", ";");
                sk.WriteLine(kzkListBox.Items[i].ToString());
            }


            sk.Close();
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
                MessageBox.Show("A könyvek fájl nem olvasható");
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
                MessageBox.Show("Az olvasók fájl nem olvasható");
            }



            try
            {


                StreamReader sk = new StreamReader(@"..\..\..\kolcsonzesek.txt");

                string ssoor = sk.ReadLine();
                while (ssoor != null)
                {
                    // string kolcson = ssoor.Replace(";", " - ");
                    kzkListBox.Items.Add(ssoor);
                    ssoor = sk.ReadLine();
                }

                sk.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A kölcsönzések fájl nem olvasható");
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
                MessageBox.Show("A szerzõ nincs megadva");
            }
            else if (KKname.Text.Trim() == "")
            {
                MessageBox.Show("A cím nem lehet üres");
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
                    MessageBox.Show("Hibás évszám");
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
                MessageBox.Show("Add meg a címed!");
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
                    MessageBox.Show("Adj meg helyes életkort!");
                }
            }
        }
        private void OOSzerk_Click(object sender, EventArgs e)
        {
            string[] sorFeld = OOListBox.Items[OOListBox.SelectedIndex].ToString().Split(" - ");
            OOAzonsito.Text = sorFeld[0].Substring(1, 4);
            OONev.Text = sorFeld[1];
            OOCim.Text = sorFeld[2];
            OOEletkor.Text = sorFeld[3];
            OOModosit.Enabled = true;
        }

        private void OOModosit_Click(object sender, EventArgs e)
        {
            if (OONev.Text.Trim() == "")
            {
                MessageBox.Show("A név nincs megadva!");
            }
            else if (OOCim.Text.Trim() == "")
            {
                MessageBox.Show("A cím nem lehet üres");
            }
            else
            {
                try
                {
                    int ev = int.Parse(OOEletkor.Text);
                    string sor = $"[{OOAzonsito.Text}] - {OONev.Text} - {OOCim.Text} - {OOEletkor.Text}";
                    OOListBox.Items[OOListBox.SelectedIndex] = sor;
                    OOModosit.Enabled = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás életkor!");
                }
            }
        }

        private void OOListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OOListBox.SelectedIndex == -1)
            {
                OOTorles.Enabled = false;
                OOSzerk.Enabled = false;
            }
            else
            {
                OOTorles.Enabled = true;
                OOSzerk.Enabled = true;
            }
        }

        private void OOTorles_Click(object sender, EventArgs e)
        {
            OOListBox.Items.RemoveAt(OOListBox.SelectedIndex);
        }

        private void kzkKolcsonzesek_Enter(object sender, EventArgs e)
        {
            kzkKolcsonzesek.Items.Clear();
            // feltöltjük a könyvekkel
            for (int ki = 0; ki < KKListbox.Items.Count; ki++)
            {
                string konyv = KKListbox.Items[ki].ToString();
                kzkKolcsonzesek.Items.Add(konyv);
            }
        }

        private void kzkKolcsonzesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kzkKolcsonzesek.SelectedIndex != -1) // ha van kiválasztott elem
            {
                string konyv = kzkKolcsonzesek.Items[kzkKolcsonzesek.SelectedIndex].ToString();
                string kkazon = konyv.Substring(1, 4); // (1023) - Kiss Péter...

                bool megvan = false;
                string kolcsonzes = "";
                // keressük ezt a könyvet a kölcsönzések között
                for (int kzki = 0; kzki < kzkListBox.Items.Count; kzki++)
                {
                    kolcsonzes = kzkListBox.Items[kzki].ToString();
                    if (kolcsonzes.Substring(0, 4) == kkazon)
                    {
                        megvan = true;
                        break; // ha megvan, akkor nem kell tovább a for ciklus
                    }
                }
                if (megvan)
                {
                    string olvasoAzon = kolcsonzes.Substring(5, 4);
                    // keressük az olvasó adatait az olvasó listában
                    string Olvaso = "";
                    bool megvanOlvaso = false;
                    for (int olvi = 0; olvi < OOListBox.Items.Count; olvi++)
                    {
                        Olvaso = OOListBox.Items[olvi].ToString();
                        if (Olvaso.Substring(1, 4) == olvasoAzon)
                        {
                            break;
                        }
                    }
                    string[] feld = Olvaso.Split(" - ");
                    kzkOlvNev.Text = feld[0] + feld[1];
                    kzkMettol.Text = kolcsonzes.Substring(10, 10);
                    kzkMeddig.Text = kolcsonzes.Substring(21, 10);
                }
                else // nincs kölcsönadva
                {
                    kzkOlvNev.Text = "";
                    kzkMettol.Text = "";
                    kzkMeddig.Text = "";
                }
            }
        }

        private void kzkVissza_Click(object sender, EventArgs e)
        {
            string konyv = kzkKolcsonzesek.Items[kzkKolcsonzesek.SelectedIndex].ToString();
            string konyvazon = konyv.Substring(0, 4);
            string kolcsonzes = "";
            int hol = 0;
            for (int kzki = 0; kzki < kzkListBox.Items.Count; kzki++)
            {
                kolcsonzes = kzkListBox.Items[kzki].ToString();
                if (kolcsonzes.Substring(0, 4) == konyvazon)
                {
                    hol = kzki;
                    break;
                }
            }
            kzkListBox.Items.RemoveAt(hol);
            kzkOlvNev.Text = "";
            kzkMettol.Text = "";
            kzkMeddig.Text = "";
            
        }

        private void kzkMeghossz_Click(object sender, EventArgs e)
        {
            if (kzkKolcsonzesek.SelectedIndex >= 0)
            {

                string konyv = kzkKolcsonzesek.Items[kzkKolcsonzesek.SelectedIndex].ToString();
                string konyvazon = konyv.Substring(1, 4);
                string kolcsonzes = "";
                int hol = 0;
                for (int kzki = 0; kzki < kzkListBox.Items.Count; kzki++)
                {
                    kolcsonzes = kzkListBox.Items[kzki].ToString();
                    if (kolcsonzes.Substring(0, 4) == konyvazon)
                    {
                        string[] feld = kolcsonzes.Split(";");
                        string med = feld[3];
                        string[] feld2 = med.Split("-");
                        int honap = int.Parse(feld2[1]);
                        int nap = int.Parse(feld2[2]);
                        nap += 10;
                        if (nap > 30)
                        {
                            nap -= 30;
                            honap++;

                        }
                        string hh = $"{honap:00}";
                        string nn = $"{nap:00}";
                        string ujkolcs = kolcsonzes.Substring(0, kolcsonzes.Length - 5) + hh + "-" + nn;
                        kzkListBox.Items[kzki] = ujkolcs;
                    }
                }
            }
        }
    }
}
