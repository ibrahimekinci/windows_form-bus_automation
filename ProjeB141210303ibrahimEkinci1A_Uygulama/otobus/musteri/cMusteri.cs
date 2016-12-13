using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otobus
{
    class cMusteri
    {
     
        public enum islemler : byte {frmMusteriListe_Detay=1, frmMusteriListe_MusteriSil, frmMusteriListe_MusteriBilgileriDegistir, frmMusteriListe_musteriSecBilet, frmMusteri_Detay, frmMusteri_musteriEkle, frmMusteri_MusteriBilgileriDegistir, frmMusteri_Sil};
        public static int islem = 0;
        cGenel cGen = new cGenel();
        private int _ilNo, _adresID, _musteriID;

        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }
 private string _ilAd, _tckn, _ad, _soyad, _cinsiyet, _ceptel, _evtel, _email;
 private int _ilceno;
        private DateTime _dogumTarih;
        private string _ilcead;
        #region MyRegion
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Evtel
        {
            get { return _evtel; }
            set { _evtel = value; }
        }

        public string Ceptel1
        {
            get { return _ceptel; }
            set { _ceptel = value; }
        }

        public string Ceptel
        {
            get { return _ceptel; }
            set { _ceptel = value; }
        }

        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Tckn
        {
            get { return _tckn; }
            set { _tckn = value; }
        }


        public int AdresID
        {
            get { return _adresID; }
            set { _adresID = value; }
        }

        public int Ilceno
        {
            get { return _ilceno; }
            set { _ilceno = value; }
        }


        public DateTime DogumTarih
        {
            get { return _dogumTarih; }
            set { _dogumTarih = value; }
        }




        public string Ilcead
        {
            get { return _ilcead; }
            set { _ilcead = value; }
        }
        public string IlAd
        {
            get { return _ilAd; }
            set { _ilAd = value; }
        }
        public int IlNo
        {
            get { return _ilNo; }
            set { _ilNo = value; }
        } 
        #endregion
        //public string IlceAd
        //{
        //    get { return _ilceAd; }
        //    set { _ilAd = value; }
        //}
        //public int IlceNo
        //{
        //    get { return _ilceNo; }
        //    set { _ilNo = value; }
        //}
     
        //public void IlleriGetir(ComboBox iller)
        //{
        //   iller.Items.Clear();
        //    SqlConnection conn = new SqlConnection(cGenel.connStr);
        //    SqlCommand comm = new SqlCommand("select * from sehir order by ad asc", conn);
           
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr = comm.ExecuteReader();
           
        //    while (dr.Read())
        //    {
        //       cMusteri m = new cMusteri();
        //       m._ilAd = dr["ad"].ToString();
        //     m._ilNo = Convert.ToInt32(dr["sehirID"]);
         

        //        iller.Items.Add(m);

        //    }
        //    dr.Close();
        //    conn.Close();


        //}
        //public void IlceleriGetir(ComboBox ilceler,TextBox SehirID)
        //{
        //    ilceler.Items.Clear();
        //    SqlConnection conn = new SqlConnection(cGenel.connStr);
        //    SqlCommand comm = new SqlCommand("select * from ilce where sehirID=@sehirID order by ad asc", conn);
        //    comm.Parameters.AddWithValue("@sehirID", SehirID.Text);
           
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr = comm.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        cMusteri m = new cMusteri();
        //        m._ilcead = Convert.ToString(dr["ad"]);
        //        m.Ilceno = Convert.ToInt32(dr["ilceID"]);
        //        ilceler.Items.Add(m);
        //    }
        //    dr.Close();
        //    conn.Close();


        //}
        ////public void IlceIDGetir(ComboBox ilceler, TextBox ilceID)
        ////{
            

        ////    SqlConnection conn = new SqlConnection(cGenel.connStr);
        ////    SqlCommand comm = new SqlCommand("select ilceID from ilceler where ad=@ad", conn);
        ////    comm.Parameters.AddWithValue("@ad",ad);

        ////    if (conn.State == ConnectionState.Closed) conn.Open();
        ////    SqlDataReader dr = comm.ExecuteReader();
        ////    while (dr.Read())
        ////    {
        ////        m._ilcead = Convert.ToString(dr["ad"]);
        ////        m.Ilceno = Convert.ToInt32(dr["ilceID"]);
        ////        ilceler.Items.Add(m);
        ////        ilceID.Text = Convert.ToString(dr["ilceID"]);
        ////    }
        ////    dr.Close();
        ////    conn.Close();


        ////}
        //public void MahalleGetir(ComboBox mahalle, TextBox IlceID)
        //{
        //   mahalle.Items.Clear();

        //    SqlConnection conn = new SqlConnection(cGenel.connStr);
        //    SqlCommand comm = new SqlCommand("select * from mahalle where ilceID=@ilceID order by mahalleAdi asc", conn);
        //    comm.Parameters.AddWithValue("@ilceID", IlceID.Text);
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr = comm.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        //cMusteri m = new cMusteri();
        //        //m._ilceAd = dr["ilceAdi"].ToString();
        //        //m._ilceNo = Convert.ToInt32(dr["ilceID"]);


        //        //ilceler.Items.Add(m);
        //       mahalle.Items.Add(dr["mahalleAdi"].ToString());

        //    }
        //    dr.Close();
        //    conn.Close();


        //}
        //public void MahalleIDGetir(string mahalleAd, TextBox mahalleID)
        //{
        //    SqlConnection conn = new SqlConnection(cGenel.connStr);
        //    SqlCommand comm = new SqlCommand("select MhalleID from mahalle where mahalleAdi=@mahalleAdi", conn);
        //    comm.Parameters.AddWithValue("@mahalleAdi", mahalleAd);

        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    SqlDataReader dr = comm.ExecuteReader();

        //    while (dr.Read())
        //    {
        //       mahalleID.Text = Convert.ToString(dr["MhalleID"]);
        //    }
        //    dr.Close();
        //    conn.Close();
        //}

        public bool InsertMusteri(cMusteri m)
        {
           

            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("insert into musteri(tckn,ad,soyad,cinsiyet,dogumTarihi,cepTelefonu,evTelefonu,eposta,adresID) Values(@tckn,@ad,@soyad,@cinsiyet,@dogumTarihi,@cepTelefonu,@evTelefonu,@email,@adresID) ", conn);

            comm.Parameters.AddWithValue("@tckn", m._tckn);
            comm.Parameters.AddWithValue("@ad", m._ad);
            comm.Parameters.AddWithValue("@soyad", m._soyad);
            comm.Parameters.AddWithValue("@cinsiyet", m._cinsiyet);
            comm.Parameters.AddWithValue("@dogumTarihi", m._dogumTarih);
        
            comm.Parameters.AddWithValue("@cepTelefonu", m._ceptel);
            comm.Parameters.AddWithValue("@evTelefonu", m._evtel);
            comm.Parameters.AddWithValue("@email", m._email);
            comm.Parameters.AddWithValue("@adresID",m._adresID );

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();

            }

            return sonuc;
        }
        public bool MusteriSil(cMusteri m)
        {


            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update musteri set durum=0 where musteriID=@musteriID ", conn);

        
            comm.Parameters.AddWithValue("@musteriID", m._musteriID);

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();

            }

            return sonuc;
        }
        public bool MusteriDegistir(cMusteri m)
        {


            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update musteri set tckn=@tckn,ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,dogumTarihi=@dogumTarihi,cepTelefonu=@cepTelefonu,evTelefonu=@evTelefonu,eposta=@email,adresID=@adresID where musteriID=@musteriID", conn);

            comm.Parameters.AddWithValue("@tckn", m._tckn);
            comm.Parameters.AddWithValue("@ad", m._ad);
            comm.Parameters.AddWithValue("@soyad", m._soyad);
            comm.Parameters.AddWithValue("@cinsiyet", m._cinsiyet);
            comm.Parameters.AddWithValue("@dogumTarihi", m._dogumTarih);

            comm.Parameters.AddWithValue("@cepTelefonu", m._ceptel);
            comm.Parameters.AddWithValue("@evTelefonu", m._evtel);
            comm.Parameters.AddWithValue("@email", m._email);
            comm.Parameters.AddWithValue("@adresID", m._adresID);
            comm.Parameters.AddWithValue("@musteriID", m._musteriID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();

            }

            return sonuc;
        }
        ////public override string ToString()
        ////{
        ////    string deger = "";
        ////    switch (tutToString)
        ////    {   
        ////        case 1:
        ////           deger=_ilAd;
        ////        break;
        ////        case 2:

        ////        deger = _ilcead;
        ////        break;
        ////    }

        ////    return deger;
        ////}
        public void MusterileriGetirByAdaGore(TextBox AdaGore, ListView Musteriler)
        {
            Musteriler.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("SELECT musteri.*, sehir.ad+'/'+ilce.ad AS Adres FROM adres INNER JOIN ilce ON adres.ilceID = ilce.ilceID INNER JOIN mahalle ON adres.mahalleID = mahalle.mahalleID AND ilce.ilceID = mahalle.ilceID INNER JOIN sehir ON adres.sehirID = sehir.sehirID AND ilce.sehirID = sehir.sehirID INNER JOIN musteri ON adres.adresID = musteri.adresID where musteri.durum=1 and musteri.ad like @musteriad+'%'", conn);
            comm.Parameters.Add("@musteriad", SqlDbType.VarChar).Value = AdaGore.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    Musteriler.Items.Add(dr["tckn"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["ad"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["soyad"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["cinsiyet"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["cepTelefonu"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["evTelefonu"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["eposta"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["Adres"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["musteriID"].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

        }
        public void MusterileriGetirByTckNoGore(TextBox tckno, ListView Musteriler)
        {
            Musteriler.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("SELECT musteri.*, sehir.ad+'/'+ilce.ad AS Adres FROM adres INNER JOIN ilce ON adres.ilceID = ilce.ilceID INNER JOIN mahalle ON adres.mahalleID = mahalle.mahalleID AND ilce.ilceID = mahalle.ilceID INNER JOIN sehir ON adres.sehirID = sehir.sehirID AND ilce.sehirID = sehir.sehirID INNER JOIN musteri ON adres.adresID = musteri.adresID where musteri.durum=1 and musteri.tckn like @tckn+'%'", conn);
            comm.Parameters.Add("@tckn", SqlDbType.VarChar).Value = tckno.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    Musteriler.Items.Add(dr["tckn"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["ad"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["soyad"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["cinsiyet"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["cepTelefonu"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["evTelefonu"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["eposta"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["Adres"].ToString());
                    Musteriler.Items[i].SubItems.Add(dr["musteriID"].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

        }
       

    }
}

    

