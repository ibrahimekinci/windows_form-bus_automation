using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace otobus
{
    public partial class frmCalisanListe : Form
    {
        public frmCalisanListe()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        cStil cSt = new cStil();
        cGenel cGen = new cGenel();
        cCalisan cCal = new cCalisan();
        public static int aktarCalisanID;

        private void frmCalisanListe_Load(object sender, EventArgs e)
        {
            tasarim();
            cPozisyon p = new cPozisyon();
            p.PoziyonlariGetir(cbPozisyonlar);
        }
        void tasarim()
        {
            cSt.frm(this);
            tasarimIslem();
            tasarimDgv();         
        }
        void tasarimIslem()
        {
         if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_Detay))
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Lütfen " + "detaylı bilgilerini görmek istediğiniz Çalışanın " + "üzerine çift tıklayınız...";
            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_CalisanSil))
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Lütfen " + "silmek istediğiniz çalışanı " + "seçiniz";

            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_CalisanBilgileriDegistir))
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Lütfen " + "bilgilerini değiştirmek istediğiniz çalışanın " + "üzerine çift tıklayınız...";

            }
        }

        void tasarimDgv()
        {
            cSt.dgv(dgv);
            dgv.DataSource = cCal.calisanListeByAd(txtAdSoyad.Text.Trim().ToLower());

        }

        void FormAcFrmThis()
        {
            frmCalisan frm = new frmCalisan();
            cGen.formAcBySecim(frm);
            this.Close();
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = cCal.calisanListeByAd(txtAdSoyad.Text.Trim().ToLower());
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_Detay) && Convert.ToString(dgv.SelectedRows [0].Cells[0].Value) != null)
            {
                if(cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_Detay))
                {
                    frmCalisan frm = new frmCalisan();
                    if (cGen.formKapat(frm))
                    {
                        cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisan_Detay);
                        frmCalisanListe.aktarCalisanID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                        cGen.FormAc(frm);
                        this.Close();       
                    }
                }           
            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_CalisanSil))
            {
                cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanSil);
                frmCalisanListe.aktarCalisanID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                FormAcFrmThis();

            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_CalisanBilgileriDegistir))
            {
                cCalisan.islem = Convert.ToInt32(cCalisan.islemler.frmCalisan_CalisanBilgileriDegistir);
                frmCalisanListe.aktarCalisanID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                FormAcFrmThis();
            }
            else if (cCalisan.islem == Convert.ToInt32(cCalisan.islemler.frmCalisanListe_SeferCalisanEkle))
            {
                cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSefer_FrmSeferEkle);
                cCalisan.AtSeferCalisanID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                FormAcFrmThis();
            }
        }

        private void mtnTckno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtnTckno.Text.Trim() != "")
            {
                try
                {
                    if (Convert.ToInt32(mtnTckno.Text) > -1)
                    {
                        dgv.DataSource = cCal.calisanListeByTCKNO(mtnTckno.Text.Trim());
                    }
                }
                catch (Exception)
                {
                    mtnTckno.Text = "";
                    MessageBox.Show("Lütfen sayısal bir değer giriniz..");
                }
            }
        }

        private void cbPozisyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = cCal.calisanListeByPozisyon(cbPozisyonlar.SelectedItem.ToString().Trim());
        }
 

    }
}
