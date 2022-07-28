namespace Library_Management.Forms {
    partial class EmanetVer {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUyeBİlgi = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefonAra = new System.Windows.Forms.TextBox();
            this.grpKitapBilgi = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.dtIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.dtTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new FontAwesome.Sharp.IconButton();
            this.btnIptal = new FontAwesome.Sharp.IconButton();
            this.btnTeslimEt = new FontAwesome.Sharp.IconButton();
            this.btnSil = new FontAwesome.Sharp.IconButton();
            this.btnNK = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUyeBİlgi.SuspendLayout();
            this.grpKitapBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(261, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(607, 326);
            this.dataGridView1.TabIndex = 48;
            // 
            // grpUyeBİlgi
            // 
            this.grpUyeBİlgi.Controls.Add(this.label3);
            this.grpUyeBİlgi.Controls.Add(this.label2);
            this.grpUyeBİlgi.Controls.Add(this.label1);
            this.grpUyeBİlgi.Controls.Add(this.txtYas);
            this.grpUyeBİlgi.Controls.Add(this.txtAdSoyad);
            this.grpUyeBİlgi.Controls.Add(this.txtTelefonAra);
            this.grpUyeBİlgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpUyeBİlgi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUyeBİlgi.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpUyeBİlgi.Location = new System.Drawing.Point(27, 21);
            this.grpUyeBİlgi.Name = "grpUyeBİlgi";
            this.grpUyeBİlgi.Size = new System.Drawing.Size(206, 149);
            this.grpUyeBİlgi.TabIndex = 49;
            this.grpUyeBİlgi.TabStop = false;
            this.grpUyeBİlgi.Text = "Üye Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefon Ara";
            // 
            // txtYas
            // 
            this.txtYas.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYas.Location = new System.Drawing.Point(94, 112);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 23);
            this.txtYas.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Location = new System.Drawing.Point(94, 74);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefonAra
            // 
            this.txtTelefonAra.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefonAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonAra.Location = new System.Drawing.Point(94, 36);
            this.txtTelefonAra.Name = "txtTelefonAra";
            this.txtTelefonAra.Size = new System.Drawing.Size(100, 23);
            this.txtTelefonAra.TabIndex = 0;
            this.txtTelefonAra.TextChanged += new System.EventHandler(this.txtTelefonAra_TextChanged);
            // 
            // grpKitapBilgi
            // 
            this.grpKitapBilgi.Controls.Add(this.label12);
            this.grpKitapBilgi.Controls.Add(this.label11);
            this.grpKitapBilgi.Controls.Add(this.label8);
            this.grpKitapBilgi.Controls.Add(this.label7);
            this.grpKitapBilgi.Controls.Add(this.label6);
            this.grpKitapBilgi.Controls.Add(this.label5);
            this.grpKitapBilgi.Controls.Add(this.label4);
            this.grpKitapBilgi.Controls.Add(this.txtSayfaSayisi);
            this.grpKitapBilgi.Controls.Add(this.dtIadeTarihi);
            this.grpKitapBilgi.Controls.Add(this.txtYayinevi);
            this.grpKitapBilgi.Controls.Add(this.dtTeslimTarihi);
            this.grpKitapBilgi.Controls.Add(this.txtYazari);
            this.grpKitapBilgi.Controls.Add(this.txtKitapAdi);
            this.grpKitapBilgi.Controls.Add(this.txtBarkodNo);
            this.grpKitapBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpKitapBilgi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKitapBilgi.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpKitapBilgi.Location = new System.Drawing.Point(27, 176);
            this.grpKitapBilgi.Name = "grpKitapBilgi";
            this.grpKitapBilgi.Size = new System.Drawing.Size(200, 295);
            this.grpKitapBilgi.TabIndex = 50;
            this.grpKitapBilgi.TabStop = false;
            this.grpKitapBilgi.Text = "Kitap Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "İade Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Teslim Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sayfa Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yayınevi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yazarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kitap Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Barkod No";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(94, 183);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(100, 23);
            this.txtSayfaSayisi.TabIndex = 11;
            // 
            // dtIadeTarihi
            // 
            this.dtIadeTarihi.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtIadeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIadeTarihi.Location = new System.Drawing.Point(94, 263);
            this.dtIadeTarihi.Name = "dtIadeTarihi";
            this.dtIadeTarihi.Size = new System.Drawing.Size(100, 23);
            this.dtIadeTarihi.TabIndex = 1;
            this.dtIadeTarihi.ValueChanged += new System.EventHandler(this.dtIadeTarihi_ValueChanged);
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYayinevi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYayinevi.Location = new System.Drawing.Point(94, 145);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(100, 23);
            this.txtYayinevi.TabIndex = 10;
            // 
            // dtTeslimTarihi
            // 
            this.dtTeslimTarihi.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTeslimTarihi.Location = new System.Drawing.Point(94, 225);
            this.dtTeslimTarihi.Name = "dtTeslimTarihi";
            this.dtTeslimTarihi.Size = new System.Drawing.Size(100, 23);
            this.dtTeslimTarihi.TabIndex = 0;
            this.dtTeslimTarihi.ValueChanged += new System.EventHandler(this.dtTeslimTarihi_ValueChanged);
            // 
            // txtYazari
            // 
            this.txtYazari.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtYazari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazari.Location = new System.Drawing.Point(94, 104);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(100, 23);
            this.txtYazari.TabIndex = 9;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKitapAdi.Location = new System.Drawing.Point(94, 63);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 23);
            this.txtKitapAdi.TabIndex = 8;
            this.txtKitapAdi.TextChanged += new System.EventHandler(this.txtKitapAdi_TextChanged);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarkodNo.Location = new System.Drawing.Point(94, 22);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNo.TabIndex = 7;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
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
            this.btnEkle.IconSize = 35;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(249, 430);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEkle.Size = new System.Drawing.Size(129, 41);
            this.btnEkle.TabIndex = 51;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnIptal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIptal.IconSize = 30;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(626, 367);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnIptal.Size = new System.Drawing.Size(115, 44);
            this.btnIptal.TabIndex = 52;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTeslimEt.FlatAppearance.BorderSize = 0;
            this.btnTeslimEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimEt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeslimEt.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnTeslimEt.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTeslimEt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeslimEt.IconSize = 30;
            this.btnTeslimEt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslimEt.Location = new System.Drawing.Point(457, 367);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnTeslimEt.Size = new System.Drawing.Size(151, 44);
            this.btnTeslimEt.TabIndex = 53;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslimEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSil.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSil.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSil.IconSize = 30;
            this.btnSil.Location = new System.Drawing.Point(763, 367);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSil.Size = new System.Drawing.Size(105, 44);
            this.btnSil.TabIndex = 54;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnNK
            // 
            this.btnNK.FlatAppearance.BorderSize = 0;
            this.btnNK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNK.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNK.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnNK.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNK.IconSize = 32;
            this.btnNK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNK.Location = new System.Drawing.Point(423, 431);
            this.btnNK.Name = "btnNK";
            this.btnNK.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnNK.Size = new System.Drawing.Size(203, 41);
            this.btnNK.TabIndex = 55;
            this.btnNK.Text = "Nasıl Kullanılır";
            this.btnNK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNK.UseVisualStyleBackColor = true;
            this.btnNK.Click += new System.EventHandler(this.btnNK_Click);
            // 
            // EmanetVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(891, 484);
            this.Controls.Add(this.btnNK);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpKitapBilgi);
            this.Controls.Add(this.grpUyeBİlgi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetVer";
            this.Text = "Emanet Ver";
            this.Load += new System.EventHandler(this.EmanetVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUyeBİlgi.ResumeLayout(false);
            this.grpUyeBİlgi.PerformLayout();
            this.grpKitapBilgi.ResumeLayout(false);
            this.grpKitapBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUyeBİlgi;
        private System.Windows.Forms.GroupBox grpKitapBilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefonAra;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.DateTimePicker dtIadeTarihi;
        private System.Windows.Forms.DateTimePicker dtTeslimTarihi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnEkle;
        private FontAwesome.Sharp.IconButton btnIptal;
        private FontAwesome.Sharp.IconButton btnTeslimEt;
        private FontAwesome.Sharp.IconButton btnSil;
        private FontAwesome.Sharp.IconButton btnNK;
    }
}