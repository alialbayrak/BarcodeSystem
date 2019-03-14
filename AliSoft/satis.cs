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
    public partial class satis : Form
    {
        
        public satis()
        {
            InitializeComponent();
        }
        public static int idyiBulVeGetir;
        public static string adiBulVeGetir;
        private void button1_Click(object sender, EventArgs e)
        {
            musterisec musterisec = new musterisec();
            musterisec.ShowDialog();
            textMusteriID.Text = idyiBulVeGetir.ToString();
            txtMusteri_adi.Text = adiBulVeGetir;
        }
        public void textMusteri_adi_TextChanged(object sender, EventArgs e)
        {          
        }
        private void satis_Load(object sender, EventArgs e)
        {
            //giris giris = new giris();
            //giris.Close();
        }
        decimal fiyat = 0;

        private void textBarkod_No_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
            }
        }
        private DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
            if(groupBoxdegisim.Visible == false)
            {
                if (txtMusteri_adi.Text != "" && textMusteriID.Text != "")
                {
                    string odemesekli = "";
                    string kartturu = "";
                    if (radioButton1.Checked)
                    {
                        odemesekli = "kk";
                        kartturu = comboBox1.Text;
                        odemesekli = odemesekli + " " + kartturu;
                    }
                    else if (radioButton2.Checked)
                        odemesekli = "n";
                    else
                        odemesekli = "";
                    if (odemesekli != "")
                    {
                        try
                        {
                            progressBar1.Visible = true;
                            progressBar1.Value += 15;
                            baglan.Open();
                            OleDbDataAdapter idbul = new OleDbDataAdapter("Select MAX(ID) AS ID From [satış$]", baglan);
                            DataTable id = new DataTable();
                            idbul.Fill(id);
                            int ID = Convert.ToInt32(id.Rows[0]["ID"].ToString());
                            ID++;
                            progressBar1.Value += 15;
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                ID++;
                                Int64 BarkodNOO = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                                int musteriID = Convert.ToInt32(textMusteriID.Text);
                                decimal Fiyati = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                                DateTime zaman = DateTime.Now;
                                string saat = DateTime.Now.ToShortTimeString();
                                OleDbCommand komut = new OleDbCommand("INSERT INTO [satış$] (ID, BARKOD_NO, MÜŞTERİ_ID, FİYAT, ÖDEME_ŞEKLİ , TARİH) VALUES(@ID, @BarkodNOO, @musteriID, '" + Fiyati + "', @odemesekli, @zaman)", baglan);
                                komut.Parameters.AddWithValue("@ID", ID);
                                komut.Parameters.AddWithValue("@BarkodNOO", BarkodNOO);
                                komut.Parameters.AddWithValue("@musteriID", musteriID);
                                komut.Parameters.AddWithValue("@odemesekli", odemesekli);
                                komut.Parameters.AddWithValue("@zaman", GetDateWithoutMilliseconds(DateTime.Now));
                                komut.ExecuteNonQuery();
                            }
                            progressBar1.Value += 60;
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                Int64 BarkodNOO = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                                OleDbDataAdapter da = new OleDbDataAdapter("SELECT ADET FROM [normal$] WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                                DataTable dtable = new DataTable();
                                da.Fill(dtable);
                                if(dtable.Rows.Count == 1)
                                {
                                    int adet = Convert.ToInt32(dtable.Rows[0]["ADET"].ToString());
                                    adet = adet - 1;
                                    OleDbCommand komut3 = new OleDbCommand("UPDATE [normal$] SET ADET =" + adet + " WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                                    komut3.ExecuteNonQuery();
                                }
                                else if(dtable.Rows.Count == 0)
                                {
                                    OleDbDataAdapter daa = new OleDbDataAdapter("SELECT ADET FROM [indirimli$] WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                                    DataTable dttable = new DataTable();
                                    daa.Fill(dttable);
                                    int adet = Convert.ToInt32(dttable.Rows[0]["ADET"].ToString());
                                    adet = adet - 1;
                                    OleDbCommand komut3 = new OleDbCommand("UPDATE [indirimli$] SET ADET =" + adet + " WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                                    komut3.ExecuteNonQuery();
                                }
                            }
                            progressBar1.Value += 10;
                            MessageBox.Show("Başarılı");
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Kayıt edilmedi " + hata.Message);
                        }
                        finally
                        {
                            progressBar1.Visible = false;
                            progressBar1.Value = 0;
                            baglan.Close();
                        }
                        this.Hide();
                        yeniSatisform = new satis();
                        yeniSatisform.FormClosing += yeniSatisform_FormClosing;
                        yeniSatisform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ÖDEME ŞEKLİ BOŞ OLAMAZ", "ÖDEME ŞEKLİ");
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri Girilmedi", "Hata");
                }
            }
            else//değişim
            {
                string odemesekli = "";
                string kartturu = "";
                if (radioButton1.Checked)
                {
                    odemesekli = "kk";
                    kartturu = comboBox1.Text;
                    odemesekli = odemesekli + " " + kartturu;
                }
                else if (radioButton2.Checked)
                    odemesekli = "n";
                else
                    odemesekli = "";
                if (odemesekli != "")
                {
                    try
                    {
                        baglan.Open();
                        OleDbDataAdapter idbul = new OleDbDataAdapter("Select MAX(ID) AS ID From [satış$]", baglan);
                        DataTable id = new DataTable();
                        idbul.Fill(id);
                        int ID = Convert.ToInt32(id.Rows[0]["ID"].ToString());
                        ID++;
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            ID++;
                            Int64 BarkodNOO = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                            int musteriID = Convert.ToInt32(textMusteriID.Text);
                            decimal Fiyati = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                            DateTime zaman = DateTime.Now;
                            string saat = DateTime.Now.ToShortTimeString();
                            OleDbCommand komut = new OleDbCommand("INSERT INTO [satış$] (ID, BARKOD_NO, MÜŞTERİ_ID, FİYAT, ÖDEME_ŞEKLİ , TARİH) VALUES(@ID, @BarkodNOO, @musteriID, '" + Fiyati + "', @odemesekli, @zaman)", baglan);
                            komut.Parameters.AddWithValue("@ID", ID);
                            komut.Parameters.AddWithValue("@BarkodNOO", BarkodNOO);
                            komut.Parameters.AddWithValue("@musteriID", musteriID);
                            komut.Parameters.AddWithValue("@odemesekli", odemesekli);
                            komut.Parameters.AddWithValue("@zaman", GetDateWithoutMilliseconds(DateTime.Now));
                            komut.ExecuteNonQuery();
                        }
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            Int64 BarkodNOO = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                            OleDbDataAdapter da = new OleDbDataAdapter("SELECT ADET FROM [normal$] WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                            DataTable dtable = new DataTable();
                            da.Fill(dtable);
                            if (dtable.Rows.Count == 1)
                            {
                                int adet = Convert.ToInt32(dtable.Rows[0]["ADET"].ToString());
                                adet = adet - 1;
                                OleDbCommand komut3 = new OleDbCommand("UPDATE [normal$] SET ADET =" + adet + " WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                                komut3.ExecuteNonQuery();
                            }
                            else if (dtable.Rows.Count == 0)
                            {
                                OleDbDataAdapter daa = new OleDbDataAdapter("SELECT ADET FROM [indirimli$] WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                                DataTable dttable = new DataTable();
                                daa.Fill(dttable);
                                int adet = Convert.ToInt32(dttable.Rows[0]["ADET"].ToString());
                                adet = adet - 1;
                                OleDbCommand komut3 = new OleDbCommand("UPDATE [indirimli$] SET ADET =" + adet + " WHERE BARKOD_NO=" + BarkodNOO + "", baglan);
                                komut3.ExecuteNonQuery();
                            }
                        }
                        //normal işlemler bitiş
                        //eski ürünlere stok ekleme
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            Int64 barkodnumarasi = Convert.ToInt64(dataGridView2.Rows[i].Cells[2].Value);
                            OleDbCommand komutsil = new OleDbCommand("UPDATE [satış$] SET FİYAT = 0 WHERE BARKOD_NO='" + barkodnumarasi + "'", baglan);//fiyatı silme
                            komutsil.ExecuteNonQuery();

                            OleDbDataAdapter da = new OleDbDataAdapter("SELECT ADET FROM [normal$] WHERE BARKOD_NO=" + barkodnumarasi + "", baglan);
                            DataTable dtable = new DataTable();
                            da.Fill(dtable);
                            if (dtable.Rows.Count == 1)
                            {
                                int adet = Convert.ToInt32(dtable.Rows[0]["ADET"].ToString());
                                adet = adet + 1;
                                OleDbCommand komut3 = new OleDbCommand("UPDATE [normal$] SET ADET =" + adet + " WHERE BARKOD_NO=" + barkodnumarasi + "", baglan);
                                komut3.ExecuteNonQuery();
                                
                            }
                            else if (dtable.Rows.Count == 0)
                            {
                                OleDbDataAdapter daa = new OleDbDataAdapter("SELECT ADET FROM [indirimli$] WHERE BARKOD_NO=" + barkodnumarasi + "", baglan);
                                DataTable dttable = new DataTable();
                                daa.Fill(dttable);
                                int adet = Convert.ToInt32(dttable.Rows[0]["ADET"].ToString());
                                adet = adet + 1;
                                OleDbCommand komut3 = new OleDbCommand("UPDATE [indirimli$] SET ADET =" + adet + " WHERE BARKOD_NO=" + barkodnumarasi + "", baglan);
                                komut3.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Başarılı");
                        this.Hide();
                        yeniSatisform = new satis();
                        yeniSatisform.FormClosing += yeniSatisform_FormClosing;
                        yeniSatisform.ShowDialog();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Kayıt edilmedi" + hata.Message);
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ÖDEME ŞEKLİ BOŞ OLAMAZ", "ÖDEME ŞEKLİ");
                }
            }
        }
        void yeniSatisform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
        satis yeniSatisform;
        void f2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
        int i = -1;
        private void button3_Click(object sender, EventArgs e)
        {
            string txtboxici = textBarkod_No.Text;
            if (txtboxici != "")
            {
                OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                if (txtboxici.Length == 13)
                {
                    try
                    {
                        textBarkod_No.ReadOnly = true;
                        baglan.Open();
                        Int64 barkodno = 0;
                        barkodno = Convert.ToInt64(textBarkod_No.Text.Substring(0, 12));
                        OleDbDataAdapter komut = new OleDbDataAdapter("Select BARKOD_NO, MODEL ,FİYAT from [normal$] where BARKOD_NO=" + barkodno + "", baglan);
                        DataTable ttable = new DataTable();
                        komut.Fill(ttable);
                        if(ttable.Rows.Count > 0)
                        {
                            dataGridView1.Rows.Add();
                            i++;
                            dataGridView1.Rows[i].Cells[0].Value = ttable.Rows[0]["BARKOD_NO"].ToString();
                            dataGridView1.Rows[i].Cells[1].Value = ttable.Rows[0]["MODEL"].ToString();
                            dataGridView1.Rows[i].Cells[2].Value = ttable.Rows[0]["FİYAT"].ToString();
                            dataGridView1.Rows[i].Cells[3].Value = 1;
                            fiyat = fiyat + Convert.ToDecimal(ttable.Rows[0]["FİYAT"].ToString());
                            lblFiyat.Text = Convert.ToString(fiyat);
                            int okutuldanurun = dataGridView1.Rows.Count - 1;
                            labelAdetokutuldu.Text = okutuldanurun + " ADET ÜRÜN OKUTULDU";
                        }
                        else if (ttable.Rows.Count == 0)
                        {
                            OleDbDataAdapter komutt = new OleDbDataAdapter("Select BARKOD_NO, MODEL , İNDİRİMLİ_FİYAT from [indirimli$] where BARKOD_NO=" + barkodno + "", baglan);
                            DataTable tttable = new DataTable();
                            komutt.Fill(tttable);
                            if (tttable.Rows.Count > 0)
                            {
                                dataGridView1.Rows.Add();
                                i++;
                                dataGridView1.Rows[i].Cells[0].Value = tttable.Rows[0]["BARKOD_NO"].ToString();
                                dataGridView1.Rows[i].Cells[1].Value = tttable.Rows[0]["MODEL"].ToString();
                                dataGridView1.Rows[i].Cells[2].Value = tttable.Rows[0]["İNDİRİMLİ_FİYAT"].ToString();
                                dataGridView1.Rows[i].Cells[3].Value = 1;
                                fiyat = fiyat + Convert.ToDecimal(tttable.Rows[0]["İNDİRİMLİ_FİYAT"].ToString());
                                lblFiyat.Text = Convert.ToString(fiyat);
                                int okutuldanurun = dataGridView1.Rows.Count - 1;
                                labelAdetokutuldu.Text = okutuldanurun + " ADET ÜRÜN OKUTULDU";
                            }
                            else
                            {
                                MessageBox.Show("Ürün Bulunamadı", "Bulunamadı");
                            } 
                        }          
                        else
                        {
                            MessageBox.Show("Ürün Bulunamadı", "Bulunamadı");
                        }
                        textBarkod_No.Clear();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                    finally
                    {
                        textBarkod_No.ReadOnly = false;
                        baglan.Close();
                    }
                }
                else if (txtboxici.Length == 12)
                {
                    try
                    {
                        Int64 barkodno = 0;
                        barkodno = Convert.ToInt64(textBarkod_No.Text.Substring(0, 11));
                        baglan.Open();
                        OleDbDataAdapter komut = new OleDbDataAdapter("Select BARKOD_NO, MODEL ,FİYAT from [normal$] where BARKOD_NO=" + barkodno + "", baglan);
                        DataTable ttable = new DataTable();
                        komut.Fill(ttable);
                        baglan.Close();
                        if (ttable.Rows.Count > 0)
                        {
                            dataGridView1.Rows.Add();
                            i++;
                            dataGridView1.Rows[i].Cells[0].Value = ttable.Rows[0]["BARKOD_NO"].ToString();
                            dataGridView1.Rows[i].Cells[1].Value = ttable.Rows[0]["MODEL"].ToString();
                            dataGridView1.Rows[i].Cells[2].Value = ttable.Rows[0]["FİYAT"].ToString();
                            dataGridView1.Rows[i].Cells[3].Value = 1;
                            fiyat = fiyat + Convert.ToDecimal(ttable.Rows[0]["FİYAT"].ToString());
                            lblFiyat.Text = Convert.ToString(fiyat);
                            int okutuldanurun = dataGridView1.Rows.Count - 1;
                            labelAdetokutuldu.Text = okutuldanurun + " ADET ÜRÜN OKUTULDU";
                        }
                        else
                        {
                            MessageBox.Show("Ürün Bulunamadı", "Bulunamadı");
                        }
                        textBarkod_No.Clear();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                }
                else
                {
                    MessageBox.Show("YANLIŞ BARKOD KODU", "HATA");
                }
            }
            else
            {
                MessageBox.Show("KUTU BOŞ OLAMAZ", "HATA");
            }
        
        }

        private void textBarkod_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            decimal fiyat, indirim, toplamfiyat = 0;
            if(checkBox1.Checked == true)
            {  
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    indirim = (fiyat * 10) / 100;
                    fiyat = fiyat - indirim;
                    dataGridView1.Rows[i].Cells[2].Value = fiyat;
                    toplamfiyat = toplamfiyat + fiyat;
                    lblFiyat.Text = toplamfiyat.ToString();
                }
            }
            else if (checkBox1.Checked == false)
            {
                DataTable dtToplamFiyat = new DataTable();
                dtToplamFiyat.Columns.Add("FİYAT", typeof(decimal));
                Int64 urunBarkodNo;
                decimal para, sonpara = 0;
                OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                try
                {
                    baglan.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        urunBarkodNo = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                        OleDbDataAdapter komut = new OleDbDataAdapter("Select FİYAT from [normal$] where BARKOD_NO=" + urunBarkodNo + "", baglan);
                        DataTable dt = new DataTable();
                        komut.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.Rows[i].Cells[2].Value = dt.Rows[0]["FİYAT"].ToString();
                            dtToplamFiyat.Rows.Add(dt.Rows[0]["FİYAT"].ToString());
                            baglan.Close();
                        }
                        else if (dt.Rows.Count == 0)
                        {
                            OleDbDataAdapter komutt = new OleDbDataAdapter("Select İNDİRİMLİ_FİYAT from [indirimli$] where BARKOD_NO=" + urunBarkodNo + "", baglan);
                            DataTable dtt = new DataTable();
                            komutt.Fill(dtt);
                            dataGridView1.Rows[i].Cells[2].Value = dtt.Rows[0]["İNDİRİMLİ_FİYAT"].ToString();
                            dtToplamFiyat.Rows.Add(dtt.Rows[0]["İNDİRİMLİ_FİYAT"].ToString());
                            baglan.Close();
                        }
                        para = Convert.ToDecimal(dtToplamFiyat.Rows[i]["FİYAT"].ToString());
                        para = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                        sonpara = sonpara + para;
                        lblFiyat.Text = sonpara.ToString();
                    }
                }
                catch(Exception hata)
                {
                    MessageBox.Show("Fiyatlar çevirilemedi " + hata.Message);
                }
                finally
                {
                    baglan.Close();
                }
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewRow drow = new DataGridViewRow();
            decimal yenifiyat = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                yenifiyat = yenifiyat + Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
            }
            lblFiyat.Text = yenifiyat.ToString();
        }
        private void txtAlinanUcret_TextChanged(object sender, EventArgs e)
        {
            if(txtAlinanUcret.Text != "")
            {
                decimal paraustu;
                paraustu = Convert.ToDecimal(txtAlinanUcret.Text) - Convert.ToDecimal(lblFiyat.Text);
                labelParaUstu.Text = paraustu.ToString();
                labelParaUstu.Visible = true;
            }
        }

        private void txtAlinanUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < txtAlinanUcret.Text.Length; i++)
            {
                if (txtAlinanUcret.Text.Substring(i,1) == ",")
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                }
                else
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ','; 
                }
            }    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if(dataGridView1.RowCount > 1)
                {
                    int uzunluk = dataGridView1.RowCount;
                    uzunluk--;
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    if (selectedIndex < uzunluk)
                    {
                        DialogResult secenek = MessageBox.Show("Ürünü silmek istiyor musunuz?", "Ürünü Sil", MessageBoxButtons.YesNo);
                        if (secenek == DialogResult.Yes)
                        {
                            fiyat = fiyat - Convert.ToDecimal(dataGridView1.Rows[selectedIndex].Cells[2].Value);
                            dataGridView1.Rows.RemoveAt(selectedIndex);
                            dataGridView1.Refresh();
                            i--;
                            string adetsil = labelAdetokutuldu.Text;
                            adetsil = adetsil.Substring(0, 1);
                            int adetsill = Convert.ToInt32(adetsil);
                            adetsill--;
                            adetsil = adetsill.ToString();
                            labelAdetokutuldu.Text = adetsil+" "+"ADET ÜRÜN OKUTULDU";


                        }

                    }
                }
                
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            detay detay = new detay();
            detay.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal fiyat, indirim, toplamfiyat = 0;
            int yuzde = Convert.ToInt16(textBox1.Text);
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    indirim = (fiyat * yuzde) / 100;
                    fiyat = fiyat - indirim;
                    dataGridView1.Rows[i].Cells[2].Value = fiyat;
                    toplamfiyat = toplamfiyat + fiyat;
                    lblFiyat.Text = toplamfiyat.ToString();
                }
                button5.Visible = false;
                button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dtToplamFiyat = new DataTable();
            dtToplamFiyat.Columns.Add("FİYAT", typeof(decimal));
            Int64 urunBarkodNo;
            decimal para, sonpara = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                urunBarkodNo = Convert.ToInt64(dataGridView1.Rows[i].Cells[0].Value);
                OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabani.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                OleDbDataAdapter komut = new OleDbDataAdapter("Select FİYAT from [normal$] where BARKOD_NO=" + urunBarkodNo + "", baglan);
                DataTable dt = new DataTable();
                komut.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[0]["FİYAT"].ToString();
                    dtToplamFiyat.Rows.Add(dt.Rows[0]["FİYAT"].ToString());
                    baglan.Close();
                }
                else if (dt.Rows.Count == 0)
                {
                    OleDbDataAdapter komutt = new OleDbDataAdapter("Select İNDİRİMLİ_FİYAT from [indirimli$] where BARKOD_NO=" + urunBarkodNo + "", baglan);
                    DataTable dtt = new DataTable();
                    komutt.Fill(dtt);
                    dataGridView1.Rows[i].Cells[2].Value = dtt.Rows[0]["İNDİRİMLİ_FİYAT"].ToString();
                    dtToplamFiyat.Rows.Add(dtt.Rows[0]["İNDİRİMLİ_FİYAT"].ToString());
                    baglan.Close();
                }

                para = Convert.ToDecimal(dtToplamFiyat.Rows[i]["FİYAT"].ToString());
                sonpara = sonpara + para;
                lblFiyat.Text = sonpara.ToString();
            }
            button5.Visible = true;
            button6.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (textBox1.TextLength == 3)
            {
                e.Handled = true;
            }
        }

        private void txtMusteri_adi_TextChanged(object sender, EventArgs e)
        {
            if(txtMusteri_adi.Text.Length > 0)
            {
                buttonDegisim.Visible = true;
            }
        }

        private void buttonUrunEklebtn_Click(object sender, EventArgs e)
        {
            urunEkle formUrunEkle = new urunEkle();
            formUrunEkle.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Visible = true;
                labelKKturu.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
                labelKKturu.Visible = false;
            }
        }

        private void buttonDegisim_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 1)
            {
                int musterikodu = Convert.ToInt32(textMusteriID.Text);
                string musteriadi = txtMusteri_adi.Text;
                degisim degisim = new degisim();
                degisim.Show();
            }
            else
            {
                MessageBox.Show("İlk önce satın alınacak ürünleri ekleyin daha sonra değişecek ürünleri seçin","HATA");
            }
            
        }
    }
}
