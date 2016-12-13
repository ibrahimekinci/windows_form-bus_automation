using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otobus
{
    class cAdres
    {
        int _sehirID, _adresID;

        public int AdresID
        {
            get { return _adresID; }
            set { _adresID = value; }
        }
        string _sehirAd, _aciklama;

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        int _ilceID;
        string _ilceAd;
        int _mahalleID;
        string _mahalleAd;

       
        #region members
        public int IlceID
        {
            get { return _ilceID; }
            set { _ilceID = value; }
        }
        public int MahalleID
        {
            get { return _mahalleID; }
            set { _mahalleID = value; }
        }
        public string IlceAd
        {
            get { return _ilceAd; }
            set { _ilceAd = value; }
        }
        public string MahalleAd
        {
            get { return _mahalleAd; }
            set { _mahalleAd = value; }
        }
          public int SehirID
        {
            get { return _sehirID; }
            set { _sehirID = value; }
        }
        public string SehirAd
        {
            get { return _sehirAd; }
            set { _sehirAd = value; }
        }
      
        #endregion
        public  enum islemler : byte {sehir=1,ilce,mahalle};
        public static int islem = 0;
        public override string ToString()
        {
            string sonuc="";
            switch (islem)
            {
                case 0:
                 sonuc=base.ToString();
                    break;
                case 1:
                sonuc= _sehirAd;
                    break;

                case 2:
                    sonuc = _ilceAd;
                    break;

                case 3:
                    sonuc = _mahalleAd;
                    break;
            }
            return sonuc;
        }
       
        public void sehirGetir(ComboBox iller)
        {
            islem = Convert.ToInt32(cAdres.islemler.sehir);
            iller.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select * from sehir order by ad asc", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cAdres a = new cAdres();
                a._sehirAd = Convert.ToString(dr["ad"]);
                a._sehirID = Convert.ToInt32(dr["sehirID"]);
                iller.Items.Add(a);
            }
            dr.Close();
            conn.Close();
            islem = 0;
        }
        public void ilceGetir(ComboBox ilce, int SehirID)
        {
            islem = Convert.ToInt32(cAdres.islemler.ilce);
            ilce.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select * from ilce where sehirID=@sehirID order by ad asc", conn);
            comm.Parameters.AddWithValue("@sehirID", SehirID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cAdres a = new cAdres();
                a._ilceAd = Convert.ToString(dr["ad"]);
                a._ilceID = Convert.ToInt32(dr["ilceID"]);
                ilce.Items.Add(a);
            }
            dr.Close();
            conn.Close();
            islem = 0;
        }
        public void mahalleGetir(ComboBox mahalle, int ilceID)
        {
            islem = Convert.ToInt32(cAdres.islemler.mahalle);
            mahalle.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select * from mahalle where ilceID=@ilceID order by ad asc", conn);
            comm.Parameters.AddWithValue("@ilceID", ilceID);

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cAdres a = new cAdres();
                a._mahalleAd = Convert.ToString(dr["ad"]);
                a._mahalleID = Convert.ToInt32(dr["mahalleID"]);
                mahalle.Items.Add(a);
            }
            dr.Close();
            conn.Close();
            islem = 0;
        }
        public int InsertAdres(cAdres a)
        {
            int adresID = 0;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("insert into adres(sehirID,ilceID,mahalleID,aciklama) Values(@sehirID,@ilceID,@mahalleID,@aciklama);Select Scope_IDENTITY() ", conn);
            comm.Parameters.AddWithValue("@sehirID", a._sehirID);
            comm.Parameters.AddWithValue("@ilceID", a._ilceID);
            comm.Parameters.AddWithValue("@mahalleID", a._mahalleID);
            comm.Parameters.AddWithValue("@aciklama",a._aciklama );
            

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                adresID = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();

            }

            return adresID;
        }
        public bool UpdateAdres(cAdres a)
        {
            bool sonuc = false;

       
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update adres set sehirID=@sehirID,ilceID=@ilceID,mahalleID=@mahalleID,aciklama=@aciklama where adresID=@adresID", conn);
            comm.Parameters.AddWithValue("@sehirID", a._sehirID);
            comm.Parameters.AddWithValue("@ilceID", a._ilceID);
            comm.Parameters.AddWithValue("@mahalleID", a._mahalleID);
            comm.Parameters.AddWithValue("@aciklama", a._aciklama);
            comm.Parameters.AddWithValue("@adresID", a._adresID);

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

    }
}
