using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Ogrenci ogr1 = new Ogrenci();
        Ogrenci ogr2 = new Ogrenci();

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            ogr1.AdSoyad = "Yavuz Gedik";
            ogr1.OgrNo = rnd.Next(1, 100);

            ogr2.AdSoyad = "Seçkin Umur";
            ogr2.OgrNo = rnd.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogr1.AdSoyad + " " + ogr1.OgrNo);
        }
    }
}
