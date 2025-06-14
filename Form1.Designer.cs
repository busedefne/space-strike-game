/*namespace defne
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ship = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_score.Location = new System.Drawing.Point(2, 3);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(142, 39);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_over.Location = new System.Drawing.Point(243, 321);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(194, 39);
            this.lbl_over.TabIndex = 6;
            this.lbl_over.Text = "Game-Over";
            // 
            // ship
            // 
            this.ship.Image = global::defne.Properties.Resources.icons8_asteroid_50__1_;
            this.ship.Location = new System.Drawing.Point(415, 67);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(50, 50);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            this.ship.Tag = "enemy";
            // 
            // alien
            // 
            this.alien.Image = global::defne.Properties.Resources.icons8_spaceship_48__1_;
            this.alien.Location = new System.Drawing.Point(86, 69);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(48, 48);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::defne.Properties.Resources.icons8_rocket_64__1_;
            this.player.Location = new System.Drawing.Point(309, 593);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::defne.Properties.Resources.IMG_0783__1_;
            this.pictureBox2.Location = new System.Drawing.Point(9, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(698, 336);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "stars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::defne.Properties.Resources.IMG_0783__1_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 336);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stars";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(453, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(182, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(701, 669);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

*/


/* şimdi

namespace defne
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ship = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_score.Location = new System.Drawing.Point(2, 3);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(142, 39);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_over.Location = new System.Drawing.Point(243, 321);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(194, 39);
            this.lbl_over.TabIndex = 6;
            this.lbl_over.Text = "Game-Over";
            // 
            // ship
            // 
            this.ship.Image = global::defne.Properties.Resources.icons8_asteroid_50__1_;
            this.ship.Location = new System.Drawing.Point(415, 67);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(50, 50);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            this.ship.Tag = "enemy";
            // 
            // alien
            // 
            this.alien.Image = global::defne.Properties.Resources.icons8_spaceship_48__1_;
            this.alien.Location = new System.Drawing.Point(86, 69);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(48, 48);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::defne.Properties.Resources.icons8_rocket_64__1_;
            this.player.Location = new System.Drawing.Point(309, 593);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::defne.Properties.Resources.IMG_0783__1_;
            this.pictureBox2.Location = new System.Drawing.Point(9, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(698, 336);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "stars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::defne.Properties.Resources.IMG_0783__1_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 336);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stars";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Aqua;
            this.progressBar1.Location = new System.Drawing.Point(495, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(182, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(701, 669);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

*/

/*
namespace defne
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ship = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_score.Location = new System.Drawing.Point(2, 3);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(142, 39);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_over.Location = new System.Drawing.Point(243, 321);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(194, 39);
            this.lbl_over.TabIndex = 6;
            this.lbl_over.Text = "Game-Over";
            // 
            // ship
            // 
            this.ship.Image = global::defne.Properties.Resources.icons8_asteroid_50__1_;
            this.ship.Location = new System.Drawing.Point(415, 67);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(50, 50);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            this.ship.Tag = "enemy";
            // 
            // alien
            // 
            this.alien.Image = global::defne.Properties.Resources.icons8_spaceship_48__1_;
            this.alien.Location = new System.Drawing.Point(86, 69);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(48, 48);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::defne.Properties.Resources.icons8_rocket_64__1_;
            this.player.Location = new System.Drawing.Point(309, 593);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::defne.Properties.Resources.IMG_0783__1_;
            this.pictureBox2.Location = new System.Drawing.Point(9, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(698, 336);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "stars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::defne.Properties.Resources.IMG_0783__1_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 336);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stars";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(473, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(701, 669);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
*/


//doğru

namespace defne
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.ship = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_score.Location = new System.Drawing.Point(12, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(142, 39);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_over.Location = new System.Drawing.Point(227, 322);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(194, 39);
            this.lbl_over.TabIndex = 6;
            this.lbl_over.Text = "Game-Over";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Aqua;
            this.progressBar1.Location = new System.Drawing.Point(458, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(219, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 100;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.BackColor = System.Drawing.Color.Black;
            this.lbl_progress.Font = new System.Drawing.Font("Engravers MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_progress.Location = new System.Drawing.Point(403, 21);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(49, 21);
            this.lbl_progress.TabIndex = 9;
            this.lbl_progress.Text = "100";
            // 
            // ship
            // 
            this.ship.Image = global::defne.Properties.Resources.icons8_asteroid_50__1_;
            this.ship.Location = new System.Drawing.Point(415, 67);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(50, 50);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            this.ship.Tag = "enemy";
            // 
            // alien
            // 
            this.alien.Image = global::defne.Properties.Resources.icons8_spaceship_48__1_;
            this.alien.Location = new System.Drawing.Point(86, 69);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(48, 48);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::defne.Properties.Resources.icons8_rocket_64__1_;
            this.player.Location = new System.Drawing.Point(309, 593);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::defne.Properties.Resources.IMG_0783__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(698, 661);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "stars";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(701, 669);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_progress;
    }
}
