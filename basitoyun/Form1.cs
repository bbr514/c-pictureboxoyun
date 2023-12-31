using System.Drawing.Drawing2D;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace basitoyun
{
    public partial class Form1 : Form
    {
        int boruHýzý = 8;//borularýn ne kadar hýzlý hareket dedceði
        int gravity = 0; // Baþlangýçta yerçekimi etkisi olmasýn hep böyle açýklama yapar chatgpt 
        int skore = 0;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            skor.Text = "Skor: " + skore.ToString();

            // Yön tuþlarýna ve fare týklamalarýna tepki göstermek için event handler'larý ekleyin
            this.KeyDown += new KeyEventHandler(gameKeysdown);
            this.MouseDown += new MouseEventHandler(gameMouseDown);

            // Timer'ý baþlatýn
            gameTimer.Start();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                // Nesnenin pozisyonunu güncelle
                brinds.Top += gravity;//brinds yukarý ve aþaðý hareket etsin
                borualt.Left -= boruHýzý;//sola doðru hareket et
                boruust.Left -= boruHýzý;

                // Borularýn ekran dýþýna çýkýp çýkmadýðýný kontrol et ve skoru güncelle
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

                // Brinds'in zemine çarpmasýný kontrol et
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

                // Brinds'in borulara çarpýp çarpmadýðýný kontrol et
                if (brinds.Bounds.IntersectsWith(boruust.Bounds) || brinds.Bounds.IntersectsWith(borualt.Bounds))
                {
                    isGameOver = true;
                    brinds.BackColor = Color.Red; // Çarpýldýðýnda rengini deðiþtir

                    // Game Over yazýsýný ekrana büyük bir þekilde göster
                    Label gameOverLabel = new Label();
                    gameOverLabel.Text = "ÖLDÜNÜZ!";
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
                    string audioFilePath = "C:\\Users\\babur\\Desktop\\Yeni klasör (2)\\wah.wav";
                    new SoundPlayer(audioFilePath).Play();
                }
            }
        }

        private void gameKeysdown(object sender, KeyEventArgs e)
        {
            // Yön tuþlarýna basýldýðýnda, brinds'in yukarý hareket etmesi için gravity'yi ayarla
            if (e.KeyCode == Keys.Up)
            {
                gravity = -15;
            }
        }

        private void gameMouseDown(object sender, MouseEventArgs e)
        {
            // Fare týklandýðýnda, brinds'in yukarý hareket etmesi için gravity'yi ayarla
            gravity = -15;
        }

        private void gamekeysup(object sender, KeyEventArgs e)
        {
            // Yön tuþlarýna basýlý býrakýldýðýnda, gravity'yi sýfýrla
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