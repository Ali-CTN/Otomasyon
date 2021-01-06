using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{   
    public partial class Menu : Form
    {
        string vazife = Giris.yetki;
        public Menu()
        {
            InitializeComponent();
        }

        
       

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void MenuSatisBTN_Click(object sender, EventArgs e)
        {
            if ((vazife == "Yönetici") || (vazife == "Pazarlama Mdr"))
            {
                Satis SatisSayfasi = new Satis();
                SatisSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void MenuAlisBTN_Click(object sender, EventArgs e)
        {
            if ((vazife == "Yönetici") || (vazife == "Pazarlama Mdr"))
            {
                Alis AlisSayfasi = new Alis();
                AlisSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void DepoUrunBTN_Click(object sender, EventArgs e)
        {
            if ((vazife == "Yönetici") || (vazife == "Pazarlama Mdr") || (vazife == "Depo Sorumlusu"))
            {
                DepoUrun DepoUrunSayfasi = new DepoUrun();
                DepoUrunSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void DepoMlzBTN_Click(object sender, EventArgs e)
        {
            if ((vazife == "Yönetici") || (vazife == "Pazarlama Mdr") || (vazife == "Depo Sorumlusu"))
            {
                DepoMalzeme DepoMalzemeSayfasi = new DepoMalzeme();
                DepoMalzemeSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");


        }

        private void PersonelBTN_Click(object sender, EventArgs e)
        {
            if (vazife == "Yönetici") 
                
            {
                Personel PersonelSayfasi = new Personel();
                PersonelSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void MusteriBTN_Click(object sender, EventArgs e)
        {
            if ((vazife == "Yönetici") || (vazife == "Pazarlama Mdr")) { 
                Musteri MusteriSayfasi = new Musteri();
            MusteriSayfasi.Show();
            this.Hide();
        }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void TedarikciBTN_Click(object sender, EventArgs e)
        {
            if ((vazife == "Yönetici") || (vazife == "Pazarlama Mdr"))
            {
                Tedarikci TedarikciSayfasi = new Tedarikci();
                TedarikciSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");

        }

        private void UrunBTN_Click(object sender, EventArgs e)
        {
            if ((vazife == "Yönetici") || (vazife == "Modelist")) { 
                Urun UrunSayfasi = new Urun();
            UrunSayfasi.Show();
            this.Hide();
        }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }

        private void KarZararBTN_Click(object sender, EventArgs e)
        {
            if (vazife == "Yönetici")
            {
                KarZarar KarZararSayfasi = new KarZarar();
                KarZararSayfasi.Show();
                this.Hide();
            }
            else MessageBox.Show("Yetkiniz yetersizdir.");
        }
    }
}
