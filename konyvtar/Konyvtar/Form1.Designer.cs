namespace Konyvtar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            KKev = new TextBox();
            KKname = new TextBox();
            KKszer = new TextBox();
            KKazon = new TextBox();
            KKkiadas = new Label();
            KKCim = new Label();
            KKSzerzo = new Label();
            KKAzonosito = new Label();
            KKTorol = new Button();
            KKFelvesz = new Button();
            KKujkonyv = new Button();
            KKModosit = new Button();
            KKSzerkeszt = new Button();
            KKListbox = new ListBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(KKev);
            tabPage1.Controls.Add(KKname);
            tabPage1.Controls.Add(KKszer);
            tabPage1.Controls.Add(KKazon);
            tabPage1.Controls.Add(KKkiadas);
            tabPage1.Controls.Add(KKCim);
            tabPage1.Controls.Add(KKSzerzo);
            tabPage1.Controls.Add(KKAzonosito);
            tabPage1.Controls.Add(KKTorol);
            tabPage1.Controls.Add(KKFelvesz);
            tabPage1.Controls.Add(KKujkonyv);
            tabPage1.Controls.Add(KKModosit);
            tabPage1.Controls.Add(KKSzerkeszt);
            tabPage1.Controls.Add(KKListbox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Könyvek";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // KKev
            // 
            KKev.Location = new Point(646, 368);
            KKev.Name = "KKev";
            KKev.Size = new Size(52, 23);
            KKev.TabIndex = 13;
            // 
            // KKname
            // 
            KKname.Location = new Point(320, 368);
            KKname.Name = "KKname";
            KKname.Size = new Size(320, 23);
            KKname.TabIndex = 12;
            // 
            // KKszer
            // 
            KKszer.Location = new Point(95, 368);
            KKszer.Name = "KKszer";
            KKszer.Size = new Size(218, 23);
            KKszer.TabIndex = 11;
            // 
            // KKazon
            // 
            KKazon.Enabled = false;
            KKazon.Location = new Point(8, 368);
            KKazon.Name = "KKazon";
            KKazon.Size = new Size(56, 23);
            KKazon.TabIndex = 10;
            // 
            // KKkiadas
            // 
            KKkiadas.AutoSize = true;
            KKkiadas.Location = new Point(636, 350);
            KKkiadas.Name = "KKkiadas";
            KKkiadas.Size = new Size(62, 15);
            KKkiadas.TabIndex = 9;
            KKkiadas.Text = "Kiadás éve";
            // 
            // KKCim
            // 
            KKCim.AutoSize = true;
            KKCim.Location = new Point(320, 350);
            KKCim.Name = "KKCim";
            KKCim.Size = new Size(29, 15);
            KKCim.TabIndex = 8;
            KKCim.Text = "Cím";
            // 
            // KKSzerzo
            // 
            KKSzerzo.AutoSize = true;
            KKSzerzo.Location = new Point(95, 350);
            KKSzerzo.Name = "KKSzerzo";
            KKSzerzo.Size = new Size(40, 15);
            KKSzerzo.TabIndex = 7;
            KKSzerzo.Text = "Szerző";
            // 
            // KKAzonosito
            // 
            KKAzonosito.AutoSize = true;
            KKAzonosito.Location = new Point(8, 350);
            KKAzonosito.Name = "KKAzonosito";
            KKAzonosito.Size = new Size(60, 15);
            KKAzonosito.TabIndex = 6;
            KKAzonosito.Text = "Azonosító";
            // 
            // KKTorol
            // 
            KKTorol.Enabled = false;
            KKTorol.Location = new Point(709, 235);
            KKTorol.Name = "KKTorol";
            KKTorol.Size = new Size(75, 23);
            KKTorol.TabIndex = 5;
            KKTorol.Text = "Töröl";
            KKTorol.UseVisualStyleBackColor = true;
            // 
            // KKFelvesz
            // 
            KKFelvesz.Enabled = false;
            KKFelvesz.Location = new Point(709, 177);
            KKFelvesz.Name = "KKFelvesz";
            KKFelvesz.Size = new Size(75, 23);
            KKFelvesz.TabIndex = 4;
            KKFelvesz.Text = "Felvesz";
            KKFelvesz.UseVisualStyleBackColor = true;
            KKFelvesz.Click += KKFelvesz_Click;
            // 
            // KKujkonyv
            // 
            KKujkonyv.Location = new Point(709, 148);
            KKujkonyv.Name = "KKujkonyv";
            KKujkonyv.Size = new Size(75, 23);
            KKujkonyv.TabIndex = 3;
            KKujkonyv.Text = "ÚjKönyv";
            KKujkonyv.UseVisualStyleBackColor = true;
            KKujkonyv.Click += KKujkonyv_Click;
            // 
            // KKModosit
            // 
            KKModosit.Enabled = false;
            KKModosit.Location = new Point(709, 96);
            KKModosit.Name = "KKModosit";
            KKModosit.Size = new Size(75, 23);
            KKModosit.TabIndex = 2;
            KKModosit.Text = "Módosítás";
            KKModosit.UseVisualStyleBackColor = true;
            // 
            // KKSzerkeszt
            // 
            KKSzerkeszt.Enabled = false;
            KKSzerkeszt.Location = new Point(709, 67);
            KKSzerkeszt.Name = "KKSzerkeszt";
            KKSzerkeszt.Size = new Size(75, 23);
            KKSzerkeszt.TabIndex = 1;
            KKSzerkeszt.Text = "Szerkeztés";
            KKSzerkeszt.UseVisualStyleBackColor = true;
            // 
            // KKListbox
            // 
            KKListbox.FormattingEnabled = true;
            KKListbox.ItemHeight = 15;
            KKListbox.Location = new Point(0, 0);
            KKListbox.Name = "KKListbox";
            KKListbox.Size = new Size(698, 334);
            KKListbox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Olvasók";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(794, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kölcsönzés";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox KKListbox;
        private TabPage tabPage3;
        private Button KKFelvesz;
        private Button KKujkonyv;
        private Button KKModosit;
        private Button KKSzerkeszt;
        private Button KKTorol;
        private Label KKkiadas;
        private Label KKCim;
        private Label KKSzerzo;
        private Label KKAzonosito;
        private TextBox KKev;
        private TextBox KKname;
        private TextBox KKszer;
        private TextBox KKazon;
    }
}
