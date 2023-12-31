using System.Drawing.Drawing2D;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace basitoyun
{
    public partial class Form1 : Form
    {
        int boruH�z� = 8;//borular�n ne kadar h�zl� hareket dedce�i
        int gravity = 0; // Ba�lang��ta yer�ekimi etkisi olmas�n hep b�yle a��klama yapar chatgpt 
        int skore = 0;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            skor.Text = "Skor: " + skore.ToString();

            // Y�n tu�lar�na ve fare t�klamalar�na tepki g�stermek i�in event handler'lar� ekleyin
            this.KeyDown += new KeyEventHandler(gameKeysdown);
            this.MouseDown += new MouseEventHandler(gameMouseDown);

            // Timer'� ba�lat�n
            gameTimer.Start();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                // Nesnenin pozisyonunu g�ncelle
                brinds.Top += gravity;//brinds yukar� ve a�a�� hareket etsin
                borualt.Left -= boruH�z�;//sola do�ru hareket et
                boruust.Left -= boruH�z�;

                // Borular�n ekran d���na ��k�p ��kmad���n� kontrol et ve skoru g�ncelle
                if (borualt.Left < -150)
                {
                    borualt.Left = 800;
                    skore++;
                    skor.Text = "Skor: " + skore.ToString();
                }

                if (boruust.Left < -180)
                {
                    boruust.Left = 950;
                    skore++;
                    skor.Text = "Skor: " + skore.ToString();
                }

                // Brinds'in zemine �arpmas�n� kontrol et
                if (brinds.Bounds.IntersectsWith(zemin.Bounds) || brinds.Top + brinds.Height >= this.ClientSize.Height)
                {
                    endgame();

                    int x = brinds.Location.X;
                    int y = brinds.Location.Y;
                    brinds.Visible = false;
                    geberikKus1.Location = new Point(x, y + 20);
                    geberikKus2.Location = new Point(x + 100, y);
                    geberikKus3.Location = new Point(x, y + 75);
                    geberikKus4.Location = new Point(x + 150, y);
                    geberikKus1.Visible = true;
                    geberikKus2.Visible = true;
                    geberikKus3.Visible = true;
                    geberikKus4.Visible = true;
                }

                // Brinds'in borulara �arp�p �arpmad���n� kontrol et
                if (brinds.Bounds.IntersectsWith(boruust.Bounds) || brinds.Bounds.IntersectsWith(borualt.Bounds))
                {
                    isGameOver = true;
                    brinds.BackColor = Color.Red; // �arp�ld���nda rengini de�i�tir

                    // Game Over yaz�s�n� ekrana b�y�k bir �ekilde g�ster
                    Label gameOverLabel = new Label();
                    gameOverLabel.Text = "�LD�N�Z!";
                    gameOverLabel.Font = new Font("Arial", 36, FontStyle.Bold);
                    gameOverLabel.AutoSize = true;
                    gameOverLabel.Location = new Point((this.Width - gameOverLabel.Width) / 2, (this.Height - gameOverLabel.Height) / 2);
                    this.Controls.Add(gameOverLabel);
                    
                    skor.ForeColor = Color.Red;

                    int x = brinds.Location.X;
                    int y = brinds.Location.Y;
                    brinds.Visible = false;
                    geberikKus1.Location = new Point(x, y + 20);
                    geberikKus2.Location = new Point(x + 100, y);
                    geberikKus3.Location = new Point(x, y + 75);
                    geberikKus4.Location = new Point(x + 150, y);
                    geberikKus1.Visible = true;
                    geberikKus2.Visible = true;
                    geberikKus3.Visible = true;
                    geberikKus4.Visible = true;
                    string audioFilePath = "C:\\Users\\babur\\Desktop\\Yeni klas�r (2)\\wah.wav";
                    new SoundPlayer(audioFilePath).Play();
                }
            }
        }

        private void gameKeysdown(object sender, KeyEventArgs e)
        {
            // Y�n tu�lar�na bas�ld���nda, brinds'in yukar� hareket etmesi i�in gravity'yi ayarla
            if (e.KeyCode == Keys.Up)
            {
                gravity = -15;
            }
        }

        private void gameMouseDown(object sender, MouseEventArgs e)
        {
            // Fare t�kland���nda, brinds'in yukar� hareket etmesi i�in gravity'yi ayarla
            gravity = -15;
        }

        private void gamekeysup(object sender, KeyEventArgs e)
        {
            // Y�n tu�lar�na bas�l� b�rak�ld���nda, gravity'yi s�f�rla
            if (e.KeyCode == Keys.Up)
            {
                gravity = 15;
            }
        }

        private void endgame()
        {
            isGameOver = true;
            gameTimer.Stop();
            skor.Text = "Game over";
        }

        bool durum = false;

        private void borualt_Click(object sender, EventArgs e)
        { 

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void geberikkuslar_Tick(object sender, EventArgs e)
        {
            if (isGameOver == true)
            {
                int max_y = 600;
                int deger = 2;

                if (geberikKus1.Location.Y != max_y)
                {
                    geberikKus1.Location = new Point(geberikKus1.Location.X + deger, geberikKus1.Location.Y - deger);
                }
                if (geberikKus2.Location.Y != max_y)
                {
                    geberikKus2.Location = new Point(geberikKus2.Location.X + deger, geberikKus2.Location.Y + deger);
                }
                if (geberikKus3.Location.Y != max_y)
                {
                    geberikKus3.Location = new Point(geberikKus3.Location.X - deger, geberikKus3.Location.Y - deger);
                }
                if (geberikKus4.Location.Y != max_y)
                {
                    geberikKus4.Location = new Point(geberikKus4.Location.X - deger, geberikKus4.Location.Y + deger);
                }

                if (geberikKus1.Location.Y == max_y && geberikKus2.Location.Y == max_y && geberikKus3.Location.Y == max_y && geberikKus4.Location.Y == max_y)
                {
                    geberikkuslar.Stop();
                }
            }
        }
    }
}