using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otobus
{
    class cKullanici
    {
        public enum islemler : byte { frmKullaniciListe_KullaniciSorgula = 1, frmKullaniciListe_Detay, frmKullaniciListe_KullaniciSil, frmKullaniciListe_KullaniciBilgileriDegistir, frmKullanici_Detay, frmKullanici_KullaniciEkle, frmKullanici_KullaniciBilgileriDegistir, frmKullanici_KullaniciSil };
        public static int islem = 0;
        cGenel cGen = new cGenel();
       
    }
}
