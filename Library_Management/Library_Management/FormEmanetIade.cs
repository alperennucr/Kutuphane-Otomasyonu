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

namespace Library_Management {
    public partial class FormEmanetIade : Form {
        public FormEmanetIade() {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataSet daset = new DataSet();
        private void FormEmanetIade_Load(object sender, EventArgs e) {
            DatagridwiewSettings(dataGridView1);
            EmanetListele();
        }

        private void EmanetListele() {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adapter.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];  //kayıtlaarı datagridviewe yüklüyoruz.
            baglanti.Close();
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
        
        private void btnIptal_Click(object sender, EventArgs e) {
            this.Close();
            
        }

        private void txtTelefonaGöre_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();                                                                     //bak dostum bu % işareti kelimenin içinde herhangi bir yerde varsa göster demek.               
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EmanetKitaplar where telefon like'%"+txtTelefonaGöre.Text+"%'",baglanti);
            adapter.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtTelefonaGöre.Text == "") {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void txtBarkodNoGöre_TextChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();                                                                     //bak dostum bu % işareti kelimenin içinde herhangi bir yerde varsa göster demek.               
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EmanetKitaplar where barkodno like'%" + txtBarkodNoGöre.Text + "%'", baglanti);
            adapter.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodNoGöre.Text == "") {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where telefon = @telefon and barkodno = @barkodno",baglanti);
            komut.Parameters.AddWithValue("@telefon",dataGridView1.CurrentRow.Cells["telefon"].Value.ToString()); //şimdi bilgileri nereden çekeceğimizi yazıyoruz.
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery(); //onaylıyoruz
            baglanti.Close();
            MessageBox.Show("Kitap iade edildi","Bilgi");
            daset.Tables["EmanetKitaplar"].Clear(); //önce temizleyecek
            EmanetListele();  // sonra listeleyecek
        }
    }
}
