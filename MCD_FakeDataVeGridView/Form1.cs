﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string isim = FakeData.NameData.GetFirstName();
            //string soyisim = FakeData.NameData.GetSurname();
            //MessageBox.Show(isim + " " + soyisim, "Fake Data İnceleme", MessageBoxButtons.OK);

            Database db = new Database();
            List<Musteri> musteriListe = db.musteriListele();

            // 1.Data bize lazım ama ekran üzerinde göstermek istemiyoruz bu gibi durumlarda columns koleksiyonu içinde ilgili kolonun id değeri veya tip prop adı verilerek Visible prop false edilmesi yeterlidir..
            //dgwMusteriListe.DataSource = musteriListe;
            //dgwMusteriListe.Columns[0].Visible = false;
            //dgwMusteriListe.Columns["id"].Visible = true;

            //Data Grid View içerisinde bulunan kolonların isimlerini değiştirmek...

            //dgwMusteriListe.Columns[0].HeaderText = "Müşteri ID";
            //dgwMusteriListe.Columns[1].HeaderText = "Müşteri İsim";
            //dgwMusteriListe.Columns[2].HeaderText = "Müşteri Soyisim";
            //dgwMusteriListe.Columns[2].Width = 500;
            //dgwMusteriListe.Columns[3].HeaderText = "Müşteri Tam Adı ";

            //2.Data bize lazım değil hiç bir şekilde ekranda görünmesini veya kullanmak istemiyoruz.

            var dgwListe = from I in musteriListe
                           select new
                           {
                               Isim = I.isim,
                               Soyisim = I.soyisim,
                               TamAdi = I.tamAdi
                           };

            dgwMusteriListe.DataSource = dgwListe.ToList();
        }
    }
}
