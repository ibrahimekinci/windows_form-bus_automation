using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobus
{
    class cArac
    {
        cGenel gnl = new cGenel();
        #region members
        private int _otobusID;
        private string _saseNumarasi;
        private int _otobusModelID;
        private string _plaka;
        private DateTime _uretimYili;
        private int _otobusMarkaID;
        private string _markaAd;
        private string _modelAd;
        private int _koltukSayisi;
        
        #endregion
        #region properties
        public int KoltukSayisi
        {
            get { return _koltukSayisi; }
            set { _koltukSayisi = value; }
        }

        public string ModelAd
        {
            get { return _modelAd; }
            set { _modelAd = value; }
        }

        public string MarkaAd
        {
            get { return _markaAd; }
            set { _markaAd = value; }
        }

        public int OtobusMarkaID
        {
            get { return _otobusMarkaID; }
            set { _otobusMarkaID = value; }
        }

        public DateTime UretimYili
        {
            get { return _uretimYili; }
            set { _uretimYili = value; }
        }

        public string Plaka
        {
            get { return _plaka; }
            set { _plaka = value; }
        }

        public int OtobusModelID
        {
            get { return _otobusModelID; }
            set { _otobusModelID = value; }
        }

        public string SaseNumarasi
        {
            get { return _saseNumarasi; }
            set { _saseNumarasi = value; }
        }
        public int OtobusID
        {
            get { return _otobusID; }
            set { _otobusID = value; }
        } 
        #endregion

        public static int AtOtoID;
        public static string AtPlaka;

        public void AraclariGetir(ListView Araclar)
        {
            Araclar.Items.Clear();
         SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select otobusID,otobus.durum,saseNumarasi,otobusMarka.ad, otobusModel.ad,plaka,koltukSayisi from otobus  inner join otobusModel on otobusModel.otobusModelID=otobus.otobusModelID inner join otobusMarka on otobusMarka.otobusMarkaID = otobusModel.otobusMarkaID  where otobus.durum=1", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Araclar.Items.Add(Convert.ToString(dr[0]));
                Araclar.Items[i].SubItems.Add(Convert.ToString(dr[1]));
                Araclar.Items[i].SubItems.Add(Convert.ToString(dr[2]));
                Araclar.Items[i].SubItems.Add(Convert.ToString(dr[3]));
                Araclar.Items[i].SubItems.Add(Convert.ToString(dr[4]));
                Araclar.Items[i].SubItems.Add(Convert.ToString(dr[5]));
                Araclar.Items[i].SubItems.Add(Convert.ToString(dr[6]));
                i++;
            }
            dr.Close();
            conn.Close();
        }
        public void ModelleriGetir(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select ad from otobusModel where durum=1", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cArac a = new cArac();
                    a._modelAd = Convert.ToString(dr["ad"]);
                    liste.Items.Add(a);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public void AraclarıGetirByModel(ComboBox model, ListView Araclar)
        {
            Araclar.Items.Clear();
            string sql = "";
            sql = "select otobusID,otobus.durum,saseNumarasi,otobusMarka.ad, otobusModel.ad,plaka,koltukSayisi from otobus  inner join otobusModel on otobusModel.otobusModelID=otobus.otobusModelID inner join otobusMarka on otobusMarka.otobusMarkaID = otobusModel.otobusMarkaID  where otobus.durum=1 and otobusModel.ad=@modelAd";
            SqlConnection baglan = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand(sql, baglan);
            comm.Parameters.Add("@modelAd", SqlDbType.VarChar).Value = Convert.ToString(model.SelectedItem);
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            SqlDataReader dr;
            int i = 0;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Araclar.Items.Add(Convert.ToString(dr[0]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[1]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[2]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[3]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[4]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[5]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[6]));
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { baglan.Close(); }
        }
        public override string ToString()
        {
            return ModelAd;
        }

        public void AraclarıGetirByTarih(string tarih, ListView Araclar)
        {
            Araclar.Items.Clear();
            string sql = "";
            sql = "select otobusID,otobus.durum,saseNumarasi,otobusMarka.ad, otobusModel.ad,plaka,koltukSayisi from otobus  inner join otobusModel on otobusModel.otobusModelID=otobus.otobusModelID inner join otobusMarka on otobusMarka.otobusMarkaID = otobusModel.otobusMarkaID  where otobus.durum=1 and otobusID not in(select sefer.otobusID from sefer inner join otobus on otobus.otobusID=sefer.otobusID where Convert(varchar(20),sefer.kalkisTarihi,104) = Convert(varchar(20),@tarih,104)) and otobus.durum=1";
            SqlConnection baglan = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand(sql, baglan);
            comm.Parameters.AddWithValue("@tarih",Convert.ToDateTime(tarih));
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            SqlDataReader dr;
            int i = 0;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Araclar.Items.Add(Convert.ToString(dr[0]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[1]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[2]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[3]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[4]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[5]));
                    Araclar.Items[i].SubItems.Add(Convert.ToString(dr[6]));
                    i++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { baglan.Close(); }
        }

    }
}
