﻿using System;
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
    public partial class KullaniciSayfa : Form
    {
        public KullaniciSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAnaSayfa anaSayfa = new UserAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
