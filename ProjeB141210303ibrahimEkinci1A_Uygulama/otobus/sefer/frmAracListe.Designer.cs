namespace otobus
{
    partial class frmAracListe
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
            this.lvAraclar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbAracModeli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.btnAracAra = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvAraclar
            // 
            this.lvAraclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvAraclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvAraclar.FullRowSelect = true;
            this.lvAraclar.GridLines = true;
            this.lvAraclar.Location = new System.Drawing.Point(12, 153);
            this.lvAraclar.Name = "lvAraclar";
            this.lvAraclar.Size = new System.Drawing.Size(509, 299);
            this.lvAraclar.TabIndex = 26;
            this.lvAraclar.UseCompatibleStateImageBehavior = false;
            this.lvAraclar.View = System.Windows.Forms.View.Details;
            this.lvAraclar.DoubleClick += new System.EventHandler(this.lvAraclar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OtobusID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Durum";
            this.columnHeader7.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "saseNumarası";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marka ";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Plaka";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Koltuk Sayısı";
            this.columnHeader6.Width = 76;
            // 
            // cbAracModeli
            // 
            this.cbAracModeli.FormattingEnabled = true;
            this.cbAracModeli.Location = new System.Drawing.Point(37, 89);
            this.cbAracModeli.Name = "cbAracModeli";
            this.cbAracModeli.Size = new System.Drawing.Size(115, 21);
            this.cbAracModeli.TabIndex = 27;
            this.cbAracModeli.Text = "Araç Modeli Seçiniz";
            this.cbAracModeli.SelectedIndexChanged += new System.EventHandler(this.cbAracModeli_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "eğer araç seferdeyse dfurumu 0 olacak sefer bittiyse durumu tekrar 1 olacak";
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(344, 87);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(21, 20);
            this.dtpTarih1.TabIndex = 29;
            this.dtpTarih1.ValueChanged += new System.EventHandler(this.dtpTarih1_ValueChanged);
            // 
            // btnAracAra
            // 
            this.btnAracAra.Location = new System.Drawing.Point(424, 87);
            this.btnAracAra.Name = "btnAracAra";
            this.btnAracAra.Size = new System.Drawing.Size(50, 23);
            this.btnAracAra.TabIndex = 31;
            this.btnAracAra.Text = "ARA";
            this.btnAracAra.UseVisualStyleBackColor = true;
            this.btnAracAra.Click += new System.EventHandler(this.btnAracAra_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(247, 87);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(100, 20);
            this.txtTarih.TabIndex = 32;
            // 
            // frmAracListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 464);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.btnAracAra);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAracModeli);
            this.Controls.Add(this.lvAraclar);
            this.Name = "frmAracListe";
            this.Text = "frmAracListe";
            this.Load += new System.EventHandler(this.frmAracListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAraclar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cbAracModeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.Button btnAracAra;
        private System.Windows.Forms.TextBox txtTarih;
    }
}