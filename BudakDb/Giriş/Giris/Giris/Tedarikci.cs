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
    public partial class Tedarikci : Form
    {
        public Tedarikci()
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
            SqlCommand komut = new SqlCommand("Select * from TEDARİKCİ", Sc);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


            }

        }

        private void TedarikciGeriBTN_Click(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void TedarikciCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tedarikci_Load(object sender, EventArgs e)
        {
            kayitGetir();




        }
        private void kayitGetir()
        {
            Sc.Open();
            string kayit = "SELECT * from Tedarikci";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            TedarikciDataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kaydet = "insert into Tedarikci(Firma,Ad,Soyad,Email,TelNo,Adres)values(@Firma,@Ad,@Soyad,@Email,@TelNo,@Adres)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            cmd.Parameters.AddWithValue("@Firma", TedarikciFirmaAdTextBox.Text);
            cmd.Parameters.AddWithValue("@Ad", TedarikciAdTextBox.Text);
            cmd.Parameters.AddWithValue("@Soyad", TedarikciSoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@Email", TedarikciEmailTextBox.Text);
            cmd.Parameters.AddWithValue("@Telno", TedarikciTelefonTextBox.Text);
            cmd.Parameters.AddWithValue("@Adres", TedarikciAdresTextBox.Text);
            cmd.ExecuteNonQuery();


            Sc.Close();
            kayitGetir();
            TedarikciFirmaAdTextBox.Clear();
            TedarikciAdTextBox.Clear();
            TedarikciSoyadTextBox.Clear();
            TedarikciEmailTextBox.Clear();
            TedarikciTelefonTextBox.Clear();
            TedarikciAdTextBox.Clear();
            TedarikciAdresTextBox.Clear();


            //cmd.Parameters.AddWithValue("@Adres", combobox.selectedindex+1);

        }





        private void TedarikciAdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TedarikciSoyadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TedarikciSoyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TedarikciTelefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TedarikciAraBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kayit = "SELECT * from Tedarikci where Ad=@Ad";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit, Sc);
            komut.Parameters.AddWithValue("@Ad", textBox3.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TedarikciDataGridView.DataSource = dt;
            Sc.Close();
        }





        private void TedarikciSilBTN_Click(object sender, EventArgs e)
        {
            if (vazife == "Yönetici")
            {
                Sc.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [Tedarikci] where Id=@ID", Sc);
            cmd.Parameters.AddWithValue("@ID", TedarikciDataGridView.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();
        }
        else MessageBox.Show("Yetkiniz yetersizdir.");

        }
      

        private void TedarikciGuncelleBTN_Click(object sender, EventArgs e)
        {


            SqlCommand update = new SqlCommand("update Tedarikci set Firma=@Firma,Ad=@Ad,Soyad=@Soyad,Email=@Email,TelNo=@TelNo,Adres=@Adres where Id=@ID", Sc);
            Sc.Open();

            update.Parameters.AddWithValue("@id", ID);
            update.Parameters.AddWithValue("@Firma", TedarikciFirmaAdTextBox.Text);
            update.Parameters.AddWithValue("@Ad", TedarikciAdTextBox.Text);
            update.Parameters.AddWithValue("@Soyad", TedarikciSoyadTextBox.Text);
            update.Parameters.AddWithValue("@Email", TedarikciEmailTextBox.Text);
            update.Parameters.AddWithValue("@Telno", TedarikciTelefonTextBox.Text);
            update.Parameters.AddWithValue("@Adres", TedarikciAdresTextBox.Text);
            update.ExecuteNonQuery();


            
            Sc.Close();
            kayitGetir();
        }

        private void TedarikciDataGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(TedarikciDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            TedarikciFirmaAdTextBox.Text = TedarikciDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            TedarikciAdTextBox.Text = TedarikciDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            TedarikciSoyadTextBox.Text = TedarikciDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            TedarikciEmailTextBox.Text = TedarikciDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            TedarikciTelefonTextBox.Text = TedarikciDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            TedarikciAdresTextBox.Text = TedarikciDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}