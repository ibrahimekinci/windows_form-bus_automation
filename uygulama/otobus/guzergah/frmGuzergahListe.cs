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
    public partial class frmGuzergahListe : Form
    {
        public frmGuzergahListe()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        cGenel cGen = new cGenel();
        cGuzergah cGuz = new cGuzergah();
        private void frmGuzergahListe_Load(object sender, EventArgs e)
        {
            tasarim();
        }
        void tasarim()
        {
            cSt.frm(this);
            cSt.dgv(dgv);
            tasarimIslem();

            dgv.DataSource = cGuz.guzergahListeByGuzergahAd(txtAd.Text.Trim());
            tasarimDgv();
        }
        void tasarimIslem()
        {
           if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahDetay))
                lblMesaj.Text = "Lütfen " + "detaylı bilgilerini görmek istediğiniz guzergahın " + "üzerine çift tıklayınız...";
            else if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahSil))
                lblMesaj.Text = "Lütfen " + "silmek istediğiniz guzergahın " + "üzerine çift tıklayınız...";
            else if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahDegistir))
                lblMesaj.Text = "Lütfen " + "bilgilerini değiştirmek istediğiniz guzergahın " + "üzerine çift tıklayınız...";
            else if (cSefer.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_SefereGuzergahEkle))
                lblMesaj.Text = "Lütfen " + " seçmek istediğiniz guzergahın " + "üzerine çift tıklayınız...";
        }
        void tasarimDgv()
        {
            for (int i = 0; i < 5; i++)
            {
               dgv.Columns[i].Width = 676/5; 
            }
            dgv.Columns[2].Width += 725-676; 
        }
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            if (Convert.ToString(dgv.SelectedRows[0].Cells[0].Value) != "")
            {
                if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahDegistir))
                {
                    frmGuzergah frm = new frmGuzergah();
                    if (cGen.formKapat(frm))
                    {
                        cGuzergah.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergah_GuzergahDegistir);
                        
                        cGuzergah.tutGuzergahID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                        cGen.FormAc(frm);
                        this.Close();
                    }
                }

                else if ( cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahDetay))
                {
                    frmGuzergahDetay frm1 = new frmGuzergahDetay();
                    if (cGen.formKapat(frm1))
                    {
                        if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahSil))
                        {
                            cGuzergah.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergahDetay_GuzergahSil);

                             cGuzergah.tutGuzergahID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                        cGen.FormAc(frm1);
                        this.Close();}

                        else if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_GuzergahDetay))
                        { cGuzergah.islem = Convert.ToInt32(cGuzergah.islemler.frmGuzergahDetay_GuzergahDetay);

                        cGuzergah.tutGuzergahID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                        cGen.FormAc(frm1);
                        this.Close();}
                    }
                   
                }
               else  if(cSefer.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahListe_SefereGuzergahEkle))
                {
                    cGuzergah.islem = Convert.ToInt32(cSefer.islemler.frmSefer_FrmSeferEkle);
                    cGuzergah.tutGuzergahID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                    cGuzergah.tutGuzergahAd = dgv.SelectedRows[0].Cells[1].Value.ToString();
                    this.Close();
                }

             }
         }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "")dgv.DataSource = cGuz.guzergahListeByGuzergahAd(txtAd.Text.Trim());
            else if (txtNo.Text.Trim() != "")dgv.DataSource = cGuz.guzergahListeByGuzergahID(txtNo.Text);
            else dgv.DataSource = cGuz.guzergahListeByGuzergahAd(txtAd.Text.Trim());
            tasarimDgv();
          
        }
        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            if (txtNo.Text.Trim() != "")
            {
                try
                {
                    if (Convert.ToInt32(txtNo.Text)>-1)dgv.DataSource = cGuz.guzergahListeByGuzergahID(txtNo.Text);
                }
                catch (Exception)
                {
                    txtNo.Text = "";
                    MessageBox.Show("Lütfen sayısal bir değer giriniz..");
                }
            }
            else dgv.DataSource = cGuz.guzergahListeByGuzergahAd(txtAd.Text.Trim());
            tasarimDgv();
        }
    }
}
