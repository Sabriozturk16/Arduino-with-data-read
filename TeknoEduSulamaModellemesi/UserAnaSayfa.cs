using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoEduSulamaModellemesi
{
    public partial class UserAnaSayfa : Form
    {
        public UserAnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MuhendiseDanis muhendiseDanis = new MuhendiseDanis();
            this.Close();
            muhendiseDanis.Show();
            //KullaniciSayfa kullaniciSayfa = new KullaniciSayfa();
            //kullaniciSayfa.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ciftcisozlugu ciftcisozlugu = new ciftcisozlugu();
            this.Close();
            ciftcisozlugu.Show();
            
            //DialogResult sorgu = MessageBox.Show("Admine Bildirim Gönderildi En Kısa Sürede Sizinle İletişime Geçilecektir \n Devam Etmek İstiyormusunuz ?","Admin Bildirim Gönderme" , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (sorgu == DialogResult.Yes)
            //{
            //    UserAnaSayfa userAnaSayfa  = new UserAnaSayfa();
            //    userAnaSayfa.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    this.Hide();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SulamaModellemesi sulamaModellemesi = new SulamaModellemesi();
            sulamaModellemesi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hakkimizda hakkimizda = new Hakkimizda();
            hakkimizda.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ciftcitakvimi ciftcitakvimi = new ciftcitakvimi();
            this.Close();
            ciftcitakvimi.Show();
            //Giris giris = new Giris();
            //giris.Show();
            //this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void UserAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("YÖNETİCİ OLMADAN AÇAMAZSINIZ");
            //iletisim iletisim = new iletisim();
            //iletisim.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Close();
            giris.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            gubrebilgi gubrebilgi = new gubrebilgi();
            this.Close();
            gubrebilgi.Show();

        }
    }
}
