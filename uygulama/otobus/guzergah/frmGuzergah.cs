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
    public partial class frmGuzergah : Form
    {
        public frmGuzergah()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();
        cGenel cGen = new cGenel();
        cGuzergah cGuz = new cGuzergah();
        private void frmYGuzergah_Load(object sender, EventArgs e)
        {
            tasarim();
            dgv();
           
        }
        #region tasarım
		void tasarim()
        {
            cSt.frm(this);
            cSt.lv(lvSube);
            cSt.lv(lvMolaTesisi);
            cSt.dgv(dgvMolaTesisi);
            cSt.dgv(dgvSube);
            tasarimIslem();
        }
        void tasarimIslem()
        {
            if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergah_GuzergahEkle))
            {
                btn.Text = "Kaydet";
                btn.Visible = true;
                lblMesaj.Text = "Guzergah Ekle";
            }
            else if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergah_GuzergahDegistir))
            {
                lblMesaj.Text = "Guzergah Değiştir";
                string[] tut = cGuz.guzergahAdAndAciklamGetirByGuzergahID();
                txtGuzergahAd.Text = tut[0];
                txtGuzergahAciklama.Text = tut[1];
                if (cGuz.guzergahUpdateBilgileriniGetir(lvSube,lvMolaTesisi))
                {
                btn.Text = "Değiştir";
                btn.Visible = true;
                }
            }
          
        } 
	#endregion
        #region dgv
		 void dgv()
        {
            mDgvSube();
             mDgvMolaTesisi(); 
        }
        void mDgvSube()
        {
            try
            {
            dgvSube.DataSource = cGuz.guzergahSubeGetirBySehir(lvSube, txtAraBySube.Text.Trim().ToUpper());
            dgvSube.Columns[0].Visible = false;
            }
            catch
            { 
            }
        }
        void mDgvMolaTesisi()
        {
            int say = lvSube.Items.Count;
            if (say > 2)
            {
                try
                {
                    dgvMolaTesisi.DataSource = cGuz.guzergahMolaTesisiGetirBySehir(lvSube, lvMolaTesisi, txtAraByMolaTesisi.Text.Trim().ToUpper());
                    dgvMolaTesisi.Columns[0].Visible = false;
                }
                catch
                {
                }
            }
            else if (say == 1 || say == 2) dgvMolaTesisi.DataSource = null;
        } 
	#endregion
        #region btn islemler
		 private void btn_Click(object sender, EventArgs e)
        {
                if (txtGuzergahAd.Text.Trim()!="")
                {
                    if (lvSube.Items.Count >0)
                    {
                        if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergah_GuzergahEkle))
                        {
             
                                    cGuzergah ekle = new  cGuzergah();
                                    ekle.GuzergahAd = txtGuzergahAd.Text.Trim();
                                    ekle.GuzergahAciklama = txtGuzergahAciklama.Text.Trim();
                                    if (Convert.ToBoolean(ekle.guzergahEkle(ekle, lvSube, lvMolaTesisi)))
                                    {
                                        if(MessageBox.Show( "Kayıt başarılı..","işlem Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk)==DialogResult.OK)
                                        {
                                            this.Close();
                                        }
                                    }
                                    else MessageBox.Show("Kayıt sırasında hatalar oluştu..");
                   
                        }
                        else if (cGuzergah.islem == Convert.ToInt32(cGuzergah.islemler.frmGuzergah_GuzergahDegistir))
                        {
                                    cGuzergah update = new  cGuzergah();
                                    update.GuzergahAd = txtGuzergahAd.Text.Trim();
                                    update.GuzergahAciklama = txtGuzergahAciklama.Text.Trim();
                                    if (Convert.ToBoolean(cGuz.guzergahUpdate(update,lvSube,lvMolaTesisi)))
                                    {
                                        if(MessageBox.Show( "update işlemi başarılı..","işlem Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk)==DialogResult.OK)
                                        {
                                            this.Close();
                                        }
                                    }
                                    else MessageBox.Show("update sırasında hatalar oluştu..");
                        }
                    }
                    else MessageBox.Show("Lütfen durak ekleyiniz..");
                }
                else MessageBox.Show("Lütfen guzergah adı giriniz..");
        } 
	#endregion
        #region ortak
         void listviewTasiAsagiYukari(ListView lv, bool tut)
        {
            //1 yukarı 0 aşagı
            // listview den seçili itemin sırasını veri  lvSube.SelectedIndices[0]
            if (lv.SelectedItems.Count > 0)
            {
                int sira = Convert.ToInt32(lv.SelectedIndices[0]);
                int tutSira = 0;
                if (tut == true) tutSira = -1;
                else tutSira = 1;
                if ((tut == true && sira > 0) || (tut == false && sira < lv.Items.Count - 1))
                {
                    string tutHucre = "";
                    for (int i = 1; i < lv.Columns.Count; i++)
                    {
                        tutHucre = lv.Items[sira + (tutSira)].SubItems[i].Text;
                        lv.Items[sira + tutSira].SubItems[i].Text = lv.Items[sira].SubItems[i].Text;
                        lv.Items[sira].SubItems[i].Text = tutHucre;
                    }
                }
                else
                {
                    if (tut == true) MessageBox.Show("Seçim zaten en üste ..");
                    else MessageBox.Show("Seçim zaten en altta ..");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce Bir seçim yapınız..");
            }
        } 
            #endregion
        #region MoldaTesisi
        private void txtAraByMolaTesisi_TextChanged(object sender, EventArgs e)
        {
            mDgvMolaTesisi();
        }
        private void btnMolaTesisiSec_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dgvMolaTesisi.SelectedRows[0].Cells[0].Value) != "")
            {
                lvMolaTesisi.Items.Add(Convert.ToString(dgvMolaTesisi.SelectedRows[0].Cells[0].Value));
                for (int i = 1; i < dgvMolaTesisi.Columns.Count; i++)
                {
                    lvMolaTesisi.Items[lvMolaTesisi.Items.Count - 1].SubItems.Add(Convert.ToString(dgvMolaTesisi.SelectedRows[0].Cells[i].Value));
                }
                dgvMolaTesisi.Rows.Remove(dgvMolaTesisi.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Lütfen önce mola tesisi seçiniz");
            }
        }

        private void btnMolaTesisiYukariTasi_Click(object sender, EventArgs e)
        {
            listviewTasiAsagiYukari(lvMolaTesisi, true);
        }

        private void btnMolaTesisiAsagiTasi_Click(object sender, EventArgs e)
        {
            listviewTasiAsagiYukari(lvMolaTesisi, false);
        }

        private void btnMolaTesisiSecimSil_Click(object sender, EventArgs e)
        {

            if (lvMolaTesisi.SelectedItems.Count > 0)
            {
                lvMolaTesisi.Items.Remove(lvMolaTesisi.SelectedItems[0]);
                mDgvMolaTesisi();
            }
            else MessageBox.Show("Lütfen bir tesis seçiniz..");
        } 
        #endregion
        #region Duraklar
        private void txtAraBySube_TextChanged(object sender, EventArgs e)
        {
            mDgvSube();
        }
        private void btnSubeSec_Click(object sender, EventArgs e)
        {
            if (txtOncekineUzakligi.Text.Trim() != "")
            {
                try
                {
                    if (Convert.ToInt32(txtOncekineUzakligi.Text) > -1)
                    {

                        if (Convert.ToString(dgvSube.SelectedRows[0].Cells[0].Value) != "")
                        {
                            lvSube.Items.Add(Convert.ToString(dgvSube.SelectedRows[0].Cells[0].Value));
                            for (int i = 1; i < dgvSube.Columns.Count; i++)
                            {
                                lvSube.Items[lvSube.Items.Count - 1].SubItems.Add(Convert.ToString(dgvSube.SelectedRows[0].Cells[i].Value));
                            }
                            lvSube.Items[lvSube.Items.Count - 1].SubItems.Add(txtOncekineUzakligi.Text);
                            dgvSube.Rows.Remove(dgvSube.SelectedRows[0]);
                            mDgvMolaTesisi();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen 2 Durak arasındaki mesafeyi hatalı girdiniz..");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen 2 Durak arasındaki mesafeye sayısal bir değer giriniz..");
                }
            }
            else MessageBox.Show("Lütfen 2 Durak arasındaki mesafeyi giriniz..");
            txtOncekineUzakligi.Text = "";
        }

        private void btnSubeYukariTasi_Click(object sender, EventArgs e)
        {
            listviewTasiAsagiYukari(lvSube, true);
            mDgvMolaTesisi();
        }

        private void btnSubeAsagiTasi_Click(object sender, EventArgs e)
        {
            listviewTasiAsagiYukari(lvSube, false);
            mDgvMolaTesisi();
        }

        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            if (lvSube.SelectedItems.Count > 0)
            {
                lvSube.Items.Remove(lvSube.SelectedItems[0]);
                dgv();
            }
            else MessageBox.Show("Lütfen Bir durak seçiniz..");
        }
        private void btnSubeDegistir_Click(object sender, EventArgs e)
        {
            if (tutLblSubeDegistirSubeID.Text == "tut")
            {
                if (lvSube.SelectedItems.Count > 0)
                {
                    tutLblSubeDegistirSubeID.Text = lvSube.SelectedItems[0].SubItems[0].Text;
                    txtSubeDegistirSubeAd.Text = lvSube.SelectedItems[0].SubItems[1].Text;
                    txtSubeDegistirSehirAd.Text = lvSube.SelectedItems[0].SubItems[2].Text;
                    txtOncekineUzakligi.Text = lvSube.SelectedItems[0].SubItems[3].Text;
                    btnSubeDegistirIptal.Visible = true;
                    gbSubeDegistir.Visible = true;
                }
                else MessageBox.Show("Lütfen Bir durak seçiniz..");

            }
            else
            {
                for (int i = 0; i < lvSube.Items.Count; i++)
                {
                    if (lvSube.SelectedItems[0].SubItems[0].Text == tutLblSubeDegistirSubeID.Text)
                    {
                        lvSube.SelectedItems[0].SubItems[3].Text = txtOncekineUzakligi.Text;
                        break;
                    }
                }
                btnSubeDegistirIptal.Visible = false;
                gbSubeDegistir.Visible = false;
                tutLblSubeDegistirSubeID.Text = "tut";
            }
        }

        private void btnSubeDegistirIptal_Click(object sender, EventArgs e)
        {
            btnSubeDegistirIptal.Visible = false;
            gbSubeDegistir.Visible = false;
            tutLblSubeDegistirSubeID.Text = "tut";
        }
        #endregion
       

    }
}
