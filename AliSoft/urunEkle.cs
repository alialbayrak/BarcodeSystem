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
    public partial class urunEkle : Form
    {
        public urunEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
        void Temizle()
        {
            textBoxUrunNo.Clear();
            textBoxUrunAciklamasi.Clear();
            textBoxSatisFiyati.Clear();
            textBoxGelisFiyati.Clear();
            textBoxindirimliFiyat.Clear();
            textBoxAdet.Clear();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            try
            {
                if (checkBox1.Checked == true)
                {
                    if(textBoxBarkodNum.Text == "")
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("SELECT MAX(BARKOD_NO) FROM [indirimli$]", baglan);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Int64 barkodno = Convert.ToInt64(dt.Rows[0]["BARKOD_NO"].ToString());
                        barkodno++;
                        OleDbCommand komut = new OleDbCommand("INSERT INTO [indirimli$] VALUES(" + barkodno + ",'" + textBoxUrunNo.Text + "','" + textBoxUrunAciklamasi.Text + "','" + textBoxSatisFiyati.Text + "','" + textBoxindirimliFiyat.Text + "'," + textBoxAdet.Text + ",'" + textBoxGelisFiyati.Text + "')", baglan);
                        komut.ExecuteNonQuery();
                    }
                    else
                    {
                        OleDbCommand komut = new OleDbCommand("INSERT INTO [indirimli$] VALUES(" + textBoxBarkodNum.Text + ",'" + textBoxUrunNo.Text + "','" + textBoxUrunAciklamasi.Text + "','" + textBoxSatisFiyati.Text + "','" + textBoxindirimliFiyat.Text + "'," + textBoxAdet.Text + ",'" + textBoxGelisFiyati.Text + "')", baglan);
                        komut.ExecuteNonQuery();
                    }
                    
                }
                else
                {
                    if (textBoxBarkodNum.Text == "")
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("SELECT BARKOD_NO FROM [normal$]", baglan);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        int uzunluk = dt.Rows.Count - 1;
                        Int64 barkodno = Convert.ToInt64(dt.Rows[uzunluk]["BARKOD_NO"].ToString());
                        barkodno++;
                        OleDbCommand komut = new OleDbCommand("INSERT INTO [normal$] VALUES(" + barkodno + ",'" + textBoxUrunNo.Text + "','" + textBoxUrunAciklamasi.Text + "','" + textBoxSatisFiyati.Text + "'," + textBoxAdet.Text + ",'" + textBoxGelisFiyati.Text + "')", baglan);
                        komut.ExecuteNonQuery();
                    }
                    else
                    {

                    }
                    
                }
            baglan.Close();
            MessageBox.Show("Ürün Başarıyla Eklendi!", "Başarılı");
            Temizle();
            }
            catch
            {
                MessageBox.Show("Ürün Eklenemedi","HATA");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true){
                textBoxindirimliFiyat.Enabled = true;
                label6.Enabled = true;
            }
            else
            {
                textBoxindirimliFiyat.Enabled = false;
                label6.Enabled = false;
            }
        }
    }
}
