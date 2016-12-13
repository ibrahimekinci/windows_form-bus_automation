namespace otobus
{
    partial class frmKullanici
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
            this.gbUyelik = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalisanID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.gbUyelik.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUyelik
            // 
            this.gbUyelik.Controls.Add(this.label2);
            this.gbUyelik.Controls.Add(this.textBox2);
            this.gbUyelik.Controls.Add(this.textBox1);
            this.gbUyelik.Controls.Add(this.label1);
            this.gbUyelik.Location = new System.Drawing.Point(42, 106);
            this.gbUyelik.Name = "gbUyelik";
            this.gbUyelik.Size = new System.Drawing.Size(300, 84);
            this.gbUyelik.TabIndex = 19;
            this.gbUyelik.TabStop = false;
            this.gbUyelik.Text = "Üye Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Şifre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Çalışan Ad Soyad";
            // 
            // txtCalisanID
            // 
            this.txtCalisanID.Location = new System.Drawing.Point(139, 45);
            this.txtCalisanID.Name = "txtCalisanID";
            this.txtCalisanID.ReadOnly = true;
            this.txtCalisanID.Size = new System.Drawing.Size(70, 20);
            this.txtCalisanID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Çalışan ID";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(42, 14);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 25;
            this.lblMesaj.Text = "Mesaj";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(45, 204);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 26;
            this.btn.Text = "işlem";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 239);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalisanID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.gbUyelik);
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            this.gbUyelik.ResumeLayout(false);
            this.gbUyelik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUyelik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalisanID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btn;
    }
}