namespace otobus
{
    partial class frmKullaniciListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("xccxc");
            this.M = new System.Windows.Forms.GroupBox();
            this.asd = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.M.SuspendLayout();
            this.SuspendLayout();
            // 
            // M
            // 
            this.M.Controls.Add(this.asd);
            this.M.Controls.Add(this.txtAdSoyad);
            this.M.Controls.Add(this.label2);
            this.M.Controls.Add(this.txtTckn);
            this.M.Controls.Add(this.label1);
            this.M.Location = new System.Drawing.Point(264, 28);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(286, 80);
            this.M.TabIndex = 12;
            this.M.TabStop = false;
            this.M.Text = "Kullanıcı Ara";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(46, 23);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(53, 13);
            this.asd.TabIndex = 1;
            this.asd.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(21, 39);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "veya";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(164, 39);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(100, 20);
            this.txtTckn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kulanıcı Adı";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lv.Location = new System.Drawing.Point(62, 147);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(670, 279);
            this.lv.TabIndex = 11;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(62, 128);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 13;
            this.lblMesaj.Text = "Mesaj";
            // 
            // frmKullaniciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 472);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.M);
            this.Controls.Add(this.lv);
            this.Name = "frmKullaniciListe";
            this.Text = "frmKullaniciListe";
            this.Load += new System.EventHandler(this.frmKullaniciListe_Load);
            this.M.ResumeLayout(false);
            this.M.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox M;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}