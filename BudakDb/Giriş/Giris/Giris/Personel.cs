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
    public partial class Personel : Form
    {




        public Personel()
        {
            InitializeComponent();


        }
        // !!!!
        //
        //  Kullanıcı adı şifre gizli soru ve cevap adlı labellar ve onların combo/text boxları vazife diğer seçilince kaybolmalı
        //  Şifre *** şeklinde olmalı
        //
        // !!!!
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adapt;
        SqlDataReader dr;
        int PersonelID = 0;

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
            string kayit = "SELECT * from PERSONEL";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            PersonelDataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }



        private void PersonelGeriBTN_Click(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }


        private void PersonelCikisBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PersonelAdiTextBox_TextChanged(object sender, EventArgs e)
        {


            PersonelAdiTextBox.CharacterCasing = CharacterCasing.Upper;





        }

        private void PersonelSoyadTextBox_TextChanged(object sender, EventArgs e)
        {

            PersonelSoyadTextBox.CharacterCasing = CharacterCasing.Upper;

        }




        private void PersonelEmailTextBox_TextChanged(object sender, EventArgs e)
        {



        }

        private void PersonelMaasTextBox_TextChanged(object sender, EventArgs e)
        {

            PersonelMaasTextBox.MaxLength = 5;



        }

        private void PersonelKullaniciAdiTextBox_TextChanged(object sender, EventArgs e)
        {
            PersonelKullaniciAdiTextBox.MaxLength = 12;






        }

        private void PersonelSifreTextBox_TextChanged(object sender, EventArgs e)
        {

            PersonelSifreTextBox.MaxLength = 10;
            PersonelSifreTextBox.PasswordChar = '*';
        }

        private void PersonelCevapTextBox_TextChanged(object sender, EventArgs e)
        {
            PersonelCevapTextBox.MaxLength = 12;
            PersonelCevapTextBox.PasswordChar = '*';




        }


        private void Personel_Temizle()
        {
            PersonelAdiTextBox.Clear(); PersonelSoyadTextBox.Clear(); PersonelTelefonTextBox.Clear(); PersonelEmailTextBox.Clear();
            PersonelMaasTextBox.Clear(); PersonelVazifeComboBox.SelectedIndex = -1; PersonelKullaniciAdiTextBox.Clear();
            PersonelSifreTextBox.Clear(); PersonelGizliSoruComboBox.SelectedIndex = -1; PersonelCevapTextBox.Clear();

        }



        private void PersonelKaydetBTN_Click(object sender, EventArgs e)
        {

            if (PersonelVazifeComboBox.Text == "Diğer")
            {
                if (PersonelAdiTextBox.Text == "" || (PersonelSoyadTextBox.Text == "" || PersonelTelefonTextBox.Text == "" || PersonelEmailTextBox.Text == "" || PersonelMaasTextBox.Text == ""))
                    MessageBox.Show("Bir bölüm boş olamaz");



                else
                    Sc.Open();
                string kaydet = "insert into PERSONEL(Ad,Soyad,Gorev,Giris_Tarihi,Maas,Tel_No,Email,Kullanıcı_Adı,Sifre,Kurtarma_Sorusu,Cevap)values(@Ad,@Soyad,@Gorev,@Giris_Tarihi,@Maas,@Tel_No,@Email,@Kullanıcı_Adı,@Sifre,@Kurtarma_Sorusu,@Cevap)";
                SqlCommand cmd = new SqlCommand(kaydet, Sc);
                cmd.Parameters.AddWithValue("@Ad", PersonelAdiTextBox.Text);
                cmd.Parameters.AddWithValue("@Soyad", PersonelSoyadTextBox.Text);
                cmd.Parameters.AddWithValue("@Gorev", PersonelVazifeComboBox.Text);
                cmd.Parameters.AddWithValue("@Giris_Tarihi", PersonelGirisDateTimePicker.Value);
                cmd.Parameters.AddWithValue("@Maas", PersonelMaasTextBox.Text);
                cmd.Parameters.AddWithValue("@Tel_No", PersonelTelefonTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", PersonelEmailTextBox.Text);
                cmd.Parameters.AddWithValue("@Kullanıcı_Adı", PersonelKullaniciAdiTextBox.Text);
                cmd.Parameters.AddWithValue("@Sifre", PersonelSifreTextBox.Text);
                cmd.Parameters.AddWithValue("@Kurtarma_Sorusu", PersonelGizliSoruComboBox.Text);
                cmd.Parameters.AddWithValue("@Cevap", PersonelCevapTextBox.Text);

                cmd.ExecuteNonQuery();


                Sc.Close();
                kayitGetir();




            }
            else
            {
                if (PersonelAdiTextBox.Text == "" || PersonelSoyadTextBox.Text == "" || PersonelTelefonTextBox.Text == "" || PersonelEmailTextBox.Text == "" || PersonelMaasTextBox.Text == "" || PersonelKullaniciAdiTextBox.Text == "" || PersonelSifreTextBox.Text == "" || PersonelCevapTextBox.Text == "" || PersonelVazifeComboBox.Text == "" || PersonelGizliSoruComboBox.Text == "")
                    MessageBox.Show("Bir bölüm boş olamaz");



                else
                {
                    Sc.Open();
                    string kaydet = "insert into PERSONEL(Ad,Soyad,Gorev,Giris_Tarihi,Maas,Tel_No,Email,Kullanıcı_Adı,Sifre,Kurtarma_Sorusu,Cevap)values(@Ad,@Soyad,@Gorev,@Giris_Tarihi,@Maas,@Tel_No,@Email,@Kullanıcı_Adı,@Sifre,@Kurtarma_Sorusu,@Cevap)";
                    SqlCommand cmd = new SqlCommand(kaydet, Sc);
                    cmd.Parameters.AddWithValue("@Ad", PersonelAdiTextBox.Text);
                    cmd.Parameters.AddWithValue("@Soyad", PersonelSoyadTextBox.Text);
                    cmd.Parameters.AddWithValue("@Gorev", PersonelVazifeComboBox.Text);
                    cmd.Parameters.AddWithValue("@Giris_Tarihi", PersonelGirisDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@Maas", PersonelMaasTextBox.Text);
                    cmd.Parameters.AddWithValue("@Tel_No", PersonelTelefonTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", PersonelEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@Kullanıcı_Adı", PersonelKullaniciAdiTextBox.Text);
                    cmd.Parameters.AddWithValue("@Sifre", PersonelSifreTextBox.Text);
                    cmd.Parameters.AddWithValue("@Kurtarma_Sorusu", PersonelGizliSoruComboBox.Text);
                    cmd.Parameters.AddWithValue("@Cevap", PersonelCevapTextBox.Text);

                    cmd.ExecuteNonQuery();


                    Sc.Close();
                    kayitGetir();

                }
            }



            return;


            //(bool kayitkontrol = false;
            //bağlantım.open();

            // oledbcommand kaydetkomutu=new oledbcommand(İnsert into Personel values('"+personeladtextbox.text+"','"+Personelsoyadtextbox.text+'")
            //kaydetkomutu.executenonquery();


            //bağlantım.close();
            //Messagebox.show("yeni personel kaydı yapıldı")
            //Personel_Temizle();
        }

        private void PersonelTelefonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PersonelTelefonTextBox.Text.Length < 11)
                errorProvider1.SetError(PersonelTelefonTextBox, "Telefon numarası 11 haneli olmalı");
            else
                errorProvider1.Clear();
        }

        private void PersonelTelefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelSoyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelMaasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelKullaniciAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelSifreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelCevapTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelAraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PersonelAraTextBox.MaxLength = 15;
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PersonelVazifeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedcmbox = PersonelVazifeComboBox.SelectedItem.ToString();

            if (selectedcmbox.ToString() == "Diğer")

            {
                PersonelKullaniciAdiTextBox.Visible = false;
                PersonelSifreTextBox.Visible = false;
                PersonelGizliSoruComboBox.Visible = false;
                PersonelCevapTextBox.Visible = false;
                PersonelKullaniciAdiLabel.Visible = false;
                PersonelSifreLabel.Visible = false;
                PersonelGizliSoruLabel.Visible = false;
                PersonelCevapLabel.Visible = false;
            }

            else
            {
                PersonelKullaniciAdiTextBox.Visible = true;
                PersonelSifreTextBox.Visible = true;
                PersonelGizliSoruComboBox.Visible = true;
                PersonelCevapTextBox.Visible = true;
                PersonelKullaniciAdiLabel.Visible = true;
                PersonelSifreLabel.Visible = true;
                PersonelGizliSoruLabel.Visible = true;
                PersonelCevapLabel.Visible = true;
            }




        }







        private void Personel_Load(object sender, EventArgs e)
        {

            kayitGetir();




        }

        private void PersonelSilBTN_Click(object sender, EventArgs e)
        {

            Sc.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [PERSONEL] where PersonelID=@PersonelID", Sc);
            cmd.Parameters.AddWithValue("@PersonelID", PersonelDataGridView.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();
        }

        private void PersonelGuncelleBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            SqlCommand update = new SqlCommand("update PERSONEL set Ad=@Ad,Soyad=@Soyad,Gorev=@Gorev,Giris_Tarihi=@Giris_Tarihi,Maas=@Maas,Tel_No=@Tel_No,Email=@Email,Kullanıcı_Adı=@Kullanıcı_Adı,Sifre=@Sifre,Kurtarma_Sorusu=@Kurtarma_Sorusu,Cevap=@Cevap where PersonelID=@ID", Sc);
            update.Parameters.AddWithValue("@id", PersonelID);
            update.Parameters.AddWithValue("@Ad", PersonelAdiTextBox.Text);
            update.Parameters.AddWithValue("@Soyad", PersonelSoyadTextBox.Text);
            update.Parameters.AddWithValue("@Gorev", PersonelVazifeComboBox.Text);
            update.Parameters.AddWithValue("@Giris_Tarihi", PersonelGirisDateTimePicker.Value);
            update.Parameters.AddWithValue("@Maas", PersonelMaasTextBox.Text);
            update.Parameters.AddWithValue("@Tel_No", PersonelTelefonTextBox.Text);
            update.Parameters.AddWithValue("@Email", PersonelEmailTextBox.Text);
            update.Parameters.AddWithValue("@Kullanıcı_Adı", PersonelKullaniciAdiTextBox.Text);
            update.Parameters.AddWithValue("@Sifre", PersonelSifreTextBox.Text);
            update.Parameters.AddWithValue("@Kurtarma_Sorusu", PersonelGizliSoruComboBox.Text);
            update.Parameters.AddWithValue("@Cevap", PersonelCevapTextBox.Text);
            update.ExecuteNonQuery();

            Sc.Close();
            kayitGetir();





        }

        private void PersonelDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                PersonelID = Convert.ToInt32(PersonelDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                PersonelAdiTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                PersonelSoyadTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                PersonelVazifeComboBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                PersonelGirisDateTimePicker.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                PersonelMaasTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                PersonelTelefonTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                PersonelEmailTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                PersonelKullaniciAdiTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                PersonelSifreTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                PersonelGizliSoruComboBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                PersonelCevapTextBox.Text = PersonelDataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();






            }
            catch (Exception)
            {
                MessageBox.Show("Bu satır seçilemez.");
            }
        }

        private void PersonelAraBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kayit = "SELECT * from Personel where Ad=@Ad";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit, Sc);
            komut.Parameters.AddWithValue("@Ad", PersonelAraTextBox.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PersonelDataGridView.DataSource = dt;
            Sc.Close();
        }
    }
}



