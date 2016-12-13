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
    public partial class frmYonetim : Form
    {
        public frmYonetim()
        {
            InitializeComponent();
        }
        cGenel cGen = new cGenel();
        cStil cSt = new cStil();
        private void frmYonetim_Load(object sender, EventArgs e)
        {
            cSt.frm(this);
            cSt.menuStrip(menu);
            anasayfa();
        }
        void anasayfa()
        {
            frmSefer frm1 = new frmSefer();
            if (cGen.formKapat(frm1))
            {
                frmSefer frm = new frmSefer();
                if (cGen.formKapat(frm))
                {
                    cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSefer_FrmSeferEkle);
                    cGen.formAcBySecim(frm);
                }
            }

        }
        private void mnSeferDetay_Click(object sender, EventArgs e)
        {
            frmSefer frm1 = new frmSefer();
            if (cGen.formKapat(frm1))
            {
                frmSeferListe frm = new frmSeferListe();
                if (cGen.formKapat(frm))
                {
                    cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSeferListe_Detay);
                    cGen.formAcBySecim(frm);
                }
            }
        }

        private void mnSeferEkle_Click(object sender, EventArgs e)
        {
            frmSefer frm1 = new frmSefer();
            if (cGen.formKapat(frm1))
            {
                frmSefer frm = new frmSefer();
                if (cGen.formKapat(frm))
                {
                    cSefer.islem =Convert.ToInt32(cSefer.islemler.frmSefer_FrmSeferEkle);
                    cGen.formAcBySecim(frm);
                }
            }
        }
        private void mnSeferDegistir_Click(object sender, EventArgs e)
        {
            frmSefer frm1 = new frmSefer();
            if (cGen.formKapat(frm1))
            {
                frmSeferListe frm = new frmSeferListe();
                if (cGen.formKapat(frm))
                {
                    cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSeferListe_SeferBilgileriDegistir);
                    cGen.formAcBySecim(frm);
                }
            }
        }
        private void mnSeferSil_Click(object sender, EventArgs e)
        {
            frmSefer frm1 = new frmSefer();
            if (cGen.formKapat(frm1))
            {
                frmSeferListe frm = new frmSeferListe();
                if (cGen.formKapat(frm))
                {
                    cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSeferListe_seferSil);
                    cGen.formAcBySecim(frm);
                }
            }
        }
        private void mnCalisanDetay_Click(object sender, EventArgs e)
        {
               frmCalisan frm1 = new frmCalisan();
               if (cGen.formKapat(frm1))
               {
                   frmCalisanListe frm = new frmCalisanListe();
                   if (cGen.formKapat(frm))
                   {
                       cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisanListe_Detay);
                       cGen.FormAc(frm);
                   }
               }
        }
        private void mnCalisanEkle_Click(object sender, EventArgs e)
        {
            frmCalisanListe frm1 = new frmCalisanListe();
              if (cGen.formKapat(frm1))
              {
                  frmCalisan frm = new frmCalisan();
                  if (cGen.formKapat(frm))
                  {
                      cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanEkle);
                      cGen.FormAc(frm);
                  }
              }
        }
        private void mnCalisanBilgileriGetir_Click(object sender, EventArgs e)
        {
          frmCalisan frm1 = new frmCalisan();
          if (cGen.formKapat(frm1))
          {
              frmCalisanListe frm = new frmCalisanListe();
              if (cGen.formKapat(frm))
              {
                  cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisanListe_CalisanBilgileriDegistir);
                  cGen.FormAc(frm);
              }
          }
        }

        private void mnCalisanSil_Click(object sender, EventArgs e)
        {
              frmCalisan frm1 = new frmCalisan();
              if (cGen.formKapat(frm1))
              {
                  frmCalisanListe frm = new frmCalisanListe();
                  if (cGen.formKapat(frm))
                  {
                      cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisanListe_CalisanSil);
                      cGen.FormAc(frm);
                  }
              }
           
        }
        private void mnGuzergahSorgulaDetay_Click(object sender, EventArgs e)
        {
             frmGuzergah frm1 = new frmGuzergah();
             if (cGen.formKapat(frm1))
             {
                 frmGuzergahListe frm = new frmGuzergahListe();
                 if (cGen.formKapat(frm))
                 {
                     cGuzergah.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahDetay);
                     cGen.FormAc(frm);
                 }
             }
        }
        
        private void mnGuzergahEkle_Click(object sender, EventArgs e)
        {
          frmGuzergahListe frm1 = new frmGuzergahListe();
          if (cGen.formKapat(frm1))
          {
              frmGuzergah frm = new frmGuzergah();
              if (cGen.formKapat(frm))
              {
                  cGuzergah.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergah_GuzergahEkle);
                  cGen.FormAc(frm);
              }
          }
        }
        private void mnGuzergahDegistir_Click(object sender, EventArgs e)
        {
              frmGuzergah frm1 = new frmGuzergah();
              if (cGen.formKapat(frm1))
              {
                  frmGuzergahListe frm = new frmGuzergahListe();
                  if (cGen.formKapat(frm))
                  {
                      cGuzergah.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahDegistir);
                      cGen.FormAc(frm);
                  }
              }
        }
        private void mnGuzergahSil_Click(object sender, EventArgs e)
        {
          frmGuzergah frm1 = new frmGuzergah();
          if (cGen.formKapat(frm1))
          {
              frmGuzergahListe frm = new frmGuzergahListe();
              if (cGen.formKapat(frm))
              {
                  cGuzergah.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahSil);
                  cGen.FormAc(frm);
              }
          }
        }

        private void mnProfiliGuncelle_Click(object sender, EventArgs e)
        {
            frmCalisanListe frm =new frmCalisanListe();
            if (cGen.formKapat(frm))
            {
                 frmCalisan frm1 = new frmCalisan();
                 if (cGen.formKapat(frm1))
                 {
                     cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisan_Profil);
                     cGen.FormAc(frm1);
                 }
            }
        }

        private void mnKullaniciCikis_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mnOtomasyonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
       
    }
}
