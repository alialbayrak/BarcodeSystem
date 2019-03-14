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

namespace AliSoft
{
    public partial class detay : Form
    {
        public detay()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
        void GunlukCiroGetir()
        {
            baglan.Open();
            DateTime tarih = dateTimePicker1.Value;
            DateTime buguntarih = tarih.AddDays(1);
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [satış$] WHERE TARİH >= @tarih AND TARİH < @tarihbugun", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih", tarih);
            da.SelectCommand.Parameters.AddWithValue("@tarihbugun", buguntarih);
            DataTable dt = new DataTable();
            da.Fill(dt);
            decimal toplamfiyatN = 0;
            decimal toplamfiyatKK = 0;
            int adet = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string oS = dt.Rows[i]["ÖDEME_ŞEKLİ"].ToString();
                if (oS.Substring(0,1) == "k")
                {
                    toplamfiyatKK = toplamfiyatKK + Convert.ToDecimal(dt.Rows[i]["FİYAT"].ToString());
                    adet++;
                }
                else if (dt.Rows[i]["ÖDEME_ŞEKLİ"].ToString() == "n")
                {
                    toplamfiyatN = toplamfiyatN + Convert.ToDecimal(dt.Rows[i]["FİYAT"].ToString());
                    adet++;
                }
            }
            decimal toplamfiyat = toplamfiyatKK + toplamfiyatN;
            labelNakit.Text = toplamfiyatN.ToString() + " ₺";
            labelKrediKarti.Text = toplamfiyatKK.ToString() + " ₺";
            labelToplam.Text = toplamfiyat.ToString() + " ₺";
            labelAdet.Text = "TOPLAM " + adet.ToString() + " ADET ÜRÜN SATILDI";
            baglan.Close();

        }
        void GunlukEnCokSatanUrunler()
        {
            dataGridView1.Rows.Clear();
            baglan.Open();
            DateTime tarih = dateTimePicker1.Value;
            DateTime buguntarih = tarih.AddDays(1);
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT TOP 20 BARKOD_NO, COUNT(BARKOD_NO) AS ADET FROM [satış$] WHERE TARİH >= @tarih AND TARİH < @tarihbugun GROUP BY BARKOD_NO ORDER BY COUNT(BARKOD_NO) DESC", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih", tarih);
            da.SelectCommand.Parameters.AddWithValue("@tarihbugun", buguntarih);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string model="";
            string fiyat="";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Int64 barkodno = Convert.ToInt64(dt.Rows[i]["BARKOD_NO"].ToString());
                DataTable mf = new DataTable();
                int Adet = Convert.ToInt32(dt.Rows[i]["ADET"].ToString());
                OleDbDataAdapter bak = new OleDbDataAdapter("SELECT MODEL,İNDİRİMLİ_FİYAT FROM [indirimli$] WHERE BARKOD_NO =" + barkodno + "", baglan);
                bak.Fill(mf);
                if(mf.Rows.Count == 1)
                {
                    model = mf.Rows[0]["MODEL"].ToString();
                    fiyat = mf.Rows[0]["İNDİRİMLİ_FİYAT"].ToString();
                }
                else if (mf.Rows.Count == 0)
                {
                    OleDbDataAdapter bak2 = new OleDbDataAdapter("SELECT MODEL,FİYAT FROM [normal$] WHERE BARKOD_NO =" + barkodno + "", baglan);
                    bak2.Fill(mf);
                    model = mf.Rows[0]["MODEL"].ToString();
                    fiyat = mf.Rows[0]["FİYAT"].ToString();
                }
                
                dataGridView1.Rows.Add(barkodno,model,fiyat,Adet);

            }
            baglan.Close();
            
        }
        void TarihliEnCokSatanUrunler()
        {
            baglan.Open();
            DateTime baslangic = dateTimePickerBaslangic.Value;
            DateTime bitis = dateTimePickerBitis.Value.AddDays(1);
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT TOP 20 BARKOD_NO, COUNT(BARKOD_NO) AS ADET FROM [satış$] WHERE TARİH >= @baslangic AND TARİH < @bitis GROUP BY BARKOD_NO ORDER BY COUNT(BARKOD_NO) DESC", baglan);
            da.SelectCommand.Parameters.AddWithValue("@baslangic",baslangic);
            da.SelectCommand.Parameters.AddWithValue("@bitis", bitis);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Int64 barkodno = Convert.ToInt64(dt.Rows[i]["BARKOD_NO"].ToString());
                if (barkodno < 869999999999 && barkodno > 869900000000)
                {
                    OleDbDataAdapter bak = new OleDbDataAdapter("SELECT MODEL,İNDİRİMLİ_FİYAT FROM [indirimli$] WHERE BARKOD_NO =" + barkodno + "", baglan);
                    DataTable mf = new DataTable();
                    bak.Fill(mf);
                    int Adet = Convert.ToInt32(dt.Rows[i]["ADET"].ToString());
                    string model = mf.Rows[0]["MODEL"].ToString();
                    string fiyat = mf.Rows[0]["İNDİRİMLİ_FİYAT"].ToString();
                    dataGridView2.Rows.Add(barkodno, model, fiyat, Adet);

                }
                else
                {
                    OleDbDataAdapter bak = new OleDbDataAdapter("SELECT MODEL,FİYAT FROM [normal$] WHERE BARKOD_NO =" + barkodno + "", baglan);
                    DataTable mf = new DataTable();
                    bak.Fill(mf);
                    int Adet = Convert.ToInt32(dt.Rows[i]["ADET"].ToString());
                    string model = mf.Rows[0]["MODEL"].ToString();
                    string fiyat = mf.Rows[0]["FİYAT"].ToString();
                    dataGridView2.Rows.Add(barkodno, model, fiyat, Adet);
                }
                

            }
            baglan.Close();

        }
        private void detay_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePickerBaslangic.Value = DateTime.Today;
            dateTimePickerBitis.Value = DateTime.Today;
            dataGridView1.Rows.Clear();
            GunlukCiroGetir();
            GunlukEnCokSatanUrunler();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dateTimePickerBaslangic.Value;
            DateTime bitis = dateTimePickerBitis.Value.AddDays(1);
            baglan.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [satış$] WHERE TARİH >= @baslangic AND TARİH < @bitis ", baglan);
            da.SelectCommand.Parameters.AddWithValue("@baslangic", baslangic);
            da.SelectCommand.Parameters.AddWithValue("@bitis", bitis);
            DataTable dt = new DataTable();
            da.Fill(dt);
            decimal TtoplamfiyatN = 0;
            decimal TtoplamfiyatKK = 0;
            int adet = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string oS = dt.Rows[i]["ÖDEME_ŞEKLİ"].ToString();
                if (oS.Substring(0,1) == "k")
                {
                    TtoplamfiyatKK = TtoplamfiyatKK + Convert.ToDecimal(dt.Rows[i]["FİYAT"].ToString());
                    adet++;
                }
                else if (dt.Rows[i]["ÖDEME_ŞEKLİ"].ToString() == "n")
                {
                    TtoplamfiyatN = TtoplamfiyatN + Convert.ToDecimal(dt.Rows[i]["FİYAT"].ToString());
                    adet++;
                }
            }
            decimal toplamfiyat = TtoplamfiyatKK + TtoplamfiyatN;
            labelTnakit.Text = TtoplamfiyatN.ToString() + " ₺";
            labelTkk.Text = TtoplamfiyatKK.ToString() + " ₺";
            labelTtoplam.Text = toplamfiyat.ToString() + " ₺";
            labelTadet.Text = "TOPLAM " + adet.ToString() + " ADET ÜRÜN SATILDI";
            dataGridView2.Rows.Clear();
            baglan.Close();
            TarihliEnCokSatanUrunler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            GunlukCiroGetir();
            GunlukEnCokSatanUrunler();
        }
    }
}
