using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otobus
{
    class cGuzergah
    {
        public static int tutGuzergahID = -1;
        public static string tutGuzergahAd;
        //Guzergah
        int _guzergahID;
        string _guzergahAd;
        string _guzergahAciklama;  
        string _guzergahEklenmeTarihi; 
        int _subeID;
        int _guzergahDurakKilometre;
        int _molaTesisID;
         #region members
 public int GuzergahID
 {
     get { return _guzergahID; }
     set { _guzergahID = value; }
 }
 public string GuzergahAd
 {
     get { return _guzergahAd; }
     set { _guzergahAd = value; }
 }
 public string GuzergahAciklama
 {
     get { return _guzergahAciklama; }
     set { _guzergahAciklama = value; }
 }
 public string GuzergahEklenmeTarihi
 {
     get { return _guzergahEklenmeTarihi; }
     set { _guzergahEklenmeTarihi = value; }
 }
 //GuzergahDurak
 public int GuzergahDurakSubeID
 {
     get { return _subeID; }
     set { _subeID = value; }
 }
 //MolaTesisi
 public int MolaTesisID
 {
     get { return _molaTesisID; }
     set { _molaTesisID = value; }
 }
 
 #endregion
        public enum islemler : byte { frmGuzergah_GuzergahEkle = 1, frmGuzergah_GuzergahDegistir, frmGuzergahDetay_GuzergahSil, frmGuzergahDetay_GuzergahDetay,frmGuzergahListe_GuzergahDetay, frmGuzergahListe_GuzergahDegistir, frmGuzergahListe_GuzergahSil,frmGuzergahListe_SefereGuzergahEkle };
        public static int islem = 0;
            //ortak     ///////////////////////////////////////////////////////////////////////////////////////////////////
            public DataTable listeleBySorgu(string sqlSorgu, string aranan)
            {
                SqlConnection conn = new SqlConnection(cGenel.connStr); 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlSorgu, conn);
                try
                {
                    da.SelectCommand.Parameters.Add("@aranan", SqlDbType.NVarChar).Value = aranan;
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    da.Fill(dt);

                    conn.Close();
                }
                catch (SqlException ex)
                {
                    string sqlHata = Convert.ToString(ex);
                }
                return dt;
            }

            public string guzergahAdGetirByGuzergahID()
            {
                string guzergahAd="";
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                SqlCommand cmd = conn.CreateCommand();
                string sqlSorgu = "select ad from guzergah where guzergahID=@guzergahID";
                cmd.CommandText = sqlSorgu;
                cmd.Parameters.AddWithValue("@guzergahID", tutGuzergahID);
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    guzergahAd = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    string sqlhata = Convert.ToString(ex);
                }
                finally { conn.Close(); }
                return guzergahAd;
            }
            //frmguzergah     ////////////////////////////////////////////////////////////////////////////////////////////
            public DataTable guzergahSubeGetirBySehir(ListView lv, string sehirAd)
            {
                string sqlSorgu = "select s.subeID, s.ad 'Şube Adı', se.ad 'Şehir Adı'  from sube s inner join adres a on  a.adresID = s.adresID inner join sehir se on se.sehirID = a.sehirID where se.ad like @aranan+'%' ";
                for (int i = 0; i < lv.Items.Count; i++)
                {
                    sqlSorgu += " and s.subeID !=" + lv.Items[i].SubItems[0].Text;
                }
                return listeleBySorgu(sqlSorgu, sehirAd);
            }
            public DataTable guzergahMolaTesisiGetirBySehir(ListView lvsube,ListView lvMolaTesisi, string sehirAd)
            {
                string sqlSorgu = "select mt.molaTesisID 'MolaTesisID', mt.ad 'Tesis Adı', se.ad 'Şehir Adı' from molaTesis mt inner join adres a on  a.adresID = mt.adresID inner join sehir se on se.sehirID = a.sehirID where se.ad like @aranan+'%' ";
                        for (int i = 0; i < lvMolaTesisi.Items.Count; i++)
                        {
                            sqlSorgu += " and mt.molaTesisID !=" + lvMolaTesisi.Items[i].SubItems[0].Text;
                          
                        }
                        if (lvsube.Items.Count>2)
                        {
                            sqlSorgu += " and (se.ad ='" + lvsube.Items[1].SubItems[2].Text.ToUpper() + "'";
                          
                            for (int i = 2; i < lvsube.Items.Count-1; i++)
                            {
                              sqlSorgu += " or se.ad ='" + lvsube.Items[i].SubItems[2].Text.ToUpper() + "'";
                            }
                            sqlSorgu += ")";
                        }
                return listeleBySorgu(sqlSorgu, sehirAd);
            }

            public bool guzergahEkle(cGuzergah c,ListView lvSube,ListView lvMolaTesisi)
            {
                bool sonuc = true;
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                //SqlTransaction tran = new SqlTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into guzergah (ad,aciklama) values (@guzergahAd,@guzergahAciklama);Select Scope_IDENTITY()";
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    //tran = conn.BeginTransaction();
                    cmd.Parameters.AddWithValue("@guzergahAd", c._guzergahAd);
                    cmd.Parameters.AddWithValue("@guzergahAciklama", c._guzergahAciklama);
                    c._guzergahID = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (sonuc)
                    {
                        for (int i = 0; i < lvSube.Items.Count - 1; i++)
                        {
                            c._subeID = Convert.ToInt32(lvSube.Items[i].SubItems[0].Text);
                            c._guzergahDurakKilometre = Convert.ToInt32(lvSube.Items[i].SubItems[3].Text);
                            sonuc = guzergahDurakEkle(c._guzergahID, c._subeID, i, c._guzergahDurakKilometre);
                            if (!sonuc) break;
                        }
                        if (sonuc)
                        {
                            for (int i = 0; i < lvMolaTesisi.Items.Count - 1; i++)
                            {
                                c._molaTesisID = Convert.ToInt32(lvSube.Items[i].SubItems[0].Text);
                                sonuc = guzergahMolaTesisiEkle(c._guzergahID, c._molaTesisID);
                                if (!sonuc) break;
                            }
                        }
                    }
                    //if (sonuc) tran.Commit();
                    //else tran.Rollback();
                }
                catch (SqlException ex)
                {
                    string sqlhata  = Convert.ToString(ex);
                    sonuc = false;
                    //tran.Rollback();
                }
                finally
                {
                    conn.Close();
                }
                return sonuc;
            }
           bool guzergahDurakEkle(int guzergahID, int subeID,int sira,int kilometre)
            {
                bool sonuc = true;
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into guzergahDurak (guzergahID,subeID,sira,kilometre) values (@guzergahID,@subeID,@sira,@kilometre);";
                cmd.Parameters.AddWithValue("@guzergahID", guzergahID);
                cmd.Parameters.AddWithValue("@subeID", subeID);
                cmd.Parameters.AddWithValue("@sira", sira);
                cmd.Parameters.AddWithValue("@kilometre", kilometre);
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    sonuc =Convert.ToBoolean(cmd.ExecuteNonQuery());

                }
                catch (SqlException ex)
                {
                 string   sqlhata = Convert.ToString(ex);
                    sonuc = false;
                }
                     finally
                {
                    conn.Close();
                }
                return sonuc;
            }
            bool guzergahMolaTesisiEkle(int guzergahID, int molaTesisID)
            {
                bool sonuc = true;
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into guzergahMola(guzergahID,molaTesisID) values (@guzergahID,@molaTesisID);";
                cmd.Parameters.AddWithValue("@guzergahID", guzergahID);
                cmd.Parameters.AddWithValue("@molaTesisID", molaTesisID);
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
                catch (SqlException ex)
                {
                    string sqlhata = Convert.ToString(ex);
                    sonuc = false;
                }
                finally
                {
                    conn.Close();
                }
                return sonuc;
            }
            //guzergahUpdate
            public string[] guzergahAdAndAciklamGetirByGuzergahID()
            {
                string[] tut = new string[2];
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                SqlCommand cmd = conn.CreateCommand();
                string sqlSorgu = "select ad,aciklama from guzergah where guzergahID=@guzergahID";
                cmd.CommandText = sqlSorgu;
                cmd.Parameters.AddWithValue("@guzergahID", tutGuzergahID);
                SqlDataReader dr;
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    { 
                    tut[0] = Convert.ToString(dr[0]);
                    tut[1] = Convert.ToString(dr[1]);
                    }
                }
                catch (SqlException ex)
                {
                    string sqlhata = Convert.ToString(ex);
                }
                finally { conn.Close(); }
                return tut;
            }
            public bool guzergahUpdateBilgileriniGetir(ListView lvGuzergahDurak,ListView lvGuzergahMola)
            {
                bool sonuc=true;
                sonuc=guzergahUpdateGetirDurakSube(lvGuzergahDurak);
                if (sonuc)
                {
                    sonuc = guzergahUpdateGetirMolaTesisi(lvGuzergahMola);
                    if(!sonuc) MessageBox.Show("Mola Tesisleri çekilirken hata meydana geldi");
                }
                else MessageBox.Show("Guzergah Durakları çekilirken hata meydana geldi");
                return sonuc;
            }
            bool guzergahUpdateGetirDurakSube(ListView lvGuzergahDurak)
            {
                bool sonuc = true;
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                string sqlSorgu = "select s.subeID,s.ad,se.ad,gd.kilometre from guzergahDurak gd  inner join sube s on s.subeID =gd.subeID inner join adres a on a.adresID= s.adresID inner join sehir se on se.sehirID=a.sehirID where gd.guzergahID=@guzergahID order by gd.sira";
                SqlCommand cmd = new SqlCommand(sqlSorgu, conn);
                cmd.Parameters.AddWithValue("@guzergahID", tutGuzergahID);
                SqlDataReader dr;
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    dr = cmd.ExecuteReader();
                    int satir = 0;
                    while (dr.Read())
                    {
                        lvGuzergahDurak.Items.Add(Convert.ToString(dr[0]));
                        for (int i = 1; i < lvGuzergahDurak.Columns.Count; i++)
                        {
                            lvGuzergahDurak.Items[satir].SubItems.Add(Convert.ToString(dr[i]));
                           
                        }
                        satir++;
                    }
                }
                catch (SqlException ex)
                {
                    string hata = Convert.ToString(ex);
                    sonuc = false;
                }
                finally { conn.Close(); }
                return sonuc;
            }
            bool guzergahUpdateGetirMolaTesisi(ListView lvGuzergahMola)
            {
                bool sonuc = true;
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                string sqlSorgu = "select mt.MolaTesisID,mt.ad,se.ad from guzergahMola gm inner join molaTesis mt on mt.molaTesisID= gm.molaTesisID inner join adres a on a.adresID = mt.adresID inner join sehir se on se.sehirID = a.sehirID where gm.guzergahID=@guzergahID";
                SqlCommand cmd = new SqlCommand(sqlSorgu, conn);
                cmd.Parameters.AddWithValue("@guzergahID", tutGuzergahID);
                SqlDataReader dr;
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    dr = cmd.ExecuteReader();
                    int satir = 0;
                    while (dr.Read())
                    {
                        lvGuzergahMola.Items.Add(Convert.ToString(dr[0]));
                        for (int i = 1; i < lvGuzergahMola.Columns.Count; i++)
                        {
                            lvGuzergahMola.Items[satir].SubItems.Add(Convert.ToString(dr[i]));
                             }
                        satir++;
                    }
                }
                catch (SqlException ex)
                {
                    string hata = Convert.ToString(ex);
                    sonuc = false;
                }
                finally { conn.Close(); }
                return sonuc;
            }
            public bool guzergahUpdate(cGuzergah c, ListView lvSube, ListView lvMolaTesisi)
            {
                bool sonuc = true;
                c._guzergahID = tutGuzergahID;
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guzergahUpdate";
                cmd.Parameters.Add("@guzergahID", SqlDbType.Int).Value=tutGuzergahID;
                cmd.Parameters.Add("@guzergahAd", SqlDbType.NVarChar).Value = c._guzergahAd;
                cmd.Parameters.Add("@guzergahAciklama", SqlDbType.NVarChar).Value = c._guzergahAciklama;
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                   sonuc = Convert.ToBoolean( cmd.ExecuteNonQuery());
                   conn.Close();
                   if (sonuc)
                   {
                       for (int i = 0; i < lvSube.Items.Count - 1; i++)
                       {
                           c._subeID = Convert.ToInt32(lvSube.Items[i].SubItems[0].Text);
                           c._guzergahDurakKilometre = Convert.ToInt32(lvSube.Items[i].SubItems[3].Text);
                           sonuc = guzergahDurakEkle(c._guzergahID, c._subeID, i, c._guzergahDurakKilometre);
                           if (!sonuc) break;
                       }
                       if (sonuc)
                       {
                           for (int i = 0; i < lvMolaTesisi.Items.Count - 1; i++)
                           {
                               c._molaTesisID = Convert.ToInt32(lvSube.Items[i].SubItems[0].Text);
                               sonuc = guzergahMolaTesisiEkle(c._guzergahID, c._molaTesisID);
                               if (!sonuc) break;
                           }
                       }
                   }
                }
                catch (SqlException ex)
                {
                    string hata = Convert.ToString(ex);
                    sonuc = false;
                }
                finally { conn.Close(); }
                return sonuc;
            }
            ////frmguzergahdetay////////////////////////////////////////////////////////////////////////////////////////
           
            public DataTable guzergahDetayDurak(bool yon)
            {
                //1 gidiş 0 dönüş
                string sqlSorgu = "select gd.guzergahDurakID 'Durak ID',se.ad 'Sehir',s.ad 'Durak Ad',gd.kilometre 'Durak Arası Mesafe(km)',gd.sira 'Sıra' from guzergah g inner join guzergahDurak gd on g.guzergahID = gd.guzergahID inner join sube s on s.subeID = gd.SubeID inner join adres a on a.adresID= s.adresID inner join sehir se on a.sehirID = se.sehirID where  gd.guzergahID=@aranan order by gd.sira " ;
                if (!yon) sqlSorgu += "desc";
                return listeleBySorgu(sqlSorgu,Convert.ToString(tutGuzergahID));
            }

            public DataTable guzergahDetayMola()
            {
             
                string sqlSorgu = "select gm.guzergahMolaID 'Guzergah Mola ID',mt.ad 'Tesis Adı', se.ad 'Sehir Adı' from guzergahMola gm inner join molaTesis mt on mt.molaTesisID =gm.molaTesisID inner join adres a on a.adresID =mt.adresID inner join sehir se on se.sehirID = a.sehirID where gm.guzergahID =@aranan order by se.sehirID ";
              
                return listeleBySorgu(sqlSorgu, Convert.ToString(tutGuzergahID));
            }
            public DataTable guzergahDetayDurakDetay(string durakID)
            {
                string sqlSorgu = "select s.subeID 'ID', s.ad 'sube',se.ad 'sehir',i.ad 'ilce',m.ad 'mahalle' from guzergahDurak gd inner join sube s on s.subeID = gd.subeID inner join adres a on a.adresID = s.adresID inner join sehir se on se.sehirID = a.sehirID inner join ilce i on i.ilceID =a.ilceID inner join mahalle m on m.mahalleID = a.mahalleID where gd.guzergahDurakID=@aranan";
                return listeleBySorgu(sqlSorgu, durakID);
            }
          public bool guzergahDetayGuzergahSil()
            {
                //1 gidiş 0 dönüş
                bool sonuc = true;
                string sqlSorgu = "delete from guzergah where guzergahID=@guzergahID";
                SqlConnection conn = new SqlConnection(cGenel.connStr);
                SqlCommand cmd = new SqlCommand(sqlSorgu,conn);

                try
                {
                    cmd.Parameters.Add("@guzergahID", SqlDbType.Int).Value = tutGuzergahID;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

                }
                catch (SqlException ex)
                {
                    string hata = Convert.ToString(ex);
                    sonuc = false;
                }
                finally
                {
                    conn.Close();
                }
                return sonuc;

            }
            //frmguzergahListele ///////////////////////////////////////////////////////////////////////////////////////
            public DataTable guzergahListeByGuzergahID(string aranan)
            {
                string sqlSorgu = "select g.guzergahID 'Guzergah ID',g.ad 'Guzergah Ad',g.aciklama 'Açıklama',g.EklenmeTarihi 'Eklenme Tarihi',Count(gb.guzergahID) 'Durak Sayısı'  from guzergahDurak gb inner join guzergah g on g.guzergahID =gb.guzergahID  where g.durum =1 and g.guzergahID like @aranan+'%' group by g.guzergahID,g.ad,g.aciklama,g.EklenmeTarihi  order by 'Guzergah Ad'";
                return listeleBySorgu(sqlSorgu, aranan);
            }
            public DataTable guzergahListeByGuzergahAd(string aranan)
            {
               
                string sqlSorgu = "select g.guzergahID 'Guzergah ID',g.ad 'Guzergah Ad',g.aciklama 'Açıklama',g.EklenmeTarihi 'Eklenme Tarihi',Count(gb.guzergahID) 'Durak Sayısı'  from guzergahDurak gb inner join guzergah g on g.guzergahID =gb.guzergahID  where g.durum =1 and g.ad like @aranan+'%' group by g.guzergahID,g.ad,g.aciklama,g.EklenmeTarihi  order by 'Guzergah Ad'";
                return listeleBySorgu(sqlSorgu, aranan);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
