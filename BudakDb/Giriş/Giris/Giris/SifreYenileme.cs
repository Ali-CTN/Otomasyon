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
    public partial class SifreYenileme : Form
    {
        public SifreYenileme()
        {
            InitializeComponent();
        }
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adapt;
        SqlDataReader dr;
        
        int idbulundu = SifremiUnuttum.idb;
      

        private void SifreYenilemeDevamBTN_Click(object sender, EventArgs e)
        {

            {
                if (SifreYenilemeYeniSifreTextBox.Text == "")
                    MessageBox.Show("Şifre Boş olamaz");
                else
                if (SifreYenilemeYeniSifreTextBox.Text != SifreYenilemeYeniSifreTekrarTextBox.Text)
                    MessageBox.Show("Şifreler Eşleşmiyor");
                else
                {
                    Sc.Open();
                    SqlCommand update = new SqlCommand("update PERSONEL set Sifre=@Sifre where PersonelID=@id", Sc);
                    update.Parameters.AddWithValue("@id", idbulundu);
                    update.Parameters.AddWithValue("@Sifre", SifreYenilemeYeniSifreTextBox.Text);
                    update.ExecuteNonQuery();
                    Sc.Close();

                    Giris GirisSayfasi = new Giris();
                    GirisSayfasi.Show();
                    this.Hide();
                }
            }
        }

        private void SifreYenilemeYeniSifreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else e.Handled = true;
        }

        private void SifreYenilemeYeniSifreTekrarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
