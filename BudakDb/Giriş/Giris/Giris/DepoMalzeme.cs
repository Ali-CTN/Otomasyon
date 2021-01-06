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
    public partial class DepoMalzeme : Form
    {
        public DepoMalzeme()
        {
            InitializeComponent();
        }
        string vazife = Giris.yetki;
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adapt;
        SqlDataReader dr;
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

            private void kayitGetir()
        {
            Sc.Open();
            string kayit = "SELECT * from Malzeme_Stok";
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

        private void button5_Click(object sender, EventArgs e)
        {
            //Malzeme Olusturma

            if (vazife == "Yönetici")
            {
                MalzemeOlustur MalzemeOlusturmaSayfasi = new MalzemeOlustur();
                MalzemeOlusturmaSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

    

        private void DepoMalzemeCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DepoMalzemeGeriBTN_Click_1(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kaydetbtn
            if (comboBox1.Text=="") MessageBox.Show("Malzeme Adı kısmı boş olamaz");
            
            if (textBox1.Text == "") MessageBox.Show("Miktar kısmı boş olamaz");
            
            
                       Sc.Open();
            string kaydet = "insert into Malzeme_stok(Malzeme,Miktar,Malzeme_Gelis_Tarihi)values(@Malzeme,@Miktar,@Malzeme_Gelis_Tarihi)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            cmd.Parameters.AddWithValue("@Malzeme", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Miktar", textBox1.Text);
            cmd.Parameters.AddWithValue("@Malzeme_Gelis_Tarihi", dateTimePicker2.Value);
            cmd.ExecuteNonQuery();


            Sc.Close();
            kayitGetir();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DepoMalzeme_Load(object sender, EventArgs e)
        {
            kayitGetir();

            SqlCommand cmd = new SqlCommand();
            Sc.Open();
            cmd.Connection = Sc;

            cmd.CommandText = "SELECT * FROM Malzeme ";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Malzeme"]);


            }
            Sc.Close();
           

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (vazife == "Yönetici")
            {
                Sc.Open();
                SqlCommand cmd = new SqlCommand("DELETE from [Malzeme_stok] where Id=@ID", Sc);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();

                Sc.Close();
                kayitGetir();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kayit = "SELECT * from Malzeme_stok where Malzeme=@Malzeme";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit, Sc);
            komut.Parameters.AddWithValue("@Malzeme", textBox3.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Sc.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Bu satır seçilemez.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sc.Open();
            SqlCommand update = new SqlCommand("update Malzeme_stok set Malzeme=@Malzeme,Miktar=@Miktar,Malzeme_Gelis_Tarihi=@Malzeme_Gelis_Tarihi where Id=@ID", Sc);
            
            update.Parameters.AddWithValue("@id", ID);
            update.Parameters.AddWithValue("@Malzeme", comboBox1.Text);
            
            update.Parameters.AddWithValue("@Miktar", textBox1.Text);
            update.Parameters.AddWithValue("@Malzeme_Gelis_Tarihi", dateTimePicker2.Value);
            update.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();
        }
    }
}
