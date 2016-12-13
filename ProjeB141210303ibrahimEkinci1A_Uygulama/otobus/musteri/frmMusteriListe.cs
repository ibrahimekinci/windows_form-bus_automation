using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otobus
{
    public partial class frmMusteriListe : Form
    {
        public frmMusteriListe()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        cGenel cGen = new cGenel();
        cMusteri cMus = new cMusteri();
        public static int MusteriID;
        private void frmMusteriListe_Load(object sender, EventArgs e)
        {
            cSt.frm(this);
            if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_Detay))
            {
                lblMesaj.Text = "Lütfen " + "detaylı bilgilerini görmek istediğiniz müşterinin " + "üzerine çift tıklayınız...";
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_MusteriSil))
            {
                lblMesaj.Text = "Lütfen " + "silmek istediğiniz müşterinin " + "üzerine çift tıklayınız...";
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_MusteriBilgileriDegistir))
            {

                lblMesaj.Text = "Lütfen " + "bilgilerini değiştirmek istediğiniz müşterinin " + "üzerine çift tıklayınız...";
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_musteriSecBilet))
            {

                lblMesaj.Text = "Lütfen " + "bilet satışı yapmak istediğiniz müşterinin " + "üzerine çift tıklayınız...";

            }
        }
        void FormAcFrmThis()
        {
            frmMusteri frm = new frmMusteri();
            cGen.formAcBySecim(frm);
            this.Close();
        }
        private void lvMusteri_DoubleClick(object sender, EventArgs e)
        {

            if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_Detay))
            {
                cMusteri.islem = Convert.ToInt32(cMusteri.islemler.frmMusteri_Detay);
                FormAcFrmThis();


            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_MusteriBilgileriDegistir))
            {
                cMusteri.islem = Convert.ToInt32(cMusteri.islemler.frmMusteri_MusteriBilgileriDegistir);
                MusteriID = Convert.ToInt32(lvMusteri.SelectedItems[0].SubItems[8].Text);
                //MessageBox.Show(MusteriID.ToString());
                FormAcFrmThis();
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_musteriSecBilet))
            {
                MusteriID = Convert.ToInt32(lvMusteri.SelectedItems[0].SubItems[8].Text);

                this.Close();
            }
            else if (cMusteri.islem == Convert.ToInt32(cMusteri.islemler.frmMusteriListe_MusteriSil))
            {
                cMusteri.islem = Convert.ToInt32(cMusteri.islemler.frmMusteri_Sil);
                FormAcFrmThis();
            }


        }


        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusterileriGetirByAdaGore(txtAdSoyad, lvMusteri);
        }

        private void txtTckn_TextChanged(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusterileriGetirByTckNoGore(txtTckn, lvMusteri);
        }

    }
}
