namespace otobus
{
    partial class frmYonetim
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.seferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSeferDetay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSeferEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSeferSil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisanDetay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisanEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisanDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCalisanSil = new System.Windows.Forms.ToolStripMenuItem();
            this.güzergahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGuzergahSorgulaDetay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGuzergahEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGuzergahDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProfiliGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKullaniciCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOtomasyonCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferToolStripMenuItem,
            this.mnCalisan,
            this.güzergahToolStripMenuItem,
            this.mnProfiliGuncelle,
            this.mnCikis});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(816, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // seferToolStripMenuItem
            // 
            this.seferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSeferDetay,
            this.mnSeferEkle,
            this.mnSeferSil});
            this.seferToolStripMenuItem.Name = "seferToolStripMenuItem";
            this.seferToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.seferToolStripMenuItem.Text = "Sefer";
            // 
            // mnSeferDetay
            // 
            this.mnSeferDetay.Name = "mnSeferDetay";
            this.mnSeferDetay.Size = new System.Drawing.Size(208, 22);
            this.mnSeferDetay.Text = "Sefer Bilgilerini Görüntüle";
            this.mnSeferDetay.Click += new System.EventHandler(this.mnSeferDetay_Click);
            // 
            // mnSeferEkle
            // 
            this.mnSeferEkle.Name = "mnSeferEkle";
            this.mnSeferEkle.Size = new System.Drawing.Size(208, 22);
            this.mnSeferEkle.Text = "Sefer Ekle";
            this.mnSeferEkle.Click += new System.EventHandler(this.mnSeferEkle_Click);
            // 
            // mnSeferSil
            // 
            this.mnSeferSil.Name = "mnSeferSil";
            this.mnSeferSil.Size = new System.Drawing.Size(208, 22);
            this.mnSeferSil.Text = "Sefer Sil";
            this.mnSeferSil.Click += new System.EventHandler(this.mnSeferSil_Click);
            // 
            // mnCalisan
            // 
            this.mnCalisan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCalisanDetay,
            this.mnCalisanEkle,
            this.mnCalisanDegistir,
            this.mnCalisanSil});
            this.mnCalisan.Name = "mnCalisan";
            this.mnCalisan.Size = new System.Drawing.Size(57, 20);
            this.mnCalisan.Text = "Çalişan";
            // 
            // mnCalisanDetay
            // 
            this.mnCalisanDetay.Name = "mnCalisanDetay";
            this.mnCalisanDetay.Size = new System.Drawing.Size(220, 22);
            this.mnCalisanDetay.Text = "Çalışan Bilgilerini Görüntüle";
            this.mnCalisanDetay.Click += new System.EventHandler(this.mnCalisanDetay_Click);
            // 
            // mnCalisanEkle
            // 
            this.mnCalisanEkle.Name = "mnCalisanEkle";
            this.mnCalisanEkle.Size = new System.Drawing.Size(220, 22);
            this.mnCalisanEkle.Text = "Çalşan Ekle";
            this.mnCalisanEkle.Click += new System.EventHandler(this.mnCalisanEkle_Click);
            // 
            // mnCalisanDegistir
            // 
            this.mnCalisanDegistir.Name = "mnCalisanDegistir";
            this.mnCalisanDegistir.Size = new System.Drawing.Size(220, 22);
            this.mnCalisanDegistir.Text = "Çalışan Bilgilerini Değiştir";
            this.mnCalisanDegistir.Click += new System.EventHandler(this.mnCalisanBilgileriGetir_Click);
            // 
            // mnCalisanSil
            // 
            this.mnCalisanSil.Name = "mnCalisanSil";
            this.mnCalisanSil.Size = new System.Drawing.Size(220, 22);
            this.mnCalisanSil.Text = "Çalışan Sil";
            this.mnCalisanSil.Click += new System.EventHandler(this.mnCalisanSil_Click);
            // 
            // güzergahToolStripMenuItem
            // 
            this.güzergahToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnGuzergahSorgulaDetay,
            this.mnGuzergahEkle,
            this.mnGuzergahDegistir});
            this.güzergahToolStripMenuItem.Name = "güzergahToolStripMenuItem";
            this.güzergahToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.güzergahToolStripMenuItem.Text = "Güzergah";
            // 
            // mnGuzergahSorgulaDetay
            // 
            this.mnGuzergahSorgulaDetay.Name = "mnGuzergahSorgulaDetay";
            this.mnGuzergahSorgulaDetay.Size = new System.Drawing.Size(232, 22);
            this.mnGuzergahSorgulaDetay.Text = "Guzergah Bilgilerini Görüntüle";
            this.mnGuzergahSorgulaDetay.Click += new System.EventHandler(this.mnGuzergahSorgulaDetay_Click);
            // 
            // mnGuzergahEkle
            // 
            this.mnGuzergahEkle.Name = "mnGuzergahEkle";
            this.mnGuzergahEkle.Size = new System.Drawing.Size(232, 22);
            this.mnGuzergahEkle.Text = "Güzergah Ekle";
            this.mnGuzergahEkle.Click += new System.EventHandler(this.mnGuzergahEkle_Click);
            // 
            // mnGuzergahDegistir
            // 
            this.mnGuzergahDegistir.Name = "mnGuzergahDegistir";
            this.mnGuzergahDegistir.Size = new System.Drawing.Size(232, 22);
            this.mnGuzergahDegistir.Text = "Güzergah Değiştir";
            this.mnGuzergahDegistir.Click += new System.EventHandler(this.mnGuzergahDegistir_Click);
            // 
            // mnProfiliGuncelle
            // 
            this.mnProfiliGuncelle.Name = "mnProfiliGuncelle";
            this.mnProfiliGuncelle.Size = new System.Drawing.Size(81, 20);
            this.mnProfiliGuncelle.Text = "Yetkili Profil";
            this.mnProfiliGuncelle.Click += new System.EventHandler(this.mnProfiliGuncelle_Click);
            // 
            // mnCikis
            // 
            this.mnCikis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKullaniciCikis,
            this.mnOtomasyonCikis});
            this.mnCikis.Name = "mnCikis";
            this.mnCikis.Size = new System.Drawing.Size(44, 20);
            this.mnCikis.Text = "Çıkış";
            // 
            // mnKullaniciCikis
            // 
            this.mnKullaniciCikis.Name = "mnKullaniciCikis";
            this.mnKullaniciCikis.Size = new System.Drawing.Size(184, 22);
            this.mnKullaniciCikis.Text = "Kullanıcıdan Çıkış";
            this.mnKullaniciCikis.Click += new System.EventHandler(this.mnKullaniciCikis_Click);
            // 
            // mnOtomasyonCikis
            // 
            this.mnOtomasyonCikis.Name = "mnOtomasyonCikis";
            this.mnOtomasyonCikis.Size = new System.Drawing.Size(184, 22);
            this.mnOtomasyonCikis.Text = "Otomasyondan Çıkış";
            this.mnOtomasyonCikis.Click += new System.EventHandler(this.mnOtomasyonCikis_Click);
            // 
            // frmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmYonetim";
            this.Text = "Yönetim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYonetim_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem seferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSeferEkle;
        private System.Windows.Forms.ToolStripMenuItem mnSeferSil;
        private System.Windows.Forms.ToolStripMenuItem güzergahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnGuzergahEkle;
        private System.Windows.Forms.ToolStripMenuItem mnGuzergahDegistir;
        private System.Windows.Forms.ToolStripMenuItem mnCalisan;
        private System.Windows.Forms.ToolStripMenuItem mnCalisanEkle;
        private System.Windows.Forms.ToolStripMenuItem mnCalisanDegistir;
        private System.Windows.Forms.ToolStripMenuItem mnProfiliGuncelle;
        private System.Windows.Forms.ToolStripMenuItem mnCikis;
        private System.Windows.Forms.ToolStripMenuItem mnGuzergahSorgulaDetay;
        private System.Windows.Forms.ToolStripMenuItem mnCalisanSil;
        private System.Windows.Forms.ToolStripMenuItem mnSeferDetay;
        private System.Windows.Forms.ToolStripMenuItem mnCalisanDetay;
        private System.Windows.Forms.ToolStripMenuItem mnKullaniciCikis;
        private System.Windows.Forms.ToolStripMenuItem mnOtomasyonCikis;
    }
}