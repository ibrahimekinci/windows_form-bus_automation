using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace otobus
{
    public partial class frmAracListe : Form
    {
        public frmAracListe()
        {
            InitializeComponent();
        }
        cStil cSt = new cStil();

        private void frmAracListe_Load(object sender, EventArgs e)
        {           
            cArac a = new cArac();
            a.AraclariGetir(lvAraclar);
            a.ModelleriGetir(cbAracModeli);
        }

        private void cbAracModeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            cArac a = new cArac();
            a.AraclarıGetirByModel(cbAracModeli, lvAraclar);
        }

        private void lvAraclar_DoubleClick(object sender, EventArgs e)
        {
            cArac.AtOtoID = Convert.ToInt32(lvAraclar.SelectedItems[0].Text);
            cArac.AtPlaka = lvAraclar.SelectedItems[0].SubItems[5].Text;
            this.Close();
        }

        private void btnAracAra_Click(object sender, EventArgs e)
        {
            cArac a = new cArac();
            a.AraclarıGetirByTarih(txtTarih.Text,lvAraclar);          
        }

        private void dtpTarih1_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih1.Value.ToShortDateString();
        }

        
          
    }
}
