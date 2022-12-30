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
    public partial class SulamaModellemesi : Form
    {
        public SulamaModellemesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAnaSayfa anaSayfa = new UserAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Zeytin Modellemesini Seçtiniz Onaylıyormusunuz ? ", "Modelleme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result1 == DialogResult.Yes)
            {
                ZeytinModel zeytinModel = new ZeytinModel();
                zeytinModel.Show();
                this.Hide();
            }
            else
            {
                SulamaModellemesi sulamaModellemesi = new SulamaModellemesi();
                sulamaModellemesi.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Üzüm Modellemesini Seçtiniz Onaylıyormusunuz ? ", "Modelleme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result1 == DialogResult.Yes)
            {
                UzumModel uzumModel = new UzumModel();
                uzumModel.Show();
                this.Hide();
            }
            else
            {
                SulamaModellemesi sulamaModellemesi = new SulamaModellemesi();
                sulamaModellemesi.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("deneme");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SulamaModellemesi_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserAnaSayfa anaSayfa = new UserAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
