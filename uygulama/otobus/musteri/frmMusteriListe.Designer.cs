namespace otobus
{
    partial class frmMusteriListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListe));
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvMusteri = new System.Windows.Forms.ListView();
            this.Tckno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CepTelefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EvTelefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.M = new System.Windows.Forms.GroupBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.M.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(21, 42);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
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
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(164, 39);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(100, 20);
            this.txtTckn.TabIndex = 0;
            this.txtTckn.TextChanged += new System.EventHandler(this.txtTckn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tckn";
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
            // lvMusteri
            // 
            this.lvMusteri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tckno,
            this.Ad,
            this.Soyad,
            this.Cinsiyet,
            this.CepTelefonu,
            this.EvTelefonu,
            this.Email,
            this.Adres,
            this.MusteriId});
            this.lvMusteri.FullRowSelect = true;
            this.lvMusteri.Location = new System.Drawing.Point(53, 135);
            this.lvMusteri.Name = "lvMusteri";
            this.lvMusteri.Size = new System.Drawing.Size(774, 279);
            this.lvMusteri.TabIndex = 2;
            this.lvMusteri.UseCompatibleStateImageBehavior = false;
            this.lvMusteri.View = System.Windows.Forms.View.Details;
            this.lvMusteri.DoubleClick += new System.EventHandler(this.lvMusteri_DoubleClick);
            // 
            // Tckno
            // 
            this.Tckno.Text = "Tckno";
            this.Tckno.Width = 82;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 51;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 69;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            this.Cinsiyet.Width = 61;
            // 
            // CepTelefonu
            // 
            this.CepTelefonu.Text = "CepTelefonu";
            this.CepTelefonu.Width = 86;
            // 
            // EvTelefonu
            // 
            this.EvTelefonu.Text = "EvTelefonu";
            this.EvTelefonu.Width = 93;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 125;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 131;
            // 
            // MusteriId
            // 
            this.MusteriId.Text = "MusteriId";
            this.MusteriId.Width = 1;
            // 
            // M
            // 
            this.M.Controls.Add(this.asd);
            this.M.Controls.Add(this.txtAdSoyad);
            this.M.Controls.Add(this.label2);
            this.M.Controls.Add(this.txtTckn);
            this.M.Controls.Add(this.label1);
            this.M.Location = new System.Drawing.Point(293, 39);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(286, 80);
            this.M.TabIndex = 3;
            this.M.TabStop = false;
            this.M.Text = "Musteri Ara";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(53, 119);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "Mesaj";
            // 
            // frmMusteriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 504);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.M);
            this.Controls.Add(this.lvMusteri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMusteriListe";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "frmMusteriListe";
            this.Load += new System.EventHandler(this.frmMusteriListe_Load);
            this.M.ResumeLayout(false);
            this.M.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvMusteri;
        private System.Windows.Forms.GroupBox M;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Tckno;
        private System.Windows.Forms.ColumnHeader CepTelefonu;
        private System.Windows.Forms.ColumnHeader EvTelefonu;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.ColumnHeader MusteriId;
    }
}