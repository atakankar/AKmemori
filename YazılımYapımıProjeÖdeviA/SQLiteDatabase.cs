using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace YazılımYapımıProjeÖdeviA
{
    public class SQLiteDatabase
    {
        SQLiteConnection con = new SQLiteConnection("Data Source= db/Kelime.db");

        public int KelimeSayısı()
        {
            con.Open();

            string Sorgu = "Select * from Kelimeler";
            SQLiteDataAdapter getir = new SQLiteDataAdapter(Sorgu, con);
            DataSet göster3 = new DataSet();
            getir.Fill(göster3, "Kelimeler");
            int sayi;
            sayi = göster3.Tables["Kelimeler"].Rows.Count;
            con.Close();
            return sayi;
        }

        public void SqliteDogruTarih(int seviyesi, int i)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source= db/Kelime.db");
            con.Open();
            SQLiteCommand guncelleme;
            if (seviyesi == 0)
            {
                DateTime sonrakiGün = DateTime.Today.AddDays(+1);
                guncelleme = new SQLiteCommand("update kelimeler SET Seviyesi='" + 1 + "', Tarih='" + sonrakiGün + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }
            else if (seviyesi == 1)
            {
                DateTime sonrakiGün = DateTime.Today.AddDays(+7);
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 2 + "', Tarih='" + sonrakiGün + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }

            else if (seviyesi == 2)
            {
                DateTime sonrakiGün = DateTime.Today.AddDays(+30);
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 3 + "', Tarih='" + sonrakiGün + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }

            else if (seviyesi == 3)
            {
                DateTime sonrakiGün = DateTime.Today.AddDays(+60);
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 4 + "', Tarih='" + sonrakiGün + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();             
            }
            else if (seviyesi == 4)
            {
                DateTime sonrakiGün = DateTime.Today;
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 5 + "', Tarih='" + sonrakiGün + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }
            
            con.Close();
        }

        public void SQLiteYanlısTarihi(int i1)
        {
            con.Open();
            SQLiteCommand guncelleme;
            DateTime sonrakiGün = DateTime.Today.AddDays(+1);
            guncelleme = new SQLiteCommand("update kelimeler SET Seviyesi='" + 0 + "', Tarih='" + sonrakiGün + "' where Numara = " + i1 + "", con);
            guncelleme.ExecuteNonQuery();
            con.Close();
        }

        public void SQliteDoğrusu(Label LABEL,int i1)
        {
            con.Open();
            string sorgum1 = "Select Numara,Ingilizcesi,Turkcesi,Turu,Cumlesi,Tarih,Seviyesi from Kelimeler where Numara = " + i1 + "";
            SQLiteDataAdapter getir2 = new SQLiteDataAdapter(sorgum1, con);
            DataSet göster = new DataSet();
            getir2.Fill(göster, "Kelimeler");
            LABEL.DataBindings.Clear();
            LABEL.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Turkcesi");
            getir2.Dispose();
            con.Close();
            LABEL.Visible = true;
        }
    }
}
