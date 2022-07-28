namespace Library_Management {
    partial class FormEmanetIade {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTeslimAl = new FontAwesome.Sharp.IconButton();
            this.btnIptal = new FontAwesome.Sharp.IconButton();
            this.txtTelefonaGöre = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtBarkodNoGöre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Location = new System.Drawing.Point(25, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(751, 307);
            this.dataGridView1.TabIndex = 50;
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.FlatAppearance.BorderSize = 0;
            this.btnTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAl.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeslimAl.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnTeslimAl.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTeslimAl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeslimAl.IconSize = 40;
            this.btnTeslimAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslimAl.Location = new System.Drawing.Point(297, 381);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnTeslimAl.Size = new System.Drawing.Size(172, 51);
            this.btnTeslimAl.TabIndex = 51;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslimAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnIptal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIptal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIptal.IconSize = 40;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(531, 381);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnIptal.Size = new System.Drawing.Size(136, 51);
            this.btnIptal.TabIndex = 52;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtTelefonaGöre
            // 
            this.txtTelefonaGöre.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefonaGöre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonaGöre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonaGöre.Location = new System.Drawing.Point(146, 26);
            this.txtTelefonaGöre.Multiline = true;
            this.txtTelefonaGöre.Name = "txtTelefonaGöre";
            this.txtTelefonaGöre.Size = new System.Drawing.Size(181, 17);
            this.txtTelefonaGöre.TabIndex = 54;
            this.txtTelefonaGöre.TextChanged += new System.EventHandler(this.txtTelefonaGöre_TextChanged);
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAd.Location = new System.Drawing.Point(75, 26);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(52, 17);
            this.lblAd.TabIndex = 53;
            this.lblAd.Text = "Telefon";
            // 
            // txtBarkodNoGöre
            // 
            this.txtBarkodNoGöre.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtBarkodNoGöre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarkodNoGöre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNoGöre.Location = new System.Drawing.Point(515, 26);
            this.txtBarkodNoGöre.Multiline = true;
            this.txtBarkodNoGöre.Name = "txtBarkodNoGöre";
            this.txtBarkodNoGöre.Size = new System.Drawing.Size(181, 17);
            this.txtBarkodNoGöre.TabIndex = 56;
            this.txtBarkodNoGöre.TextChanged += new System.EventHandler(this.txtBarkodNoGöre_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(420, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Kitap Barkod";
            // 
            // FormEmanetIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBarkodNoGöre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefonaGöre);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEmanetIade";
            this.Text = "Emanet İade";
            this.Load += new System.EventHandler(this.FormEmanetIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnTeslimAl;
        private FontAwesome.Sharp.IconButton btnIptal;
        private System.Windows.Forms.TextBox txtTelefonaGöre;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtBarkodNoGöre;
        private System.Windows.Forms.Label label1;
    }
}