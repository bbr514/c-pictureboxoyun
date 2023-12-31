namespace basitoyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            brinds = new PictureBox();
            zemin = new PictureBox();
            borualt = new PictureBox();
            boruust = new PictureBox();
            pictureBox8 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            skor = new Label();
            geberikKus1 = new PictureBox();
            geberikKus2 = new PictureBox();
            geberikKus3 = new PictureBox();
            geberikKus4 = new PictureBox();
            geberikkuslar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)brinds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borualt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruust).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus4).BeginInit();
            SuspendLayout();
            // 
            // brinds
            // 
            brinds.Image = (Image)resources.GetObject("brinds.Image");
            brinds.Location = new Point(77, 155);
            brinds.Name = "brinds";
            brinds.Size = new Size(110, 88);
            brinds.SizeMode = PictureBoxSizeMode.StretchImage;
            brinds.TabIndex = 0;
            brinds.TabStop = false;
            // 
            // zemin
            // 
            zemin.BackColor = Color.FromArgb(128, 64, 0);
            zemin.Location = new Point(-1, 421);
            zemin.Name = "zemin";
            zemin.Size = new Size(797, 104);
            zemin.TabIndex = 1;
            zemin.TabStop = false;
            // 
            // borualt
            // 
            borualt.Image = (Image)resources.GetObject("borualt.Image");
            borualt.Location = new Point(372, 241);
            borualt.Name = "borualt";
            borualt.Size = new Size(68, 184);
            borualt.SizeMode = PictureBoxSizeMode.StretchImage;
            borualt.TabIndex = 2;
            borualt.TabStop = false;
            borualt.Click += borualt_Click;
            // 
            // boruust
            // 
            boruust.Image = (Image)resources.GetObject("boruust.Image");
            boruust.Location = new Point(679, -3);
            boruust.Name = "boruust";
            boruust.Size = new Size(68, 186);
            boruust.SizeMode = PictureBoxSizeMode.StretchImage;
            boruust.TabIndex = 3;
            boruust.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox8.Location = new Point(-1, 421);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(797, 23);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimerEvent;
            // 
            // skor
            // 
            skor.AutoSize = true;
            skor.Location = new Point(82, 109);
            skor.Name = "skor";
            skor.Size = new Size(57, 20);
            skor.TabIndex = 8;
            skor.Text = "Score:0";
            // 
            // geberikKus1
            // 
            geberikKus1.Image = (Image)resources.GetObject("geberikKus1.Image");
            geberikKus1.Location = new Point(12, 12);
            geberikKus1.Name = "geberikKus1";
            geberikKus1.Size = new Size(45, 40);
            geberikKus1.SizeMode = PictureBoxSizeMode.StretchImage;
            geberikKus1.TabIndex = 9;
            geberikKus1.TabStop = false;
            geberikKus1.Visible = false;
            // 
            // geberikKus2
            // 
            geberikKus2.Image = (Image)resources.GetObject("geberikKus2.Image");
            geberikKus2.Location = new Point(63, 12);
            geberikKus2.Name = "geberikKus2";
            geberikKus2.Size = new Size(45, 40);
            geberikKus2.SizeMode = PictureBoxSizeMode.StretchImage;
            geberikKus2.TabIndex = 10;
            geberikKus2.TabStop = false;
            geberikKus2.Visible = false;
            // 
            // geberikKus3
            // 
            geberikKus3.Image = (Image)resources.GetObject("geberikKus3.Image");
            geberikKus3.Location = new Point(114, 12);
            geberikKus3.Name = "geberikKus3";
            geberikKus3.Size = new Size(45, 40);
            geberikKus3.SizeMode = PictureBoxSizeMode.StretchImage;
            geberikKus3.TabIndex = 11;
            geberikKus3.TabStop = false;
            geberikKus3.Visible = false;
            // 
            // geberikKus4
            // 
            geberikKus4.Image = (Image)resources.GetObject("geberikKus4.Image");
            geberikKus4.Location = new Point(165, 12);
            geberikKus4.Name = "geberikKus4";
            geberikKus4.Size = new Size(45, 40);
            geberikKus4.SizeMode = PictureBoxSizeMode.StretchImage;
            geberikKus4.TabIndex = 12;
            geberikKus4.TabStop = false;
            geberikKus4.Visible = false;
            // 
            // geberikkuslar
            // 
            geberikkuslar.Enabled = true;
            geberikkuslar.Interval = 10;
            geberikkuslar.Tick += geberikkuslar_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(793, 521);
            Controls.Add(geberikKus4);
            Controls.Add(geberikKus3);
            Controls.Add(geberikKus2);
            Controls.Add(geberikKus1);
            Controls.Add(skor);
            Controls.Add(pictureBox8);
            Controls.Add(boruust);
            Controls.Add(borualt);
            Controls.Add(zemin);
            Controls.Add(brinds);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gameKeysdown;
            KeyUp += gamekeysup;
            ((System.ComponentModel.ISupportInitialize)brinds).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)borualt).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruust).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus1).EndInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus2).EndInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus3).EndInit();
            ((System.ComponentModel.ISupportInitialize)geberikKus4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox brinds;
        private PictureBox zemin;
        private PictureBox borualt;
        private PictureBox boruust;
        private PictureBox pictureBox8;
       // private Label score;
        private System.Windows.Forms.Timer gameTimer;
        private Label skor;
        private PictureBox geberikKus1;
        private PictureBox geberikKus2;
        private PictureBox geberikKus3;
        private PictureBox geberikKus4;
        private System.Windows.Forms.Timer geberikkuslar;
    }
}
