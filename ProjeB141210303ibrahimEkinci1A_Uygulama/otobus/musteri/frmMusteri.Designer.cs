namespace otobus
{
    partial class frmMusteri
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
            this.btn = new System.Windows.Forms.Button();
            this.txtMahalleID = new System.Windows.Forms.TextBox();
            this.txtAdresID = new System.Windows.Forms.TextBox();
            this.txtIlceID = new System.Windows.Forms.TextBox();
            this.txtSehirID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTckn = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblHataDogumTarihi = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHataSoyad = new System.Windows.Forms.Label();
            this.lblHataAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHataTckn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBayan = new System.Windows.Forms.RadioButton();
            this.rbBay = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHataTelefon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCepTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEvTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.esfse = new System.Windows.Forms.GroupBox();
            this.cbMahalle = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblHataMahalle = new System.Windows.Forms.Label();
            this.lblHataIlce = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblHataSehir = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.esfse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(424, 270);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 13;
            this.btn.Text = "işlem";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtMahalleID
            // 
            this.txtMahalleID.Location = new System.Drawing.Point(739, 117);
            this.txtMahalleID.Name = "txtMahalleID";
            this.txtMahalleID.Size = new System.Drawing.Size(15, 20);
            this.txtMahalleID.TabIndex = 25;
            // 
            // txtAdresID
            // 
            this.txtAdresID.Location = new System.Drawing.Point(739, 154);
            this.txtAdresID.Name = "txtAdresID";
            this.txtAdresID.Size = new System.Drawing.Size(15, 20);
            this.txtAdresID.TabIndex = 24;
            // 
            // txtIlceID
            // 
            this.txtIlceID.Location = new System.Drawing.Point(739, 86);
            this.txtIlceID.Name = "txtIlceID";
            this.txtIlceID.Size = new System.Drawing.Size(15, 20);
            this.txtIlceID.TabIndex = 23;
            // 
            // txtSehirID
            // 
            this.txtSehirID.Location = new System.Drawing.Point(739, 52);
            this.txtSehirID.Name = "txtSehirID";
            this.txtSehirID.Size = new System.Drawing.Size(15, 20);
            this.txtSehirID.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTckn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtAd);
            this.groupBox4.Controls.Add(this.lblHataDogumTarihi);
            this.groupBox4.Controls.Add(this.txtSoyad);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblHataSoyad);
            this.groupBox4.Controls.Add(this.lblHataAd);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblHataTckn);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.txtDogumTarihi);
            this.groupBox4.Location = new System.Drawing.Point(88, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 182);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kişisel Bilgiler ";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(105, 23);
            this.txtTckn.Mask = "00000000000";
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(156, 20);
            this.txtTckn.TabIndex = 11;
            this.txtTckn.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTckn_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 11);
            this.label7.TabIndex = 10;
            this.label7.Text = "Doğum T.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 11);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tckn";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(105, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // lblHataDogumTarihi
            // 
            this.lblHataDogumTarihi.AutoSize = true;
            this.lblHataDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataDogumTarihi.ForeColor = System.Drawing.Color.Red;
            this.lblHataDogumTarihi.Location = new System.Drawing.Point(270, 147);
            this.lblHataDogumTarihi.Name = "lblHataDogumTarihi";
            this.lblHataDogumTarihi.Size = new System.Drawing.Size(15, 20);
            this.lblHataDogumTarihi.TabIndex = 9;
            this.lblHataDogumTarihi.Text = "*";
            this.lblHataDogumTarihi.Visible = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(105, 77);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(157, 20);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 11);
            this.label2.TabIndex = 3;
            this.label2.Text = "AD";
            // 
            // lblHataSoyad
            // 
            this.lblHataSoyad.AutoSize = true;
            this.lblHataSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblHataSoyad.Location = new System.Drawing.Point(267, 74);
            this.lblHataSoyad.Name = "lblHataSoyad";
            this.lblHataSoyad.Size = new System.Drawing.Size(15, 20);
            this.lblHataSoyad.TabIndex = 9;
            this.lblHataSoyad.Text = "*";
            this.lblHataSoyad.Visible = false;
            // 
            // lblHataAd
            // 
            this.lblHataAd.AutoSize = true;
            this.lblHataAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataAd.ForeColor = System.Drawing.Color.Red;
            this.lblHataAd.Location = new System.Drawing.Point(270, 50);
            this.lblHataAd.Name = "lblHataAd";
            this.lblHataAd.Size = new System.Drawing.Size(15, 20);
            this.lblHataAd.TabIndex = 9;
            this.lblHataAd.Text = "*";
            this.lblHataAd.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 11);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad";
            // 
            // lblHataTckn
            // 
            this.lblHataTckn.AutoSize = true;
            this.lblHataTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataTckn.ForeColor = System.Drawing.Color.Red;
            this.lblHataTckn.Location = new System.Drawing.Point(270, 28);
            this.lblHataTckn.Name = "lblHataTckn";
            this.lblHataTckn.Size = new System.Drawing.Size(15, 20);
            this.lblHataTckn.TabIndex = 9;
            this.lblHataTckn.Text = "*";
            this.lblHataTckn.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBayan);
            this.groupBox1.Controls.Add(this.rbBay);
            this.groupBox1.Location = new System.Drawing.Point(21, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // rbBayan
            // 
            this.rbBayan.AutoSize = true;
            this.rbBayan.Location = new System.Drawing.Point(163, 18);
            this.rbBayan.Name = "rbBayan";
            this.rbBayan.Size = new System.Drawing.Size(58, 15);
            this.rbBayan.TabIndex = 1;
            this.rbBayan.TabStop = true;
            this.rbBayan.Text = "Bayan";
            this.rbBayan.UseVisualStyleBackColor = true;
            // 
            // rbBay
            // 
            this.rbBay.AutoSize = true;
            this.rbBay.Location = new System.Drawing.Point(84, 16);
            this.rbBay.Name = "rbBay";
            this.rbBay.Size = new System.Drawing.Size(44, 15);
            this.rbBay.TabIndex = 0;
            this.rbBay.TabStop = true;
            this.rbBay.Text = "Bay";
            this.rbBay.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 147);
            this.dateTimePicker1.MaxDate = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(105, 147);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.ReadOnly = true;
            this.txtDogumTarihi.Size = new System.Drawing.Size(137, 20);
            this.txtDogumTarihi.TabIndex = 5;
            this.txtDogumTarihi.Text = "Doğum tarihi seç";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblHataTelefon);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCepTelefon);
            this.groupBox3.Controls.Add(this.txtEvTelefon);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Location = new System.Drawing.Point(88, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 114);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İrtibat Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 11);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 11);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ev Telefonu";
            // 
            // lblHataTelefon
            // 
            this.lblHataTelefon.AutoSize = true;
            this.lblHataTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataTelefon.ForeColor = System.Drawing.Color.Red;
            this.lblHataTelefon.Location = new System.Drawing.Point(270, 19);
            this.lblHataTelefon.Name = "lblHataTelefon";
            this.lblHataTelefon.Size = new System.Drawing.Size(15, 20);
            this.lblHataTelefon.TabIndex = 9;
            this.lblHataTelefon.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 11);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-Posta";
            // 
            // txtCepTelefon
            // 
            this.txtCepTelefon.Location = new System.Drawing.Point(105, 19);
            this.txtCepTelefon.Mask = "(999) 000-0000";
            this.txtCepTelefon.Name = "txtCepTelefon";
            this.txtCepTelefon.Size = new System.Drawing.Size(157, 20);
            this.txtCepTelefon.TabIndex = 7;
            // 
            // txtEvTelefon
            // 
            this.txtEvTelefon.Location = new System.Drawing.Point(105, 45);
            this.txtEvTelefon.Mask = "(999) 000-0000";
            this.txtEvTelefon.Name = "txtEvTelefon";
            this.txtEvTelefon.Size = new System.Drawing.Size(157, 20);
            this.txtEvTelefon.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // esfse
            // 
            this.esfse.Controls.Add(this.cbMahalle);
            this.esfse.Controls.Add(this.cbIlce);
            this.esfse.Controls.Add(this.cbSehir);
            this.esfse.Controls.Add(this.label14);
            this.esfse.Controls.Add(this.label13);
            this.esfse.Controls.Add(this.label12);
            this.esfse.Controls.Add(this.txtAciklama);
            this.esfse.Controls.Add(this.lblHataMahalle);
            this.esfse.Controls.Add(this.lblHataIlce);
            this.esfse.Controls.Add(this.label15);
            this.esfse.Controls.Add(this.lblHataSehir);
            this.esfse.Location = new System.Drawing.Point(433, 27);
            this.esfse.Name = "esfse";
            this.esfse.Size = new System.Drawing.Size(300, 203);
            this.esfse.TabIndex = 19;
            this.esfse.TabStop = false;
            this.esfse.Text = "Adres Bilgileri";
            // 
            // cbMahalle
            // 
            this.cbMahalle.FormattingEnabled = true;
            this.cbMahalle.Location = new System.Drawing.Point(104, 90);
            this.cbMahalle.Name = "cbMahalle";
            this.cbMahalle.Size = new System.Drawing.Size(157, 19);
            this.cbMahalle.TabIndex = 10;
            this.cbMahalle.SelectedIndexChanged += new System.EventHandler(this.cbMahalle_SelectedIndexChanged);
            // 
            // cbIlce
            // 
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(104, 54);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(157, 19);
            this.cbIlce.TabIndex = 10;
            this.cbIlce.SelectedIndexChanged += new System.EventHandler(this.cbIlce_SelectedIndexChanged);
            // 
            // cbSehir
            // 
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(104, 24);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(157, 19);
            this.cbSehir.TabIndex = 10;
            this.cbSehir.SelectedIndexChanged += new System.EventHandler(this.cbSehir_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 11);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mahalle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 11);
            this.label13.TabIndex = 9;
            this.label13.Text = "İlçe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 11);
            this.label12.TabIndex = 9;
            this.label12.Text = "Şehir";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(104, 123);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(157, 62);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // lblHataMahalle
            // 
            this.lblHataMahalle.AutoSize = true;
            this.lblHataMahalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataMahalle.ForeColor = System.Drawing.Color.Red;
            this.lblHataMahalle.Location = new System.Drawing.Point(267, 86);
            this.lblHataMahalle.Name = "lblHataMahalle";
            this.lblHataMahalle.Size = new System.Drawing.Size(15, 20);
            this.lblHataMahalle.TabIndex = 9;
            this.lblHataMahalle.Text = "*";
            this.lblHataMahalle.Visible = false;
            // 
            // lblHataIlce
            // 
            this.lblHataIlce.AutoSize = true;
            this.lblHataIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataIlce.ForeColor = System.Drawing.Color.Red;
            this.lblHataIlce.Location = new System.Drawing.Point(267, 55);
            this.lblHataIlce.Name = "lblHataIlce";
            this.lblHataIlce.Size = new System.Drawing.Size(15, 20);
            this.lblHataIlce.TabIndex = 9;
            this.lblHataIlce.Text = "*";
            this.lblHataIlce.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 11);
            this.label15.TabIndex = 3;
            this.label15.Text = "Açıklama";
            // 
            // lblHataSehir
            // 
            this.lblHataSehir.AutoSize = true;
            this.lblHataSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHataSehir.ForeColor = System.Drawing.Color.Red;
            this.lblHataSehir.Location = new System.Drawing.Point(267, 23);
            this.lblHataSehir.Name = "lblHataSehir";
            this.lblHataSehir.Size = new System.Drawing.Size(15, 20);
            this.lblHataSehir.TabIndex = 9;
            this.lblHataSehir.Text = "*";
            this.lblHataSehir.Visible = false;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(12, 9);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(38, 11);
            this.lblMesaj.TabIndex = 26;
            this.lblMesaj.Text = "Mesaj";
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 374);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtMahalleID);
            this.Controls.Add(this.txtAdresID);
            this.Controls.Add(this.txtIlceID);
            this.Controls.Add(this.txtSehirID);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.esfse);
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("Gulim", 8.25F);
            this.Name = "frmMusteri";
            this.Text = "frmMusteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.esfse.ResumeLayout(false);
            this.esfse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtMahalleID;
        private System.Windows.Forms.TextBox txtAdresID;
        private System.Windows.Forms.TextBox txtIlceID;
        private System.Windows.Forms.TextBox txtSehirID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblHataDogumTarihi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHataSoyad;
        private System.Windows.Forms.Label lblHataAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHataTckn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBayan;
        private System.Windows.Forms.RadioButton rbBay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHataTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCepTelefon;
        private System.Windows.Forms.MaskedTextBox txtEvTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox esfse;
        private System.Windows.Forms.ComboBox cbMahalle;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblHataMahalle;
        private System.Windows.Forms.Label lblHataIlce;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblHataSehir;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.MaskedTextBox txtTckn;
    }
}