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
    class cSube
    {
        cGenel gnl = new cGenel();

        private int _subeID;
        private string _Ad;
        private int _adresID;
        private DateTime _acilisTarihi;

        #region properties

        public DateTime AcilisTarihi
        {
            get { return _acilisTarihi; }
            set { _acilisTarihi = value; }
        }

        public int AdresID
        {
            get { return _adresID; }
            set { _adresID = value; }
        }

        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }

        public int SubeID
        {
            get { return _subeID; }
            set { _subeID = value; }
        } 
        #endregion


        public void SubeleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connStr);
            SqlCommand comm = new SqlCommand("Select * from sube ", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cSube s = new cSube();
                    s._Ad = Convert.ToString(dr["ad"]);
                    s._subeID = Convert.ToInt32(dr["subeID"]);
                    liste.Items.Add(s);
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
