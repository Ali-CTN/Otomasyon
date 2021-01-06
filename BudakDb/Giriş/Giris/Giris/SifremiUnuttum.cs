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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        static public int idb;
        private void SifremiUnuttumGeriBTN_Click(object sender, EventArgs e)
        {
            Giris GirisSayfasi = new Giris();
            GirisSayfasi.Show();
            this.Hide();
        }

        public void idbul()
        {
            Sc.Open();
            SqlCommand SQLKomut = new SqlCommand("select PersonelID from PERSONEL where Kullanıcı_Adı=@USERNAME", Sc);
            SQLKomut.Parameters.AddWithValue("@USERNAME", SifremiUnuttumKullaniciAdiTextBox.Text);
            SqlDataReader sdr = SQLKomut.ExecuteReader();
            while (sdr.Read())
            {

               idb = Int32.Parse(sdr["PersonelId"].ToString());


            }
            
            sdr.Close();
            Sc.Close();
        }


        private void SifremiUnuttumDevamEtBTN_Click(object sender, EventArgs e)
        {

            if (SifremiUnuttumKullaniciAdiTextBox.Text == "")
                MessageBox.Show("Kullanıcı Adı kısmı boş olamaz");
            else
            if (SifremiUnuttumCevapTextBox.Text == "")
                MessageBox.Show("Cevap kısmı boş olamaz");
            else
            if (SifremiUnuttumGizliSoruComboBox.Text == "")
                MessageBox.Show("Gizli soru seçilmelidir");
            else
            {
                SqlCommand SC_USERNAME_PASSWORD = new SqlCommand("Select * From PERSONEL Where Kullanıcı_Adı=@USERNAME and Cevap=@Cevap", Sc);
                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@USERNAME", SifremiUnuttumKullaniciAdiTextBox.Text);
                
                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@Cevap", SifremiUnuttumCevapTextBox.Text);
                idbul();
                try
                {
                    Sc.Open();
                    int TABLE_COUNT = Convert.ToInt32(SC_USERNAME_PASSWORD.ExecuteScalar());
                    Sc.Close();
                    if (TABLE_COUNT != 0)
                    {

                        SifreYenileme SifreYenilemeSayfasi = new SifreYenileme();
                        SifreYenilemeSayfasi.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Girilen bilgiler yanlış");
                    }

                }
                catch (Exception h)
                {
                    MessageBox.Show(h.Message);
                }




            }
        }

        private void SifremiUnuttumKullaniciAdiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SifremiUnuttumKullaniciAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else e.Handled = true;
        }

        private void SifremiUnuttumCevapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
