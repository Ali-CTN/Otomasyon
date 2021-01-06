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
    public partial class Urun : Form
    {


        public Urun()
        {
            InitializeComponent();
        }
        string vazife = Giris.yetki;
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");

        int ID = 0;
        private void verilerigoster()
        {
            Sc.Open();
            SqlCommand komut = new SqlCommand("Select * from URUN", Sc);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {


            }

        }
        private void kayitGetir()
        {
            Sc.Open();
            string kayit = "SELECT * from URUN";
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


        private void UrunCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UrunGeriBTN_Click(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void UrunFiyatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void UrunFiyatTextBox_TextChanged(object sender, EventArgs e)
        {
            UrunFiyatTextBox.MaxLength = 8;
        }

        private void UrunAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void UrunAdiTextBox_TextChanged(object sender, EventArgs e)
        {
            UrunAdiTextBox.MaxLength = 20;
        }

        private void UrunPictureBox_Click(object sender, EventArgs e)
        {

        }



        private void UrunKaydetBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kaydet = "insert into URUN(Ürün,Renk,Birim,Fiyat)values(@Ürün,@Renk,@Birim,@Fiyat)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            cmd.Parameters.AddWithValue("@Ürün", UrunAdiTextBox.Text);
            cmd.Parameters.AddWithValue("@Renk", textBox1.Text);
            cmd.Parameters.AddWithValue("@Birim", UrunBirimComboBox.Text);
            cmd.Parameters.AddWithValue("@Fiyat", UrunFiyatTextBox.Text);

            cmd.ExecuteNonQuery();
            Sc.Close();
            kayitGetir();

        }

        private void UrunBirimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UrunRenkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Urun_Load(object sender, EventArgs e)
        {
            kayitGetir();





        }

        private void UrunSilBTN_Click(object sender, EventArgs e)
        {

            if (vazife == "Yönetici")
            {
                Sc.Open();
                SqlCommand cmd = new SqlCommand("DELETE from [URUN] where ID=@ID", Sc);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();

                Sc.Close();
                kayitGetir();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void UrunGuncelleBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            SqlCommand update = new SqlCommand("update URUN set Ürün=@Ürün,Birim=@Birim,Fiyat=@Fiyat,Renk=@Renk where Id=@ID", Sc);

            update.Parameters.AddWithValue("@id", ID);
            update.Parameters.AddWithValue("@Ürün", UrunAdiTextBox.Text);

            update.Parameters.AddWithValue("@Birim", UrunBirimComboBox.Text);
            update.Parameters.AddWithValue("@Fiyat", UrunFiyatTextBox.Text);
            update.Parameters.AddWithValue("@Renk", textBox1.Text);
            update.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                UrunAdiTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                UrunBirimComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Bu satır seçilemez.");
            }
        }
    }
}
