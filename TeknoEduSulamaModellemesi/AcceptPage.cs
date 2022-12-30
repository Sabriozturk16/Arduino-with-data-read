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
    public partial class AcceptPage : Form
    {
        GirisYap giris = new GirisYap();
        public AcceptPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris.yonetici();
            giris.Admin();
            if (textBox1.Text == giris.Password ||  textBox1.Text == giris.adminpassword)
            {
                DialogResult furkan = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz ? ", "Çıkış Yapma", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (furkan == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    Giris giris = new Giris();
                    giris.Show();
                    this.Hide();

                }

            }
            else
            {
                DialogResult result1 = MessageBox.Show("Yönetici Değilsiniz Sistemi Ellemeyiniz ", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
