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
    public partial class FormUyeListesi : Form {
        public FormUyeListesi() {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            txttel.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            //bu kısım çok güzel, buranın sayesinde tabloya çift tıkladığımızda bilgiler textboxların içinde yerleşiyor.
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void txtadsoyad_TextChanged(object sender, EventArgs e) {
            
        }
        DataSet daset = new DataSet();
        private void txtAraTc_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            daset.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from uye where telefon like '%" + txtAraTc.Text + "%'", baglanti);
            adapter.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            DialogResult dialog;
            dialog = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes) {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where telefon=@telefon", baglanti); //deminden beri komut isminde oluşturuyoruz, aslında farklı isimler de verilebilir.
                komut.Parameters.AddWithValue("@telefon", dataGridView1.CurrentRow.Cells["telefon"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme Başarılı..");
                daset.Tables["uye"].Clear();
                uyelistele();
                foreach (Control item in Controls) {
                    if (item is TextBox) {
                        item.Text = "";
                    }
                }
            }
            
        }
        private void uyelistele() {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from uye",baglanti);
            adapter.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"]; //0 da yazabiliriz çünkü bir tablo var
            baglanti.Close();
        }
        private void FormUyeListesi_Load(object sender, EventArgs e) {
            DatagridwiewSettings(dataGridView1);
            uyelistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set adsoyad = @adsoyad,yas=@yas,cinsiyet=@cinsiyet where telefon = @telefon",baglanti);
            komut.Parameters.AddWithValue("@adsoyad",txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttel.Text);
            komut.Parameters.AddWithValue("@yas", txtyas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbboxcinsiyet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye bilgileri güncellendi..");
            //temizletip listelemek için tekrardan(üstte de vardı)
            daset.Tables["uye"].Clear();
            uyelistele();
            foreach (Control item in Controls) {
                if (item is TextBox) {
                    item.Text = "";
                }
            }
        }

        private void txttel_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where telefon like '" + txttel.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();  //textlerde kayıtların görünmesi için
            while (read.Read()) {  //kayıtlar okunduğu sürece
                txtadsoyad.Text = read["adsoyad"].ToString();
                //satır sildim.
                txtyas.Text = read["yas"].ToString();
                cmbboxcinsiyet.Text = read["cinsiyet"].ToString();
            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        public void DatagridwiewSettings(DataGridView datagridview) {
            dataGridView1.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None; //borderstyleı kaldırıldı
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34, 33, 74); // datagridview lerin arkaplan rengi
            datagridview.DefaultCellStyle.SelectionBackColor = Color.DarkBlue; //seçilen datagridview in rengi
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Gainsboro;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;  //başlık arkaplan rengi
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
