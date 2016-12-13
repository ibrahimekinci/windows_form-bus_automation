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
    public partial class frmCalisan : Form
    {
        public frmCalisan()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        cCalisan cal = new cCalisan();
        cStil cSt = new cStil();
        cAdres adres = new cAdres();
        cGenel gnl = new cGenel();


        private void frmCalisan_Load(object sender, EventArgs e)
        {
            cSt.frm(this);
            tas();

        }
        void tas()
        {
            tasarimIslem();
            ComboTasarim();
        }

        void tasarimIslem()
        {
            if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_Detay))
            {
                btn.Visible = false;
                lblMesaj.Text = "Detaylı Çalışan Bilgileri";
                txtCalisanNO.Text = Convert.ToString(frmCalisanListe.aktarCalisanID);
                bilgiaktar();
                kullaniciGetir();
            }

            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanEkle))
            {
                btn.Text = "Kaydet";
                lblMesaj.Text = "Yeni Çalışan Kaydı...";
                mtbTckno.Focus();
                gbUyelik.Visible = false;
                cCalisan cal = new cCalisan();
                txtCalisanNO.Text = cal.SonIDBul().ToString();
            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanBilgileriDegistir))
            {
                btn.Text = "Güncelle";
                lblMesaj.Text = "Çalışan Bilgilerini Güncelle...";
                txtCalisanNO.Text = Convert.ToString(frmCalisanListe.aktarCalisanID);
                bilgiaktar();
                kullaniciGetir();
                mtbTckno.ReadOnly = true; txtAd.ReadOnly = true; txtSoyad.ReadOnly = true; gbCinsiyet.Enabled = false;
                dtpGiris.Enabled = false;
            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanSil))
            {
                btn.Text = "Sil";
                lblMesaj.Text = "Çalışan Silme İşlemi";
                txtCalisanNO.Text = Convert.ToString(frmCalisanListe.aktarCalisanID);
                bilgiaktar();
                kullaniciGetir();
                btn.Enabled = true;
            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_Profil))
            {
                btn.Text = "Güncelle";
                lblMesaj.Text = "Profil Bilgilerini Güncelle...";
                txtCalisanNO.Text = Convert.ToString(cGenel.kullaniciID);
                bilgiaktar();
                kullaniciGetir();
                txtMaas.ReadOnly = true; cbPozisyon.Enabled = false; cbSubeAd.Enabled = false;
            }
        }

        void ComboTasarim()
        {
            cPozisyon p = new cPozisyon();
            p.PoziyonlariGetir(cbPozisyon);
            cSube s = new cSube();
            s.SubeleriGetir(cbSubeAd);
            adres.sehirGetir(cbSehir);
        }

        void bilgiaktar()
        {

            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand cmd = new SqlCommand("select calisan.* ,calisanPozisyon.ad as pozisyon,sube.ad as subead,adres.* ,ilce.ad as ilcead,sehir.ad as sehirad,mahalle.ad as mahallead from calisan inner join calisanPozisyon on calisanPozisyon.calisanPozisyonID = calisan.calisanPozisyonID inner join sube on sube.subeID=calisan.subeID inner join adres on adres.adresID = calisan.adresID inner join sehir on sehir.sehirID = adres.sehirID inner join ilce on adres.ilceID = ilce.ilceID inner join mahalle on adres.mahalleID = mahalle.mahalleID where calisanID=@calisanID", conn);
            cmd.Parameters.Add("@calisanID", SqlDbType.Int).Value = txtCalisanNO.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtAd.Text = dr["ad"].ToString();
                    txtSoyad.Text = dr["soyad"].ToString();
                    mtbTckno.Text = dr["calisanTCKNO"].ToString();
                    txtTelefon.Text = dr["telefon"].ToString();
                    dtpDogumTarihi.Text = dr["dogumTarihi"].ToString();
                    txtEposta.Text = dr["mail"].ToString();
                    txtIlceID.Text = dr["ilceID"].ToString();
                    txtSehirID.Text = dr["sehirID"].ToString();
                    txtMahalleID.Text = dr["mahalleID"].ToString();
                    txtAdresID.Text = dr["adresID"].ToString();
                    cbIlce.Text = dr["ilcead"].ToString();
                    cbSehir.Text = dr["sehirad"].ToString();
                    cbMahalle.Text = dr["mahallead"].ToString();
                    txtPozisyonID.Text = dr["calisanPozisyonID"].ToString();
                    cbPozisyon.Text = dr["pozisyon"].ToString();
                    txtSubeID.Text = dr["subeID"].ToString();
                    cbSubeAd.Text = dr["subead"].ToString();
                    txtMaas.Text = dr["maas"].ToString();
                    if (dr["cinsiyet"].ToString() == "Bay") { rbBay.Checked = true; rbBayan.Checked = false; rbBayan.Enabled = false; }
                    else if (dr["cinsiyet"].ToString() == "Bayan") { rbBayan.Checked = true; rbBay.Checked = false; rbBay.Enabled = false; }
                    if (dr["ehliyetSinifi"].ToString() == "")
                    {
                        rbEhYok.Checked = true; rbEhVar.Checked = false;
                    }
                    else if (dr["ehliyetSinifi"].ToString() != "")
                    {
                        rbEhVar.Checked = true; rbEhYok.Checked = false;
                        cbEhliyetSinifi.Text = dr["ehliyetSinifi"].ToString();
                        dtpAlisTarihi.Text = dr["ehliyetAlisTarihi"].ToString();
                        cbEhliyetSinifi.Visible = true; dtpAlisTarihi.Visible = true; lblEsinifi.Visible = true; lblAlisTarihi.Visible = true;
                    }
                    dtpGiris.Text = dr["girisTarihi"].ToString();
                    if (dr["cikisTarihi"].ToString() != "")
                    {
                        txtCikis.Text = dr["cikisTarihi"].ToString(); lblCikis.Visible = true;
                        lblmaas.Visible = false; txtMaas.Visible = false; txtCikis.Visible = true;
                    }
                    else if (dr["cikisTarihi"].ToString() == "")
                    {
                        lblmaas.Visible = true; txtMaas.Visible = true;
                        txtMaas.Text = dr["maas"].ToString();
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string sqlhata = ex.Message;
            }
            finally { conn.Close(); }
        }

        void kullaniciGetir()
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand cmd = new SqlCommand("select calisanKullanici,calisan.calisanID,kadi,sifre from calisan inner join calisanKullanici on calisanKullanici.calisanID=calisan.calisanID where calisan.calisanID=@calisanID", conn);
            cmd.Parameters.Add("@calisanID", SqlDbType.Int).Value = txtCalisanNO.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtKullaniciNo.Text = dr["calisan.calisanID"].ToString();
                    txtUser.Text = dr["kadi"].ToString();
                    txtUserPswd.Text = dr["sifre"].ToString();
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string sqlhata = Convert.ToString(ex);
            }
            finally { conn.Close(); }
        }


        private void rbEhVar_CheckedChanged(object sender, EventArgs e)
        {

            cbEhliyetSinifi.Visible = true;
            dtpAlisTarihi.Visible = true;
            lblAlisTarihi.Visible = true;
            lblEsinifi.Visible = true;
        }

        private void rbEhYok_CheckedChanged(object sender, EventArgs e)
        {
            cbEhliyetSinifi.Visible = false;
            lblEsinifi.Visible = false;
            dtpAlisTarihi.Visible = false;
            lblAlisTarihi.Visible = false;
        }

        private void cbSubeAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cSube s = (cSube)cbSubeAd.SelectedItem;
            txtSubeID.Text = Convert.ToString(s.SubeID);
        }

        private void cbPozisyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPozisyon p = (cPozisyon)cbPozisyon.SelectedItem;
            txtPozisyonID.Text = Convert.ToString(p.CalisanPozisyonID);
        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cAdres a = (cAdres)cbSehir.SelectedItem;
            txtSehirID.Text = Convert.ToString(a.SehirID);
            a.ilceGetir(cbIlce, Convert.ToInt32(txtSehirID));
        }

        private void cbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cAdres a = (cAdres)cbIlce.SelectedItem;
            txtIlceID.Text = Convert.ToString(a.IlceID);
            a.mahalleGetir(cbMahalle, Convert.ToInt32( txtIlceID));
        }

        private void cbMahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cAdres a = (cAdres)cbMahalle.SelectedItem;
            txtMahalleID.Text = Convert.ToString(a.MahalleID);
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mtbTckno.Clear();
            txtTelefon.Clear();
            dtpDogumTarihi.Text = DateTime.Now.ToShortDateString();
            txtEposta.Clear();
            txtIlceID.Clear();
            txtSehirID.Clear();
            txtMahalleID.Clear();
            txtAdresID.Clear();
            txtSubeID.Clear();
            txtPozisyonID.Clear();
            txtMaas.Clear();
            dtpAlisTarihi.Text = DateTime.Now.ToShortDateString();
            dtpGiris.Text = DateTime.Now.ToShortDateString();
            txtMaas.Text = "";
            rbBay.Checked = true; rbEhYok.Checked = true;
            cbSehir.Text = "Şehir Seçiniz";
            cbIlce.Text = "İlçe Seçiniz";
            cbMahalle.Text = "Mahalle Seçiniz";
            cbPozisyon.Text = "Pozisyon Seçiniz";
            cbSubeAd.Text = "Şube Seçiniz";
            cbEhliyetSinifi.Text = "Ehliyet Seçiniz";
        }

        private void mtbTckno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbTckno.Text.Trim() != "" && mtbTckno.TextLength == 11)
            {
                string tckimlik;
                try
                {
                    tckimlik = mtbTckno.Text;
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
                        mtbTckno.Clear();
                        mtbTckno.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Tekrar Dene");
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanEkle))
            {
                #region Ekleme
                bool sonuc = false;
                if (txtAd.Text.Trim() == "" || txtSoyad.Text.Trim() == "" || mtbTckno.Text != "")
                {
                    if (txtSehirID.Text != "" && txtIlceID.Text != "" && txtMahalleID.Text != "")
                    {
                        cAdres a = new cAdres();
                        a.SehirID = Convert.ToInt32(txtSehirID.Text);
                        a.IlceID = Convert.ToInt32(txtIlceID.Text);
                        a.MahalleID = Convert.ToInt32(txtMahalleID.Text);
                        a.Aciklama = txtAciklama.Text;
                        int adresID = a.InsertAdres(a);
                        txtAdresID.Text = Convert.ToString(adresID);

                        if (txtPozisyonID.Text != "" && txtSubeID.Text != "")
                        {
                            if (adresID > 0)
                            {
                                cCalisan c = new cCalisan();
                                c.CalisanPozisyonID = Convert.ToInt32(txtPozisyonID.Text);
                                c.CalisanTCKNO = mtbTckno.Text;
                                c.SubeID = Convert.ToInt32(txtSubeID.Text);
                                c.Ad = txtAd.Text;
                                c.Soyad = txtSoyad.Text;
                                if (rbBay.Checked == true) { c.Cinsiyet = "Bay"; }
                                else { c.Cinsiyet = "Bayan"; }
                                c.DogumTarihi = dtpDogumTarihi.Value;
                                if (rbEhVar.Checked == true)
                                {
                                    c.EhliyetSinifi = cbEhliyetSinifi.Text;
                                    c.EhliyetAlisTarihi = dtpAlisTarihi.Value;
                                }
                                else if (rbEhYok.Checked == true)
                                {
                                    c.EhliyetSinifi = "";
                                    c.EhliyetAlisTarihi = Convert.ToDateTime("01/01/1800 00:00:00");
                                }
                                Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                                if (txtEposta.Text != "")
                                {
                                    if (!reg.IsMatch(txtEposta.Text))
                                    {
                                        MessageBox.Show("Email Geçersiz!");
                                        txtEposta.Focus(); txtEposta.Clear();
                                        return;
                                    }
                                    else { c.Mail = txtEposta.Text; }
                                }
                                else
                                {
                                    c.Mail = "";
                                }
                                if (txtTelefon.Text.Trim() != "") { c.Telefon = txtTelefon.Text; }
                                else { MessageBox.Show("Telefon Numarasını Kontrol Ediniz"); txtTelefon.Focus(); return; }
                                c.AdresID = adresID;
                                c.GirisTarihi = dtpGiris.Value;
                                if (txtMaas.Text == "") { MessageBox.Show("Maaş bilgisi Giriniz"); txtMaas.Focus(); return; }
                                else { c.Maas = Convert.ToDecimal(txtMaas.Text); }
                                sonuc = c.CalisanEkle(c);
                                if (sonuc)
                                {
                                    if (c.CalisanPozisyonID < 4)
                                    {
                                        cCalisan ca = new cCalisan();
                                        ca.CalisanID = Convert.ToInt32(txtCalisanNO.Text);
                                        ca.Kadi = txtSoyad.Text + txtPozisyonID.Text;
                                        ca.Sifre = "12345";
                                        sonuc = ca.InsertKullanici(ca);
                                        MessageBox.Show("Kayıt Başarılı", "Bilgi");
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("kayıt hatalı!!", "Hata");
                                    Temizle();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Departman Bilgileri Boş Bırakılamaz !!", "Hata");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Adres Boş Bırakılamaz!!", "Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Kişisel Bilgiler Boş Bırakılamaz");
                    Temizle();
                }
                #endregion
            }

            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanBilgileriDegistir))
            {
                #region Güncelleme
                bool sonuc = false;
                if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && mtbTckno.Text != "")
                {
                    if (txtSehirID.Text != "" && txtIlceID.Text != "" && txtMahalleID.Text != "")
                    {
                        cAdres a = new cAdres();
                        a.SehirID = Convert.ToInt32(txtSehirID.Text);
                        a.IlceID = Convert.ToInt32(txtIlceID.Text);
                        a.MahalleID = Convert.ToInt32(txtMahalleID.Text);
                        a.Aciklama = txtAciklama.Text;
                        a.AdresID = Convert.ToInt32(txtAdresID.Text);
                        if (a.UpdateAdres(a))
                        {
                            if (txtPozisyonID.Text != "" && txtSubeID.Text != "")
                            {
                                cCalisan c = new cCalisan();
                                c.CalisanID = Convert.ToInt32(txtCalisanNO.Text);
                                c.CalisanPozisyonID = Convert.ToInt32(txtPozisyonID.Text);
                                c.SubeID = Convert.ToInt32(txtSubeID.Text);
                                if (rbEhVar.Checked == true)
                                {
                                    c.EhliyetSinifi = cbEhliyetSinifi.Text;
                                    c.EhliyetAlisTarihi = dtpAlisTarihi.Value;
                                }
                                else if (rbEhYok.Checked == true)
                                {
                                    c.EhliyetSinifi = "";
                                    c.EhliyetAlisTarihi = Convert.ToDateTime("01/01/1800 00:00:00");
                                }
                                if (txtTelefon.Text.Trim() != "") { c.Telefon = txtTelefon.Text; }
                                else { MessageBox.Show("Telefon Numarasını Kontrol Ediniz"); txtTelefon.Focus(); return; }
                                Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                                if (txtEposta.Text != "")
                                {
                                    if (!reg.IsMatch(txtEposta.Text))
                                    {
                                        MessageBox.Show("Hatalı email girişi!");
                                        txtEposta.Focus(); txtEposta.Clear();
                                        return;
                                    }
                                    else { c.Mail = txtEposta.Text; }
                                }
                                else { c.Mail = ""; }
                                c.AdresID = Convert.ToInt32(txtAdresID.Text);
                                if (txtMaas.Text == "") { MessageBox.Show("Maaş bilgisi Giriniz"); txtMaas.Focus(); return; }
                                else { c.Maas = Convert.ToDecimal(txtMaas.Text); }
                                sonuc = c.CalisanBilgileriGuncelle(c);

                                if (sonuc)
                                {
                                        MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi");
                                        this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Güncelleme Başarısız", "Hata");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Departman Bilgileri Boş Bırakılamaz!!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Adres Boş Bırakılamaz!!", "Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Kişisel Bilgiler Boş Bırakılamaz");
                    Temizle();
                }
                #endregion
            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanSil))
            {
                #region Silme
                bool sonuc = false;
                if (txtCalisanNO.Text != "" && txtAd.Text.Trim() != "")
                {
                    if (MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " " + "adlı Calışanı Silmek İstiyormusunz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cCalisan c = new cCalisan();
                        txtCikis.Text = DateTime.Now.ToShortDateString();
                        sonuc = c.CalisanSil(Convert.ToInt32(txtCalisanNO.Text));
                        if (sonuc)
                        {
                            if (Convert.ToInt32(txtPozisyonID.Text) < 4)
                            {
                                cCalisan ca = new cCalisan();
                                ca.CalisanID = Convert.ToInt32(txtCalisanNO.Text);
                                ca.Kadi = txtUser.Text;
                                ca.Sifre = txtUserPswd.Text;
                                sonuc = ca.KullaniciSil(Convert.ToInt32(txtCalisanNO.Text));
                                MessageBox.Show("Çalışan Bilgileri Silindi!", "Bilgi");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Çalışan Bilgileri Silinemedi", "Hata");
                            this.Close();
                        }
                    }
                }
                #endregion
            }

            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisan_Profil))
            {
                #region Profil
                bool sonuc = false;
                if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && mtbTckno.Text != "")
                {
                    if (txtSehirID.Text != "" && txtIlceID.Text != "" && txtMahalleID.Text != "")
                    {
                        cAdres a = new cAdres();
                        a.SehirID = Convert.ToInt32(txtSehirID.Text);
                        a.IlceID = Convert.ToInt32(txtIlceID.Text);
                        a.MahalleID = Convert.ToInt32(txtMahalleID.Text);
                        a.Aciklama = txtAciklama.Text;
                        a.AdresID = Convert.ToInt32(txtAdresID.Text);
                        if (a.UpdateAdres(a))
                        {
                            cCalisan c = new cCalisan();
                            c.CalisanID = Convert.ToInt32(txtCalisanNO.Text);
                            c.CalisanPozisyonID = Convert.ToInt32(txtPozisyonID.Text);
                            c.SubeID = Convert.ToInt32(txtSubeID.Text);
                            if (rbEhVar.Checked == true)
                            {
                                c.EhliyetSinifi = cbEhliyetSinifi.Text;
                                c.EhliyetAlisTarihi = dtpAlisTarihi.Value;
                            }
                            else if (rbEhYok.Checked == true)
                            {
                                c.EhliyetSinifi = "";
                                c.EhliyetAlisTarihi = Convert.ToDateTime("01/01/1800 00:00:00");
                            }
                            if (txtTelefon.Text.Trim() != "") { c.Telefon = txtTelefon.Text; }
                            else { MessageBox.Show("Telefon Numarasını Kontrol Ediniz"); txtTelefon.Focus(); return; }
                            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                            if (txtEposta.Text != "")
                            {
                                if (!reg.IsMatch(txtEposta.Text))
                                {
                                    MessageBox.Show("Hatalı email girişi!");
                                    txtEposta.Focus(); txtEposta.Clear();
                                    return;
                                }
                                else { c.Mail = txtEposta.Text; }
                            }
                            else { c.Mail = ""; }
                            c.AdresID = Convert.ToInt32(txtAdresID.Text);
                            if (txtMaas.Text == "") { MessageBox.Show("Maaş bilgisi Giriniz"); txtMaas.Focus(); return; }
                            else { c.Maas = Convert.ToDecimal(txtMaas.Text); }
                            sonuc = c.CalisanBilgileriGuncelle(c);
                            if (sonuc)
                            {
                                    cCalisan ca = new cCalisan();
                                    ca.CalisanID = Convert.ToInt32(txtCalisanNO.Text);
                                    ca.Kadi = txtUser.Text;
                                    ca.Sifre = txtUserPswd.Text;
                                    sonuc = ca.UpdateKullanici(ca);
                                    MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi");
                                    this.Close();                                  
                            }
                            else
                            {
                                MessageBox.Show("Güncelleme Başarısız", "Hata");
                            }
                        }
                    }
                    else
                    {
                            MessageBox.Show(" Adres Boş Bırakılamaz!!", "Hata");
                    }
                }
                else
                {
                        MessageBox.Show("Kişisel Bilgiler Boş Bırakılamaz");
                        Temizle();
                 }
                #endregion
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
    }
}
