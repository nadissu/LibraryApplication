using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_BitirmeProjeSon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\veritabani.mdb");
        vtb veritabanı = new vtb();

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapguncelle();
            ogrenciguncelle();
            ogrenciekle();
            dateTimePicker2.MaxDate = DateTime.Now.AddDays(90);
            dateTimePicker2.MinDate = DateTime.Now;

            dateTimePicker1.MaxDate = DateTime.Now;

        }

        private void ogrenciekle()
        {
            emanet_ograd1.Items.Clear();
            emanet_ograd2.Items.Clear();
            ogr_duzenle_adsoyad.Items.Clear();


            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM ogrenci";
            komut.Connection = baglanti;

            baglanti.Open();


            OleDbDataReader oku = komut.ExecuteReader();
            

            while(oku.Read())
            {
                emanet_ograd1.Items.Add(oku["isim_soyisim"].ToString());
                emanet_ograd2.Items.Add(oku["isim_soyisim"].ToString());
                ogr_duzenle_adsoyad.Items.Add(oku["isim_soyisim"].ToString());
            }
            baglanti.Close();

            kitapekle();
        }


        public void kitapekle()
        {
            emanet_ver_kitap_ad.Items.Clear();
            kitap_duzenle_ad.Items.Clear();


            OleDbCommand komut2 = new OleDbCommand();
            komut2.CommandText = "SELECT * FROM kitap";
            komut2.Connection = baglanti;

            baglanti.Open();
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                emanet_ver_kitap_ad.Items.Add(oku2["ad"].ToString());
                kitap_duzenle_ad.Items.Add(oku2["ad"].ToString());
            }

            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kitap_Adi = kitap_ad.Text;
            string kitap_Yazari = kitap_yazar.Text;
            string kitap_Konu = kitap_konu.Text;
            string aciklama = kitap_aciklama.Text;

            veritabanı.yaz("kitap", "'"+ kitap_Adi + "','" + kitap_Yazari + "','" + kitap_Konu + "','" + aciklama + "'","ad,yazar,konu,aciklama");

            kitapguncelle();
            kitapekle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ograd = ogr_ekle_ad.Text;
            string ogrmail = ogr_ekle_mail.Text;
            string ogrno = ogr_ekle_no.Text;
            string ogrtckn = ogr_ekle_tckn.Text;

            veritabanı.yaz("ogrenci", "'" + ograd + "','" + ogrno + "','" + ogrmail + "','" + ogrtckn + "'", "isim_soyisim, telefon, mail, tckn");

            ogrenciguncelle();
            ogrenciekle();
        }


        public void kitapguncelle()
        {
            data_kitap.Rows.Clear();
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM kitap";
            komut.Connection = baglanti;

            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                data_kitap.Rows.Add(oku["ad"].ToString(), oku["yazar"].ToString(), oku["konu"].ToString(), oku["aciklama"].ToString());
            }
            baglanti.Close();

            ogrenciekle();
        }


        public void ogrenciguncelle()
        {
            data_ogrenci.Rows.Clear();
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM ogrenci";
            komut.Connection = baglanti;
            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                data_ogrenci.Rows.Add(oku["isim_soyisim"].ToString(), oku["mail"].ToString(), oku["telefon"].ToString(), oku["tckn"].ToString());
            }
            baglanti.Close();

            ogrenciekle();
        }

        private void kitap_guncelle_Tick(object sender, EventArgs e)
        {
            kitapguncelle();
            ogrenciguncelle();
           
        }

        private void kitap_duzenle_ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kitap_adi = kitap_duzenle_ad.Text;

            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM kitap WHERE ad='"+kitap_adi+"'";
            komut.Connection = baglanti;

            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                kitap_duzenle_yazar.Text = oku["yazar"].ToString();
                kitap_duzenle_konu.Text = oku["konu"].ToString();
                kitap_duzenle_aciklama.Text = oku["aciklama"].ToString();
            }

            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yazar = kitap_duzenle_yazar.Text;
            string aciklama = kitap_duzenle_aciklama.Text;
            string konu = kitap_duzenle_konu.Text;

            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE kitap SET yazar='"+yazar+"', konu='"+konu+"', aciklama='"+aciklama +"' WHERE ad='" + kitap_duzenle_ad.Text + "';";

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            kitapguncelle();
            kitapekle();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kitap_duzenle_ad.Text))
            {
                OleDbCommand komut = new OleDbCommand();

                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM kitap WHERE ad='" + kitap_duzenle_ad.Text +"';";

                baglanti.Open();

                komut.ExecuteNonQuery();

                baglanti.Close();

                kitap_duzenle_ad.Text = "";
                kitap_duzenle_aciklama.Text = "";
                kitap_duzenle_konu.Text = "";
                kitap_duzenle_yazar.Text = "";
                kitapguncelle();
                kitapekle();
            }
        }

        private void ogrekle_adsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ograd = ogr_duzenle_adsoyad.Text;

            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM ogrenci WHERE isim_soyisim='" + ograd + "'";
            komut.Connection = baglanti;

            baglanti.Open();

            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ogr_duzenle_tel.Text = oku["telefon"].ToString();
                ogr_duzenle_mail.Text = oku["mail"].ToString();
                ogr_duzenle_tckn.Text = oku["tckn"].ToString();
            }

            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mail = ogr_duzenle_mail.Text;
            string tel = ogr_duzenle_tel.Text;
            string tckn = ogr_duzenle_tckn.Text;

            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE ogrenci SET mail='" + mail + "', telefon='" + tel + "', tckn='" + tckn + "' WHERE isim_soyisim='" + ogr_duzenle_adsoyad.Text + "';";

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            ogrenciguncelle();
            ogrenciekle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ogr_duzenle_adsoyad.Text))
            {
                OleDbCommand komut = new OleDbCommand();

                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM ogrenci WHERE isim_soyisim='" + ogr_duzenle_adsoyad.Text + "';";

                baglanti.Open();

                komut.ExecuteNonQuery();

                baglanti.Close();

                ogr_duzenle_adsoyad.Text = "";
                ogr_duzenle_mail.Text = "";
                ogr_duzenle_tckn.Text = "";
                ogr_duzenle_tel.Text = "";
                ogrenciekle();
                ogrenciguncelle();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(emanet_ograd2.Text) && !string.IsNullOrEmpty(emanet_ver_kitap_ad.Text))
            {
                try
                {
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO emanet (ogr_ad, kitap_ad, verilis_tarih, alma_tarih, notlar) VALUES ('" + emanet_ograd2.Text + "', '" + emanet_ver_kitap_ad.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + dateTimePicker2.Value.ToShortDateString() + "', '" + emanet_Ver_not.Text + "');";

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    baglanti.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Emaner verilirken hata: " + ex.Message);
                    baglanti.Close();
                }
                
            }
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(emanet_ograd1.Text) && !string.IsNullOrEmpty(emanet_al_kitap_ad.Text))
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE emanet SET alindi=1 WHERE ogr_ad = '" + emanet_ograd1.Text + "' AND kitap_ad = '" + emanet_al_kitap_ad.Text + "';";
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                emanet_ograd1.Text = "";
                emanet_al_kitap_ad.Text = "";
            }
        }

        private void emanet_ograd1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emanet_ograd1.Text))
            {
                string ad = emanet_ograd1.Text;

                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM emanet WHERE ogr_ad='" + ad + "';";

                baglanti.Open();

                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.HasRows)
                {
                    emanet_al_kitap_ad.Items.Clear();
                    while (oku.Read())
                    {
                        emanet_al_kitap_ad.Items.Add(oku["kitap_ad"].ToString());
                    }
                    baglanti.Close();
                }
                else
                {
                    notifyIcon1.ShowBalloonTip(1000, "Bilgi", "Bu öğrencide emanet kitap yok!",ToolTipIcon.Info);
                    baglanti.Close();
                }
            }
        }

     
    }
}
