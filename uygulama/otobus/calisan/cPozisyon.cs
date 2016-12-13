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
    class cPozisyon
    {
        cGenel cGen = new cGenel();

        
        private int _calisanPozisyonID;
        private string _ad;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public int CalisanPozisyonID
        {
            get { return _calisanPozisyonID; }
            set { _calisanPozisyonID = value; }
        }

        

        public void PoziyonlariGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from calisanPozisyon order by calisanPozisyonID asc", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cPozisyon p = new cPozisyon();
                    p._calisanPozisyonID = Convert.ToInt32(dr[0]);
                    p._ad = Convert.ToString(dr[1]);
                    liste.Items.Add(p);
                }
                dr.Close();
                conn.Close();
      
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }


        public override string ToString()
        {
            return Ad;
        }
    }
}
