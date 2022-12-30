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
    public partial class UzumModel : Form
    {
        public UzumModel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAnaSayfa anaSayfa = new UserAnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }

        private void UzumModel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 25;
            
            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label6.Text = "Kumlu Toprağı Seçtiğiniz %7,2 Su alma Kapasitesine sahiptir";
            }
            else if (comboBox2.SelectedIndex == 1)
                {
                label6.Text = "Tınlı Kum Toprağı Seçtiğiniz %10,5 Su alma Kapasitesine sahiptir";
                }
            else if (comboBox2.SelectedIndex == 2)
                {
                label6.Text = "Tın Toprağı Seçtiğiniz %19,6 Su alma Kapasitesine sahiptir";
                }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            ToprakTipler toprakTipler = new ToprakTipler();
            toprakTipler.Show();
            this.Hide();
        }
    }
}
