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
    public partial class DepoUrun : Form
    {
        public DepoUrun()
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
            SqlCommand komut = new SqlCommand("Select * from URUN_STOK", Sc);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


            }
        }

        private void kayitGetir()
        {
            Sc.Open();
            string kayit = "SELECT * from URUN_STOK";
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

        private void button6_Click(object sender, EventArgs e)
        {
            //Geri Butonu kodlarıdır.
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void DepoUrunCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DepoUrunUrunKoduTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepoUrunUrunKoduTEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void DepoUrunMiktarTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            DepoUrunMiktarTEXTBOX.MaxLength = 8;
        }

        private void DepoUrunMiktarTEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }
       //Kaydet Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kaydet = "insert into URUN_STOK(Ürün,Miktar,Ürün_Gelis_Tarihi)values(@Ürün,@Miktar,@Ürün_Gelis_Tarihi)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            cmd.Parameters.AddWithValue("@Ürün", DepoUrunUrunAdiCOMBOBOX.Text);
            cmd.Parameters.AddWithValue("@Miktar",DepoUrunMiktarTEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Ürün_Gelis_Tarihi", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();


            Sc.Close();
            kayitGetir();


        }

        private void DepoUrunUrunAdiCOMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepoUrunBirimCOMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepoUrun_Load(object sender, EventArgs e)
        {
            kayitGetir();

            SqlCommand cmd = new SqlCommand();
            Sc.Open();
            cmd.Connection = Sc;

            cmd.CommandText = "SELECT * FROM URUN ";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DepoUrunUrunAdiCOMBOBOX.Items.Add(dr["Ürün"]);


            }
            Sc.Close();
        }

        private void DepoUrunSilBTN_Click(object sender, EventArgs e)
        {

            if (vazife == "Yönetici")
            {
                Sc.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [URUN_STOK] where Id=@ID", Sc);
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
            string kayit = "SELECT * from URUN_STOK where Ürün=@Ürün";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit, Sc);
            komut.Parameters.AddWithValue("@Ürün", textBox3.Text);
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
                DepoUrunUrunAdiCOMBOBOX.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DepoUrunMiktarTEXTBOX.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bu satır seçilemez.");
            }
        }

        private void DepoUrunGuncelleBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            SqlCommand update = new SqlCommand("update URUN_STOK set Ürün=@Ürün,Miktar=@Miktar,Ürün_Gelis_Tarihi=@Ürün_Gelis_Tarihi where Id=@ID", Sc);

            update.Parameters.AddWithValue("@id", ID);
            update.Parameters.AddWithValue("@Ürün", DepoUrunUrunAdiCOMBOBOX.Text);

            update.Parameters.AddWithValue("@Miktar", DepoUrunMiktarTEXTBOX.Text);
            update.Parameters.AddWithValue("@Ürün_Gelis_Tarihi", dateTimePicker1.Value);
            update.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();
        }
    }
}
