using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace otobus
{  
    public partial class frmSefer : Form
    {
        public frmSefer()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        cGenel cGen = new cGenel();
        cCalisan cCal = new cCalisan();
        cPozisyon p = new cPozisyon();
        cGenel gnl = new cGenel();

        private void frmSefer_Load(object sender, EventArgs e)
        {
            tasarim();
            saat();
        }
        void saat()
        {
            for (int i = 0; i < 60; i++)
            {
                    if (i > 0 && i <= 23)
                    {
                        if (i < 10)
                            cbSaat.Items.Add("0" + Convert.ToString(i));
                        else
                            cbSaat.Items.Add(Convert.ToString(i));
                    }
                    if (i < 10)
                        cbDakika.Items.Add("0" + Convert.ToString(i));
                    else
                        cbDakika.Items.Add(Convert.ToString(i));
            }
            cbDakika.SelectedIndex = 0;
            cbSaat.SelectedIndex = 0;
        }
        void tasarim()
        {
            cSt.frm(this);
            tasarimIslem();
        }
        void tasarimIslem()
        {
            cSt.frm(this);
            if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSefer_Detay))
            {
                btn.Visible = false;
                lblMesaj.Text = "Detaylı Sefer Bilgileri";
                lblMesaj.Visible = true;
                Seferbilgiaktar();
                dgvCalisanlar.Visible = false;
            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSefer_SeferSil))
            {
                btn.Text = "Sil";
                lblMesaj.Text = "Seferi Sil...";
                lblMesaj.Visible = true;
                Seferbilgiaktar();
            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSefer_FrmSeferEkle))
            {
                btn.Text = "Kaydet";
                lblMesaj.Text = "Yeni Sefer Kaydı...";
                lblMesaj.Visible = true;
                cSefer s = new cSefer();
                txtSeferNo.Text = s.SonIDBul().ToString();

            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSefer_SeferBilgileriDegistir))
            {
                btn.Text = "Güncelle";
                lblMesaj.Text = "Sefer Bilgilerini Güncelle...";
                lblMesaj.Visible = true;
                Seferbilgiaktar();
            }
        }    


        private void btnGuzergahSec_Click(object sender, EventArgs e)
        {
                    frmGuzergahListe frm = new frmGuzergahListe();
                    cSefer.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_SefereGuzergahEkle);
                    frm.ShowDialog();
                    txtGuzergahID.Text = Convert.ToString(cGuzergah.tutGuzergahID);
                    txtGuzergah.Text = cGuzergah.tutGuzergahAd;
        }
        private void btn_Click(object sender, EventArgs e)
        {            
            if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSefer_SeferSil))
            {
                if (MessageBox.Show("Silmek istiyormusunz?", "SİLİNSİNMİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cSefer c = new cSefer();
                    bool sonuc = c.SeferSil(Convert.ToInt32(txtSeferNo.Text));
                    if(sonuc)
                    {
                        sonuc = c.SeferCalisanSil(Convert.ToInt32(txtSeferNo.Text));
                        MessageBox.Show("Sefer Silindi");
                    }
                    else
                    {
                        MessageBox.Show("İşlem Gerçekleşmedi");
                    }
                }
            }
            else if (btn.Text=="Kaydet")
            {
                bool sonuc = false;
                if (txtGuzergahID.Text != "" & txtAracID.Text !="" & lvCalisanlar.Items.Count !=0)
                {
                    cSefer c = new cSefer();
                    c.GuzergahID = Convert.ToInt32(txtGuzergahID.Text);
                    c.KalkisTarihi = Convert.ToDateTime(txtTarih.Text);
                    c.OtobusId = Convert.ToInt32(txtAracID.Text);
                    sonuc = c.SeferEkle(c);
                    if (sonuc)
                    {
                        cSefer s = new cSefer();
                        s.SeferId = Convert.ToInt32(txtSeferNo.Text);
                        for (int i = 0; i < lvCalisanlar.Items.Count; i++)
                        {
                            s.CalisanId = Convert.ToInt32(lvCalisanlar.Items[i].SubItems[0].Text);
                            sonuc = s.SeferCalisanIDEkle(s.SeferId, s.CalisanId);
                            if (!sonuc) break;
                 
                        }
                        MessageBox.Show("Sefer Başarıyla Kaydedildi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sefer Kaydedilemedi!!");
                        temizle();
                    }
                }
                else
                {
                    MessageBox.Show("boş alan bırakmayınız");
                    temizle();
                }
            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSefer_SeferBilgileriDegistir))
            {
                bool sonuc = false;
                cSefer c = new cSefer();
                c.SeferId = Convert.ToInt32(txtSeferNo.Text);
                c.KalkisTarihi = Convert.ToDateTime(txtTarih.Text);
                c.OtobusId = Convert.ToInt32(txtAracID.Text);
                c.GuzergahID = Convert.ToInt32(txtGuzergahID.Text);
                sonuc = c.SeferGuncelle(c);
                if (sonuc)
                {
                    MessageBox.Show("Sefer Güncellendi");
                    temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız!!");
                }

            }         
        }
        void Seferbilgiaktar()
        {
            txtSeferNo.Text = Convert.ToString(frmSeferListe.AseferNumarasi);
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select sefer.*,plaka,seferCalisanID,guzergah.ad as guzergah,calisan.calisanID as ID,calisan.ad as ad,calisan.soyad as soyad,calisanPozisyon.ad as pozisyon from sefer inner join otobus on otobus.otobusID=sefer.otobusID inner join guzergah on guzergah.guzergahID=sefer.guzergahID inner join seferCalisan on seferCalisan.seferID=sefer.seferID inner join calisan on calisan.calisanID=seferCalisan.calisanID inner join calisanPozisyon on calisanPozisyon.calisanPozisyonID=calisan.calisanPozisyonID where sefer.seferID=@seferID", conn);
            comm.Parameters.AddWithValue("@seferID", txtSeferNo.Text);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {                
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    txtGuzergahID.Text = dr["guzergahID"].ToString();
                    txtGuzergah.Text = dr["guzergah"].ToString();
                    txtTarih.Text = dr["kalkisTarihi"].ToString();
                    dtpBaslangıcTarih.Text = txtTarih.Text = dr["kalkisTarihi"].ToString();
                    cbSaat.Items.Add(Convert.ToDateTime(dr["kalkisTarihi"]).Hour);
                    cbDakika.Items.Add(Convert.ToDateTime(dr["kalkisTarihi"]).Minute);
                    txtTarih.Text = Convert.ToDateTime(dr["kalkisTarihi"]).ToLongDateString();
                    txtAracID.Text = dr["otobusID"].ToString();
                    txtAracPlaka.Text = dr["plaka"].ToString();
                    lvCalisanlar.Items.Add(Convert.ToString(dr["ID"]));
                    lvCalisanlar.Items[i].SubItems.Add(Convert.ToString(dr["ad"]));
                    lvCalisanlar.Items[i].SubItems.Add(Convert.ToString(dr["soyad"]));
                    lvCalisanlar.Items[i].SubItems.Add(Convert.ToString(dr["pozisyon"]));
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string sqlhata = ex.Message;
            }
            finally { conn.Close(); }
        }

        private void dtpBaslangıcTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpBaslangıcTarih.Value.ToShortDateString() + " " + cbSaat.SelectedItem + ":" + cbDakika.SelectedItem;
           
        }

        private void btnAracAra_Click(object sender, EventArgs e)
        {
            frmAracListe frm = new frmAracListe();
            frm.ShowDialog();
            txtAracID.Text = Convert.ToString(cArac.AtOtoID);
            txtAracPlaka.Text = cArac.AtPlaka;
        }
        void temizle()
        {
            txtSeferNo.Clear();
            txtGuzergah.Clear();
            txtGuzergahID.Clear();
            txtTarih.Clear();
            txtAracID.Clear();
            txtAracPlaka.Clear();
            lvCalisanlar.Items.Clear();
        }
        private void btnSagaAt_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.Rows.Count != 1 &&  Convert.ToString(dgvCalisanlar.SelectedRows[0].Cells[0].Value) != "")
            {
                    lvCalisanlar.Items.Add(Convert.ToString(dgvCalisanlar.SelectedRows[0].Cells[0].Value));
                    lvCalisanlar.Items[lvCalisanlar.Items.Count - 1].SubItems.Add(Convert.ToString(dgvCalisanlar.SelectedRows[0].Cells[1].Value));
                    lvCalisanlar.Items[lvCalisanlar.Items.Count - 1].SubItems.Add(Convert.ToString(dgvCalisanlar.SelectedRows[0].Cells[2].Value));       
                    lvCalisanlar.Items[lvCalisanlar.Items.Count - 1].SubItems.Add(Convert.ToString(dgvCalisanlar.SelectedRows[0].Cells[3].Value));
                    dgvCalisanlar.Rows.Remove(dgvCalisanlar.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Çalışan Seçiniz");
            }
        }

        private void btnSolaAt_Click(object sender, EventArgs e)
        {
                lvCalisanlar.Items.Clear();
                //dgvCalisanlar.DataSource = cCal.Calisanlistele(txtTarih.Text);
        }

        private void cbSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpBaslangıcTarih.Value.ToShortDateString() + " " + cbSaat.SelectedItem + ":" + cbDakika.SelectedItem;
        }
        private void cbDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpBaslangıcTarih.Value.ToShortDateString() + " " + cbSaat.SelectedItem + ":" + cbDakika.SelectedItem;
        }

        private void btnCalisanGetir_Click(object sender, EventArgs e)
        {
            cCalisan c = new cCalisan();
            dgvCalisanlar.DataSource = c.Calisanlistele(txtTarih.Text);
            dgvCalisanlar.Columns[0].Width = 20;
            dgvCalisanlar.Columns[1].Width = 70;
            dgvCalisanlar.Columns[2].Width = 60;
            dgvCalisanlar.Columns[3].Width = 60;
        }

    }
}