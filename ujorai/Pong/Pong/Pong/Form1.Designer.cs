namespace Pong
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
            uto = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)uto).BeginInit();
            SuspendLayout();
            // 
            // uto
            // 
            uto.Image = Properties.Resources.baseballbat2;
            uto.Location = new Point(301, 388);
            uto.Name = "uto";
            uto.Size = new Size(163, 50);
            uto.SizeMode = PictureBoxSizeMode.StretchImage;
            uto.TabIndex = 0;
            uto.TabStop = false;
            uto.Click += uto_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uto);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            PreviewKeyDown += Form1_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)uto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox uto;
        private System.Windows.Forms.Timer timer1;
    }
}
