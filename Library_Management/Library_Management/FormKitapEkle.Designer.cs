namespace Library_Management.Forms {
    partial class FormKitapEkle {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new FontAwesome.Sharp.IconButton();
            this.btnIptal = new FontAwesome.Sharp.IconButton();
            this.comboTuru = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(218, 32);
            this.txtBarkodNo.Multiline = true;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(259, 27);
            this.txtBarkodNo.TabIndex = 15;
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAd.Location = new System.Drawing.Point(45, 32);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(143, 27);
            this.lblAd.TabIndex = 14;
            this.lblAd.Text = "Kitap Barkod";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(218, 93);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(259, 27);
            this.txtKitapAdi.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(80, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Adı";
            // 
            // txtYazari
            // 
            this.txtYazari.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYazari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazari.Location = new System.Drawing.Point(218, 159);
            this.txtYazari.Multiline = true;
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(259, 27);
            this.txtYazari.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(112, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yazarı";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(126, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Türü";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(218, 283);
            this.txtSayfaSayisi.Multiline = true;
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(259, 27);
            this.txtSayfaSayisi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(57, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYayinevi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinevi.Location = new System.Drawing.Point(218, 222);
            this.txtYayinevi.Multiline = true;
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(259, 27);
            this.txtYayinevi.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(89, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yayınevi";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEkle.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnEkle.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEkle.IconSize = 40;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(498, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEkle.Size = new System.Drawing.Size(135, 60);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnIptal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIptal.IconSize = 40;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(652, 32);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnIptal.Size = new System.Drawing.Size(136, 60);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // comboTuru
            // 
            this.comboTuru.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboTuru.FormattingEnabled = true;
            this.comboTuru.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Biyografi",
            "Gezi",
            "Bilgi ",
            "Din ",
            "Anı ",
            "Gezi",
            "Diğer"});
            this.comboTuru.Location = new System.Drawing.Point(218, 347);
            this.comboTuru.Name = "comboTuru";
            this.comboTuru.Size = new System.Drawing.Size(259, 33);
            this.comboTuru.TabIndex = 32;
            // 
            // FormKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboTuru);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblAd);
            this.Name = "FormKitapEkle";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.FormKitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnEkle;
        private FontAwesome.Sharp.IconButton btnIptal;
        private System.Windows.Forms.ComboBox comboTuru;
    }
}