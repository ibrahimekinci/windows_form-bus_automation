using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace otobus
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private void frmGiris_Load(object sender, EventArgs e)
        {
            cSt.frm(this);
            hatirla.cookiesGetir(txtKullaniciAdi, txtSifre);

        }
        cGenel cGen = new cGenel();
        cStil cSt = new cStil();
        cBeniHatirla hatirla = new cBeniHatirla();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            this.Focus();
            cSt.frm(this);
            hatirla.cookiesGetir(txtKullaniciAdi, txtSifre);
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select calisanKullanici.calisanID,calisanPozisyonID,kadi,sifre from calisanKullanici inner join calisan on calisanKullanici.calisanID = calisan.calisanID where kadi=@kadi and sifre=@sifre and calisanKullanici.durum=1", conn);
            comm.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
            comm.Parameters.AddWithValue("@sifre", txtSifre.Text);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
                {
                    SqlDataReader dr = comm.ExecuteReader();
                    if (dr.Read())
                    {
                        if (cbHatirla.Checked == true)
                        {
                            cCalisan c = new cCalisan();
                            c.Kadi = txtKullaniciAdi.Text;
                            hatirla.cookiesKaydet(txtKullaniciAdi.Text, txtSifre.Text);
                        }
                        else hatirla.cookiesSil();
                        cGenel.kullaniciID = Convert.ToInt32(dr["calisanID"]);
                        if (Convert.ToInt32(dr["calisanPozisyonID"]) < 3)
                        {

                            frmYonetim frm = new frmYonetim();
                            frm.ShowDialog();
                            dr.Close();
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Giriş Yaptınız!! Tekrar Deneyiniz");
                            txtKullaniciAdi.Clear(); txtSifre.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Boş alan Bırakmayınız!!");
                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ~frmGiris()
        {
            Application.Exit();
        }
        private void btnYonetici_Click(object sender, EventArgs e)
        {
            frmYonetim frm = new frmYonetim();
            frm.Show();
            this.Hide();
        }


        public object txt { get; set; }

    }
}
