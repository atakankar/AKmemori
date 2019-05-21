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
    public partial class Ogren : MetroFramework.Forms.MetroForm
    {
        public Ogren()
        {
            InitializeComponent();
        }

        int i = 1, seviye;

        private void Ogren_Load(object sender, EventArgs e)
        {
            metroLabelIng.Visible = false;
            metroLabelTuru.Visible = false;
            metroLabeCumle.Visible = false;
            metroLabelTr.Visible = false;
            metroLabel1.Visible = false;
            TxtBoxIng.Visible = false;
            TxtBoxTuru.Visible = false;
            TxtBoxCumle.Visible = false;
            TxtBoxCumleTr.Visible = false;
            TxtBoxTr.Visible = false;
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonAnaSyfa_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa ana = new Anasayfa();
            ana.Show();
        }

        private void OgrenBtn_Click(object sender, EventArgs e)
        {
            metroLabelIng.Visible = true;
            metroLabelTuru.Visible = true;
            metroLabeCumle.Visible = true;
            metroLabelTr.Visible = true;
            metroLabel1.Visible = true;
            TxtBoxIng.Visible = true;
            TxtBoxTuru.Visible = true;
            TxtBoxCumle.Visible = true;
            TxtBoxCumleTr.Visible = true;
            TxtBoxTr.Visible = true;
            KelimeleriGoster();
            SeviyeUpdate();
            OgrenBtn.Text = "Sıradaki";

            i++;
        }


        private void KelimeleriGoster()
        {
            SQLiteDatabase db1 = new SQLiteDatabase();
            int sayi = db1.KelimeSayısı();

            for (int j = 1; j < sayi; j++)
            {

                string bağlantı, sorgum1;
                bağlantı = "Data Source= db/Kelime.db";
                sorgum1 = "Select Numara,Ingilizcesi,Turkcesi,Turu,Cumlesi,CumleTrsi,Tarih,Seviyesi from Kelimeler where Numara = " + i + "";
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
                TxtBoxCumleTr.Text = "";
                TxtBoxCumleTr.DataBindings.Clear();
                TxtBoxTr.Text = "";
                TxtBoxTr.DataBindings.Clear();


                if (i > sayi)
                {
                    TxtBoxIng.Text = "Sorular bitti";
                    break;

                }
                TxtBoxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Seviyesi");
                seviye = Convert.ToInt32(TxtBoxIng.Text);
                TxtBoxIng.Text = "";
                TxtBoxIng.DataBindings.Clear();

                if (seviye == 0)
                {
                    TxtBoxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Ingilizcesi");
                    TxtBoxTuru.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Turu");
                    TxtBoxCumle.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Cumlesi");
                    TxtBoxCumleTr.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "CumleTrsi");
                    TxtBoxTr.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Turkcesi");
                    break;
                }
                else
                    i++;                
            }
        }

        private void SeviyeUpdate()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source= db/Kelime.db");
            con.Open();
            SQLiteCommand guncelleme;
            DateTime sonrakiGün = DateTime.Today.AddDays(+1);
            guncelleme = new SQLiteCommand("update kelimeler SET Seviyesi='" + 1 + "' where Numara = " + i + "", con);
            guncelleme.ExecuteNonQuery();
            con.Close();
        }
    }
}
