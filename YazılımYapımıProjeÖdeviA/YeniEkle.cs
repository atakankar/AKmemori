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

namespace YazılımYapımıProjeÖdeviA
{
    public partial class YeniEkle : MetroFramework.Forms.MetroForm
    {
        public YeniEkle()
        {
            InitializeComponent();
        }

        private void YeniEkle_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa ana = new Anasayfa();
            ana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (metroTextBoxTr.Text == "" || metroTextBoxIng.Text == "" || metroTextBoxTuru.Text == "" || metroTextBoxCumle.Text == "" || metroTextBoxCumleTrsi.Text=="")
            {
                MessageBox.Show("LÜTFEN ALANLARI BOŞ BIRAKMAYIN");
            }

            else
            {
                string ing = metroTextBoxIng.Text, tr = metroTextBoxTr.Text;
                string turu = metroTextBoxTuru.Text, cumle = metroTextBoxCumle.Text;
                string cumletr = metroTextBoxCumleTrsi.Text;

                Ekle ke = new Ekle();
                ke.KayıtEkle(ing, tr, turu, cumle,cumletr);
                string mesaj = "Kayıt Eklendi";
                MessageBox.Show(mesaj);
            }
        }
    }
}
