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
            StreamWriter sw = new StreamWriter("konyvek.txt");
            for (int i = 0; i < KKListbox.Items.Count; i++)
            {
                string pontos = KKListbox.Items[i].ToString().Replace(" - ",";");
                sw.WriteLine(pontos);
            }

            sw.Close();
        }
    }
}
