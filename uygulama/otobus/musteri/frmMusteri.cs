using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace otobus
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();

        }
        cStil cSt = new cStil();
        cMusteri cMus = new cMusteri();
        cAdres adres = new cAdres();
        int tutMusteriID = 0, tutSehirID = 0, tutIlceID = 0, tutMahalleID = 0;
        private void frmMusteri_Load(object sender, EventArgs e)
        {

            cSt.frm(this);

            adres.sehirGetir(cbSehir);

            if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_Detay))
            {
                tutMusteriID = frmMusteriListe.MusteriID;
                btn.Visible = false;
                lblMesaj.Text = "Detaylı Müşteri Bilgileri";
                MusteriIDYeGoreGetir();

            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_musteriEkle))
            {

                btn.Text = "Kaydet";
                lblMesaj.Text = "Yeni Müşteri Kaydı...";
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_MusteriBilgileriDegistir))
            {
                btn.Text = "Güncelle";
                lblMesaj.Text = "Müşteri Bilgilerini Güncelle...";
                tutMusteriID = frmMusteriListe.MusteriID;
                MusteriIDYeGoreGetir();
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_Sil))
            {
                btn.Text = "Sil";
                lblMesaj.Text = "Müşteri Bilgilerini Sil...";
                tutMusteriID = frmMusteriListe.MusteriID;
                MusteriIDYeGoreGetir();


            }
        }
        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cAdres a = (cAdres)cbSehir.SelectedItem;
            tutSehirID =a.SehirID;
            a.ilceGetir(cbIlce, tutSehirID);

        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cAdres a = (cAdres)cbIlce.SelectedItem;
            tutIlceID =a.IlceID;
            a.mahalleGetir(cbMahalle, tutIlceID);
        }
        private void cbMahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cAdres a = (cAdres)cbMahalle.SelectedItem;
            tutMahalleID =a.MahalleID;


        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_Detay))
            {

            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_musteriEkle))
            {
                
                
                if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != ""  )
                {
                    cAdres a = new cAdres();
                    a.SehirID = Convert.ToInt32(tutSehirID);
                    a.IlceID = Convert.ToInt32(tutIlceID);
                    a.MahalleID = Convert.ToInt32(tutMahalleID);
                    a.Aciklama = txtAciklama.Text;
                    int adresID = a.InsertAdres(a);

                    txtAdresID.Text = Convert.ToString(adresID);

                    

                    cMusteri m = new cMusteri();
                    m.Ad = txtAd.Text;
                    m.Soyad = txtSoyad.Text;
                    m.Ceptel = txtCepTelefon.Text;
                    m.Evtel = txtEvTelefon.Text;
                    m.Tckn = txtTckn.Text;
                    m.Email = txtEmail.Text;
                    m.AdresID = Convert.ToInt32(txtAdresID.Text);
                    m.DogumTarih = Convert.ToDateTime(txtDogumTarihi.Text);
                    if (rbBay.Checked == true)
                    {
                        m.Cinsiyet = rbBay.Text;

                    }
                    else
                    {
                        m.Cinsiyet = rbBayan.Text;
                    }





                    bool sonuc = m.InsertMusteri(m);
                    if (sonuc)
                    {
                        MessageBox.Show("Bilgiler Kaydedildi");
                        //btnKaydet.Enabled = false;
                        //m.MusterilerGoster(lvMusteriler);
                    }
                    else
                    {
                        MessageBox.Show("kayıt işlemi gerçekleşmedi");
                        //txtAdres.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ad ve Soyad alanlarını boş bırakmayınız");
                }

            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_MusteriBilgileriDegistir))
            {
                if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "")
                {

                    cAdres a = new cAdres();
                    a.SehirID = Convert.ToInt32(tutSehirID);
                    a.IlceID = Convert.ToInt32(tutIlceID);
                    a.MahalleID = Convert.ToInt32(tutMahalleID);
                    a.Aciklama = txtAciklama.Text;
                    a.AdresID = Convert.ToInt32(txtAdresID.Text);
                    if (a.UpdateAdres(a))
                    {
                        MessageBox.Show("Adres degistirilmiştir");
                    }


                    cMusteri m = new cMusteri();
                    m.Ad = txtAd.Text;
                    m.Soyad = txtSoyad.Text;
                    m.Ceptel = txtCepTelefon.Text;
                    m.Evtel = txtEvTelefon.Text;
                    m.Tckn = txtTckn.Text;
                    m.Email = txtEmail.Text;
                    m.AdresID = Convert.ToInt32(txtAdresID.Text);
                    m.DogumTarih = Convert.ToDateTime(txtDogumTarihi.Text);
                    m.MusteriID = Convert.ToInt32(tutMusteriID);
                    if (rbBay.Checked == true)
                    {
                        m.Cinsiyet = rbBay.Text;

                    }
                    else
                    {
                        m.Cinsiyet = rbBayan.Text;
                    }





                    bool sonuc = m.MusteriDegistir(m);
                    if (sonuc)
                    {
                        MessageBox.Show("Bilgiler Degistirildi");
                        //btnKaydet.Enabled = false;
                        //m.MusterilerGoster(lvMusteriler);
                    }
                    else
                    {
                        MessageBox.Show("degistirme işlemi gerçekleşmedi");
                        //txtAdres.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ad ve Soyad alanlarını boş bırakmayınız");
                }
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteri_Sil))
            {
                if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "")
                {




                    cMusteri m = new cMusteri();
                    m.MusteriID = Convert.ToInt32(tutMusteriID);
                    if (Convert.ToBoolean(m.MusteriSil(m)))
                    {
                        MessageBox.Show("Bilgiler Silindi");

                    }
                    else
                    {
                        MessageBox.Show("silmeişlemi gerçekleşmedi");

                    }
                }
                else
                {
                    MessageBox.Show("Ad ve Soyad alanlarını boş bırakmayınız");
                }
            }
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDogumTarihi.Text = dateTimePicker1.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        public bool EmailKontrol(string email)
        {
            string pattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            if (String.IsNullOrEmpty(email)) return Regex.IsMatch(email, pattern);
            else return false;
        }
        private void MusteriIDYeGoreGetir()
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("SELECT musteri.*,ilce.ad as ilcead,ilce.ilceID,adres.sehirID,adres.aciklama,mahalle.mahalleID,mahalle.ad as mahallead,sehir.ad as sehiradi FROM adres INNER join ilce ON adres.ilceID =ilce.ilceID INNER JOIN mahalle ON adres.mahalleID = mahalle.mahalleID AND ilce.ilceID = mahalle.ilceID INNER JOIN musteri ON adres.adresID = musteri.adresID INNER JOIN sehir ON adres.sehirID =sehir.sehirID AND ilce.sehirID =sehir.sehirID where musteriID=@musteriID", conn);
            comm.Parameters.AddWithValue("@musteriID", tutMusteriID);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txtAd.Text = dr["ad"].ToString();
                    txtSoyad.Text = dr["soyad"].ToString();
                    txtTckn.Text = dr["tckn"].ToString();
                    txtDogumTarihi.Text = dr["dogumTarihi"].ToString();
                    txtCepTelefon.Text = dr["cepTelefonu"].ToString();
                    txtEvTelefon.Text = dr["evTelefonu"].ToString();
                    txtEmail.Text = dr["eposta"].ToString();
                    tutIlceID = Convert.ToInt32(dr["ilceID"]);
                    tutSehirID =Convert.ToInt32( dr["sehirID"]);
                    tutMahalleID = Convert.ToInt32(dr["mahalleID"]);
                    txtAdresID.Text = dr["adresID"].ToString();
                    txtAciklama.Text = dr["aciklama"].ToString();

                    if (dr["cinsiyet"].ToString() == "Bay")
                    {
                        rbBay.Checked = true;
                    }
                    else if (dr["cinsiyet"].ToString() == "Bayan")
                    {
                        rbBayan.Checked = true;
                    }

                    cbIlce.Text = dr["ilcead"].ToString();

                    cbSehir.Text = dr["sehiradi"].ToString();
                    cbMahalle.Text = dr["mahallead"].ToString();
                }
                dr.Close();
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }



        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtTckn_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtTckn.Text.Trim() != "" && txtTckn.TextLength == 11)
            {
                string tckimlik;
                try
                {
                    tckimlik = txtTckn.Text;
                    int i = 0;
                    int toplam = 0;
                    foreach (char n in tckimlik)
                    {
                        if (i < 10)
                        {
                            toplam += Convert.ToInt32(char.ToString(n));
                        }
                        i++;
                    }
                    if (toplam % 10 != Convert.ToInt32(tckimlik[10].ToString()))
                    {
                        MessageBox.Show("Geçersiz Tc Kimlik Numarası");
                        txtTckn.Clear();
                        txtTckn.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Tekrar Dene");
                }
            }
        }
    }
}
