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
    public partial class frmGuzergahDetay : Form
    {
        public frmGuzergahDetay()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        cGuzergah cGuz = new cGuzergah();
   
        private void frmGuzargahDetay_Load(object sender, EventArgs e)
        {
            tasarim();
            txtGuzergahID.Text = Convert.ToString(cGuzergah.tutGuzergahID);

           txtGuzergahAd.Text=cGuz.guzergahAdGetirByGuzergahID();
            txtDuraklarArasiBitis.Text = Convert.ToString(Convert.ToInt32(dgvDurak.Rows.Count) - 2);
            detayDuraklarArasi();
        }
        void tasarim()
        {
            cSt.frm(this);
            rbGidis.Checked = true;
  
            tasarimIslem();
          
            detayKutuBindingSource();   
            
        }
        void tasarimIslem()
        {
            if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahDetay_GuzergahDetay))
            {
                lblMesaj.Text = "Guzergah Detay";
            }
            else if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahDetay_GuzergahSil))
            {
                btn.Text = "Guzergah Sil";
                btn.Visible = true;
                lblMesaj.Text = "Guzergah Sil";
            }
        }
      
          BindingSource bs;
          void detayKutuBindingSource()
          {
              bs = new BindingSource();
              bs.DataSource = cGuz.guzergahDetayDurakDetay(Convert.ToString(dgvDurak.Rows[0].Cells[0].Value));
              txtDurakAd.DataBindings.Add("Text", bs, "sube");
              txtDurakID.DataBindings.Add("Text", bs, "ID");
              txtDurakSehir.DataBindings.Add("Text",bs,"sehir");
              txtDurakIlce.DataBindings.Add("Text", bs, "ilce");
              txtDurakMahalle.DataBindings.Add("Text",bs,"mahalle");
          }
       
     
        void Dgv(bool yon)
        {
            cSt.dgv(dgvDurak);
            cSt.dgv(dgvMola);

            dgvDurak.DataSource = cGuz.guzergahDetayDurak(yon);
            dgvMola.DataSource =cGuz.guzergahDetayMola();

            dgvDurak.Columns[0].Width = 82;
            dgvDurak.Columns[1].Width =(474-(82+42))/3;
            dgvDurak.Columns[2].Width = (474 - (82 + 42)) / 3;
            dgvDurak.Columns[3].Width = (474 - (82 + 42)) / 3;
            dgvDurak.Columns[4].Width = 42;
            dgvMola.Columns[0].Width = 474/3;
            dgvMola.Columns[1].Width = 474 / 3;
            dgvMola.Columns[1].Width = 474 / 3;
        }
        private void rbGidis_CheckedChanged(object sender, EventArgs e)
        {
            Dgv(true);
        }
        private void rbDonus_CheckedChanged(object sender, EventArgs e)
        {
            Dgv(false);
        }
     
        private void dgvDuraklar_DoubleClick(object sender, EventArgs e)
        {
  bs.DataSource = cGuz.guzergahDetayDurakDetay(Convert.ToString(dgvDurak.SelectedRows[0].Cells[0].Value));
        }

        
        bool detayDuraklarArasiKontroller()
        {
            string hata = "";
            bool sonuc = true;
            if (txtDuraklarArasiBaslangic.Text.Trim() == "")
            {hata = "Başlangıç Durağı boş geçilemez...";
            sonuc=false;
            }
            else  if (txtDuraklarArasiBitis.Text.Trim() == "") 
            {hata = "Bitiş Durağı boş geçilemez...";
             sonuc=false;}
            else if (Convert.ToInt32(txtDuraklarArasiBitis.Text.Trim()) < 0 || Convert.ToInt32(txtDuraklarArasiBaslangic.Text.Trim()) <0)
            {
                hata = "Başlangıç veya bitiş durakların sırası 0 dan küçük olamaz";
                sonuc = false;
            }
            if (!sonuc) MessageBox.Show(hata);
            return sonuc;
        }
        void detayDuraklarArasi()
        {//7 km 1 lira
            if (detayDuraklarArasiKontroller())
            {
                int bas = Convert.ToInt32(txtDuraklarArasiBaslangic.Text.Trim());
                int bit = Convert.ToInt32(txtDuraklarArasiBitis.Text.Trim());
                if (bas < bit)
                    bit++;
                else if (bas > bit) bit--;

                int dSayi = 0;
                double mesafe = 0;
                

                while (bas != bit)
                {
                    mesafe += Convert.ToInt32(dgvDurak.Rows[bas].Cells[3].Value);
                    if (bas < bit)
                        bas++;
                    else if(bas>bit) bas--;
                    dSayi++;                  
                }

                txtDuraklarArasiDurakSayisi.Text = Convert.ToString(dSayi);
                txtDuraklarArasiMesafe.Text = Convert.ToString(mesafe)+" KM";
                txtDuraklarArasiFiyat.Text = Convert.ToString(Convert.ToInt32(mesafe / 7)) + " TL";
                double sure = 0;
                sure = mesafe / 90;//90 otobusun saatteki hızı
                //saat hesaplama
                txtDuraklarArasiSure.Text = Convert.ToString(Math.Floor(sure)) + " Saat ";
                //dakika hesaplama
                sure -= Math.Floor(sure);
                sure *= 60;
                txtDuraklarArasiSure.Text += Convert.ToString(Math.Ceiling(sure)) + " Dakika ";

            } 
        }
        private void btnDuraklarArasiHesapla_Click(object sender, EventArgs e)
        {
            detayDuraklarArasi();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergahDetay_GuzergahSil))
            {
                if (cGuz.guzergahDetayGuzergahSil())
                {
                if(MessageBox.Show( "Guzergah Silinde...","işlem Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk)==DialogResult.OK)
                            {
                                this.Close();
                            }
                }
               
                else
                    MessageBox.Show("Guzergah Silinirken hata oluştu");
                this.Close();

            }
        }

       
    }
}
