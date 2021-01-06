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
   public partial class Giris : Form
    {
        
        public Giris()
        {

            InitializeComponent();
        }
        

        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Okul dersler-projeler etc\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        static public string yetki;
   
        public void yetkibul()
        {
            Sc.Open();
            SqlCommand SQLKomut = new SqlCommand("select Gorev from PERSONEL where Kullanıcı_Adı=@USERNAME", Sc);
            SQLKomut.Parameters.AddWithValue("@USERNAME", textBox1.Text);
            SqlDataReader sdr = SQLKomut.ExecuteReader();
            while (sdr.Read())
            {

               yetki=sdr["Gorev"].ToString();

            }
            sdr.Close();
            Sc.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
                MessageBox.Show("ID kısmı boş olamaz");
            else
            if (textBox2.Text == "")
                MessageBox.Show("Şifre kısmı boş olamaz");

            else
            {
                SqlCommand SC_USERNAME_PASSWORD = new SqlCommand("Select * From PERSONEL Where Kullanıcı_Adı=@USERNAME and Sifre=@PASSWORD", Sc);
                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@USERNAME", textBox1.Text);
                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@PASSWORD", textBox2.Text);

                yetkibul();
               
  



                try
                {
                    Sc.Open();
                    int TABLE_COUNT = Convert.ToInt32(SC_USERNAME_PASSWORD.ExecuteScalar());
                    Sc.Close();
                    if (TABLE_COUNT != 0)
                    {
                        Menu AnaMenu = new Menu();
                        AnaMenu.Show();
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

        private void GirisCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GirisSifremiUnuttumLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum SifreUnuttumSayfasi = new SifremiUnuttum();
            SifreUnuttumSayfasi.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            {
                if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                    e.Handled = false;
                else e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {
          
        }
    }
}
