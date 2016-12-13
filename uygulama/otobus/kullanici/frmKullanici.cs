using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otobus
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        private void frmKullanici_Load(object sender, EventArgs e)
        {
            cSt.frm(this);
            if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullanici_Detay))
            {
                btn.Visible = false;
                lblMesaj.Text = "Detaylı Kullanici Bilgileri";
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciSil))
            {
                btn.Text = "Sil";
                lblMesaj.Text = "Kullanici Sil...";
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciEkle))
            {
                btn.Text = "Kaydet";
                lblMesaj.Text = "Yeni Kullanici Kaydı...";
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciBilgileriDegistir))
            {
                btn.Text = "Güncelle";
                lblMesaj.Text = "Kullanici Bilgilerini Güncelle...";
            } 
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciSil))
            {
               //işlem
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciEkle))
            {
               //işlem
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciBilgileriDegistir))
            {
               //işlem
            } 
        }
    }
}
