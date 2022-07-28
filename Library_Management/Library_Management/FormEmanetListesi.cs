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
    public partial class FormEmanetListesi : Form {
        public FormEmanetListesi() {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        DataSet daset = new DataSet();
        private void FormEmanetListesi_Load(object sender, EventArgs e) {
            DatagridwiewSettings(dataGridView1);
            EmanetListele();  //ctrl r ve m yaptık ve formload a yazdığımız şeyleri methodladık.
            combofiltre.SelectedIndex = 0; //ilk nesne seçili başlıyor
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

        private void EmanetListele() {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adapter.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];  //kayıtlaarı datagridviewe yüklüyoruz.
            baglanti.Close();
        }

        private void comboTuru_SelectedIndexChanged(object sender, EventArgs e) {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            daset.Tables["EmanetKitaplar"].Clear();
            if (combofiltre.SelectedIndex==0) {
                EmanetListele();
            }
            else if (combofiltre.SelectedIndex == 1) { //geciken kitaplar
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select *from EmanetKitaplar where '"+ DateTime.Now.ToShortDateString()  +"'>iadetarihi", baglanti);
                adapter.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];  //kayıtlaarı datagridviewe yüklüyoruz.
                baglanti.Close();
            }
            else if (combofiltre.SelectedIndex == 2) { //gecikmeyen kitaplar
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select *from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'<=iadetarihi", baglanti);
                adapter.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];  //kayıtlaarı datagridviewe yüklüyoruz.
                baglanti.Close();
            }
        }
    }
}
