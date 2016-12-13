using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otobus
{
    class cSefer
    {
        cGenel gnl = new cGenel();

          #region members

        private int _seferId;
        private int _otobusId;
        private DateTime _kalkisTarihi;
        private DateTime _varisTarihi;
        private int _guzergahID;
        private int _calisanId;
        #endregion
          #region Properties

        public int GuzergahID
        {
            get { return _guzergahID; }
            set { _guzergahID = value; }
        }
        public int CalisanId
        {
            get { return _calisanId; }
            set { _calisanId = value; }
        }
        public DateTime VarisTarihi
        {
            get { return _varisTarihi; }
            set { _varisTarihi = value; }
        }

        public DateTime KalkisTarihi
        {
            get { return _kalkisTarihi; }
            set { _kalkisTarihi = value; }
        }

        public int OtobusId
        {
            get { return _otobusId; }
            set { _otobusId = value; }
        }

        public int SeferId
        {
            get { return _seferId; }
            set { _seferId = value; }
        }
        #endregion



        public enum islemler : byte {  frmSeferListe_Detay=1, frmSeferListe_seferSil, frmSeferListe_SeferBilgileriDegistir, frmSefer_Detay, frmSefer_FrmSeferEkle, frmSefer_SeferBilgileriDegistir, frmSefer_SeferSil };
        public static int islem = 0;

               

        public void SeferleriGetir( ListView Seferler )
        {
            Seferler.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select seferID,sefer.guzergahID,guzergah.ad, kalkisTarihi,sefer.otobusID from sefer inner join otobus on otobus.otobusID = sefer.otobusID inner join guzergah on guzergah.guzergahID=sefer.guzergahID where sefer.durum=1", conn); // durum =1 sefer var demek 0 yok demek
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Seferler.Items.Add(Convert.ToString(dr[0]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[1]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[2]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[3]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[4]));
                i++;
            }
            dr.Close();
            conn.Close();
        }

        public void SeferleriGetirByGuzergah(string GuzergahAd, ListView Seferler)
        {
            Seferler.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select seferID,sefer.guzergahID,guzergah.ad, kalkisTarihi,sefer.otobusID from sefer inner join otobus on otobus.otobusID = sefer.otobusID inner join guzergah on guzergah.guzergahID=sefer.guzergahID where sefer.durum=1 and guzergah.ad like '%'+ @guzergah +'%' ", conn);
            comm.Parameters.Add("@guzergah", SqlDbType.VarChar).Value = GuzergahAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Seferler.Items.Add(Convert.ToString(dr[0]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[1]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[2]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[3]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[4]));         
                i++;
            }
            dr.Close();
            conn.Close();
        }

        public void SeferleriGetirByTariheGore(string Tarih1,string Tarih2,ListView Seferler)
        {
            Seferler.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select seferID,sefer.guzergahID,guzergah.ad, kalkisTarihi,sefer.otobusID from sefer inner join otobus on otobus.otobusID = sefer.otobusID inner join guzergah on guzergah.guzergahID=sefer.guzergahID  where Convert(varchar(20),sefer.kalkisTarihi,104) >=@Tarih1 and Convert(varchar(20),sefer.kalkisTarihi,104) <=@Tarih2 and sefer.durum =1", conn);
            comm.Parameters.AddWithValue("@Tarih1", Tarih1);
            comm.Parameters.AddWithValue("@Tarih2",Tarih2);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Seferler.Items.Add(Convert.ToString(dr[0]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[1]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[2]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[3]));
                Seferler.Items[i].SubItems.Add(Convert.ToString(dr[4])); 
                i++;
            }
            dr.Close();
            conn.Close();
        }

        public bool SeferEkle(cSefer s)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("insert into sefer(otobusID,kalkisTarihi,guzergahID) values(@otobusID,@kalkisTarihi,@guzergahID)", conn);
            comm.Parameters.Add("@OtobusId", SqlDbType.Int).Value = s._otobusId;
            comm.Parameters.Add("@kalkisTarihi", SqlDbType.DateTime).Value = s._kalkisTarihi;
            comm.Parameters.Add("@guzergahID", SqlDbType.Int).Value = s._guzergahID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
                //if (sonuc)
                //{              
                    //sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
                    //for (int i = 0; i < lvCalisanlar.Items.Count - 1; i++)
                    //{
                    //    s._calisanId = Convert.ToInt32(lvCalisanlar.Items[i].SubItems[0].Text);
                    //    sonuc = SeferCalisanIDEkle(s._seferId, s._calisanId);
                    //    if (!sonuc) break;
                    //}
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool SeferCalisanIDEkle(int SeferId, int CalisanId)
        {
            bool sonuc = true;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("insert into seferCalisan(seferID,calisanID) values(@seferId,@calisanID);Select Scope_IDENTITY()", conn);
            comm.Parameters.AddWithValue("@seferID",SeferId);
            comm.Parameters.AddWithValue("@calisanID",CalisanId);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());     
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                sonuc = false;
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        } 

        public bool SeferSil(int SeferNo)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update sefer set durum=0 where seferID=@seferID ",conn);
            comm.Parameters.Add("@seferID",SqlDbType.Int).Value = SeferNo;
            if(conn.State == ConnectionState.Closed) conn.Open();
            try 
            {	        
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally {conn.Close();}
            return sonuc;
        }

        public bool SeferCalisanSil(int SeferNo)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("delete from seferCalisan where seferCalisan.seferID = @seferID", conn);
            comm.Parameters.Add("@seferID", SqlDbType.Int).Value = SeferNo;
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

        public bool SeferGuncelle(cSefer s)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("update sefer set kalkisTarihi=@kalkisTarihi,  otobusID=@otobusID, guzergahID=@guzergahID where seferID=@seferID ", conn);
            comm.Parameters.Add("@seferID", SqlDbType.Int).Value = s._seferId;
            comm.Parameters.Add("@OtobusId", SqlDbType.Int).Value = s._otobusId;
            comm.Parameters.Add("@kalkisTarihi", SqlDbType.DateTime).Value = s._kalkisTarihi;
            comm.Parameters.Add("@guzergahID", SqlDbType.Int).Value = s._guzergahID;
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
            SqlCommand comm = new SqlCommand("select seferID from sefer", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ID = Convert.ToInt32(dr["seferID"]) + 1;
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
    }
}
