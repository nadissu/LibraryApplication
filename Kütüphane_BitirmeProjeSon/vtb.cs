using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Kütüphane_BitirmeProjeSon
{
    class vtb
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\veritabani.mdb");

        public bool yaz(string tablo, string degerler, string sutunlar = "")
        {
            try
            {
                baglanti.Open();
                if(sutunlar == "")
                {
                    OleDbCommand yazdir = new OleDbCommand("INSERT INTO " + tablo + " VALUES(" + degerler + ");", baglanti);
                    yazdir.ExecuteNonQuery();
                    baglanti.Close();
                    return true;
                }
                else
                {
                    OleDbCommand yazdir = new OleDbCommand("INSERT INTO " + tablo + "(" + sutunlar + ") VALUES(" + degerler + ");",baglanti);
                    yazdir.ExecuteNonQuery();
                    baglanti.Close();
                    return true;
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("VeriTabanı bağlantısı sırasında hata!" + System.Environment.NewLine + ex.Message);
                baglanti.Close();
                return false;
            }
        }

        public OleDbDataReader oku(string sutunlar, string tablo, string where = "")
        {
            OleDbDataReader rdr;
            OleDbDataReader rdr2;

            rdr2 = new OleDbCommand("", baglanti).ExecuteReader();
            try
            {
                baglanti.Open();
                if (where == "")
                {
                    OleDbCommand oku = new OleDbCommand("SELECT " + sutunlar + " FROM " + tablo + ";");

                    rdr = oku.ExecuteReader();
                    baglanti.Close();
                    return rdr;
                }
                else
                {
                    OleDbCommand oku = new OleDbCommand("SELECT " + sutunlar + " FROM " + tablo + " WHERE "+ where +";");
                    rdr = oku.ExecuteReader();
                    baglanti.Close();
                    return rdr;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("VeriTabanı bağlantısı sırasında hata!" + System.Environment.NewLine + ex.Message);
                baglanti.Close();
                return rdr2;
            }

        }

        public bool guncelle(string tablo, string duzenleme, string where)
        {
            baglanti.Open();
            try
            {
                OleDbCommand komut = new OleDbCommand("UPDATE "+ tablo + " SET "+ duzenleme + " WHERE " + where+";",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("VeriTabanı bağlantısı sırasında hata!" + System.Environment.NewLine + ex.Message);
                baglanti.Close();
                return false;
            }
            
        }
    }
}
