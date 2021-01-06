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
    public partial class PastaGrafik : Form
    {
        public PastaGrafik()
        {
            InitializeComponent();
        }

        private void PastaGrafikGeriBTN_Click(object sender, EventArgs e)
        {
            KarZarar KarZararSayfasi = new KarZarar();
            KarZararSayfasi.Show();
            this.Hide();
        }
    }
}
