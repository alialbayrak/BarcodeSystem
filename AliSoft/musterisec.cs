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
    public partial class musterisec : Form
    {
        public musterisec()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
        void musterigetir()
        {
            try
            {
                listView1.Items.Clear();
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }

                OleDbCommand komutVerileriGetir = new OleDbCommand("Select * from [müşteri$] ORDER BY ID DESC", baglan);
                OleDbDataReader bilgileriOku = komutVerileriGetir.ExecuteReader();

                while (bilgileriOku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = bilgileriOku["ID"].ToString();
                    ekle.SubItems.Add(bilgileriOku["AD_SOYAD"].ToString());
                    ekle.SubItems.Add(bilgileriOku["TELEFON"].ToString());
                    ekle.SubItems.Add(bilgileriOku["E_POSTA"].ToString());

                    listView1.Items.Add(ekle);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            finally
            {
                baglan.Close();
            }
        }
        private void musterisec_Load(object sender, EventArgs e)
        {
            musterigetir();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            satis satis = new satis();
            satis.idyiBulVeGetir = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            satis.adiBulVeGetir = listView1.SelectedItems[0].SubItems[1].Text;
            this.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand idsec = new OleDbCommand("Select MAX(ID) from [müşteri$]", baglan);
                OleDbDataAdapter idbul = new OleDbDataAdapter(idsec);
                DataTable id = new DataTable();
                idbul.Fill(id);
                int ID = Convert.ToInt32(id.Rows[0]["Expr1000"].ToString());
                ID++;
                OleDbDataAdapter kontrolet = new OleDbDataAdapter("SELECT * FROM [müşteri$] WHERE TELEFON = '" + texttelefon.Text + "'", baglan);
                DataTable ktable = new DataTable();
                kontrolet.Fill(ktable);
                if (ktable.Rows.Count > 0)
                {
                    string tTelefonNo = ktable.Rows[0]["TELEFON"].ToString();
                    string bTelefonNo = texttelefon.Text;
                    satis.idyiBulVeGetir = Convert.ToInt32(ktable.Rows[0]["ID"].ToString());
                    satis.adiBulVeGetir = ktable.Rows[0]["AD_SOYAD"].ToString();
                    this.Close();
                }
                else
                {
                    OleDbCommand komut = new OleDbCommand("INSERT INTO [müşteri$] (ID ,AD_SOYAD, TELEFON, E_POSTA) VALUES(" + ID + ",'" + textad_soyad.Text + "','" + texttelefon.Text + "','" + texte_posta.Text + "')", baglan);
                    komut.ExecuteNonQuery();
                }
                listView1.Items.Clear();
                musterigetir();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string isim = textBoxArama.Text;
            if(isim != "")
            {
                listView1.Items.Clear();
                OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                baglan.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select ID, AD_SOYAD, TELEFON, E_POSTA FROM [müşteri$] Where AD_SOYAD LIKE '%" + isim + "%' ", baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglan.Close();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] satir = { dt.Rows[i]["ID"].ToString(), dt.Rows[i]["AD_SOYAD"].ToString(), dt.Rows[i]["TELEFON"].ToString(), dt.Rows[i]["E_POSTA"].ToString() };
                    var ekle = new ListViewItem(satir);
                    listView1.Items.Add(ekle);
                }
            }
            else
            {
                musterigetir();
            }
        }
    }
}
