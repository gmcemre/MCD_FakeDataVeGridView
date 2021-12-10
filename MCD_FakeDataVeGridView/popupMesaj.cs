using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_FakeDataVeGridView
{
    public partial class popupMesaj : Form
    {
        Musteri musteriData;
        public popupMesaj(Musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupMesaj_Load(object sender, EventArgs e)
        {
            txtİsim.Text = musteriData.isim;
            txtSoyisim.Text = musteriData.soyisim;
            txtTamAd.Text = musteriData.tamAdi;
            txtEmailAdres.Text = musteriData.emailAdres;
            txtTelefonNo.Text = musteriData.telefonNumara;
            txtIlIlce.Text = $"{musteriData.il} / { musteriData.ilce}";
            txtAdres.Text = musteriData.adres;
        }
    }
}
