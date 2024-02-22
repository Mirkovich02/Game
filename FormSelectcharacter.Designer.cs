using System;

namespace Game
{
    partial class FormSelectcharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectcharacter));
            pbChooseMagier = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pbChoosePatrick = new PictureBox();
            pbChooseGoku = new PictureBox();
            pbchooseStreetFighter = new PictureBox();
            bRandom = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbChooseMagier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbChoosePatrick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbChooseGoku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbchooseStreetFighter).BeginInit();
            SuspendLayout();
            // 
            // pbChooseMagier
            // 
            pbChooseMagier.BackColor = Color.Transparent;
            pbChooseMagier.BorderStyle = BorderStyle.FixedSingle;
            pbChooseMagier.Image = (Image)resources.GetObject("pbChooseMagier.Image");
            pbChooseMagier.Location = new Point(325, 259);
            pbChooseMagier.Name = "pbChooseMagier";
            pbChooseMagier.Size = new Size(172, 126);
            pbChooseMagier.SizeMode = PictureBoxSizeMode.Zoom;
            pbChooseMagier.TabIndex = 0;
            pbChooseMagier.TabStop = false;
            pbChooseMagier.Click += pictureBox1_Click;
            // 
            // pbChoosePatrick
            // 
            pbChoosePatrick.BackColor = Color.Transparent;
            pbChoosePatrick.BorderStyle = BorderStyle.FixedSingle;
            pbChoosePatrick.Image = (Image)resources.GetObject("pbChoosePatrick.Image");
            pbChoosePatrick.Location = new Point(125, 421);
            pbChoosePatrick.Name = "pbChoosePatrick";
            pbChoosePatrick.Size = new Size(172, 125);
            pbChoosePatrick.SizeMode = PictureBoxSizeMode.Zoom;
            pbChoosePatrick.TabIndex = 1;
            pbChoosePatrick.TabStop = false;
            pbChoosePatrick.Click += pbChoosePatrick_Click;
            // 
            // pbChooseGoku
            // 
            pbChooseGoku.BackColor = Color.Transparent;
            pbChooseGoku.BorderStyle = BorderStyle.FixedSingle;
            pbChooseGoku.Image = (Image)resources.GetObject("pbChooseGoku.Image");
            pbChooseGoku.Location = new Point(325, 421);
            pbChooseGoku.Name = "pbChooseGoku";
            pbChooseGoku.Size = new Size(178, 126);
            pbChooseGoku.SizeMode = PictureBoxSizeMode.Zoom;
            pbChooseGoku.TabIndex = 2;
            pbChooseGoku.TabStop = false;
            pbChooseGoku.Click += pictureBox3_Click;
            // 
            // pbchooseStreetFighter
            // 
            pbchooseStreetFighter.BackColor = Color.Transparent;
            pbchooseStreetFighter.BorderStyle = BorderStyle.FixedSingle;
            pbchooseStreetFighter.Image = (Image)resources.GetObject("pbchooseStreetFighter.Image");
            pbchooseStreetFighter.Location = new Point(125, 259);
            pbchooseStreetFighter.Name = "pbchooseStreetFighter";
            pbchooseStreetFighter.Size = new Size(178, 126);
            pbchooseStreetFighter.SizeMode = PictureBoxSizeMode.Zoom;
            pbchooseStreetFighter.TabIndex = 3;
            pbchooseStreetFighter.TabStop = false;
            pbchooseStreetFighter.Click += pbchooseStreetFighter_Click;
            // 
            // bRandom
            // 
            bRandom.BackColor = Color.Purple;
            bRandom.ForeColor = Color.Gainsboro;
            bRandom.Location = new Point(540, 513);
            bRandom.Name = "bRandom";
            bRandom.Size = new Size(99, 33);
            bRandom.TabIndex = 4;
            bRandom.Text = "Random";
            bRandom.UseVisualStyleBackColor = false;
            bRandom.Click += bRandom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(187, 388);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "Yamato";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(385, 388);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Merkelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.InactiveBorder;
            label3.Location = new Point(170, 549);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Patrick der Star";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(374, 550);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "Son Goku ";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.MenuText;
            label6.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumSlateBlue;
            label6.Location = new Point(125, 60);
            label6.Name = "label6";
            label6.Size = new Size(423, 61);
            label6.TabIndex = 10;
            label6.Text = "Wähle dein Charakter aus:";
            // 
            // FormSelectcharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(842, 595);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bRandom);
            Controls.Add(pbchooseStreetFighter);
            Controls.Add(pbChooseGoku);
            Controls.Add(pbChoosePatrick);
            Controls.Add(pbChooseMagier);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormSelectcharacter";
            Text = "FormSelectcharecter";
            ((System.ComponentModel.ISupportInitialize)pbChooseMagier).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbChoosePatrick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbChooseGoku).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbchooseStreetFighter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbChooseMagier;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pbChoosePatrick;
        private PictureBox pbChooseGoku;
        private PictureBox pbchooseStreetFighter;
        private Button bRandom;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}