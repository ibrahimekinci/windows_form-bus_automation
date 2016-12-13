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
    public partial class frmUyelik : Form
    {
        public frmUyelik()
        {
            InitializeComponent();
        }

        private void frmUyelik_Load(object sender, EventArgs e)
        {
            //txtCalisanId.Text = Convert.ToString(cCalisan.IDyiAt);
            //txtKullanici.Text = Convert.ToString(frmCalisan.AtKullaniciNO);
            //txtCalisanId.Text = Convert.ToString(frmCalisanListe.aktarID);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
             if (txtUser.Text.Trim() != "" && txtUserPass.Text.Trim() != "")
             {
                 bool sonuc = false;
                 cCalisan c = new cCalisan();
                 c.CalisanID = Convert.ToInt32(txtCalisanId.Text);
                 c.Kadi = txtUser.Text;
                 c.Sifre = txtUserPass.Text;
                 sonuc = c.InsertKullanici(c);
                 if (sonuc)
                 {
                     MessageBox.Show("kullanıcı eklenmiştir");
                     this.Close();
                 }
                 else
                 {
                     MessageBox.Show("Boş alan bırakmayınız");
                     txtUser.Focus();
                 }
             }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "" && txtUserPass.Text.Trim() != "")
            {
                bool sonuc = false;
                cCalisan c = new cCalisan();
                c.CalisanKullanici = Convert.ToInt32(txtKullanici.Text);
                c.CalisanID = Convert.ToInt32(txtCalisanId.Text);
                c.Kadi = txtUser.Text;
                c.Sifre = txtUserPass.Text;
                sonuc = c.UpdateKullanici(c);
                if (sonuc)
                {
                    MessageBox.Show("kullanıcı bilgileri güncellenmiştir");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Boş alan bırakmayınız");
                    txtUser.Focus();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool sonuc = false;      
            if (txtCalisanId.Text.Trim() !="")
            {
                if (MessageBox.Show( "Kullanıcıyı Silmek İstiyormusunz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cCalisan c= new cCalisan();
                    sonuc = c.KullaniciSil(Convert.ToInt32(txtCalisanId.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kullanıcı Bilgileri Silindi!", "Bilgi");
                        this.Close();                        
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bilgileri Silinemedi", "Hata");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçmelisiniz!", "Bilgi");
            }
        }
    
    }
}




