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

namespace Giris
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        string vazife = Giris.yetki;
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        int SatısID = 0;

        private void verilerigoster()
        {
            Sc.Open();
            SqlCommand komut = new SqlCommand("Select * from URUN_SATIS", Sc);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


            }

        }

        private void kayitGetir()
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
            SatisDataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }
        private void Satis_Load(object sender, EventArgs e)
        {
            kayitGetir();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM MUSTERİ";
            komut.Connection = Sc;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            Sc.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SatisMusteriAdiComboBox.Items.Add(dr["Ad"]);
            }
            Sc.Close();

            
            komut.CommandText = "SELECT *FROM URUN";
            komut.Connection = Sc;
            komut.CommandType = CommandType.Text;

            
            Sc.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SatisUrunComboBox.Items.Add(dr["Ürün"]);
            }
            Sc.Close();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void SatisCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SatisMiktarComboBox_TextChanged(object sender, EventArgs e)
        {
            SatisMiktarComboBox.MaxLength = 8;
        }

        private void SatisFiyatComboBox_TextChanged(object sender, EventArgs e)
        {
            SatisFiyatComboBox.MaxLength = 8;
        }

        private void SatisKaydetBtn_Click(object sender, EventArgs e)
        {
      
            Sc.Open();
            string kaydet = "insert into URUN_SATIS(Ad,ürün,miktar,fiyat,teslim_tarihi,Toplam_Fiyat)values(@Ad,@ürün,@miktar,@fiyat,@Teslim_Tarihi,@Toplam_Fiyat)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            
        
            cmd.Parameters.AddWithValue("@Ad", SatisMusteriAdiComboBox.Text);
            cmd.Parameters.AddWithValue("@ürün", SatisUrunComboBox.Text);
            cmd.Parameters.AddWithValue("@miktar", SatisMiktarComboBox.Text);
            cmd.Parameters.AddWithValue("@fiyat", SatisFiyatComboBox.Text);
            cmd.Parameters.AddWithValue("@teslim_tarihi", SatisDateTimePicker.Value);
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(SatisMiktarComboBox.Text);
            sayi2 = Convert.ToInt32(SatisFiyatComboBox.Text);
            int Toplam_Fiyat = Convert.ToInt32(sayi1 * sayi2);
            cmd.Parameters.AddWithValue("@Toplam_Fiyat", Toplam_Fiyat);

            cmd.ExecuteNonQuery();
            Sc.Close();
            kayitGetir();


        } 


            private void SatisMiktarComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void SatisFiyatComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void SatisMusteriAdiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SatisUrunComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SatisSilBTN_Click(object sender, EventArgs e)
        {
            if (vazife == "Yönetici")
            {
                Sc.Open();
                SqlCommand cmd = new SqlCommand("DELETE from [URUN_SATIS] where SatısId=@ID", Sc);
                cmd.Parameters.AddWithValue("@ID", SatisDataGridView.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();

                Sc.Close();
                kayitGetir();
            }
            else
                 MessageBox.Show("Yetkiniz yetersizdir.");

        }

        private void SatisGuncelleBTN_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update URUN_SATIS set Ad=@Ad,ürün=@ürün,miktar=@miktar,fiyat=@fiyat,Teslim_Tarihi=@Teslim_Tarihi,Toplam_Fiyat=@Toplam_Fiyat where SatısId=@SatısId", Sc);
            Sc.Open();
            update.Parameters.AddWithValue("@SatısId", SatısID);
            update.Parameters.AddWithValue("@Ad", SatisMusteriAdiComboBox.Text);
            update.Parameters.AddWithValue("@ürün", SatisUrunComboBox.Text);
            update.Parameters.AddWithValue("@miktar", SatisMiktarComboBox.Text);
            update.Parameters.AddWithValue("@fiyat", SatisFiyatComboBox.Text);
            update.Parameters.AddWithValue("@Teslim_Tarihi", SatisDateTimePicker.Value);
            

            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(SatisMiktarComboBox.Text);
            sayi2 = Convert.ToInt32(SatisFiyatComboBox.Text);
            int Toplam_Fiyat = Convert.ToInt32(sayi1 * sayi2);
            update.Parameters.AddWithValue("@Toplam_Fiyat", Toplam_Fiyat);

        


            update.ExecuteNonQuery();



            Sc.Close();
            kayitGetir();

        }

        private void SatisDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SatısID = Convert.ToInt32(SatisDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                SatisMusteriAdiComboBox.Text = SatisDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SatisUrunComboBox.Text = SatisDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                SatisMiktarComboBox.Text = SatisDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                SatisFiyatComboBox.Text = SatisDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                


            }
            catch (Exception)
            {
                MessageBox.Show("Bu satır seçilemez.");
            }
        }

        private void SatisAraBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kayit = "SELECT * from URUN_SATIS where Ad=@Ad";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit, Sc);
            komut.Parameters.AddWithValue("@Ad", SatisAraTextBox.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SatisDataGridView.DataSource = dt;
            Sc.Close();
        }
    }
}
