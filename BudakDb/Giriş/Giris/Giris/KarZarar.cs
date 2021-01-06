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
namespace Giris
{
    public partial class KarZarar : Form
    {
        public KarZarar()
        {
            InitializeComponent();
        }
        public int x, y, z;
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");

        public void personelgider()
        {
            
            SqlCommand SQLKomut = new SqlCommand("select sum(Maas) as toplam from PERSONEL ", Sc);
            
            SqlDataReader sdr = SQLKomut.ExecuteReader();
            while (sdr.Read())
            {

                x = Int32.Parse(sdr["toplam"].ToString());
                MessageBox.Show(""+x+"");

            }

            sdr.Close();
            
        
        }

        private void kayitGetir_Satıs()
        {
            Sc.Open();
            string kayit = "SELECT * from URUN_SATIS";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
           KarDataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }

        private void kayitGetir_Personel()
        {
            Sc.Open();
            string kayit = "SELECT * from Personel";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            PersonelZararDataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }

        private void kayitGetir_alıs()
        {
            Sc.Open();
            string kayit = "SELECT * from Malzeme_Alım";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            MalzemeZaraDataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }

        private void KarZararGeriBTN_Click(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void KarZararCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KarZararPastaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PastaGrafik PastaGrafikSayfasi = new PastaGrafik();
            PastaGrafikSayfasi.Show();
            this.Hide();
        }

        private void KarZarar_Load(object sender, EventArgs e)
        {
            kayitGetir_Satıs();
            kayitGetir_Personel();
            kayitGetir_alıs();
        }

        private void KarZararBitisDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Sc.Open();
            string sql = "select sum(Maas) as Toplam    FROM Personel Where Giris_Tarihi BETWEEN @tar1 and @tar2";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, Sc);
            adp.SelectCommand.Parameters.AddWithValue("@tar1", KarZararBaslangicDateTimePicker.Value);
            adp.SelectCommand.Parameters.AddWithValue("@tar2", KarZararBitisDateTimePicker.Value);
            adp.Fill(dt);
            
            Sc.Close();
            PersonelZararDataGridView.DataSource = dt;

            Sc.Open();
            string sql1 = "select sum(Toplam_Fiyat) as Toplam  FROM Malzeme_Alım Where Teslim_Tarih BETWEEN @tar11 and @tar21";
            DataTable dt1 = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(sql1, Sc);
            adp1.SelectCommand.Parameters.AddWithValue("@tar11", KarZararBaslangicDateTimePicker.Value);
            adp1.SelectCommand.Parameters.AddWithValue("@tar21", KarZararBitisDateTimePicker.Value);
            adp1.Fill(dt1);
            Sc.Close();
            MalzemeZaraDataGridView.DataSource = dt1;


            Sc.Open();
            string sql2 = "select sum(Toplam_Fiyat) as Toplam  FROM URUN_SATIS Where Teslim_Tarihi BETWEEN @tar12 and @tar22";
            DataTable dt2 = new DataTable();
            SqlDataAdapter adp2 = new SqlDataAdapter(sql2, Sc);
            adp2.SelectCommand.Parameters.AddWithValue("@tar12", KarZararBaslangicDateTimePicker.Value);
            adp2.SelectCommand.Parameters.AddWithValue("@tar22", KarZararBitisDateTimePicker.Value);
            adp2.Fill(dt2);
            Sc.Close();
            KarDataGridView.DataSource = dt2;
        }

        private void KarZararBaslangicDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Sc.Open();
            string sql = "select sum(Maas) as Toplam  FROM Personel Where Giris_Tarihi BETWEEN @tar1 and @tar2";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, Sc);
            adp.SelectCommand.Parameters.AddWithValue("@tar1", KarZararBaslangicDateTimePicker.Value);
            adp.SelectCommand.Parameters.AddWithValue("@tar2", KarZararBitisDateTimePicker.Value);
            adp.Fill(dt);
            Sc.Close();
            PersonelZararDataGridView.DataSource = dt;

            Sc.Open();
            string sql1 = "select sum(Toplam_Fiyat) as Toplam  FROM Malzeme_Alım Where Teslim_Tarih BETWEEN @tar11 and @tar21";
            DataTable dt1 = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(sql1, Sc);
            adp1.SelectCommand.Parameters.AddWithValue("@tar11", KarZararBaslangicDateTimePicker.Value);
            adp1.SelectCommand.Parameters.AddWithValue("@tar21", KarZararBitisDateTimePicker.Value);
            adp1.Fill(dt1);
            Sc.Close();
            MalzemeZaraDataGridView.DataSource = dt1;


            Sc.Open();
            string sql2 = "select sum(Toplam_Fiyat) as Toplam  FROM URUN_SATIS Where Teslim_Tarihi BETWEEN @tar12 and @tar22";
            DataTable dt2 = new DataTable();
            SqlDataAdapter adp2 = new SqlDataAdapter(sql2, Sc);
            adp2.SelectCommand.Parameters.AddWithValue("@tar12", KarZararBaslangicDateTimePicker.Value);
            adp2.SelectCommand.Parameters.AddWithValue("@tar22", KarZararBitisDateTimePicker.Value);
            adp2.Fill(dt2);
            Sc.Close();
            KarDataGridView.DataSource = dt2;

        }
    }
}
