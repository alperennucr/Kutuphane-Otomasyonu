namespace Library_Management.Forms {
    partial class FormUyeListesi {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIptal = new FontAwesome.Sharp.IconButton();
            this.btnGuncelle = new FontAwesome.Sharp.IconButton();
            this.cmbboxcinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAraTc = new System.Windows.Forms.TextBox();
            this.txtTelAra = new System.Windows.Forms.Label();
            this.btnSil = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnIptal.IconSize = 25;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(202, 332);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnIptal.Size = new System.Drawing.Size(115, 36);
            this.btnIptal.TabIndex = 33;
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
            this.btnGuncelle.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnGuncelle.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuncelle.IconSize = 25;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(29, 332);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnGuncelle.Size = new System.Drawing.Size(140, 37);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbboxcinsiyet
            // 
            this.cmbboxcinsiyet.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbboxcinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbboxcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxcinsiyet.FormattingEnabled = true;
            this.cmbboxcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbboxcinsiyet.Location = new System.Drawing.Point(120, 250);
            this.cmbboxcinsiyet.Name = "cmbboxcinsiyet";
            this.cmbboxcinsiyet.Size = new System.Drawing.Size(223, 24);
            this.cmbboxcinsiyet.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(36, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cinsiyet";
            // 
            // txtyas
            // 
            this.txtyas.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtyas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyas.Location = new System.Drawing.Point(120, 170);
            this.txtyas.Multiline = true;
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(170, 26);
            this.txtyas.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(46, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Yaş";
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.Color.RoyalBlue;
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(120, 101);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(170, 26);
            this.txttel.TabIndex = 27;
            this.txttel.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(36, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Telefon";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtadsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(120, 30);
            this.txtadsoyad.Multiline = true;
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(170, 26);
            this.txtadsoyad.TabIndex = 25;
            this.txtadsoyad.TextChanged += new System.EventHandler(this.txtadsoyad_TextChanged);
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAd.Location = new System.Drawing.Point(26, 36);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(77, 20);
            this.lblAd.TabIndex = 24;
            this.lblAd.Text = "Ad - Soyad";
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
            this.dataGridView1.Location = new System.Drawing.Point(370, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(500, 251);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtAraTc
            // 
            this.txtAraTc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAraTc.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtAraTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAraTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraTc.Location = new System.Drawing.Point(537, 30);
            this.txtAraTc.Multiline = true;
            this.txtAraTc.Name = "txtAraTc";
            this.txtAraTc.Size = new System.Drawing.Size(225, 23);
            this.txtAraTc.TabIndex = 36;
            this.txtAraTc.TextChanged += new System.EventHandler(this.txtAraTc_TextChanged);
            // 
            // txtTelAra
            // 
            this.txtTelAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelAra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelAra.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTelAra.Location = new System.Drawing.Point(434, 30);
            this.txtTelAra.Name = "txtTelAra";
            this.txtTelAra.Size = new System.Drawing.Size(83, 23);
            this.txtTelAra.TabIndex = 35;
            this.txtTelAra.Text = "Telefon İle  Ara";
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSil.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSil.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSil.IconSize = 25;
            this.btnSil.Location = new System.Drawing.Point(595, 385);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSil.Size = new System.Drawing.Size(107, 44);
            this.btnSil.TabIndex = 37;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FormUyeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtAraTc);
            this.Controls.Add(this.txtTelAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbboxcinsiyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "FormUyeListesi";
            this.Text = "Üye Listesi";
            this.Load += new System.EventHandler(this.FormUyeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnIptal;
        private FontAwesome.Sharp.IconButton btnGuncelle;
        private System.Windows.Forms.ComboBox cmbboxcinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAraTc;
        private System.Windows.Forms.Label txtTelAra;
        private FontAwesome.Sharp.IconButton btnSil;
    }
}