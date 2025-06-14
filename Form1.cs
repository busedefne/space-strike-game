
/*
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace defne
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private bool right, left, space;
        private bool gameOver = false;
        private int score;
        private int missedEnemies = 0; // Kaçan düşman sayısı
        private List<PictureBox> explosionList = new List<PictureBox>();

        private PictureBox newEnemy = new PictureBox();
        private bool newEnemyActive = false;

        private PictureBox secondEnemy = new PictureBox(); // Score 10 için yeni düşman
        private bool secondEnemyActive = false;

        private PictureBox thirdEnemy = new PictureBox(); // Score 15 için yeni düşman
        private bool thirdEnemyActive = false;

        private PictureBox fourthEnemy = new PictureBox(); // Score 25 için yeni düşman
        private bool fourthEnemyActive = false;

        private PictureBox fifthEnemy = new PictureBox(); // Score 30 için yeni düşman
        private bool fifthEnemyActive = false;

        private PictureBox sixthEnemy = new PictureBox(); // Score 50 için yeni düşman
        private bool sixthEnemyActive = false;
        private int sixthEnemyHealth = 5; // Sixth enemy'nin sağlığı (5 mermiye dayanacak)

        // Skor 50 düşmanı için can değeri

        public Form1()
        {
            InitializeComponent();
            lbl_over.Hide();
            progressBar1.Value = 100; // Başlangıçta progres bar dolu olacak
            progressBar1.Maximum = 100;
            progressBar1.ForeColor = Color.Green; // Başlangıçta yeşil
            gameOver = false;  // Oyunun başlangıcında gameOver false
            lbl_progress.Text = progressBar1.Value.ToString();
        }

        // sixthEnemy için sağlık değeri

        // Yeni düşman eklerken sağlık değeri başlatılacak
        private void Add_New_Enemy()
        {
            if (score >= 5 && !newEnemyActive)
            {
                InitializeEnemy(newEnemy, "newEnemy", Properties.Resources.download);
                newEnemyActive = true;
            }

            if (score >= 10 && !secondEnemyActive)
            {
                InitializeEnemy(secondEnemy, "secondEnemy", Properties.Resources.download__1_);
                secondEnemyActive = true;
            }

            if (score >= 15 && !thirdEnemyActive)
            {
                InitializeEnemy(thirdEnemy, "thirdEnemy", Properties.Resources.download__2_);
                thirdEnemyActive = true;
            }

            if (score >= 25 && !fourthEnemyActive)
            {
                InitializeEnemy(fourthEnemy, "fourthEnemy", Properties.Resources.download__4_);
                fourthEnemyActive = true;
            }

            if (score >= 30 && !fifthEnemyActive)
            {
                InitializeEnemy(fifthEnemy, "fifthEnemy", Properties.Resources.download__6_);
                fifthEnemyActive = true;
            }

            if (score >= 75 && !sixthEnemyActive)
            {
                InitializeEnemy(sixthEnemy, "sixthEnemy", Properties.Resources.download__5_);
                sixthEnemyActive = true;
                sixthEnemyHealth = 5;  // Son düşman için sağlık ekleniyor.
            }
        }


        private void InitializeEnemy(PictureBox enemy, string tag, Image image)
        {
            enemy.SizeMode = PictureBoxSizeMode.AutoSize;

            if (image != null)
            {
                enemy.Image = image;
            }

            enemy.Tag = tag;
            enemy.Location = new Point(rnd.Next(0, this.ClientSize.Width - enemy.Width), -50);

            this.Controls.Add(enemy);
            enemy.BringToFront();
        }

        private void NewEnemy_Movement()
        {
            MoveEnemy(newEnemy, ref newEnemyActive);
            MoveEnemy(secondEnemy, ref secondEnemyActive);
            MoveEnemy(thirdEnemy, ref thirdEnemyActive);
            MoveEnemy(fourthEnemy, ref fourthEnemyActive);
            MoveEnemy(fifthEnemy, ref fifthEnemyActive);
            MoveEnemy(sixthEnemy, ref sixthEnemyActive);
        }



        private void MoveEnemy(PictureBox enemy, ref bool isActive)
        {
            if (isActive)
            {
                enemy.Top += 10;

                if (enemy.Top > this.ClientSize.Height)
                {
                    // Düşman gözden kayarsa
                    missedEnemies++;
                    UpdateProgressBar();

                    enemy.Top = -50;
                    enemy.Left = rnd.Next(0, this.ClientSize.Width - enemy.Width);
                }
            }
        }



        private void UpdateProgressBar()
        {
            // Her gözden kaçan düşman için progress bar'ın değerini azalt
            progressBar1.Value = 100 - (missedEnemies * 10); // Her kaybedilen düşman için değer %10 azalır

            // Eğer 10 düşman kayarsa, oyun biter
            if (missedEnemies >= 10)
            {
                EndGame();
            }

            // Progress bar'ın rengini güncelle
            int red = (missedEnemies * 25); // Kırmızı artacak
            int green = 255 - red; // Yeşil azalacak

            // Kırmızı-yeşil tonlarında bir renk oluşturuyoruz
            progressBar1.ForeColor = Color.FromArgb(Math.Min(red, 255), Math.Min(green, 255), 0);

            // Progress bar'daki değeri label'a yansıt
            lbl_progress.Text = progressBar1.Value.ToString();  // Progress bar'daki değeri label'a yansıt
        }

        private void Game_Result()
        {
            // Diğer düşmanlar için çarpışma kontrolü
            CheckCollision(newEnemy, ref newEnemyActive);
            CheckCollision(secondEnemy, ref secondEnemyActive);
            CheckCollision(thirdEnemy, ref thirdEnemyActive);
            CheckCollision(fourthEnemy, ref fourthEnemyActive);
            CheckCollision(fifthEnemy, ref fifthEnemyActive);

            // Son düşman (sixthEnemy) için özel çarpışma kontrolü
            if (sixthEnemyActive)
            {
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (j.Bounds.IntersectsWith(sixthEnemy.Bounds)) // sixthEnemy ile mermi çarpışma kontrolü
                        {
                            HandleBulletCollision((PictureBox)j, sixthEnemy);
                        }
                    }
                }
            }

            // Diğer mermi çarpışmaları ve oyun bitiş kontrolleri
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "bullet")
                {
                    foreach (Control i in this.Controls)
                    {
                        if (i is PictureBox && (i.Tag == "enemy" || i.Tag == "newEnemy" || i.Tag == "secondEnemy" || i.Tag == "thirdEnemy" || i.Tag == "fourthEnemy" || i.Tag == "fifthEnemy" || i.Tag == "sixthEnemy"))
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                HandleBulletCollision((PictureBox)j, (PictureBox)i);
                            }
                        }
                    }
                }
            }

            // Player ile çarpışma kontrolü
            if (player.Bounds.IntersectsWith(ship.Bounds) || player.Bounds.IntersectsWith(alien.Bounds))
            {
                EndGame();
            }
        }


        private void CheckCollision(PictureBox enemy, ref bool isActive)
        {
            if (isActive && player.Bounds.IntersectsWith(enemy.Bounds))
            {
                EndGame();
            }
        }


        private void HandleBulletCollision(PictureBox bullet, PictureBox enemy)
        {
            // Eğer mermi patlamışsa, tekrar işlem yapma
            if (bullet.Tag == "exploded")
            {
                return;
            }

            bullet.Tag = "exploded"; // Mermiyi patlamış olarak işaretle
            bullet.Image = Properties.Resources.explosion;
            explosionList.Add(bullet);
            score++;
            lbl_score.Text = "Score : " + score;

            // sixthEnemy için özel sağlık kontrolü
            if (enemy.Tag == "sixthEnemy")
            {
                sixthEnemyHealth--;  // Sağlık bir azalmış oluyor
                if (sixthEnemyHealth <= 0)
                {
                    // Düşman öldü
                    enemy.Top = -50;
                    enemy.Left = rnd.Next(0, this.ClientSize.Width - enemy.Width);
                    sixthEnemyHealth = 5; // Sağlık sıfırlandı, yeni düşman yerleştirildi
                }
            }
            else
            {
                // Diğer düşmanlar için normal çarpışma işlemi
                enemy.Top = -50;
                enemy.Left = rnd.Next(0, this.ClientSize.Width - enemy.Width);
            }

            Timer explosionTimer = new Timer();
            explosionTimer.Interval = 100;
            explosionTimer.Tick += (sender, e) => RemoveExplosion(explosionTimer, bullet);
            explosionTimer.Start();
        }


        private void EndGame()
        {
            timer1.Stop();
            lbl_over.Show();
            lbl_over.BringToFront();
            gameOver = true; // Oyun bittiğinde gameOver true olur
        }



        private void RemoveExplosion(Timer timer, PictureBox explosion)
        {
            this.Controls.Remove(explosion);
            explosionList.Remove(explosion);
            timer.Stop();
            timer.Dispose();
        }


        private void Star()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "stars")
                {
                    j.Top += 30;
                    if (j.Top > 80)
                    {
                        j.Top = 0;
                    }
                }
            }
        }


        private void Add_Bullet()
        {
            if (gameOver) return;

            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            if (Properties.Resources.icons8_bullet_16__1_1 != null)
            {
                bullet.Image = Properties.Resources.icons8_bullet_16__1_1;
            }
            bullet.BackColor = Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + (player.Width / 2) - (bullet.Width / 2);
            bullet.Top = player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void Bullet_Movement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if (x.Top < 100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void Enemy_Movement()
        {
            if (alien.Top >= 500)
            {
                alien.Location = new Point(rnd.Next(0, 300), 0);
            }

            if (ship.Top >= 500)
            {
                ship.Location = new Point(rnd.Next(0, 300), 0);
            }
            else
            {
                alien.Top += 15;
                ship.Top += 10;
            }
        }

        private void Arrow_key_Movement()
        {
            if (right)
            {
                if (player.Left < 465)
                {
                    player.Left += 20;
                }
            }



            if (left)
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }



        // Add_FallingBullet metodunu düzenleyelim
        private PictureBox fallingBullet = new PictureBox(); // Yukarıdan düşen mermi

        private void Add_FallingBullet()
        {
            if (score >= 50 && fallingBullet.Top == 0)  // Skor 5 olduğunda mermi düşmeye başlasın
            {
                fallingBullet.SizeMode = PictureBoxSizeMode.AutoSize;
                fallingBullet.Image = Properties.Resources.healtkit4;  // Aynı mermi resmini kullanalım
                fallingBullet.Tag = "fallingBullet";
                fallingBullet.Left = rnd.Next(0, this.ClientSize.Width - fallingBullet.Width); // Mermiyi rastgele yere yerleştir
                fallingBullet.Top = 0;  // Başlangıçta üstte olacak
                this.Controls.Add(fallingBullet);
                fallingBullet.BringToFront();
            }
        }

        // FallingBullet hareketini düzenleyelim
        private void FallingBullet_Movement()
        {
            if (fallingBullet.Top < this.ClientSize.Height) // Ekranın altına kadar düşsün
            {
                fallingBullet.Top += 8;  // Düşme hızı
            }
            else
            {
                // Ekranın altına ulaştığında mermiyi sıfırla
                fallingBullet.Top = 0;
                fallingBullet.Left = rnd.Next(0, this.ClientSize.Width - fallingBullet.Width);
            }
        }

        // Düşen mermi ile çarpışma kontrolü ve progressBar güncellemesi
        private void CheckFallingBulletCollision()
        {
            if (player.Bounds.IntersectsWith(fallingBullet.Bounds))  // Eğer roket mermiyle çarpışırsa
            {
                // Progres bar değerini artır
                if (progressBar1.Value < 100)  // Eğer progres bar 100'den düşükse
                {
                    progressBar1.Value += 10;  // Progres bar değerini 10 artır
                    lbl_progress.Text = progressBar1.Value.ToString();  // Progress bar'daki değeri label'a yansıt
                }

                // Mermiyi sıfırla
                fallingBullet.Top = 0;
                fallingBullet.Left = rnd.Next(0, this.ClientSize.Width - fallingBullet.Width);
            }
        }

        // Timer1_Tick fonksiyonu içinde tüm fonksiyonları çağırıyoruz
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gameOver)  // Eğer oyun bitmemişse
            {
                Add_New_Enemy(); // Skora bağlı olarak yeni düşmanları ekle
                Add_FallingBullet(); // Skor 5 olduğunda mermi düşür
                Star(); // Yıldızları hareket ettir
                Enemy_Movement(); // Düşmanları hareket ettir
                NewEnemy_Movement(); // Yeni düşmanları hareket ettir
                Bullet_Movement(); // Mermileri hareket ettir
                Game_Result(); // Çarpışma kontrolünü yap
                Arrow_key_Movement(); // Ok tuşlarıyla hareketi kontrol et
                FallingBullet_Movement(); // Düşen mermiyi hareket ettir
                CheckFallingBulletCollision(); // Düşen mermiyle çarpışma kontrolü
            }
        }

    }
}*/

