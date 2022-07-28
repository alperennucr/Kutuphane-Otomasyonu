namespace Library_Management.Forms {
    partial class FormKitapListesi {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboTuru = new System.Windows.Forms.ComboBox();
            this.btnIptal = new FontAwesome.Sharp.IconButton();
            this.btnGuncelle = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new FontAwesome.Sharp.IconButton();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTuru
            // 
            this.comboTuru.BackColor = System.Drawing.Color.RoyalBlue;
            this.comboTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboTuru.FormattingEnabled = true;
            this.comboTuru.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Biyografi",
            "Gezi",
            "Diğer"});
            this.comboTuru.Location = new System.Drawing.Point(119, 329);
            this.comboTuru.Name = "comboTuru";
            this.comboTuru.Size = new System.Drawing.Size(181, 24);
            this.comboTuru.TabIndex = 46;
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnIptal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIptal.IconSize = 30;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(188, 386);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnIptal.Size = new System.Drawing.Size(112, 39);
            this.btnIptal.TabIndex = 45;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.IconChar = FontAwesome.Sharp.IconChar.SlackHash;
            this.btnGuncelle.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuncelle.IconSize = 30;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(25, 386);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnGuncelle.Size = new System.Drawing.Size(142, 39);
            this.btnGuncelle.TabIndex = 44;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(64, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Türü";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(119, 276);
            this.txtSayfaSayisi.Multiline = true;
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(181, 17);
            this.txtSayfaSayisi.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(29, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYayinevi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinevi.Location = new System.Drawing.Point(119, 215);
            this.txtYayinevi.Multiline = true;
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(181, 17);
            this.txtYayinevi.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(46, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Yayınevi";
            // 
            // txtYazari
            // 
            this.txtYazari.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYazari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazari.Location = new System.Drawing.Point(119, 152);
            this.txtYazari.Multiline = true;
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(181, 17);
            this.txtYazari.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(57, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Yazarı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(119, 86);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(181, 17);
            this.txtKitapAdi.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Kitap Adı";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(119, 25);
            this.txtBarkodNo.Multiline = true;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(181, 17);
            this.txtBarkodNo.TabIndex = 34;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAd.Location = new System.Drawing.Point(22, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(84, 17);
            this.lblAd.TabIndex = 33;
            this.lblAd.Text = "Kitap Barkod";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(341, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(712, 291);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSil.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSil.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSil.IconSize = 25;
            this.btnSil.Location = new System.Drawing.Point(664, 359);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSil.Size = new System.Drawing.Size(108, 44);
            this.btnSil.TabIndex = 48;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtBarkodAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarkodAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodAra.Location = new System.Drawing.Point(618, 22);
            this.txtBarkodAra.Multiline = true;
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(181, 17);
            this.txtBarkodAra.TabIndex = 50;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(508, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Barkod ile Ara";
            // 
            // FormKitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboTuru);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
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
            this.Name = "FormKitapListesi";
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.FormKitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTuru;
        private FontAwesome.Sharp.IconButton btnIptal;
        private FontAwesome.Sharp.IconButton btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnSil;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Label label6;
    }
}