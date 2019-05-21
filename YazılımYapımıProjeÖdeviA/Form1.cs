using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MetroFramework;
using MetroFramework.Controls;

namespace YazılımYapımıProjeÖdeviA
{
    public partial class Anasayfa : MetroFramework.Forms.MetroForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonOgren_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ogren frm1 = new Ogren();
            frm1.Show();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            YeniEkle frm2 = new YeniEkle();
            frm2.Show();
        }

        private void buttonHazine_Click(object sender, EventArgs e)
        {
            this.Hide();
            Goruntule frm3 = new Goruntule();
            frm3.Show();
        }

        private void buttonIstatistik_Click(object sender, EventArgs e)
        {
            this.Hide();
            Istatistik frm4 = new Istatistik();
            frm4.Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test frm5 = new Test();
            frm5.Show();
        }
    }
}
