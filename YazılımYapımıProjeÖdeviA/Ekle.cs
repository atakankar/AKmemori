using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace YazılımYapımıProjeÖdeviA
{
    public class Ekle
    {
        public void KayıtEkle(string ingi,string turki, string turui, string cumlei, string cumletri)
        {
            
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=db/Kelime.db");

            turki = turki.ToLower();

            baglan.Open();
            string sql = "Insert into Kelimeler(Ingilizcesi,Turkcesi,Turu,Cumlesi,CumleTrsi,Tarih,Seviyesi) values(@Ingilizcesi,@Turkcesi,@Turu,@Cumlesi,@CumleTrsi,@Tarih,@Seviyesi)";
            SQLiteCommand cmd = new SQLiteCommand(sql, baglan);
            cmd.Parameters.AddWithValue("@Ingilizcesi", ingi);
            cmd.Parameters.AddWithValue("@Turkcesi", turki);
            cmd.Parameters.AddWithValue("@Turu", turui);
            cmd.Parameters.AddWithValue("@Cumlesi", cumlei);
            cmd.Parameters.AddWithValue("@CumleTrsi", cumlei);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Today.ToString());
            cmd.Parameters.AddWithValue("@Seviyesi", "0");

            cmd.ExecuteNonQuery();
            baglan.Close();
            cmd.Dispose();
           
        }
    }
}
