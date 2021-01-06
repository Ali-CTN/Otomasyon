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
    public partial class Alis : Form
    {
        public Alis()
        {
            InitializeComponent();
        }
        string vazife = Giris.yetki;
        SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ali_c\Desktop\Yeni klasör\stok\STOK_TAKİP_OTOMASYONU\Budak Tekstil\Giris\Giris\BudakDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataReader dr;
        int ID = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            Menu AnaMenu = new Menu();
            AnaMenu.Show();
            this.Hide();
        }

        private void verilerigoster()
        {
            Sc.Open();
            SqlCommand komut = new SqlCommand("Select * from Malzeme_Alım", Sc);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {


            }
        }
            private void kayitGetir()
        {
            Sc.Open();
            string kayit = "SELECT * from Malzeme_Alım";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, Sc);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            AlisDATAGRIDVIEW.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            Sc.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void AlisFiyatTEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;

        }

        private void AlisFiyatTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            AlisFiyatTEXTBOX.MaxLength = 8;
        }

        private void AlisMiktarTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            AlisMiktarTEXTBOX.MaxLength = 8;
        }

        private void AlisMiktarTEXTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void AlisKaydetBTN_Click(object sender, EventArgs e)
        {
            if (AlisTedarikciAdiCOMBOBOX.Text == "")
                MessageBox.Show("Tedarikci Seciniz");
            if (AlisMalzemeCOMBOBOX.Text == "")
                MessageBox.Show("Malzeme Seciniz");
            if (AlisBirimCOMBOBOX.Text == "")
                MessageBox.Show("Birim Seciniz");
            if (AlisFiyatTEXTBOX.Text == "")
                MessageBox.Show("Fiyat Giriniz");
            if (AlisMiktarTEXTBOX.Text == "")
                MessageBox.Show("Miktar giriniz");
            if (alisrenktext.Text == "")
                MessageBox.Show("Renk Seciniz");

            Sc.Open();
            string kaydet = "insert into Malzeme_Alım(Malzeme,Birim,Renk,Miktar,Fiyat,Toplam_Fiyat,Firma,Teslim_Tarih)values(@Malzeme,@Birim,@Renk,@Miktar,@Fiyat,@Toplam_Fiyat,@Firma,@Teslim_Tarih)";
            SqlCommand cmd = new SqlCommand(kaydet, Sc);
            cmd.Parameters.AddWithValue("@Malzeme", AlisMalzemeCOMBOBOX.Text);
            cmd.Parameters.AddWithValue("@Birim", AlisBirimCOMBOBOX.Text);
            cmd.Parameters.AddWithValue("@Renk", alisrenktext.Text);
            cmd.Parameters.AddWithValue("@Miktar", AlisMiktarTEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Fiyat", AlisFiyatTEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Firma", AlisTedarikciAdiCOMBOBOX.Text);

            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(AlisFiyatTEXTBOX.Text);
            sayi2 = Convert.ToInt32(AlisMiktarTEXTBOX.Text);
            int Toplam_Fiyat = Convert.ToInt32(sayi1 * sayi2);
            cmd.Parameters.AddWithValue("@Toplam_Fiyat", Toplam_Fiyat);

            cmd.Parameters.AddWithValue("@teslim_tarih", AlisDATETIMEPICKER.Value);

            cmd.ExecuteNonQuery();


            Sc.Close();
            kayitGetir();




        }

        private void Alis_Load(object sender, EventArgs e)
        {
            kayitGetir();
            
            SqlCommand cmd = new SqlCommand();
            Sc.Open();
            cmd.Connection = Sc;

            cmd.CommandText = "SELECT * FROM Tedarikci ";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                AlisTedarikciAdiCOMBOBOX.Items.Add(dr["Firma"]);

            }
            Sc.Close();


            cmd.CommandText = "SELECT * FROM MALZEME";
            cmd.Connection = Sc;
            cmd.CommandType = CommandType.Text;


            Sc.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AlisMalzemeCOMBOBOX.Items.Add(dr["Malzeme"]);
            }
            Sc.Close();

        }

        private void AlisSilBTN_Click(object sender, EventArgs e)
        {
            if (vazife == "Yönetici")
            {
                Sc.Open();
                SqlCommand cmd = new SqlCommand("DELETE from [Malzeme_Alım] where Id=@ID", Sc);
                cmd.Parameters.AddWithValue("@ID", AlisDATAGRIDVIEW.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();

                Sc.Close();
                kayitGetir();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");

        }

        private void AlisDATAGRIDVIEW_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(AlisDATAGRIDVIEW.Rows[e.RowIndex].Cells[0].Value.ToString());
            AlisMalzemeCOMBOBOX.Text = AlisDATAGRIDVIEW.Rows[e.RowIndex].Cells[1].Value.ToString();
            AlisBirimCOMBOBOX.Text = AlisDATAGRIDVIEW.Rows[e.RowIndex].Cells[2].Value.ToString();
            alisrenktext.Text = AlisDATAGRIDVIEW.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            AlisTedarikciAdiCOMBOBOX.Text = AlisDATAGRIDVIEW.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void AlisGuncelleBTN_Click(object sender, EventArgs e)
        {

            SqlCommand update = new SqlCommand("update Malzeme_Alım set Malzeme=@Malzeme,Birim=@Birim,Renk=@Renk,Miktar=@Miktar,Fiyat=@Fiyat,Toplam_Fiyat=@Toplam_Fiyat,Firma=@Firma,Teslim_Tarih=@Teslim_Tarih where Id=@ID", Sc);
            Sc.Open();
            update.Parameters.AddWithValue("@id", ID);
            update.Parameters.AddWithValue("@Malzeme", AlisMalzemeCOMBOBOX.Text);
            update.Parameters.AddWithValue("@Birim", AlisBirimCOMBOBOX.Text);
            update.Parameters.AddWithValue("@Renk", alisrenktext.Text);
            update.Parameters.AddWithValue("@Miktar", AlisMiktarTEXTBOX.Text);
            update.Parameters.AddWithValue("@Fiyat", AlisFiyatTEXTBOX.Text);
            update.Parameters.AddWithValue("@Firma", AlisTedarikciAdiCOMBOBOX.Text);

            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(AlisFiyatTEXTBOX.Text);
            sayi2 = Convert.ToInt32(AlisMiktarTEXTBOX.Text);
            int Toplam_Fiyat = Convert.ToInt32(sayi1 * sayi2);
            update.Parameters.AddWithValue("@Toplam_Fiyat", Toplam_Fiyat);

            update.Parameters.AddWithValue("@teslim_tarih", AlisDATETIMEPICKER.Value);

            
            update.ExecuteNonQuery();



            Sc.Close();
            kayitGetir();
        }

        private void AlisAraBTN_Click(object sender, EventArgs e)
        {
            Sc.Open();
            string kayit = "SELECT * from Malzeme_Alım where Firma=@Firma";
            //musteriler tablosundaki tüm alanları isim parametresi
            SqlCommand komut = new SqlCommand(kayit, Sc);
            komut.Parameters.AddWithValue("@Firma", AlisAraTEXTBOX.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AlisDATAGRIDVIEW.DataSource = dt;
            Sc.Close();
        }
    }
}
