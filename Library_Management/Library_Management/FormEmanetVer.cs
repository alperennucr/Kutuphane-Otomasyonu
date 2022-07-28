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
    public partial class EmanetVer : Form {
        public EmanetVer() {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataSet daset = new DataSet();
        private void EmanetVer_Load(object sender, EventArgs e) {
            DatagridViewSettings(dataGridView1);
            sepetlistele();
            //kitapsayisi();
        }

        //private void kitapsayisi() {
        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from sepet",baglanti);
        //    lblKitapSayi.Text = komut.ExecuteScalar().ToString();
        //    baglanti.Close();
        //}

        public void DatagridViewSettings(DataGridView datagridview) {
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

        private void txtBarkodNo_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like '"+txtBarkodNo.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazari.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
            }
            baglanti.Close();
            if (txtBarkodNo.Text == "") { // burdaki if sayesinde barkodno silinmiyor ve yazınca değerler geliyor.
                foreach (Control item in grpKitapBilgi.Controls) { // üstüne if atmazsak barkodno sürekli silinir.
                    if (item is TextBox) {

                        item.Text = "";

                    }
                }
            }
           
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e) {  

        }

        private void dtIadeTarihi_ValueChanged(object sender, EventArgs e) {  

        }

        private void dtTeslimTarihi_ValueChanged(object sender, EventArgs e) {  

        }
        
        private void sepetlistele() {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from sepet",baglanti);
            adapter.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes) {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Yapıldı", "Silme İşlemi");
                daset.Tables["sepet"].Clear();
                sepetlistele();
            }

        }
            //Telefon Arayı üye tablosundan barkodnoyu kitap tablosundan çağıracağız.
        private void btnEkle_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();                                                                                                                               //@ = değişen anlamına gelir.
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,teslimtarihi,iadetarihi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@teslimtarihi,@iadetarihi) ", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@teslimtarihi", dtTeslimTarihi.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dtIadeTarihi.Text);
            komut.ExecuteNonQuery(); //update, insert, delete olaylarından etkilenen satır sayısı döndürüyor.
            baglanti.Close();
            MessageBox.Show("Kitap sepete eklendi..","Ekleme İşlemi");
            //sonradan geldik
            daset.Tables["sepet"].Clear(); //tabloyu temizledik
            sepetlistele();//kayıtları görmemiz için yapmamız gerekiyor.
            
            //kitapsayisi();
            foreach (Control item in grpKitapBilgi.Controls) {  //grpKitapBilgideki kontrolleri tara
                if (item is TextBox) {   //şayet kontroller textbox ise

                        item.Text = "";  //textleri temizle
                    
                }
            }
        }

        private void txtTelefonAra_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where telefon like'" + txtTelefonAra.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
            }
            baglanti.Close();
            //sonradan geldik
            //baglanti.Open();
            //SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from emanetkitaplar",baglanti);
            //lblKayitliKitapSayi.Text = komut2.ExecuteScalar().ToString();
            //baglanti.Close();

            if (txtTelefonAra.Text=="") {
                foreach (Control item in grpUyeBİlgi.Controls) {
                    if (item is TextBox) {    // burası önemli item is textbox diyoruz çünkü label'leri silmesini istemiyoruz.
                        item.Text = "";
                        
                    }
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            //if (lblKitapSayi.Text != "") {
            //if (lblKayitliKitapSayi.Text == "" && int.Parse(lblKitapSayi.Text)<=3 || lblKitapSayi.Text != "" && int.Parse(lblKayitliKitapSayi.Text) + int.Parse(lblKitapSayi.Text) <= 3) {
            if (txtTelefonAra.Text != "" && txtAdSoyad.Text != "" && txtYas.Text != "") {
                        //ekleyeceğimiz birden fazla satır olacağı için bir for açmamız gerekiyor.
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into emanetkitaplar(telefon,adsoyad,yas,barkodno,kitapadi,yazari,yayinevi,sayfasayisi,teslimtarihi,iadetarihi) values(@telefon,@adsoyad,@yas,@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@telefon", txtTelefonAra.Text);
                            komut.Parameters.AddWithValue("@adsoyad",txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@yas", txtYas.Text);
                            komut.Parameters.AddWithValue("barkodno",dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            komut.Parameters.AddWithValue("yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();

                            baglanti.Close();

                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet",baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap emanet edildi..");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txtTelefonAra.Text = "";

                        //ağaşısı for dışında yer alacak
                       
                        //kitapsayisi();
                        
                        //komut satırları
                    }
                    else {
                        MessageBox.Show("- Önce sepete kitap eklemeniz gerekli\n\n- Eğer sepete kitap eklediyseniz üye seçmeniz gerekli !","Uyarı");
                    }
                //}
                //else {
                //    MessageBox.Show("Emanet Kitap sayısı 3'ten fazla olamaz !","Uyarı");
                //}
            //}
            //else {
            //    MessageBox.Show("Önce Sepete Kitap Eklenmelidir..","Uyarı");
            //}

        }

        private void btnNK_Click(object sender, EventArgs e) {
            MessageBox.Show("- Öncelikle kitap bilgilerini doldurunuz.\n\n- Teslim Tarihine bugünü ve İade Tarihine kitabın gelmesi gereken\n  en son tarihi yazınız.\n\n- Sonrasında Ekle butonu ile kitabı sepete ekleyiniz.\n\n- Sepete eklediğiniz kitapların hepsi üyeye verilecek olan kitaplar\n  olmalıdır.\n\n- Eklenecek kitapları ekledikten sonra Üye bilgilerini giriniz.\n\n- Artık kitapları Teslim Et butonu ile üyeye teslim edebilirsiniz.", "Nasıl Kullanılır ?");
        }
    }
}
