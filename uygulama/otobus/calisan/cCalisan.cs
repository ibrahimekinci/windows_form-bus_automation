using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace otobus
{
    class cCalisan
    {
        cGenel cGen = new cGenel();
        //public static int IDyiAt;
        
        #region members
        private int _calisanID;
        private int _calisanPozisyonID;
        private int _subeID;
        private string _ad;
        private string _soyad;
        private string _cinsiyet;
        private DateTime _dogumTarihi;
        private string _ehliyetSinifi;
        private DateTime _ehliyetAlisTarihi;
        private string _telefon;
        private string _mail;
        private int _adresID;
        private DateTime _girisTarihi;
        private DateTime _cikisTarihi;
        private decimal _maas;
        private string _sehir;
        private string _calisanTCKNO;
        private string _kadi;
        private string _sifre;
        private int _calisanKullanici;


        #endregion
        #region Properties
        public int CalisanKullanici
        {
            get { return _calisanKullanici; }
            set { _calisanKullanici = value; }
        }
        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }

        public string Kadi
        {
            get { return _kadi; }
            set { _kadi = value; }
        }
        public string CalisanTCKNO
        {
            get { return _calisanTCKNO; }
            set { _calisanTCKNO = value; }
        }
        public string Sehir
        {
            get { return _sehir; }
            set { _sehir = value; }
        }
        public decimal Maas
        {
            get { return _maas; }
            set { _maas = value; }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public DateTime CikisTarihi
        {
            get { return _cikisTarihi; }
            set { _cikisTarihi = value; }
        }

        public DateTime GirisTarihi
        {
            get { return _girisTarihi; }
            set { _girisTarihi = value; }
        }

        public int AdresID
        {
            get { return _adresID; }
            set { _adresID = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public DateTime EhliyetAlisTarihi
        {
            get { return _ehliyetAlisTarihi; }
            set { _ehliyetAlisTarihi = value; }
        }

        public string EhliyetSinifi
        {
            get { return _ehliyetSinifi; }
            set { _ehliyetSinifi = value; }
        }

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public int SubeID
        {
            get { return _subeID; }
            set { _subeID = value; }
        }

        public int CalisanPozisyonID
        {
            get { return _calisanPozisyonID; }
            set { _calisanPozisyonID = value; }
        }

        public int CalisanID
        {
            get { return _calisanID; }
            set { _calisanID = value; }
        }
        #endregion

        public static int AtSeferCalisanID;
        public enum islemler : byte { frmCalisanListe_Detay=1, frmCalisanListe_CalisanSil, frmCalisanListe_CalisanBilgileriDegistir, frmCalisan_Detay, frmCalisan_CalisanEkle, frmCalisan_CalisanBilgileriDegistir, frmCalisan_CalisanSil, frmCalisan_Profil,frmCalisanListe_SeferCalisanEkle };
        public static int islem = 0;

        DataTable dt = new DataTable();


        public DataTable Calisanlistele(string tarih)  // sefer için eleman seçme
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlDataAdapter da = new SqlDataAdapter("select calisanID ID,c.ad Ad,soyad Soyad,cp.ad Pozisyon from calisan c inner join calisanPozisyon cp on c.calisanPozisyonID=cp.calisanPozisyonID where (cp.calisanPozisyonID='4' or cp.calisanPozisyonID='5') and  calisanID not in(select sc.calisanID from seferCalisan sc inner join sefer s on s.seferID = sc.seferID where Convert(varchar(20),s.kalkisTarihi,104) = Convert(varchar(20),@tarih,104)) and durum=1", conn);
            dt.Rows.Clear();
            try
            {
                da.SelectCommand.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih));
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string sqlHata = Convert.ToString(ex);
            }
            return dt;
        }
        public DataTable listeleBySorgu(string sqlSorgu, string aranan)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlDataAdapter da = new SqlDataAdapter(sqlSorgu, conn);
            dt.Rows.Clear();
            try
            {
                da.SelectCommand.Parameters.Add("@aranan", SqlDbType.NVarChar).Value = aranan;
                da.Fill(dt);   
            }
             
            catch (SqlException ex)
            {
                string sqlHata = Convert.ToString(ex);
            }
            return dt;
        }
        public DataTable calisanListeByAd(string aranan)
        {
            string sqlSorgu = "select calisanID as ID,calisanTCKNO 'Kimlik No',calisanPozisyon.ad as Pozisyon ,calisan.ad as Ad,calisan.soyad as Soyad,cinsiyet as Cinsiyet from calisan inner join calisanPozisyon on calisanPozisyon.calisanPozisyonID = calisan.calisanPozisyonID where durum=1  and calisan.ad like '%'+@aranan+'%'";

            return listeleBySorgu(sqlSorgu, aranan);
        }
        public DataTable calisanListeByTCKNO(string aranan)
        {
            string sqlSorgu = "select calisanID as ID,calisanTCKNO 'Kimlik No',calisanPozisyon.ad as Pozisyon ,calisan.ad as Ad,calisan.soyad as Soyad,cinsiyet as Cinsiyet  from calisan inner join calisanPozisyon on calisanPozisyon.calisanPozisyonID = calisan.calisanPozisyonID where durum=1   and calisan.calisanTCKNO like '%'+@aranan+'%'";
            return listeleBySorgu(sqlSorgu, aranan);
        }
        public DataTable calisanListeByPozisyon(string aranan)
        {
            string sqlSorgu = "select calisanID as ID,calisanTCKNO 'Kimlik No',calisanPozisyon.ad as Pozisyon ,calisan.ad as Ad,calisan.soyad as Soyad,cinsiyet as Cinsiyet  from calisan inner join calisanPozisyon on calisanPozisyon.calisanPozisyonID = calisan.calisanPozisyonID where durum=1  and calisanPozisyon.ad like '%'+@aranan+'%' ";
            return listeleBySorgu(sqlSorgu, aranan);
        }
        public bool CalisanSil(int CalisanID)
        {
            bool sonuc = false;
             SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update calisan set durum=0,cikisTarihi=@cikisTarihi  where calisanID=@calisanID ", conn);
            comm.Parameters.Add("@calisanID", SqlDbType.Int).Value = CalisanID;
            comm.Parameters.Add("@cikisTarihi", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString();
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool CalisanEkle(cCalisan c)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("insert into calisan(calisanPozisyonID,calisanTCKNO,subeID,ad,soyad,cinsiyet,dogumTarihi,ehliyetSinifi,ehliyetAlisTarihi,telefon,mail,adresID,girisTarihi,maas) values(@calisanPozisyonID,@calisanTCKNO,@subeID,@ad,@soyad,@cinsiyet,@dogumTarihi,@ehliyetSinifi,@ehliyetAlisTarihi,@telefon,@mail,@adresID,@girisTarihi,@maas) ", conn);
            comm.Parameters.Add("@calisanPozisyonID", SqlDbType.Int).Value = c._calisanPozisyonID;
            comm.Parameters.Add("@calisanTCKNO", SqlDbType.VarChar).Value = c._calisanTCKNO;
            comm.Parameters.Add("@subeID", SqlDbType.Int).Value = c._subeID;
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = c._ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = c._soyad;
            comm.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = c._cinsiyet;
            comm.Parameters.Add("@dogumTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(c._dogumTarihi);
            comm.Parameters.Add("@ehliyetSinifi", SqlDbType.VarChar).Value = c._ehliyetSinifi;
            comm.Parameters.Add("@ehliyetAlisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(c._ehliyetAlisTarihi);
            comm.Parameters.Add("@telefon", SqlDbType.VarChar).Value = c._telefon;
            comm.Parameters.Add("@mail", SqlDbType.VarChar).Value = c._mail;
            comm.Parameters.Add("@adresID", SqlDbType.Int).Value = c._adresID;
            comm.Parameters.Add("@girisTarihi", SqlDbType.DateTime).Value =Convert.ToDateTime(c._girisTarihi);
            comm.Parameters.Add("@maas", SqlDbType.Decimal).Value = c._maas;
            if (conn.State == ConnectionState.Closed) conn.Open();   
            try 
	        {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
	        }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool InsertKullanici(cCalisan c)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("insert into calisanKullanici(calisanID,kadi,sifre) values(@calisanID,@kadi,@sifre);Select Scope_IDENTITY()", conn);
            comm.Parameters.AddWithValue("@calisanID", c._calisanID);
            comm.Parameters.AddWithValue("@kadi", c._kadi);
            comm.Parameters.AddWithValue("@sifre", c._sifre);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }   
        public bool CalisanBilgileriGuncelle(cCalisan c)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update calisan set calisanPozisyonID=@calisanPozisyonID,subeID=@subeID,ehliyetSinifi=@ehliyetSinifi,ehliyetAlisTarihi=@ehliyetAlisTarihi,telefon=@telefon,mail=@mail,adresID=@adresID,maas=@maas where calisanID=@calisanID", conn);
            comm.Parameters.Add("@calisanID", SqlDbType.Int).Value = c._calisanID;
            comm.Parameters.Add("@calisanPozisyonID", SqlDbType.Int).Value = c._calisanPozisyonID;
            comm.Parameters.Add("@subeID", SqlDbType.Int).Value = c._subeID;
            comm.Parameters.Add("@ehliyetSinifi", SqlDbType.VarChar).Value = c._ehliyetSinifi;
            comm.Parameters.Add("@ehliyetAlisTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(c._ehliyetAlisTarihi);
            comm.Parameters.Add("@telefon", SqlDbType.VarChar).Value = c._telefon;
            comm.Parameters.Add("@mail", SqlDbType.VarChar).Value = c._mail;
            comm.Parameters.Add("@adresID", SqlDbType.Int).Value = c._adresID;
            comm.Parameters.Add("@maas", SqlDbType.Decimal).Value = c._maas;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool UpdateKullanici(cCalisan c)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update calisanKullanici set calisanID=@calisanID,kadi=@kadi,sifre=@sifre where calisanKullanici=@calisanKullanici", conn);
            comm.Parameters.AddWithValue("@calisanKullanici",c._calisanKullanici);
            comm.Parameters.AddWithValue("@calisanID", c._calisanID);
            comm.Parameters.AddWithValue("@kadi", c._kadi);
            comm.Parameters.AddWithValue("@sifre", c._sifre);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public bool KullaniciSil(int CalisanID)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update calisanKullanici set durum=0 where calisanID=@calisanID ", conn);
            comm.Parameters.Add("@calisanID", SqlDbType.Int).Value = CalisanID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }
        public int SonIDBul()
        {           
            int ID = 0;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select calisanID from calisan", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read()) 
                {
                    ID = Convert.ToInt32(dr["calisanID"]) + 1;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally {conn.Close();}
            return ID;
        }
        public int SonKullaniciIDBul()
        {
            int ID = 0;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select calisanKullanici from calisanKullanici", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ID = Convert.ToInt32(dr["calisanKullanici"]) + 1;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return ID;
        }

        public bool BeniHatırlaUserKaydet(cCalisan c)
        {
            StreamWriter UserEkle = new StreamWriter("SifreKartlari.txt", true);
            UserEkle.WriteLine(c._kadi.ToString());
            UserEkle.Close();
            return true;
        }








    }
}
