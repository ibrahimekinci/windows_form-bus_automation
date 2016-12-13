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
    public partial class frmKullaniciListe : Form
    {
        public frmKullaniciListe()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        cGenel cGen = new cGenel();
        private void frmKullaniciListe_Load(object sender, EventArgs e)
        {
            cSt.frm(this);
            if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullaniciListe_KullaniciSorgula))
            {
                lblMesaj.Text = "Kullanicinın varlığını bu formda sorgulayabilirsiniz...";
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullaniciListe_Detay))
            {
                lblMesaj.Text = "Lütfen " + "detaylı bilgilerini görmek istediğiniz Kullanicinın " + "üzerine çift tıklayınız...";
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullaniciListe_KullaniciSil))
            {
                lblMesaj.Text = "Lütfen " + "silmek istediğiniz Kullanicinın " + "üzerine çift tıklayınız...";
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullaniciListe_KullaniciBilgileriDegistir))
            {

                lblMesaj.Text = "Lütfen " + "bilgilerini değiştirmek istediğiniz Kullanicinın " + "üzerine çift tıklayınız...";
            }
        }
        void FormAcFrmThis()
        {
            frmKullanici frm = new frmKullanici();
            cGen.formAcBySecim(frm);
            this.Close();
        }
        private void lv_DoubleClick(object sender, EventArgs e)
        {
             if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullaniciListe_Detay))
            {
                cKullanici.islem = Convert.ToInt32(cKullanici.islemler.frmKullanici_Detay);
                FormAcFrmThis();
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullaniciListe_KullaniciSil))
            {
                cKullanici.islem = Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciSil);
                FormAcFrmThis();
            }
            else if (cKullanici.islem == Convert.ToInt32(cKullanici.islemler.frmKullaniciListe_KullaniciBilgileriDegistir))
            {
                cKullanici.islem = Convert.ToInt32(cKullanici.islemler.frmKullanici_KullaniciBilgileriDegistir);
                FormAcFrmThis();
              
            }
        }
    }
}
