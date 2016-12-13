using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
namespace otobus
{
    class cStil 
    {
        public void frm(Form frm)
        {
            frm.Top = 0;
            frm.Left = 0;
            frm.BackColor = ColorTranslator.FromHtml("#eeeeee");
            /*/icon ekle */string iconYol = Convert.ToString(Application.StartupPath).Replace("bin\\Debug", " ").Trim() + "resim\\Bus.ico";
            Icon ico = new Icon(iconYol);    /*/icon ekle */
            frm.Icon = ico;
         
        }
        public void menuStrip(MenuStrip ms)
        {
            ms.BackColor = ColorTranslator.FromHtml("#f4f4f4");
            ms.RenderMode = ToolStripRenderMode.System;
            ms.Font = new Font("SANS SERIF",12);
            ms.ForeColor = ColorTranslator.FromHtml("#666");
            ms.AutoSize = false;
            ms.Height = 40;
        }

        public void lv(ListView lv)
        {
            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;
        }
        public  void cb(ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DropDownWidth = 111;
        }
       public void dgv(DataGridView dgv)
        {
           dgv.MultiSelect = false;
           dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
           dgv.BackgroundColor = Color.AliceBlue;
           dgv.BorderStyle = BorderStyle.Fixed3D;
           dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           dgv.ReadOnly = true;
           dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
           dgv.RowTemplate.ReadOnly = true;
           dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
