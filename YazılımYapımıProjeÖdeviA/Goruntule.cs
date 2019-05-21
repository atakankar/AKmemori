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
    public partial class Goruntule : MetroFramework.Forms.MetroForm
    {
        public Goruntule()
        {
            InitializeComponent();
        }

        private void Goruntule_Load(object sender, EventArgs e)
        {
            SQLiteConnection bag = new SQLiteConnection("Data Source=db/Kelime.db");

            DataSet dtst = new DataSet();

            bag.Open();

            SQLiteDataAdapter getir = new SQLiteDataAdapter("select * From Kelimeler", bag);

            getir.Fill(dtst, "Kelimeler");

            dataGridView1.DataSource = dtst.Tables["Kelimeler"];

            getir.Dispose();

            bag.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa ana = new Anasayfa();
            ana.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
