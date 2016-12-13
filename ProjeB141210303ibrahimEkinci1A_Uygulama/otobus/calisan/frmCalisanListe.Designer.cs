namespace otobus{
    partial class frmCalisanListe
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
            this.M = new System.Windows.Forms.GroupBox();
            this.mtnTckno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pozisyon = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbPozisyonlar = new System.Windows.Forms.ComboBox();
            this.M.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // M
            // 
            this.M.Controls.Add(this.cbPozisyonlar);
            this.M.Controls.Add(this.mtnTckno);
            this.M.Controls.Add(this.label3);
            this.M.Controls.Add(this.Pozisyon);
            this.M.Controls.Add(this.asd);
            this.M.Controls.Add(this.txtAdSoyad);
            this.M.Controls.Add(this.label2);
            this.M.Controls.Add(this.label1);
            this.M.Location = new System.Drawing.Point(137, 44);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(454, 80);
            this.M.TabIndex = 8;
            this.M.TabStop = false;
            this.M.Text = "Çalışan Ara";
            // 
            // mtnTckno
            // 
            this.mtnTckno.Location = new System.Drawing.Point(163, 39);
            this.mtnTckno.Mask = "00000000000";
            this.mtnTckno.Name = "mtnTckno";
            this.mtnTckno.Size = new System.Drawing.Size(100, 20);
            this.mtnTckno.TabIndex = 5;
            this.mtnTckno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtnTckno_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "veya";
            // 
            // Pozisyon
            // 
            this.Pozisyon.AutoSize = true;
            this.Pozisyon.Location = new System.Drawing.Point(338, 23);
            this.Pozisyon.Name = "Pozisyon";
            this.Pozisyon.Size = new System.Drawing.Size(49, 13);
            this.Pozisyon.TabIndex = 4;
            this.Pozisyon.Text = "Pozisyon";
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
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tckn";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(134, 143);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(34, 13);
            this.lblMesaj.TabIndex = 11;
            this.lblMesaj.Text = "mesaj";
            this.lblMesaj.Visible = false;
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(46, 172);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(768, 304);
            this.dgv.TabIndex = 10;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // cbPozisyonlar
            // 
            this.cbPozisyonlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPozisyonlar.FormattingEnabled = true;
            this.cbPozisyonlar.Location = new System.Drawing.Point(308, 39);
            this.cbPozisyonlar.Name = "cbPozisyonlar";
            this.cbPozisyonlar.Size = new System.Drawing.Size(121, 21);
            this.cbPozisyonlar.TabIndex = 6;
            this.cbPozisyonlar.SelectedIndexChanged += new System.EventHandler(this.cbPozisyonlar_SelectedIndexChanged);
            // 
            // frmCalisanListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 488);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.M);
            this.Name = "frmCalisanListe";
            this.Text = "frmCalisanListe";
            this.Load += new System.EventHandler(this.frmCalisanListe_Load);
            this.M.ResumeLayout(false);
            this.M.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox M;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Pozisyon;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MaskedTextBox mtnTckno;
        private System.Windows.Forms.ComboBox cbPozisyonlar;
    }
}