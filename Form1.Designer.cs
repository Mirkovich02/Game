using System.Windows.Forms;

namespace Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbPatrikLeft = new PictureBox();
            bSurrender = new Button();
            pbMagierRight = new PictureBox();
            kbProgressBarPlayer1 = new Krypton.Toolkit.KryptonProgressBar();
            kbProgressBarPlayer2 = new Krypton.Toolkit.KryptonProgressBar();
            bAttack = new Button();
            lDamageShowPlayer1 = new Label();
            lDamageShowPlayer2 = new Label();
            pbStreetFighterLeft = new PictureBox();
            pbGoku = new PictureBox();
            pbGokuRight = new PictureBox();
            pbStreetFighterRight = new PictureBox();
            pbPatrikRight = new PictureBox();
            pbMagierLeft = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPatrikLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagierRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStreetFighterLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGoku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGokuRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStreetFighterRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPatrikRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMagierLeft).BeginInit();
            SuspendLayout();
            // 
            // pbPatrikLeft
            // 
            pbPatrikLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbPatrikLeft.BackColor = Color.Transparent;
            pbPatrikLeft.BackgroundImage = (Image)resources.GetObject("pbPatrikLeft.BackgroundImage");
            pbPatrikLeft.BackgroundImageLayout = ImageLayout.Zoom;
            pbPatrikLeft.Location = new Point(161, 337);
            pbPatrikLeft.Name = "pbPatrikLeft";
            pbPatrikLeft.Size = new Size(233, 232);
            pbPatrikLeft.TabIndex = 0;
            pbPatrikLeft.TabStop = false;
            pbPatrikLeft.Visible = false;
            // 
            // bSurrender
            // 
            bSurrender.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bSurrender.BackColor = Color.Transparent;
            bSurrender.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bSurrender.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bSurrender.FlatStyle = FlatStyle.Flat;
            bSurrender.ForeColor = SystemColors.Control;
            bSurrender.Location = new Point(1082, 628);
            bSurrender.Name = "bSurrender";
            bSurrender.Size = new Size(113, 39);
            bSurrender.TabIndex = 1;
            bSurrender.Text = "Surrender";
            bSurrender.UseVisualStyleBackColor = false;
            bSurrender.Click += bSurrender_Click;
            // 
            // pbMagierRight
            // 
            pbMagierRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbMagierRight.BackColor = Color.Transparent;
            pbMagierRight.BackgroundImage = (Image)resources.GetObject("pbMagierRight.BackgroundImage");
            pbMagierRight.BackgroundImageLayout = ImageLayout.Zoom;
            pbMagierRight.Location = new Point(775, 352);
            pbMagierRight.Name = "pbMagierRight";
            pbMagierRight.Size = new Size(244, 251);
            pbMagierRight.TabIndex = 2;
            pbMagierRight.TabStop = false;
            pbMagierRight.Visible = false;
            // 
            // kbProgressBarPlayer1
            // 
            kbProgressBarPlayer1.Location = new Point(127, 50);
            kbProgressBarPlayer1.Name = "kbProgressBarPlayer1";
            kbProgressBarPlayer1.RightToLeft = RightToLeft.Yes;
            kbProgressBarPlayer1.Size = new Size(267, 32);
            kbProgressBarPlayer1.StateCommon.Back.Color1 = Color.Green;
            kbProgressBarPlayer1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            kbProgressBarPlayer1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            kbProgressBarPlayer1.TabIndex = 3;
            kbProgressBarPlayer1.Text = "100%";
            kbProgressBarPlayer1.UseValueAsText = true;
            kbProgressBarPlayer1.Value = 100;
            kbProgressBarPlayer1.Values.Text = "100%";
            // 
            // kbProgressBarPlayer2
            // 
            kbProgressBarPlayer2.Location = new Point(793, 50);
            kbProgressBarPlayer2.Name = "kbProgressBarPlayer2";
            kbProgressBarPlayer2.Size = new Size(267, 32);
            kbProgressBarPlayer2.StateCommon.Back.Color1 = Color.Green;
            kbProgressBarPlayer2.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            kbProgressBarPlayer2.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            kbProgressBarPlayer2.TabIndex = 4;
            kbProgressBarPlayer2.Text = "100%";
            kbProgressBarPlayer2.UseValueAsText = true;
            kbProgressBarPlayer2.Value = 100;
            kbProgressBarPlayer2.Values.Text = "100%";
            // 
            // bAttack
            // 
            bAttack.BackColor = Color.Red;
            bAttack.FlatAppearance.BorderColor = Color.Red;
            bAttack.FlatStyle = FlatStyle.Flat;
            bAttack.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bAttack.ForeColor = SystemColors.HighlightText;
            bAttack.Location = new Point(482, 600);
            bAttack.Name = "bAttack";
            bAttack.Size = new Size(185, 57);
            bAttack.TabIndex = 5;
            bAttack.Text = "Attack";
            bAttack.UseVisualStyleBackColor = false;
            bAttack.Click += bAttack_Click;
            // 
            // lDamageShowPlayer1
            // 
            lDamageShowPlayer1.AutoSize = true;
            lDamageShowPlayer1.BackColor = Color.Transparent;
            lDamageShowPlayer1.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lDamageShowPlayer1.ForeColor = Color.Red;
            lDamageShowPlayer1.Location = new Point(233, 238);
            lDamageShowPlayer1.Name = "lDamageShowPlayer1";
            lDamageShowPlayer1.Size = new Size(62, 63);
            lDamageShowPlayer1.TabIndex = 7;
            lDamageShowPlayer1.Text = "0";
            // 
            // lDamageShowPlayer2
            // 
            lDamageShowPlayer2.AutoSize = true;
            lDamageShowPlayer2.BackColor = Color.Transparent;
            lDamageShowPlayer2.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lDamageShowPlayer2.ForeColor = Color.Red;
            lDamageShowPlayer2.Location = new Point(876, 238);
            lDamageShowPlayer2.Name = "lDamageShowPlayer2";
            lDamageShowPlayer2.Size = new Size(62, 63);
            lDamageShowPlayer2.TabIndex = 8;
            lDamageShowPlayer2.Text = "0";
            // 
            // pbStreetFighterLeft
            // 
            pbStreetFighterLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbStreetFighterLeft.BackColor = Color.Transparent;
            pbStreetFighterLeft.BackgroundImage = Properties.Resources.AnständigerLeft_removebg_preview;
            pbStreetFighterLeft.BackgroundImageLayout = ImageLayout.Zoom;
            pbStreetFighterLeft.Location = new Point(170, 325);
            pbStreetFighterLeft.Name = "pbStreetFighterLeft";
            pbStreetFighterLeft.Size = new Size(233, 232);
            pbStreetFighterLeft.TabIndex = 9;
            pbStreetFighterLeft.TabStop = false;
            pbStreetFighterLeft.Visible = false;
            // 
            // pbGoku
            // 
            pbGoku.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbGoku.BackColor = Color.Transparent;
            pbGoku.BackgroundImage = Properties.Resources.goku;
            pbGoku.BackgroundImageLayout = ImageLayout.Zoom;
            pbGoku.Location = new Point(161, 308);
            pbGoku.Name = "pbGoku";
            pbGoku.Size = new Size(244, 250);
            pbGoku.TabIndex = 10;
            pbGoku.TabStop = false;
            pbGoku.Visible = false;
            // 
            // pbGokuRight
            // 
            pbGokuRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbGokuRight.BackColor = Color.Transparent;
            pbGokuRight.BackgroundImage = Properties.Resources.goku;
            pbGokuRight.BackgroundImageLayout = ImageLayout.Zoom;
            pbGokuRight.Location = new Point(775, 307);
            pbGokuRight.Name = "pbGokuRight";
            pbGokuRight.Size = new Size(244, 250);
            pbGokuRight.TabIndex = 13;
            pbGokuRight.TabStop = false;
            pbGokuRight.Visible = false;
            // 
            // pbStreetFighterRight
            // 
            pbStreetFighterRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbStreetFighterRight.BackColor = Color.Transparent;
            pbStreetFighterRight.BackgroundImage = Properties.Resources.AnständigerRight_removebg_preview;
            pbStreetFighterRight.BackgroundImageLayout = ImageLayout.Zoom;
            pbStreetFighterRight.Location = new Point(775, 325);
            pbStreetFighterRight.Name = "pbStreetFighterRight";
            pbStreetFighterRight.Size = new Size(233, 232);
            pbStreetFighterRight.TabIndex = 12;
            pbStreetFighterRight.TabStop = false;
            pbStreetFighterRight.Visible = false;
            // 
            // pbPatrikRight
            // 
            pbPatrikRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbPatrikRight.BackColor = Color.Transparent;
            pbPatrikRight.BackgroundImage = Properties.Resources.patrickRight;
            pbPatrikRight.BackgroundImageLayout = ImageLayout.Zoom;
            pbPatrikRight.Location = new Point(775, 333);
            pbPatrikRight.Name = "pbPatrikRight";
            pbPatrikRight.Size = new Size(233, 232);
            pbPatrikRight.TabIndex = 11;
            pbPatrikRight.TabStop = false;
            pbPatrikRight.Visible = false;
            // 
            // pbMagierLeft
            // 
            pbMagierLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbMagierLeft.BackColor = Color.Transparent;
            pbMagierLeft.BackgroundImage = Properties.Resources.cocWizzardLeft;
            pbMagierLeft.BackgroundImageLayout = ImageLayout.Zoom;
            pbMagierLeft.Location = new Point(159, 346);
            pbMagierLeft.Name = "pbMagierLeft";
            pbMagierLeft.Size = new Size(244, 251);
            pbMagierLeft.TabIndex = 14;
            pbMagierLeft.TabStop = false;
            pbMagierLeft.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dcb62069f3857cc8edcfd98e7c27e942;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1207, 679);
            Controls.Add(pbGoku);
            Controls.Add(pbMagierLeft);
            Controls.Add(pbStreetFighterRight);
            Controls.Add(pbPatrikRight);
            Controls.Add(pbStreetFighterLeft);
            Controls.Add(lDamageShowPlayer2);
            Controls.Add(lDamageShowPlayer1);
            Controls.Add(bAttack);
            Controls.Add(kbProgressBarPlayer2);
            Controls.Add(kbProgressBarPlayer1);
            Controls.Add(pbMagierRight);
            Controls.Add(bSurrender);
            Controls.Add(pbPatrikLeft);
            Controls.Add(pbGokuRight);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbPatrikLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagierRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStreetFighterLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGoku).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGokuRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStreetFighterRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPatrikRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMagierLeft).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPatrikLeft;
        private Button bSurrender;
        private PictureBox pbMagierRight;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar2;
        private Krypton.Toolkit.KryptonProgressBar kbProgressBarPlayer1;
        private Krypton.Toolkit.KryptonProgressBar kbProgressBarPlayer2;
        private Button bAttack;
        private Label lDamageShowPlayer1;
        private Label lDamageShowPlayer2;
        private PictureBox pbStreetFighterLeft;
        private PictureBox pbGoku;
        private PictureBox pbGokuRight;
        private PictureBox pbStreetFighterRight;
        private PictureBox pbPatrikRight;
        private PictureBox pbMagierLeft;
    }
}