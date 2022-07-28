namespace Library_Management.Forms {
    partial class FormUyeEkle {
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.cmbboxcinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new FontAwesome.Sharp.IconButton();
            this.btnIptal = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(226, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cinsiyet";
            // 
            // txtyas
            // 
            this.txtyas.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtyas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyas.Location = new System.Drawing.Point(370, 205);
            this.txtyas.Multiline = true;
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(246, 28);
            this.txtyas.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(242, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Yaş";
            // 
            // txttel
            // 
            this.txttel.BackColor = System.Drawing.Color.RoyalBlue;
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.Location = new System.Drawing.Point(370, 114);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(246, 28);
            this.txttel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(226, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Telefon";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtadsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(370, 29);
            this.txtadsoyad.Multiline = true;
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(246, 28);
            this.txtadsoyad.TabIndex = 13;
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAd.Location = new System.Drawing.Point(207, 27);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(147, 37);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad - Soyad";
            // 
            // cmbboxcinsiyet
            // 
            this.cmbboxcinsiyet.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbboxcinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbboxcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxcinsiyet.FormattingEnabled = true;
            this.cmbboxcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbboxcinsiyet.Location = new System.Drawing.Point(370, 289);
            this.cmbboxcinsiyet.Name = "cmbboxcinsiyet";
            this.cmbboxcinsiyet.Size = new System.Drawing.Size(246, 32);
            this.cmbboxcinsiyet.TabIndex = 21;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKaydet.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnKaydet.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKaydet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKaydet.IconSize = 40;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(204, 358);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnKaydet.Size = new System.Drawing.Size(150, 60);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnIptal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIptal.IconSize = 40;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(413, 358);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnIptal.Size = new System.Drawing.Size(150, 60);
            this.btnIptal.TabIndex = 23;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbboxcinsiyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "FormUyeEkle";
            this.Text = "Üye Ekle";
            this.Load += new System.EventHandler(this.FormUyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ComboBox cmbboxcinsiyet;
        private FontAwesome.Sharp.IconButton btnKaydet;
        private FontAwesome.Sharp.IconButton btnIptal;
    }
}