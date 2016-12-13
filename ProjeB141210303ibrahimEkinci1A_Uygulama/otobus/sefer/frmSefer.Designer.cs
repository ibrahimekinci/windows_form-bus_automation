namespace otobus
{
    partial class frmSefer
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtSeferNo = new System.Windows.Forms.TextBox();
            this.gbSeferDuzenle = new System.Windows.Forms.GroupBox();
            this.btnCalisanGetir = new System.Windows.Forms.Button();
            this.btnSolaAt = new System.Windows.Forms.Button();
            this.btnSagaAt = new System.Windows.Forms.Button();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.lvCalisanlar = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTarihSec = new System.Windows.Forms.GroupBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSaat = new System.Windows.Forms.ComboBox();
            this.cbDakika = new System.Windows.Forms.ComboBox();
            this.dtpBaslangıcTarih = new System.Windows.Forms.DateTimePicker();
            this.gbGuzergahArac = new System.Windows.Forms.GroupBox();
            this.btnAracAra = new System.Windows.Forms.Button();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAracID = new System.Windows.Forms.TextBox();
            this.txtGuzergah = new System.Windows.Forms.TextBox();
            this.btnGuzergahSec = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtGuzergahID = new System.Windows.Forms.TextBox();
            this.gbSeferDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.gbTarihSec.SuspendLayout();
            this.gbGuzergahArac.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Teal;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.Location = new System.Drawing.Point(790, 452);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 33);
            this.btn.TabIndex = 53;
            this.btn.Text = "İşlem";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(428, 16);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(50, 16);
            this.lblMesaj.TabIndex = 65;
            this.lblMesaj.Text = "Mesaj";
            this.lblMesaj.Visible = false;
            // 
            // txtSeferNo
            // 
            this.txtSeferNo.ForeColor = System.Drawing.Color.Violet;
            this.txtSeferNo.Location = new System.Drawing.Point(34, 10);
            this.txtSeferNo.Name = "txtSeferNo";
            this.txtSeferNo.ReadOnly = true;
            this.txtSeferNo.Size = new System.Drawing.Size(26, 20);
            this.txtSeferNo.TabIndex = 66;
            // 
            // gbSeferDuzenle
            // 
            this.gbSeferDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbSeferDuzenle.Controls.Add(this.btnCalisanGetir);
            this.gbSeferDuzenle.Controls.Add(this.btnSolaAt);
            this.gbSeferDuzenle.Controls.Add(this.btnSagaAt);
            this.gbSeferDuzenle.Controls.Add(this.dgvCalisanlar);
            this.gbSeferDuzenle.Controls.Add(this.lvCalisanlar);
            this.gbSeferDuzenle.Controls.Add(this.gbTarihSec);
            this.gbSeferDuzenle.Controls.Add(this.gbGuzergahArac);
            this.gbSeferDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSeferDuzenle.ForeColor = System.Drawing.Color.Black;
            this.gbSeferDuzenle.Location = new System.Drawing.Point(14, 52);
            this.gbSeferDuzenle.Name = "gbSeferDuzenle";
            this.gbSeferDuzenle.Size = new System.Drawing.Size(945, 396);
            this.gbSeferDuzenle.TabIndex = 67;
            this.gbSeferDuzenle.TabStop = false;
            this.gbSeferDuzenle.Text = "Sefer Düzenle";
            // 
            // btnCalisanGetir
            // 
            this.btnCalisanGetir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalisanGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanGetir.Location = new System.Drawing.Point(726, 9);
            this.btnCalisanGetir.Name = "btnCalisanGetir";
            this.btnCalisanGetir.Size = new System.Drawing.Size(125, 31);
            this.btnCalisanGetir.TabIndex = 85;
            this.btnCalisanGetir.Text = "Çalışan Getir";
            this.btnCalisanGetir.UseVisualStyleBackColor = false;
            this.btnCalisanGetir.Click += new System.EventHandler(this.btnCalisanGetir_Click);
            // 
            // btnSolaAt
            // 
            this.btnSolaAt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSolaAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSolaAt.Location = new System.Drawing.Point(566, 244);
            this.btnSolaAt.Name = "btnSolaAt";
            this.btnSolaAt.Size = new System.Drawing.Size(46, 33);
            this.btnSolaAt.TabIndex = 49;
            this.btnSolaAt.Text = ">>";
            this.btnSolaAt.UseVisualStyleBackColor = false;
            this.btnSolaAt.Click += new System.EventHandler(this.btnSolaAt_Click);
            // 
            // btnSagaAt
            // 
            this.btnSagaAt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSagaAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSagaAt.Location = new System.Drawing.Point(566, 190);
            this.btnSagaAt.Name = "btnSagaAt";
            this.btnSagaAt.Size = new System.Drawing.Size(46, 34);
            this.btnSagaAt.TabIndex = 74;
            this.btnSagaAt.Text = "<<";
            this.btnSagaAt.UseVisualStyleBackColor = false;
            this.btnSagaAt.Click += new System.EventHandler(this.btnSagaAt_Click);
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AllowDrop = true;
            this.dgvCalisanlar.AllowUserToOrderColumns = true;
            this.dgvCalisanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCalisanlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCalisanlar.Location = new System.Drawing.Point(658, 46);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.ReadOnly = true;
            this.dgvCalisanlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCalisanlar.RowTemplate.ReadOnly = true;
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(281, 344);
            this.dgvCalisanlar.TabIndex = 84;
            // 
            // lvCalisanlar
            // 
            this.lvCalisanlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvCalisanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2});
            this.lvCalisanlar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvCalisanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvCalisanlar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvCalisanlar.FullRowSelect = true;
            this.lvCalisanlar.GridLines = true;
            this.lvCalisanlar.Location = new System.Drawing.Point(332, 26);
            this.lvCalisanlar.Name = "lvCalisanlar";
            this.lvCalisanlar.Size = new System.Drawing.Size(310, 147);
            this.lvCalisanlar.TabIndex = 83;
            this.lvCalisanlar.UseCompatibleStateImageBehavior = false;
            this.lvCalisanlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 37;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyad";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pozisyon";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 96;
            // 
            // gbTarihSec
            // 
            this.gbTarihSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbTarihSec.Controls.Add(this.txtTarih);
            this.gbTarihSec.Controls.Add(this.label2);
            this.gbTarihSec.Controls.Add(this.cbSaat);
            this.gbTarihSec.Controls.Add(this.cbDakika);
            this.gbTarihSec.Controls.Add(this.dtpBaslangıcTarih);
            this.gbTarihSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTarihSec.Location = new System.Drawing.Point(6, 200);
            this.gbTarihSec.Name = "gbTarihSec";
            this.gbTarihSec.Size = new System.Drawing.Size(313, 137);
            this.gbTarihSec.TabIndex = 82;
            this.gbTarihSec.TabStop = false;
            this.gbTarihSec.Text = "Tarih Seç";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(6, 23);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(129, 20);
            this.txtTarih.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = ":";
            // 
            // cbSaat
            // 
            this.cbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaat.DropDownWidth = 30;
            this.cbSaat.FormattingEnabled = true;
            this.cbSaat.Location = new System.Drawing.Point(23, 70);
            this.cbSaat.Name = "cbSaat";
            this.cbSaat.Size = new System.Drawing.Size(44, 21);
            this.cbSaat.TabIndex = 63;
            this.cbSaat.SelectedIndexChanged += new System.EventHandler(this.cbSaat_SelectedIndexChanged);
            // 
            // cbDakika
            // 
            this.cbDakika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDakika.DropDownWidth = 30;
            this.cbDakika.FormattingEnabled = true;
            this.cbDakika.Location = new System.Drawing.Point(91, 70);
            this.cbDakika.Name = "cbDakika";
            this.cbDakika.Size = new System.Drawing.Size(41, 21);
            this.cbDakika.TabIndex = 63;
            this.cbDakika.SelectedIndexChanged += new System.EventHandler(this.cbDakika_SelectedIndexChanged);
            // 
            // dtpBaslangıcTarih
            // 
            this.dtpBaslangıcTarih.CustomFormat = "\'00/00/0000\'";
            this.dtpBaslangıcTarih.Location = new System.Drawing.Point(137, 23);
            this.dtpBaslangıcTarih.Name = "dtpBaslangıcTarih";
            this.dtpBaslangıcTarih.Size = new System.Drawing.Size(19, 20);
            this.dtpBaslangıcTarih.TabIndex = 47;
            this.dtpBaslangıcTarih.ValueChanged += new System.EventHandler(this.dtpBaslangıcTarih_ValueChanged);
            // 
            // gbGuzergahArac
            // 
            this.gbGuzergahArac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbGuzergahArac.Controls.Add(this.btnAracAra);
            this.gbGuzergahArac.Controls.Add(this.txtAracPlaka);
            this.gbGuzergahArac.Controls.Add(this.label1);
            this.gbGuzergahArac.Controls.Add(this.txtAracID);
            this.gbGuzergahArac.Controls.Add(this.txtGuzergah);
            this.gbGuzergahArac.Controls.Add(this.btnGuzergahSec);
            this.gbGuzergahArac.Controls.Add(this.lbl);
            this.gbGuzergahArac.Controls.Add(this.txtGuzergahID);
            this.gbGuzergahArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGuzergahArac.Location = new System.Drawing.Point(6, 26);
            this.gbGuzergahArac.Name = "gbGuzergahArac";
            this.gbGuzergahArac.Size = new System.Drawing.Size(313, 147);
            this.gbGuzergahArac.TabIndex = 81;
            this.gbGuzergahArac.TabStop = false;
            this.gbGuzergahArac.Text = "Güzergah ve Araç Seç";
            // 
            // btnAracAra
            // 
            this.btnAracAra.BackColor = System.Drawing.Color.Maroon;
            this.btnAracAra.Location = new System.Drawing.Point(239, 94);
            this.btnAracAra.Name = "btnAracAra";
            this.btnAracAra.Size = new System.Drawing.Size(50, 23);
            this.btnAracAra.TabIndex = 61;
            this.btnAracAra.Text = "...";
            this.btnAracAra.UseVisualStyleBackColor = false;
            this.btnAracAra.Click += new System.EventHandler(this.btnAracAra_Click);
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(106, 95);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.ReadOnly = true;
            this.txtAracPlaka.Size = new System.Drawing.Size(127, 20);
            this.txtAracPlaka.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Araç";
            // 
            // txtAracID
            // 
            this.txtAracID.Location = new System.Drawing.Point(10, 97);
            this.txtAracID.Name = "txtAracID";
            this.txtAracID.ReadOnly = true;
            this.txtAracID.Size = new System.Drawing.Size(21, 20);
            this.txtAracID.TabIndex = 64;
            // 
            // txtGuzergah
            // 
            this.txtGuzergah.Location = new System.Drawing.Point(105, 39);
            this.txtGuzergah.Name = "txtGuzergah";
            this.txtGuzergah.ReadOnly = true;
            this.txtGuzergah.Size = new System.Drawing.Size(128, 20);
            this.txtGuzergah.TabIndex = 58;
            // 
            // btnGuzergahSec
            // 
            this.btnGuzergahSec.BackColor = System.Drawing.Color.Maroon;
            this.btnGuzergahSec.Location = new System.Drawing.Point(239, 37);
            this.btnGuzergahSec.Name = "btnGuzergahSec";
            this.btnGuzergahSec.Size = new System.Drawing.Size(50, 22);
            this.btnGuzergahSec.TabIndex = 56;
            this.btnGuzergahSec.Text = "...";
            this.btnGuzergahSec.UseVisualStyleBackColor = false;
            this.btnGuzergahSec.Click += new System.EventHandler(this.btnGuzergahSec_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(36, 39);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 13);
            this.lbl.TabIndex = 57;
            this.lbl.Text = "Güzergah";
            // 
            // txtGuzergahID
            // 
            this.txtGuzergahID.Location = new System.Drawing.Point(9, 37);
            this.txtGuzergahID.Name = "txtGuzergahID";
            this.txtGuzergahID.ReadOnly = true;
            this.txtGuzergahID.Size = new System.Drawing.Size(21, 20);
            this.txtGuzergahID.TabIndex = 60;
            // 
            // frmSefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 497);
            this.Controls.Add(this.gbSeferDuzenle);
            this.Controls.Add(this.txtSeferNo);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btn);
            this.Name = "frmSefer";
            this.Text = "Sefer";
            this.Load += new System.EventHandler(this.frmSefer_Load);
            this.gbSeferDuzenle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.gbTarihSec.ResumeLayout(false);
            this.gbTarihSec.PerformLayout();
            this.gbGuzergahArac.ResumeLayout(false);
            this.gbGuzergahArac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtSeferNo;
        private System.Windows.Forms.GroupBox gbSeferDuzenle;
        private System.Windows.Forms.GroupBox gbTarihSec;
        private System.Windows.Forms.DateTimePicker dtpBaslangıcTarih;
        private System.Windows.Forms.GroupBox gbGuzergahArac;
        private System.Windows.Forms.Button btnAracAra;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAracID;
        private System.Windows.Forms.TextBox txtGuzergah;
        private System.Windows.Forms.Button btnGuzergahSec;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtGuzergahID;
        private System.Windows.Forms.Button btnSagaAt;
        private System.Windows.Forms.Button btnSolaAt;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.ListView lvCalisanlar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbDakika;
        private System.Windows.Forms.ComboBox cbSaat;
        private System.Windows.Forms.Button btnCalisanGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarih;

    }
}