namespace otobus
{
    partial class frmGuzergahDetay
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.a = new System.Windows.Forms.GroupBox();
            this.rbGidis = new System.Windows.Forms.RadioButton();
            this.rbDonus = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDuraklarArasiBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtDuraklarArasiBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.btnDuraklarArasiHesapla = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Label();
            this.sasd = new System.Windows.Forms.Label();
            this.txtGuzergahID = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblMesaj2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGuzergahAd = new System.Windows.Forms.TextBox();
            this.tutLblDurakID = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtDuraklarArasiFiyat = new System.Windows.Forms.TextBox();
            this.txtDuraklarArasiDurakSayisi = new System.Windows.Forms.TextBox();
            this.txtDuraklarArasiSure = new System.Windows.Forms.TextBox();
            this.txtDuraklarArasiMesafe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDurak = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvMola = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDurakID = new System.Windows.Forms.TextBox();
            this.txtDurakAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDurakMahalle = new System.Windows.Forms.TextBox();
            this.txtDurakIlce = new System.Windows.Forms.TextBox();
            this.txtDurakSehir = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.a.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDurak)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMola)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.rbGidis);
            this.a.Controls.Add(this.rbDonus);
            this.a.Location = new System.Drawing.Point(275, 30);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(264, 51);
            this.a.TabIndex = 8;
            this.a.TabStop = false;
            this.a.Text = "Durak listeleme Kriteri";
            // 
            // rbGidis
            // 
            this.rbGidis.AutoSize = true;
            this.rbGidis.Location = new System.Drawing.Point(18, 19);
            this.rbGidis.Name = "rbGidis";
            this.rbGidis.Size = new System.Drawing.Size(105, 17);
            this.rbGidis.TabIndex = 0;
            this.rbGidis.Text = "Gidişe göre sırala";
            this.rbGidis.UseVisualStyleBackColor = true;
            this.rbGidis.CheckedChanged += new System.EventHandler(this.rbGidis_CheckedChanged);
            // 
            // rbDonus
            // 
            this.rbDonus.AutoSize = true;
            this.rbDonus.Location = new System.Drawing.Point(129, 19);
            this.rbDonus.Name = "rbDonus";
            this.rbDonus.Size = new System.Drawing.Size(113, 17);
            this.rbDonus.TabIndex = 0;
            this.rbDonus.Text = "Dönüşe göre sırala";
            this.rbDonus.UseVisualStyleBackColor = true;
            this.rbDonus.CheckedChanged += new System.EventHandler(this.rbDonus_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDuraklarArasiBitis);
            this.groupBox1.Controls.Add(this.txtDuraklarArasiBaslangic);
            this.groupBox1.Controls.Add(this.btnDuraklarArasiHesapla);
            this.groupBox1.Controls.Add(this.x);
            this.groupBox1.Controls.Add(this.sasd);
            this.groupBox1.Location = new System.Drawing.Point(582, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duraklar arası detayları gör";
            // 
            // txtDuraklarArasiBitis
            // 
            this.txtDuraklarArasiBitis.Location = new System.Drawing.Point(158, 45);
            this.txtDuraklarArasiBitis.Mask = "00000";
            this.txtDuraklarArasiBitis.Name = "txtDuraklarArasiBitis";
            this.txtDuraklarArasiBitis.Size = new System.Drawing.Size(113, 20);
            this.txtDuraklarArasiBitis.TabIndex = 5;
            this.txtDuraklarArasiBitis.Text = "0";
            this.txtDuraklarArasiBitis.ValidatingType = typeof(int);
            // 
            // txtDuraklarArasiBaslangic
            // 
            this.txtDuraklarArasiBaslangic.Location = new System.Drawing.Point(13, 48);
            this.txtDuraklarArasiBaslangic.Mask = "00000";
            this.txtDuraklarArasiBaslangic.Name = "txtDuraklarArasiBaslangic";
            this.txtDuraklarArasiBaslangic.Size = new System.Drawing.Size(113, 20);
            this.txtDuraklarArasiBaslangic.TabIndex = 5;
            this.txtDuraklarArasiBaslangic.Text = "0";
            this.txtDuraklarArasiBaslangic.ValidatingType = typeof(int);
            // 
            // btnDuraklarArasiHesapla
            // 
            this.btnDuraklarArasiHesapla.Location = new System.Drawing.Point(91, 81);
            this.btnDuraklarArasiHesapla.Name = "btnDuraklarArasiHesapla";
            this.btnDuraklarArasiHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnDuraklarArasiHesapla.TabIndex = 4;
            this.btnDuraklarArasiHesapla.Text = "Hesapla";
            this.btnDuraklarArasiHesapla.UseVisualStyleBackColor = true;
            this.btnDuraklarArasiHesapla.Click += new System.EventHandler(this.btnDuraklarArasiHesapla_Click);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(159, 29);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(116, 13);
            this.x.TabIndex = 3;
            this.x.Text = "Başlangıç Durak Sırası:";
            // 
            // sasd
            // 
            this.sasd.AutoSize = true;
            this.sasd.Location = new System.Drawing.Point(10, 32);
            this.sasd.Name = "sasd";
            this.sasd.Size = new System.Drawing.Size(116, 13);
            this.sasd.TabIndex = 3;
            this.sasd.Text = "Başlangıç Durak Sırası:";
            // 
            // txtGuzergahID
            // 
            this.txtGuzergahID.Location = new System.Drawing.Point(9, 18);
            this.txtGuzergahID.Name = "txtGuzergahID";
            this.txtGuzergahID.ReadOnly = true;
            this.txtGuzergahID.Size = new System.Drawing.Size(56, 20);
            this.txtGuzergahID.TabIndex = 13;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(54, 10);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(34, 13);
            this.lblMesaj.TabIndex = 16;
            this.lblMesaj.Text = "mesaj";
            // 
            // lblMesaj2
            // 
            this.lblMesaj2.AutoSize = true;
            this.lblMesaj2.Location = new System.Drawing.Point(59, 474);
            this.lblMesaj2.Name = "lblMesaj2";
            this.lblMesaj2.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj2.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGuzergahAd);
            this.groupBox4.Controls.Add(this.txtGuzergahID);
            this.groupBox4.Location = new System.Drawing.Point(53, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 51);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Guzergah Bilgileri";
            // 
            // txtGuzergahAd
            // 
            this.txtGuzergahAd.Location = new System.Drawing.Point(72, 17);
            this.txtGuzergahAd.Name = "txtGuzergahAd";
            this.txtGuzergahAd.ReadOnly = true;
            this.txtGuzergahAd.Size = new System.Drawing.Size(125, 20);
            this.txtGuzergahAd.TabIndex = 13;
            // 
            // tutLblDurakID
            // 
            this.tutLblDurakID.AutoSize = true;
            this.tutLblDurakID.BackColor = System.Drawing.Color.DarkRed;
            this.tutLblDurakID.Location = new System.Drawing.Point(892, 62);
            this.tutLblDurakID.Name = "tutLblDurakID";
            this.tutLblDurakID.Size = new System.Drawing.Size(13, 13);
            this.tutLblDurakID.TabIndex = 18;
            this.tutLblDurakID.Text = "1";
            this.tutLblDurakID.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDuraklarArasiFiyat);
            this.groupBox6.Controls.Add(this.txtDuraklarArasiDurakSayisi);
            this.groupBox6.Controls.Add(this.txtDuraklarArasiSure);
            this.groupBox6.Controls.Add(this.txtDuraklarArasiMesafe);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(582, 508);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 140);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Duraklar Arası Detaylar";
            // 
            // txtDuraklarArasiFiyat
            // 
            this.txtDuraklarArasiFiyat.Location = new System.Drawing.Point(104, 107);
            this.txtDuraklarArasiFiyat.Name = "txtDuraklarArasiFiyat";
            this.txtDuraklarArasiFiyat.ReadOnly = true;
            this.txtDuraklarArasiFiyat.Size = new System.Drawing.Size(157, 20);
            this.txtDuraklarArasiFiyat.TabIndex = 11;
            // 
            // txtDuraklarArasiDurakSayisi
            // 
            this.txtDuraklarArasiDurakSayisi.Location = new System.Drawing.Point(105, 79);
            this.txtDuraklarArasiDurakSayisi.Name = "txtDuraklarArasiDurakSayisi";
            this.txtDuraklarArasiDurakSayisi.ReadOnly = true;
            this.txtDuraklarArasiDurakSayisi.Size = new System.Drawing.Size(157, 20);
            this.txtDuraklarArasiDurakSayisi.TabIndex = 11;
            // 
            // txtDuraklarArasiSure
            // 
            this.txtDuraklarArasiSure.Location = new System.Drawing.Point(105, 53);
            this.txtDuraklarArasiSure.Name = "txtDuraklarArasiSure";
            this.txtDuraklarArasiSure.ReadOnly = true;
            this.txtDuraklarArasiSure.Size = new System.Drawing.Size(157, 20);
            this.txtDuraklarArasiSure.TabIndex = 11;
            // 
            // txtDuraklarArasiMesafe
            // 
            this.txtDuraklarArasiMesafe.Location = new System.Drawing.Point(105, 30);
            this.txtDuraklarArasiMesafe.Name = "txtDuraklarArasiMesafe";
            this.txtDuraklarArasiMesafe.ReadOnly = true;
            this.txtDuraklarArasiMesafe.Size = new System.Drawing.Size(157, 20);
            this.txtDuraklarArasiMesafe.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fiyat(TL)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Durak Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Süre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mesafe(km):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDurak);
            this.groupBox3.Location = new System.Drawing.Point(57, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 388);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duraklar";
            // 
            // dgvDurak
            // 
            this.dgvDurak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDurak.Location = new System.Drawing.Point(6, 19);
            this.dgvDurak.Name = "dgvDurak";
            this.dgvDurak.Size = new System.Drawing.Size(474, 358);
            this.dgvDurak.TabIndex = 0;
            this.dgvDurak.DoubleClick += new System.EventHandler(this.dgvDuraklar_DoubleClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvMola);
            this.groupBox7.Location = new System.Drawing.Point(53, 508);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(486, 140);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Molalar";
            // 
            // dgvMola
            // 
            this.dgvMola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMola.Location = new System.Drawing.Point(10, 19);
            this.dgvMola.Name = "dgvMola";
            this.dgvMola.Size = new System.Drawing.Size(470, 115);
            this.dgvMola.TabIndex = 0;
            this.dgvMola.DoubleClick += new System.EventHandler(this.dgvDuraklar_DoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDurakID);
            this.groupBox5.Controls.Add(this.txtDurakAd);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(582, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 78);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Şube Bilgileri";
            // 
            // txtDurakID
            // 
            this.txtDurakID.Location = new System.Drawing.Point(105, 16);
            this.txtDurakID.Name = "txtDurakID";
            this.txtDurakID.ReadOnly = true;
            this.txtDurakID.Size = new System.Drawing.Size(157, 20);
            this.txtDurakID.TabIndex = 10;
            // 
            // txtDurakAd
            // 
            this.txtDurakAd.Location = new System.Drawing.Point(105, 48);
            this.txtDurakAd.Name = "txtDurakAd";
            this.txtDurakAd.ReadOnly = true;
            this.txtDurakAd.Size = new System.Drawing.Size(157, 20);
            this.txtDurakAd.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şube ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Durak Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDurakMahalle);
            this.groupBox2.Controls.Add(this.txtDurakIlce);
            this.groupBox2.Controls.Add(this.txtDurakSehir);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(582, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 137);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgileri";
            // 
            // txtDurakMahalle
            // 
            this.txtDurakMahalle.Location = new System.Drawing.Point(104, 84);
            this.txtDurakMahalle.Name = "txtDurakMahalle";
            this.txtDurakMahalle.ReadOnly = true;
            this.txtDurakMahalle.Size = new System.Drawing.Size(157, 20);
            this.txtDurakMahalle.TabIndex = 10;
            // 
            // txtDurakIlce
            // 
            this.txtDurakIlce.Location = new System.Drawing.Point(104, 51);
            this.txtDurakIlce.Name = "txtDurakIlce";
            this.txtDurakIlce.ReadOnly = true;
            this.txtDurakIlce.Size = new System.Drawing.Size(157, 20);
            this.txtDurakIlce.TabIndex = 10;
            // 
            // txtDurakSehir
            // 
            this.txtDurakSehir.Location = new System.Drawing.Point(104, 21);
            this.txtDurakSehir.Name = "txtDurakSehir";
            this.txtDurakSehir.ReadOnly = true;
            this.txtDurakSehir.Size = new System.Drawing.Size(157, 20);
            this.txtDurakSehir.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mahalle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "İlçe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Şehir";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(784, 666);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 17;
            this.btn.Text = "islem";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Visible = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // frmGuzergahDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 756);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.tutLblDurakID);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblMesaj2);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.a);
            this.Name = "frmGuzergahDetay";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "frmGuzargahDetay";
            this.Load += new System.EventHandler(this.frmGuzargahDetay_Load);
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDurak)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMola)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.RadioButton rbGidis;
        private System.Windows.Forms.RadioButton rbDonus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDuraklarArasiHesapla;
        private System.Windows.Forms.Label sasd;
        private System.Windows.Forms.TextBox txtGuzergahID;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label lblMesaj2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label tutLblDurakID;
        private System.Windows.Forms.TextBox txtGuzergahAd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDuraklarArasiBaslangic;
        private System.Windows.Forms.MaskedTextBox txtDuraklarArasiBitis;
        private System.Windows.Forms.TextBox txtDuraklarArasiFiyat;
        private System.Windows.Forms.TextBox txtDuraklarArasiDurakSayisi;
        private System.Windows.Forms.TextBox txtDuraklarArasiSure;
        private System.Windows.Forms.TextBox txtDuraklarArasiMesafe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDurak;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDurakID;
        private System.Windows.Forms.TextBox txtDurakAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDurakMahalle;
        private System.Windows.Forms.TextBox txtDurakIlce;
        private System.Windows.Forms.TextBox txtDurakSehir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgvMola;
    }
}