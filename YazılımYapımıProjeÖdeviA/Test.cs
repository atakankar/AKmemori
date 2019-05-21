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
    public partial class Test : MetroFramework.Forms.MetroForm
    {
        public Test()
        {
            InitializeComponent();
        }
        int i = 1;
        int seviye = 0;

        private void Test_Load(object sender, EventArgs e)
        {
            metroLabelIng.Visible = false;
            metroLabelTuru.Visible = false;
            metroLabeCumle.Visible = false;
            metroLabelTr.Visible = false;
            TxtBoxIng.Visible = false;
            TxtBoxTuru.Visible = false;
            TxtBoxCumle.Visible = false;
            TxtBoxTr.Visible = false;
            MetroBtnKontrol.Visible = false;
            labelDogrusu.Visible = false;
            MetroBtnKontrol.Enabled = false;
        }

        private void MetroBtnBasla_Click(object sender, EventArgs e)
        {
            metroLabelIng.Visible = true;
            metroLabelTuru.Visible = true;
            metroLabeCumle.Visible = true;
            metroLabelTr.Visible = true;
            TxtBoxIng.Visible = true;
            TxtBoxTuru.Visible = true;
            TxtBoxCumle.Visible = true;
            TxtBoxTr.Visible = true;
            MetroBtnKontrol.Visible = true;
            MetroBtnBasla.Visible = false;
            MetroBtnKontrol.Enabled = true;
            labelDogrusu.DataBindings.Clear();
            labelDogrusu.Visible = false;
            TxtBoxTr.ReadOnly = false;
            TxtBoxTr.Text = "";
            KelimeleriGoster();
        }

        private void MetroBtnKontrol_Click(object sender, EventArgs e)
        {
            if (TxtBoxTr.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜRKÇE KISMINI BOŞ BIRAKMAYIN");
            }

            else
            {
                SQLiteConnection con = new SQLiteConnection("Data Source= db/Kelime.db");
                con.Open();
                string sql = "SELECT * FROM Kelimeler WHERE Ingilizcesi=@ing AND Turkcesi=@turkce";

                SQLiteParameter prm1 = new SQLiteParameter("ing", TxtBoxIng.Text);
                SQLiteParameter prm2 = new SQLiteParameter("turkce", TxtBoxTr.Text.ToLower());

                SQLiteCommand cmd = new SQLiteCommand(sql, con);

                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Doğru");
                    DogruTarih(seviye);
                    i++;
                }
                else
                {
                    MessageBox.Show("Yanlış yaptın!");
                    Dogrusu();
                    YanlısTarihi();
                    i++;

                }

                MetroBtnBasla.Text = "SIRADAKİ";
                MetroBtnBasla.Visible = true;
                MetroBtnKontrol.Enabled = false;
                TxtBoxTr.ReadOnly = true;

                con.Close();
            }
        }


        private void Dogrusu()
        {
            SQLiteDatabase db1 = new SQLiteDatabase();
            db1.SQliteDoğrusu(labelDogrusu, i);
        }

        private void KelimeleriGoster()
        {
            SQLiteDatabase db1 = new SQLiteDatabase();
            int sayi = db1.KelimeSayısı();

            for (int j = 1; j < sayi; j++)
            {

                string bağlantı, sorgum1;
                bağlantı = "Data Source= db/Kelime.db";
                sorgum1 = "Select Numara,Ingilizcesi,Turkcesi,Turu,Cumlesi,Tarih,Seviyesi from Kelimeler where Numara = " + i + "";
                SQLiteConnection yeni = new SQLiteConnection(bağlantı);
                yeni.Open();
                SQLiteDataAdapter getir2 = new SQLiteDataAdapter(sorgum1, yeni);
                DataSet göster = new DataSet();
                getir2.Fill(göster, "Kelimeler");
                TxtBoxIng.Text = "";
                TxtBoxIng.DataBindings.Clear();
                TxtBoxTuru.Text = "";
                TxtBoxTuru.DataBindings.Clear();
                TxtBoxCumle.Text = "";
                TxtBoxCumle.DataBindings.Clear();


                if (i > sayi)
                {
                    TxtBoxIng.Text = "Sorular bitti";
                    MetroBtnKontrol.Enabled = false;
                    break;

                }
                DateTime bugun = DateTime.Today;
                TxtBoxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Tarih");
                DateTime sorunungunu = Convert.ToDateTime(TxtBoxIng.Text);
                TxtBoxIng.Text = "";
                TxtBoxIng.DataBindings.Clear();

                TxtBoxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Seviyesi");
                seviye = Convert.ToInt32(TxtBoxIng.Text);
                TxtBoxIng.Text = "";
                TxtBoxIng.DataBindings.Clear();



                int ZamanıGeldiniMi = DateTime.Compare(bugun, sorunungunu);
                TxtBoxIng.DataBindings.Clear();
                if (ZamanıGeldiniMi >= 0 && seviye < 5)
                {

                    TxtBoxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Ingilizcesi");
                    TxtBoxTuru.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Turu");
                    TxtBoxCumle.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Cumlesi");
                    break;
                }
                else
                    i++;


            }

        }

        private void DogruTarih(int seviyesi1)
        {
            SQLiteDatabase db1 = new SQLiteDatabase();
            db1.SqliteDogruTarih(seviyesi1, i);
        }

        private void YanlısTarihi()
        {
            SQLiteDatabase db1 = new SQLiteDatabase();
            db1.SQLiteYanlısTarihi(i);
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
    }
}
