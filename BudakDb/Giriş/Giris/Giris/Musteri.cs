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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        string vazife = Giris.yetki;
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adapt;
        int ID = 0;

        private void verilerigoster()
        {
            Sc.Open();
            SqlCommand komut = new SqlCommand("Select * from MUSTERİ", Sc);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


            }
        }

        private void kayitGetir()
        {
            Sc.Open();
            string kayit = "SELECT * from MUSTERİ";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();

        }

       






        private void MusteriGeriBTN_Click(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void MusteriCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MusteriFirmaAdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MusteriAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MusteriSoyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MusteriTelefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MusteriTelefonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MusteriTelefonTextBox.Text.Length > 11)
                MessageBox.Show("Telefon numarası 11 haneden uzun olamaz.");
        }

        private void MusteriKaydetBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kaydet = "insert into MUSTERİ(Firma,Ad,Soyad,Email,Telefon,Adres)values(@Firma,@Ad,@Soyad,@Email,@Telefon,@Adres)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            cmd.Parameters.AddWithValue("@Firma", MusteriFirmaAdTextBox.Text);
            cmd.Parameters.AddWithValue("@Ad", MusteriAdiTextBox.Text);
            cmd.Parameters.AddWithValue("@Soyad", MusteriSoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@Email", MusteriEmailTextBox.Text);
            cmd.Parameters.AddWithValue("@Telefon", MusteriTelefonTextBox.Text);
            cmd.Parameters.AddWithValue("@Adres", MusteriAdresTextBox.Text);
            cmd.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();





        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void MusteriSilBTN_Click(object sender, EventArgs e)
        {

            if (vazife == "Yönetici")
            { 

                Sc.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [MUSTERİ] where Id=@ID", Sc);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();
        }
         else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)

        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            MusteriFirmaAdTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            MusteriAdiTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            MusteriSoyadTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            MusteriEmailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            MusteriTelefonTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            MusteriAdresTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void MusteriGuncelleBTN_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update MUSTERİ set Firma=@Firma,Ad=@Ad,Soyad=@Soyad,Email=@Email,TelNo=@TelNo,Adres=@Adres where Id=@ID", Sc);
            Sc.Open();

            update.Parameters.AddWithValue("@id", ID);
            update.Parameters.AddWithValue("@Firma", MusteriFirmaAdTextBox.Text);
            update.Parameters.AddWithValue("@Ad", MusteriAdiTextBox.Text);
            update.Parameters.AddWithValue("@Soyad", MusteriSoyadTextBox.Text);
            update.Parameters.AddWithValue("@Email", MusteriEmailTextBox.Text);
            update.Parameters.AddWithValue("@Telno", MusteriTelefonTextBox.Text);
            update.Parameters.AddWithValue("@Adres", MusteriAdresTextBox.Text);
            update.ExecuteNonQuery();



            Sc.Close();
            kayitGetir();
        }
    }
}

