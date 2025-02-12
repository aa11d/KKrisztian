namespace Labda
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
            timer1 = new System.Windows.Forms.Timer(components);
            labda1 = new PictureBox();
            baseballbat1 = new PictureBox();
            baseballbat2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)labda1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseballbat1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseballbat2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labda1
            // 
            labda1.Image = Properties.Resources.transparentball;
            labda1.Location = new Point(373, 220);
            labda1.Name = "labda1";
            labda1.Size = new Size(64, 59);
            labda1.SizeMode = PictureBoxSizeMode.StretchImage;
            labda1.TabIndex = 0;
            labda1.TabStop = false;
            // 
            // baseballbat1
            // 
            baseballbat1.Image = Properties.Resources.baseballbat1;
            baseballbat1.Location = new Point(12, 106);
            baseballbat1.Name = "baseballbat1";
            baseballbat1.Size = new Size(53, 173);
            baseballbat1.SizeMode = PictureBoxSizeMode.StretchImage;
            baseballbat1.TabIndex = 1;
            baseballbat1.TabStop = false;
            baseballbat1.Click += baseballbat1_Click;
            // 
            // baseballbat2
            // 
            baseballbat2.Image = Properties.Resources.baseballbat1;
            baseballbat2.Location = new Point(721, 106);
            baseballbat2.Name = "baseballbat2";
            baseballbat2.Size = new Size(53, 173);
            baseballbat2.SizeMode = PictureBoxSizeMode.StretchImage;
            baseballbat2.TabIndex = 2;
            baseballbat2.TabStop = false;
            baseballbat2.Click += baseballbat2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "0 : 0";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(baseballbat2);
            Controls.Add(baseballbat1);
            Controls.Add(labda1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PreviewKeyDown += Form1_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)labda1).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseballbat1).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseballbat2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox labda1;
        private PictureBox baseballbat1;
        private PictureBox baseballbat2;
        private Label label1;
    }
}
