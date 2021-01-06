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
    public partial class MalzemeOlustur : Form
    {
        public MalzemeOlustur()
        {
            InitializeComponent();
        }
        string vazife = Giris.yetki;

        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        int Id = 0;
        private void verilerigoster()
        {
            Sc.Open();
            SqlCommand komut = new SqlCommand("Select * from MALZEME", Sc);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


            }
        }
        private void kayitGetir()
        {
            Sc.Open();
            string kayit = "SELECT * from MALZEME";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            MalzemeOlusturDataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            //Malzeme oluştur geri butonu
            DepoMalzeme DepoMalzemeSayfasi = new DepoMalzeme();
            DepoMalzemeSayfasi.Show();
            this.Hide();
        }

        private void MalzemeOlusturBirimFiyatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MalzemeOlusturAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void MalzemeOlusturKaydetBTN_Click(object sender, EventArgs e)
        {

            Sc.Open();
            string kaydet = "insert into MALZEME(Malzeme,Renk,Birim,Fiyat)values(@Malzeme,@Renk,@Birim,@Fiyat)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            cmd.Parameters.AddWithValue("@Malzeme", MalzemeOlusturAdiTextBox.Text);
            cmd.Parameters.AddWithValue("@Renk", textBox2.Text);
            cmd.Parameters.AddWithValue("@Birim", MalzemeOlusturBirimComboBox.Text);
            cmd.Parameters.AddWithValue("@Fiyat", MalzemeOlusturBirimFiyatTextBox.Text);

            cmd.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();


        }

        private void mALZEMEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.mALZEMEBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.budakDBDataSet1);

        }

        private void MalzemeOlustur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budakDBDataSet1.MALZEME' table. You can move, or remove it, as needed.
            //this.mALZEMETableAdapter.Fill(this.budakDBDataSet1.MALZEME);

        }

        private void SilBTN_Load(object sender, EventArgs e)
        {
            //Yanlıs adlandırma form load burası
            kayitGetir();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM MALZEME";
            komut.Connection = Sc;
            komut.CommandType = CommandType.Text;

           


        }

        private void MalzemeOlusturSilBTN_Click(object sender, EventArgs e)
        {

            if (vazife == "Yönetici")
            {
                Sc.Open();
                SqlCommand cmd = new SqlCommand("DELETE from [MALZEME] where Id=@ID", Sc);
                cmd.Parameters.AddWithValue("@ID", MalzemeOlusturDataGridView.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();

                Sc.Close();
                kayitGetir();
            }
            else
                 MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void MalzemeOlusturGuncelleBTN_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update MALZEME set Malzeme=@Malzeme,Renk=@Renk,Birim=@Birim,Fiyat=@Fiyat where Id=@Id", Sc);
            Sc.Open();
            update.Parameters.AddWithValue("@Id", Id);
            update.Parameters.AddWithValue("@Malzeme", MalzemeOlusturAdiTextBox.Text);
            update.Parameters.AddWithValue("@Renk", textBox2.Text);
            update.Parameters.AddWithValue("@Birim", MalzemeOlusturBirimComboBox.Text);
            update.Parameters.AddWithValue("@Fiyat", MalzemeOlusturBirimFiyatTextBox.Text);

            update.ExecuteNonQuery();
            
            Sc.Close();
            kayitGetir();
        }

        private void MalzemeOlusturDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(MalzemeOlusturDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                MalzemeOlusturAdiTextBox.Text = MalzemeOlusturDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = MalzemeOlusturDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                MalzemeOlusturBirimComboBox.Text = MalzemeOlusturDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                MalzemeOlusturBirimFiyatTextBox.Text = MalzemeOlusturDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();



            }
            catch (Exception)
            {
                MessageBox.Show("Bu satır seçilemez.");
            }
        }
    }
}