//son temiz kodum 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace defne
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random(); //Rastgele sayı üretici
        private bool right, left, space; //Hareket kontrol değişkenleri
        private bool gameOver = false; //0yun durumu değişkeni
        private int score; //Skor değişkeni
        private int missedEnemies = 0; // Kaçan düşman sayısı
        private List<PictureBox> explosionList = new List<PictureBox>(); //Patlama efektleri için liste
        SoundPlayer backgroundMusic; //Arkaplan müziği

        private PictureBox newEnemy = new PictureBox(); //score 5 için yeni düşman
        private bool newEnemyActive = false;

        private PictureBox secondEnemy = new PictureBox(); // Score 10 için yeni düşman
        private bool secondEnemyActive = false;

        private PictureBox thirdEnemy = new PictureBox(); // Score 15 için yeni düşman
        private bool thirdEnemyActive = false;

        private PictureBox fourthEnemy = new PictureBox(); // Score 25 için yeni düşman
        private bool fourthEnemyActive = false;

        private PictureBox fifthEnemy = new PictureBox(); // Score 30 için yeni düşman
        private bool fifthEnemyActive = false;

        private PictureBox sixthEnemy = new PictureBox(); // Score 50 için yeni düşman Bos
        private bool sixthEnemyActive = false;
        private int sixthEnemyHealth = 5; // Sixth enemy'nin sağlığı (5 mermiye dayanacak)

        

        public Form1()
        {
            
            InitializeComponent();
            lbl_over.Hide(); //Oyun bittiğinde gelecek olan yazıyı gizle
            backgroundMusic = new SoundPlayer(Properties.Resources.spaceBacgraundSound);
            backgroundMusic.PlayLooping(); //Arkaplan müziğini dögü şeklinde çal
            progressBar1.Value = 100; // Başlangıçta progres bar dolu olacak
            progressBar1.Maximum = 100;
            progressBar1.ForeColor = Color.Green; // Başlangıçta yeşil (bu satır olmasa da olur)
            gameOver = false;  // Oyunun başlangıcında gameOver false
            lbl_progress.Text = progressBar1.Value.ToString();
        }

        

        // Skora bağlı olarak yeni düşmanları oyuna ekleyen fonksiyon
        private void Add_New_Enemy()
        {
            if (score >= 5 && !newEnemyActive)
            {
                InitializeEnemy(newEnemy, "newEnemy", Properties.Resources.download);
                newEnemyActive = true;
            }

            if (score >= 10 && !secondEnemyActive)
            {
                InitializeEnemy(secondEnemy, "secondEnemy", Properties.Resources.download__1_);
                secondEnemyActive = true;
            }

            if (score >= 15 && !thirdEnemyActive)
            {
                InitializeEnemy(thirdEnemy, "thirdEnemy", Properties.Resources.download__2_);
                thirdEnemyActive = true;
            }

            if (score >= 25 && !fourthEnemyActive)
            {
                InitializeEnemy(fourthEnemy, "fourthEnemy", Properties.Resources.download__4_);
                fourthEnemyActive = true;
            }

            if (score >= 30 && !fifthEnemyActive)
            {
                InitializeEnemy(fifthEnemy, "fifthEnemy", Properties.Resources.download__6_);
                fifthEnemyActive = true;
            }

            if (score >= 75 && !sixthEnemyActive)
            {
                InitializeEnemy(sixthEnemy, "sixthEnemy", Properties.Resources.download__5_);
                sixthEnemyActive = true;
                sixthEnemyHealth = 5;  // Son düşman için sağlık ekleniyor.
            }
        }

        // düşman rastgele başlatma fonksiyonu
        private void InitializeEnemy(PictureBox enemy, string tag, Image image)
        {
            enemy.SizeMode = PictureBoxSizeMode.AutoSize;

            if (image != null)
            {
                enemy.Image = image;
            }

            enemy.Tag = tag;
            enemy.Location = new Point(rnd.Next(0, this.ClientSize.Width - enemy.Width), -50);

            this.Controls.Add(enemy);
            enemy.BringToFront();
        }

        //Oyundaki düşmanları hareket ettirme fonksiyonu
        private void NewEnemy_Movement()
        {
            MoveEnemy(newEnemy, ref newEnemyActive);
            MoveEnemy(secondEnemy, ref secondEnemyActive);
            MoveEnemy(thirdEnemy, ref thirdEnemyActive);
            MoveEnemy(fourthEnemy, ref fourthEnemyActive);
            MoveEnemy(fifthEnemy, ref fifthEnemyActive);
            MoveEnemy(sixthEnemy, ref sixthEnemyActive);
        }


        
        private void MoveEnemy(PictureBox enemy, ref bool isActive)
        {
            if (isActive)
            {
                enemy.Top += 10; //Düşman aşağıya hareket eder

                if (enemy.Top > this.ClientSize.Height)
                {
                    // Düşman gözden kayarsa
                    missedEnemies++; //Kaçan düşman sayısını arttır
                    UpdateProgressBar(); //ProgresBarı güncelle

                    enemy.Top = -50;
                    enemy.Left = rnd.Next(0, this.ClientSize.Width - enemy.Width);
                }
            }
        }


        //Progress barı takip edip güncelleyen 
        private void UpdateProgressBar()
        {
            // Her gözden kaçan düşman için progress bar'ın değerini azalt
            progressBar1.Value = 100 - (missedEnemies * 10); // Her kaybedilen düşman için değer %10 azalır

            // Eğer 10 düşman kayarsa, oyun biter
            if (missedEnemies >= 10)
            {
                EndGame();
            }

            // Progress bar'ın rengini güncelle
            int red = (missedEnemies * 25); // Kırmızı artacak
            int green = 255 - red; // Yeşil azalacak

            // Kırmızı-yeşil tonlarında bir renk oluşturuyoruz
            progressBar1.ForeColor = Color.FromArgb(Math.Min(red, 255), Math.Min(green, 255), 0);

            // Progress bar'daki değeri label'a yansıt
            lbl_progress.Text = progressBar1.Value.ToString();  // Progress bar'daki değeri label'a yansıt
        }

        private void Game_Result()
        {
            // Diğer düşmanlar için çarpışma kontrolü 
            CheckCollision(newEnemy, ref newEnemyActive);
            CheckCollision(secondEnemy, ref secondEnemyActive);
            CheckCollision(thirdEnemy, ref thirdEnemyActive);
            CheckCollision(fourthEnemy, ref fourthEnemyActive);
            CheckCollision(fifthEnemy, ref fifthEnemyActive);

            // Son düşman (sixthEnemy) için özel çarpışma kontrolü
            if (sixthEnemyActive)
            {
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (j.Bounds.IntersectsWith(sixthEnemy.Bounds)) // sixthEnemy ile mermi çarpışma kontrolü
                        {
                            HandleBulletCollision((PictureBox)j, sixthEnemy);
                        }
                    }
                }
            }

            // Diğer mermi çarpışmaları ve oyun bitiş kontrolleri
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "bullet")
                {
                    foreach (Control i in this.Controls)
                    {
                        if (i is PictureBox && (i.Tag == "enemy" || i.Tag == "newEnemy" || i.Tag == "secondEnemy" || i.Tag == "thirdEnemy" || i.Tag == "fourthEnemy" || i.Tag == "fifthEnemy" || i.Tag == "sixthEnemy"))
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                HandleBulletCollision((PictureBox)j, (PictureBox)i);
                            }
                        }
                    }
                }
            }

            // Player ile çarpışma kontrolü ship ve alien için  intersectsWith
            if (player.Bounds.IntersectsWith(ship.Bounds) || player.Bounds.IntersectsWith(alien.Bounds))
            {
                EndGame();
            }
        }

        //düşmanla oyuncunun çarpışma durumunu kontrol ediyoruzz bitiş
        private void CheckCollision(PictureBox enemy, ref bool isActive)
        {
            if (isActive && player.Bounds.IntersectsWith(enemy.Bounds))
            {
                EndGame();
            }
        }

        //Mermi ve düşman arasındaki çarpışma durumu
        private void HandleBulletCollision(PictureBox bullet, PictureBox enemy)
        {
            // Eğer mermi patlamışsa, tekrar işlem yapma
            if (bullet.Tag == "exploded")
            {
                return;
            }

            bullet.Tag = "exploded"; // Mermiyi patlamış olarak işaretle
            bullet.Image = Properties.Resources.explosion; //!!Merminin görüntüsünü patlama efektiyle değiştirir.
            explosionList.Add(bullet);//Patlayan mermiyi, patlamaların kaydedildiği explosionList adlı bir listeye ekler.
            score++;
            lbl_score.Text = "Score : " + score;

            // sixthEnemy için özel sağlık kontrolü
            if (enemy.Tag == "sixthEnemy")
            {
                sixthEnemyHealth--;  // Sağlık bir azalmış oluyor
                if (sixthEnemyHealth <= 0)
                {
                    // Düşman öldü
                    enemy.Top = -50; //konum
                    enemy.Left = rnd.Next(0, this.ClientSize.Width - enemy.Width);
                    sixthEnemyHealth = 5; // Sağlık sıfırlandı, yeni düşman yerleştirildi
                }
            }
            else
            {
                // Diğer düşmanlar için normal çarpışma işlemi
                enemy.Top = -50; //konum
                enemy.Left = rnd.Next(0, this.ClientSize.Width - enemy.Width);
            }

            Timer explosionTimer = new Timer(); //Patlama animasyonunun süresini kontrol etmek için bir zamanlayıcı
            explosionTimer.Interval = 100; //Zamanlayıcı, 100 milisaniyelik bir aralıkla çalışacak şekilde ayarlanır.
            explosionTimer.Tick += (sender, e) => RemoveExplosion(explosionTimer, bullet);
            // Zamanlayıcı her tetiklendiğinde, patlama nesnesini ve zamanlayıcıyı kaldırmak için RemoveExplosion fonksiyonu çağrılır.

            explosionTimer.Start();
        }

        //Oyun bittiğinde fonksiyonların durdurulması
        private void EndGame()
        {
            backgroundMusic.Stop();
            timer1.Stop();
            lbl_over.Show();
            lbl_over.BringToFront();
            gameOver = true; // Oyun bittiğinde gameOver true olur
        }


        //patlama efektini ekrandan sil
        private void RemoveExplosion(Timer timer, PictureBox explosion)
        {
            this.Controls.Remove(explosion);  //explosion nesnesini picturebox formdan kaldırır
            explosionList.Remove(explosion); //patlama nesnesini ortadan kaldırıyoruz
            timer.Stop(); 
            timer.Dispose();  //metodu zamanlayıcının kullanılmayan kaynaklarını temizler.
        }


        //Arkaplan yıldızının kayması
        private void Star()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "stars")
                {
                    j.Top += 30;
                    if (j.Top > 80)
                    {
                        j.Top = 0;
                    }
                }
            }
        }

        //Mermi ateşleme ekliyoruz
        private void Add_Bullet()
        {
            if (gameOver) return; //oyun sona erince mermi atabilme durumunu durdurmak için

            PictureBox bullet = new PictureBox(); //mermi ekledim
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            if (Properties.Resources.icons8_bullet_16__1_1 != null) //mermi resmiyle uğraşmacaa
            {
                bullet.Image = Properties.Resources.icons8_bullet_16__1_1;
            }
            bullet.BackColor = Color.Transparent; 
            bullet.Tag = "bullet";
            bullet.Left = player.Left + (player.Width / 2) - (bullet.Width / 2); //roketin tam ortasına mermi yerleştirme işi
            bullet.Top = player.Top - 30; //dikey yukarı
            this.Controls.Add(bullet);
            bullet.BringToFront(); 
        }

        //tatlıs mermilerimin yukarı kanatlanma hareketi 
        private void Bullet_Movement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10; // mermiyi her döngüde 10 piksel yukarı kaydır
                    if (x.Top < 100) //merminin üst kısmı 100 pikselin altına inerse, mermi ekrandan kaldırılır
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }


        //ilk iki düşmanım alien ve ship için hareket kontrol mekanizması 
        private void Enemy_Movement()
        {
            if (alien.Top >= 500)
            {
                alien.Location = new Point(rnd.Next(0, 300), 0);
            }

            if (ship.Top >= 500)
            {
                ship.Location = new Point(rnd.Next(0, 300), 0);
            }
            else
            {
                alien.Top += 15;
                ship.Top += 10;
            }
        }


        //roketimin ekran içinde sağa sola gidiş durumunu ayarlayalım
        private void Arrow_key_Movement()
        {
            if (right)
            {
                if (player.Left < 465)
                {
                    player.Left += 20;
                }
            }



            if (left)
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }

        }

        //klavye kontrol"
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();
            }
        }


        //gereksiz
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //Roketin hareketi
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }



        // Add_FallingBullet metodunu düzenleyelim
        private PictureBox fallingBullet = new PictureBox(); // Yukarıdan düşen can kiti


        //Can kiti ekledim
        private void Add_FallingBullet()
        {
            if (score >= 50 && fallingBullet.Top == 0)  // Skor 50 olduğunda yokarıdan can kiti düşmeye başlasın
            {
                fallingBullet.SizeMode = PictureBoxSizeMode.AutoSize;
                fallingBullet.Image = Properties.Resources.healtkit4;  // Can kiti resmi
                fallingBullet.Tag = "fallingBullet";
                fallingBullet.Left = rnd.Next(0, this.ClientSize.Width - fallingBullet.Width); // Can kitini rastgele yere yerleştir
                fallingBullet.Top = 0;  // Başlangıçta üstte olacak
                this.Controls.Add(fallingBullet);
                fallingBullet.BringToFront();
            }
        }

        // Can kitii  FallingBullet hareketini düzenleyelim can kiti
        private void FallingBullet_Movement()
        {
            if (fallingBullet.Top < this.ClientSize.Height) // Ekranın altına kadar düşsün
            {
                fallingBullet.Top += 8;  // Düşme hızı
            }
            else
            {
                // Ekranın altına ulaştığında sıfırla
                fallingBullet.Top = 0;
                fallingBullet.Left = rnd.Next(0, this.ClientSize.Width - fallingBullet.Width);
            }
        }

        // Düşen can kiti ile çarpışma kontrolü ve progressBar güncellemesi
        private void CheckFallingBulletCollision()
        {
            if (player.Bounds.IntersectsWith(fallingBullet.Bounds))  // Eğer roket can kitiyle çarpışırsa
            {
                // Progres bar değerini artır
                if (progressBar1.Value < 100)  // Eğer progres bar 100'den düşükse
                {
                    progressBar1.Value += 10;  // Progres bar değerini 10 artır
                    lbl_progress.Text = progressBar1.Value.ToString();  // Progress bar'daki değeri label'a yansıt
                }

                // Can kitini sıfırla
                fallingBullet.Top = 0;
                fallingBullet.Left = rnd.Next(0, this.ClientSize.Width - fallingBullet.Width);
            }
        }
      
        // Timer1_Tick fonksiyonu içinde tüm fonksiyonları çağırıyoruz
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gameOver)  // Eğer oyun bitmemişse
            {
                Add_New_Enemy(); // Skora bağlı olarak yeni düşmanları ekle
                Add_FallingBullet(); // Skor 50 olduğunda can kiti düşür
                Star(); // Yıldızları hareket ettir
                Enemy_Movement(); // Düşmanları hareket ettir
                NewEnemy_Movement(); // Yeni düşmanları hareket ettir
                Bullet_Movement(); // Mermileri hareket ettir
                Game_Result(); // Çarpışma kontrolünü yap
                Arrow_key_Movement(); // Ok tuşlarıyla hareketi kontrol et
                FallingBullet_Movement(); // Düşen can kitini hareket ettir
                CheckFallingBulletCollision(); // Düşen mermiyle çarpışma kontrolü
            }
        }

    }
}