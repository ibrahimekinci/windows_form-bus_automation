using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace otobus
{
    class cGenel
    {
        public static int kullaniciID=7;
       //public static string connStr = "Data Source=SC-105-03;Initial Catalog=Stok;uid=sa;pwd=12345;";
        public static string connStr = "Data Source=.;Initial Catalog=ProjeB141210303ibrahimEkinci1A; Integrated Security=True;";

        /*******************************************************************************************************************/
         //açilacaği form this olmalıdır aksi taktirde çalışmaz.bir başka değiş bu metotla formu ancak bulunduğumuz sayfa 
        //içinde açarız.aksi halde açık haldeki formu yakalamamız gerecek
        public  void FormAc(Form frm)//form açık değilse açar
        {
            if (!formAcikmi(frm))
            {
                frm.MdiParent = Application.OpenForms[1];
                frm.Show();
            }
            else
            {
                frm.Dispose();
            }
        }
        public  bool formAcikmi (Form frm) // form açıkmı diye kontrol eder
        {
            bool Acikmi = false;
            if (Application.OpenForms[1].MdiChildren.Length > 0)
            {
                for (int i = 0; i < Application.OpenForms[1].MdiChildren.Length; i++)
                {
                    if (frm.Name == Application.OpenForms[1].MdiChildren[i].Name)
                    {
                        Acikmi = true;
                    }
                }
            }      
            return Acikmi;
        }
        public bool formAcBySecim(Form frm) //form açıksa kapatılsın mı diye sorar evet yanıtı verilirse forma reset atar
        {
           bool sonuc = false;
           if (formKapat(frm))
           { FormAc(frm);
             sonuc = true;
           }
            return sonuc;
        }
        public void formAcByReset(Form frm) //form açıksa forma reset atar
        {
            if (formAcikmi(frm))
            {
                    Application.OpenForms[frm.Name].Close();
            }
            FormAc(frm);
        }
        public bool formKapat(Form frm)     //form kapatmak istediğimiz zaman işlem kaybı yaşamamak için sorarak kapatır
        {
            bool sonuc = false;
            if (formAcikmi(frm))
            {
                if (MessageBox.Show("işleminizin yapılması için Ulaşmak istediğiniz sayfadaki işlemler sonlandırılmalıdır.Sondırılsın mı?.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.OpenForms[frm.Name].Close();
                    sonuc = true;
                }
            }
            else sonuc = true; 
            return sonuc;
        }
        /*******************************************************************************************************************/
    
    
    
    }
}
