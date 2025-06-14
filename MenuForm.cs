using System;
using System.Windows.Forms;

namespace defne
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.Text = "Ana Menü";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Oyuna başlama: Form1 açılır
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide(); // MenuForm'u gizle
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Yardım mesajı göster
            MessageBox.Show("Oyunu oynamak için yön tuşlarını ve boşluk tuşunu kullanın.",
                "Yardım", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Uygulamayı kapat
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button1 için yapılacak işlemleri buraya yazabilirsiniz
            MessageBox.Show("Her beş score da bir yeni düşman gelecek!\n" +
                "Yeni düşmanlara ateş edemezsen canın azalır. \n" +
                "Score 50 olunca can kiti toplayarak canını arttırabilirsin!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
