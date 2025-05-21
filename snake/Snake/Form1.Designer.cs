namespace Snake
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
            components = new System.ComponentModel.Container();
            pbFej = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pbAlma = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFej).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlma).BeginInit();
            SuspendLayout();
            // 
            // pbFej
            // 
            pbFej.Location = new Point(1, 0);
            pbFej.Name = "pbFej";
            pbFej.Size = new Size(64, 64);
            pbFej.TabIndex = 0;
            pbFej.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // pbAlma
            // 
            pbAlma.Location = new Point(309, 67);
            pbAlma.Name = "pbAlma";
            pbAlma.Size = new Size(64, 64);
            pbAlma.TabIndex = 1;
            pbAlma.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 621);
            Controls.Add(pbAlma);
            Controls.Add(pbFej);
            KeyPreview = true;
            Name = "Form1";
            Text = "Snake1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbFej).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbFej;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbAlma;
    }
}
