namespace otobus
{
    partial class frmSeferListe
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lvSeferListe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGuzergah = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.gbGuzergah = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbGuzergah.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMesaj.Location = new System.Drawing.Point(33, 52);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 12;
            this.lblMesaj.Text = "Mesaj";
            this.lblMesaj.Visible = false;
            // 
            // lvSeferListe
            // 
            this.lvSeferListe.BackColor = System.Drawing.Color.DarkGray;
            this.lvSeferListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8});
            this.lvSeferListe.FullRowSelect = true;
            this.lvSeferListe.GridLines = true;
            this.lvSeferListe.Location = new System.Drawing.Point(374, 24);
            this.lvSeferListe.Name = "lvSeferListe";
            this.lvSeferListe.Size = new System.Drawing.Size(240, 478);
            this.lvSeferListe.TabIndex = 10;
            this.lvSeferListe.UseCompatibleStateImageBehavior = false;
            this.lvSeferListe.View = System.Windows.Forms.View.Details;
            this.lvSeferListe.DoubleClick += new System.EventHandler(this.lvSeferListe_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Güzergah ID";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Güzergah";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sefer Tarihi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Otobüs ID";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 1;
            // 
            // txtGuzergah
            // 
            this.txtGuzergah.Location = new System.Drawing.Point(6, 40);
            this.txtGuzergah.Name = "txtGuzergah";
            this.txtGuzergah.Size = new System.Drawing.Size(167, 21);
            this.txtGuzergah.TabIndex = 13;
            this.txtGuzergah.TextChanged += new System.EventHandler(this.txtGuzergah_TextChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(162, 23);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(20, 21);
            this.dtpTarih.TabIndex = 16;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(22, 23);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(143, 21);
            this.txtTarih.TabIndex = 17;
            // 
            // txtTarih2
            // 
            this.txtTarih2.Location = new System.Drawing.Point(22, 72);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.Size = new System.Drawing.Size(143, 21);
            this.txtTarih2.TabIndex = 20;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(162, 72);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(20, 21);
            this.dtpTarih2.TabIndex = 19;
            this.dtpTarih2.ValueChanged += new System.EventHandler(this.dtpTarih2_ValueChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Gray;
            this.btnAra.Location = new System.Drawing.Point(215, 39);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(46, 38);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // gbGuzergah
            // 
            this.gbGuzergah.Controls.Add(this.txtGuzergah);
            this.gbGuzergah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuzergah.Location = new System.Drawing.Point(58, 303);
            this.gbGuzergah.Name = "gbGuzergah";
            this.gbGuzergah.Size = new System.Drawing.Size(200, 89);
            this.gbGuzergah.TabIndex = 22;
            this.gbGuzergah.TabStop = false;
            this.gbGuzergah.Text = "Güzergaha göre ara";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtTarih2);
            this.groupBox1.Controls.Add(this.dtpTarih2);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.txtTarih);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 113);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarihe göre ara";
            // 
            // frmSeferListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGuzergah);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lvSeferListe);
            this.Name = "frmSeferListe";
            this.Text = "frmSeferListe";
            this.Load += new System.EventHandler(this.frmSeferListe_Load);
            this.gbGuzergah.ResumeLayout(false);
            this.gbGuzergah.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtGuzergah;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtTarih;
        public System.Windows.Forms.ListView lvSeferListe;
        private System.Windows.Forms.TextBox txtTarih2;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox gbGuzergah;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}