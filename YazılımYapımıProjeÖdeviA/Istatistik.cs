using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using System.Data.SQLite;

namespace YazılımYapımıProjeÖdeviA
{
    public partial class Istatistik : MetroFramework.Forms.MetroForm
    {
        public Istatistik()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection("Data Source=db/Kelime.db");

        private void Istatistik_Load(object sender, EventArgs e)
        {
            GrafikDoldur();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa ana = new Anasayfa();
            ana.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private int O_AyOgrenilenler(int ay , int yıl)
        {
            int sonay = 0;
            con.Open();
            string sql = "SELECT count(*) FROM Kelimeler";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());


            for (int i = 1; i<kayitSayisi; i++ )
            {

                SQLiteCommand cmd1 = new SQLiteCommand("Select Tarih from Kelimeler where Numara=" + i + "",con);
                DateTime Gün = Convert.ToDateTime(cmd1.ExecuteScalar());
                int günayı = Convert.ToInt32(Gün.Month.ToString());
                int günyılı = Convert.ToInt32(Gün.Year.ToString());


                SQLiteCommand cmd2 = new SQLiteCommand("Select Seviyesi from Kelimeler where Numara=" + i + "", con);
                int seviye = Convert.ToInt32(cmd2.ExecuteScalar());


                if(günayı==ay && günyılı== yıl && seviye==5)
                {
                    sonay++;
                }

            }
            con.Close();
            return sonay;
        }

        private void GrafikDoldur()
        {
            int ay1 = Convert.ToInt32(DateTime.Today.Month);
            int yıl1 = Convert.ToInt32(DateTime.Today.Year);

            int ay2 = Convert.ToInt32(DateTime.Today.AddMonths(-1).Month);
            int yıl2 = Convert.ToInt32(DateTime.Today.AddMonths(-1).Year);

            int ay3 = Convert.ToInt32(DateTime.Today.AddMonths(-2).Month);
            int yıl3 = Convert.ToInt32(DateTime.Today.AddMonths(-2).Year);

            int ay4 = Convert.ToInt32(DateTime.Today.AddMonths(-3).Month);
            int yıl4 = Convert.ToInt32(DateTime.Today.AddMonths(-3).Year);

            int a1 = O_AyOgrenilenler(ay4, yıl4), a2 = O_AyOgrenilenler(ay3, yıl3),a3 = O_AyOgrenilenler(ay2, yıl2),a4= O_AyOgrenilenler(ay1, yıl1);           

            chart1.Series["Ezberlendi"].Points.AddXY(ay4 + "/" + yıl4, a1);
            chart1.Series["Ezberlendi"].Points.AddXY(ay3 + "/" + yıl3, a2);
            chart1.Series["Ezberlendi"].Points.AddXY(ay2 + "/" + yıl2, a3);
            chart1.Series["Ezberlendi"].Points.AddXY(ay1 + "/" + yıl1, a4);


        }

        private void Goster_Click(object sender, EventArgs e)
        {


            if (mCboxAy.SelectedIndex == -1 || mCboxYıl.SelectedIndex == -1)
                MessageBox.Show("Lütfen Seçim Yapınız");

            else
            {
                int ay = Convert.ToInt32(mCboxAy.SelectedItem.ToString());
                int yıl = Convert.ToInt32(mCboxYıl.SelectedItem.ToString());
                LblÖğrenilen.Text = O_AyOgrenilenler(ay, yıl).ToString() + " " + "Ezberlendi.";
            }

        }
    }
}
