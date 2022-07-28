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
    public partial class FormKitapListesi : Form {
        public FormKitapListesi() {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        DataSet daset = new DataSet();
        private void kitaplistele() {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from kitap", baglanti);
            adapter.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"]; //0 da yazabiliriz çünkü bir tablo var
            baglanti.Close();
        }
        private void FormKitapListesi_Load(object sender, EventArgs e) {
            kitaplistele();
            DatagridwiewSettings(dataGridView1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set kitapadi=@kitapadi,yazari=@yazari,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu where barkodno=@barkodno", baglanti);  //barkodno değişmeyecek çünkü onun ile arayacağız diğer güncellede de böyle idi.
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboTuru.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye bilgileri güncellendi..");
            //temizletip listelemek için tekrardan(üstte de vardı)
            daset.Tables["kitap"].Clear();
            kitaplistele();
            foreach (Control item in Controls) {
                if (item is TextBox) {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            DialogResult dialog;
            dialog = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes) {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kitap where barkodno=@barkodno", baglanti); //deminden beri komut isminde oluşturuyoruz, yapabiliriz hepsi farklı durumlarda
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme Başarılı..");
                daset.Tables["kitap"].Clear();
                kitaplistele();
                foreach (Control item in Controls) {
                    if (item is TextBox) {
                        item.Text = "";
                    }
                }
            }

        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from kitap where barkodno like '%" + txtBarkodAra.Text + "%'", baglanti);
            adapter.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();  //textlerde kayıtların görünmesi için
            while (read.Read()) {  //kayıtlar okunduğu sürece
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazari.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                comboTuru.Text = read["turu"].ToString();
            }
            baglanti.Close();
        }

        public void DatagridwiewSettings(DataGridView datagridview) {
            dataGridView1.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None; //borderstyleı kaldırıldı
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34,33,74); // datagridview lerin arkaplan rengi
            datagridview.DefaultCellStyle.SelectionBackColor = Color.DarkBlue; //seçilen datagridview in rengi
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Gainsboro;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;  //başlık arkaplan rengi
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            //bu kısım çok güzel, buranın sayesinde tabloya çift tıkladığımızda bilgiler textboxların içinde yerleşiyor.
        }

        private void btnIptal_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
