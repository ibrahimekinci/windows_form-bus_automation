using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otobus.otobuss
{
    class otobuss
    {
       #region members
        string _koltukNo;

        public string KoltukNo
        {
            get { return _koltukNo; }
            set { _koltukNo = value; }
        }
      
        string _cinsiyet;
        public string Cinsiyet
        {
          get { return _cinsiyet; }
          set { _cinsiyet = value; }
        } 
	#endregion
        public static int otobusTipi = 0;
        public int otobusTipiBul(int seferID)
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("select om.koltukSayisi from sefer s inner join otobus o on o.otobusID= s.otobusID inner join otobusModel om on om.otobusModelID =o.otobusModelID where s.seferID=@seferID", conn);
            comm.Parameters.AddWithValue("@seferID", seferID);
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                sonuc = Convert.ToInt32(comm.ExecuteScalar());//koltuk sayısını aldık
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            if (sonuc == 46)
                sonuc = 0;
            else if (sonuc == 54)
                sonuc = 1;
            return sonuc;
        }
    }
}
