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
    public partial class frmSeferListe : Form
    {
        public frmSeferListe()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        cGenel cGen = new cGenel();
        public static int AseferNumarasi;
        private void frmSeferListe_Load(object sender, EventArgs e)
        {
            tasarim();
            cSefer c = new cSefer();
            c.SeferleriGetir(lvSeferListe);
        }
        void tasarim()
        { 
             cSt.frm(this);
             tasarimIslem();
        }
        void tasarimIslem()
        {
           if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSeferListe_Detay))
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Lütfen " + "detaylı bilgilerini görmek istediğiniz Seferin " + "üzerine çift tıklayınız...";
            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSeferListe_seferSil))
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Lütfen " + "silmek istediğiniz seferin " + "üzerine çift tıklayınız...";
            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSeferListe_SeferBilgileriDegistir))
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Lütfen " + "bilgilerini değiştirmek istediğiniz seferin " + "üzerine çift tıklayınız...";
            }
        }
       
        void FormAcFrmThis()
        {
            frmSefer frm = new frmSefer();
            cGen.formAcBySecim(frm);
            this.Close();
        }
   
        private void txtGuzergah_TextChanged(object sender, EventArgs e)
        {
            cSefer s = new cSefer();
            s.SeferleriGetirByGuzergah(txtGuzergah.Text, lvSeferListe);
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }
        private void lvSeferListe_DoubleClick(object sender, EventArgs e)
        {
            if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSeferListe_Detay) && lvSeferListe.SelectedItems.ToString() !="")
            {
                frmCalisan frm = new frmCalisan();
                if (cGen.formKapat(frm))
                {
                    cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSefer_Detay);
                    frmSeferListe.AseferNumarasi = Convert.ToInt32(lvSeferListe.SelectedItems[0].Text);
                    FormAcFrmThis();
                }               
            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSeferListe_seferSil))
            {
                cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSefer_SeferSil);
                frmSeferListe.AseferNumarasi = Convert.ToInt32(lvSeferListe.SelectedItems[0].Text);
                FormAcFrmThis();
            }
            else if (cSefer.islem == Convert.ToInt32(cSefer.islemler.frmSeferListe_SeferBilgileriDegistir))
            {
                cSefer.islem = Convert.ToInt32(cSefer.islemler.frmSefer_SeferBilgileriDegistir);
                frmSeferListe.AseferNumarasi = Convert.ToInt32(lvSeferListe.SelectedItems[0].Text);
                FormAcFrmThis();
            }
        }

        private void dtpTarih2_ValueChanged(object sender, EventArgs e)
        {
            txtTarih2.Text = dtpTarih2.Value.ToShortDateString();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            cSefer s = new cSefer();
            s.SeferleriGetirByTariheGore(txtTarih.Text,txtTarih2.Text,lvSeferListe);
        }




    }
}
