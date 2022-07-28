using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management.Forms {
    public partial class FormUyeEkle : Form {
        public FormUyeEkle() {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void FormUyeEkle_Load(object sender, EventArgs e) {

        }

        private void btnIptal_Click(object sender, EventArgs e) {
            this.Close();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(adsoyad,telefon,yas,cinsiyet) values(@adsoyad,@telefon,@yas,@cinsiyet)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad",txtadsoyad.Text.ToString());
            komut.Parameters.AddWithValue("@telefon", txttel.Text.ToString());
            komut.Parameters.AddWithValue("@yas", txtyas.Text.ToString());
            komut.Parameters.AddWithValue("@cinsiyet", cmbboxcinsiyet.Text.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydedildi");
            foreach (Control item in Controls) {
                if (item is TextBox) {
                        item.Text = "";    
                }
            }
        }
    }
}
