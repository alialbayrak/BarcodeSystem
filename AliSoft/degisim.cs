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
    public partial class degisim : Form
    {
        public degisim()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
        private void degisim_Load(object sender, EventArgs e)
        {
            textBoxMusteriAdi.Text = satis.adiBulVeGetir;
            textBoxMusteriKodu.Text = satis.idyiBulVeGetir.ToString();
            baglan.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select ID, BARKOD_NO, MÜŞTERİ_ID, FİYAT, ÖDEME_ŞEKLİ, TARİH from [satış$] Where MÜŞTERİ_ID = @Musteriid", baglan);
            da.SelectCommand.Parameters.AddWithValue("@Musteriid", textBoxMusteriKodu.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for(int i = 0;i < dt.Rows.Count;i++)
            {
                OleDbDataAdapter daa = new OleDbDataAdapter("Select MODEL from [normal$] Where BARKOD_NO = @BarkodNo", baglan);
                daa.SelectCommand.Parameters.AddWithValue("@BarkodNo", dt.Rows[i]["BARKOD_NO"]);
                DataTable model = new DataTable();
                daa.Fill(model);
                if(model.Rows.Count == 1)
                {
                    dataGridView1.Rows.Add(dt.Rows[i]["ID"], dt.Rows[i]["MÜŞTERİ_ID"], dt.Rows[i]["BARKOD_NO"], model.Rows[0]["MODEL"].ToString(), dt.Rows[i]["FİYAT"].ToString(), dt.Rows[i]["ÖDEME_ŞEKLİ"].ToString(), dt.Rows[i]["TARİH"]);

                }
                else if (model.Rows.Count == 0)
                {
                    OleDbDataAdapter daaa = new OleDbDataAdapter("Select MODEL from [indirimli$] Where BARKOD_NO = @BarkodNo", baglan);
                    daaa.SelectCommand.Parameters.AddWithValue("@BarkodNo", dt.Rows[i]["BARKOD_NO"]);
                    DataTable modell = new DataTable();
                    daaa.Fill(modell);
                    dataGridView1.Rows.Add(dt.Rows[i]["ID"], dt.Rows[i]["MÜŞTERİ_ID"], dt.Rows[i]["BARKOD_NO"], modell.Rows[0]["MODEL"].ToString(), dt.Rows[i]["FİYAT"].ToString(), dt.Rows[i]["ÖDEME_ŞEKLİ"].ToString(), dt.Rows[i]["TARİH"]);

                }
            }
            baglan.Close();
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            int musterikodu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            string barkod = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string urunAciklamasi = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            decimal fiyat = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            string odemeSekli = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DateTime tarih = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[6].Value);
            dataGridView2.Rows.Add(id, musterikodu, barkod, urunAciklamasi, fiyat, odemeSekli, tarih);
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satis satis = (satis)Application.OpenForms["satis"];
            decimal tfiyat = 0;
            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                int id = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                int musterikodu = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                string barkod = dataGridView2.Rows[i].Cells[2].Value.ToString();
                string urunAciklamasi = dataGridView2.Rows[i].Cells[3].Value.ToString();
                decimal fiyat = Convert.ToDecimal(dataGridView2.Rows[i].Cells[4].Value.ToString());
                tfiyat = tfiyat + fiyat;
                string odemeSekli = dataGridView2.Rows[i].Cells[5].Value.ToString();
                DateTime tarih = Convert.ToDateTime(dataGridView2.Rows[i].Cells[6].Value);
                satis.groupBoxdegisim.Visible = true;
                satis.dataGridView2.Rows.Add(id, musterikodu, barkod, urunAciklamasi, fiyat, odemeSekli, tarih);
            }
            satis.degisecekurunfiyati.Text = tfiyat.ToString();
            decimal odenecektutar = Convert.ToDecimal(satis.lblFiyat.Text) - tfiyat;
            satis.odenecektutar.Text = odenecektutar.ToString();
            this.Close();
        }
    }
}
