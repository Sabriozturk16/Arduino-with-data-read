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
    public partial class Giris : Form
    {
        GirisYap giris = new GirisYap();
        int durum = 0;

        public Giris()
        {                     
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris.yonetici();
            giris.Admin();
            if(textBox1.Text==giris.User && textBox2.Text == giris.Password || textBox1.Text==giris.admin && textBox2.Text==giris.adminpassword)
            {
                UserAnaSayfa anaSayfa = new UserAnaSayfa();
                anaSayfa.Show();
                this.Hide();

            }
            else
            {
                DialogResult result1 = MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!!! \n Yeniden Denemek İstermisiniz ? ", "Hatalı Giriş", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(result1 == DialogResult.Yes)
                {
                    Giris giris = new Giris();
                    giris.Show();
                    this.Hide();
                }
                else
                {
                    Giris giris = new Giris();
                    giris.Show();
                    this.Hide();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }

            else
            {
                textBox2.PasswordChar = '\0';
            }

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            CancelButton = button2;
            AcceptButton = button1;
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }

            else
            {
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcceptPage acceptPage = new AcceptPage();
            acceptPage.Show();
            this.Hide();
            



            //DialogResult furkan = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz ? ", "Çıkış Yapma", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //if (furkan == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    Giris giris = new Giris();
            //    giris.Show();
            //    this.Hide();

            //}
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            //if (durum == 0)
            //{
            //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //    durum = 1;
            //}
            //else
            //{
            //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                
            //    durum = 0;
            //}

        }
    }
}
