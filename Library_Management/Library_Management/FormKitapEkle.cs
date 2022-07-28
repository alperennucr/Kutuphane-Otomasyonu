using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Forms {
    public partial class FormKitapEkle : Form {
        public FormKitapEkle() {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        
        private void FormKitapEkle_Load(object sender, EventArgs e) {
          
        }

        private void btnIptal_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,kayittarihi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi",txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari",txtYazari.Text);
            komut.Parameters.AddWithValue("@yayinevi",txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi",txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu",comboTuru.Text);
            komut.Parameters.AddWithValue("@kayittarihi",DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydedildi");
            foreach (Control item in Controls) {
                if (item is TextBox) {
                    item.Text = "";
                }
                    
            }
        }
    }
}
