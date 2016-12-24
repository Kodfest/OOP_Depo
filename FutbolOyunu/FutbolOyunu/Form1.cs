using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string adi = TxtAd.Text;
            byte formaNo = Convert.ToByte(NumNo.Value);
            string takimi = TxtTakim.Text;

            Oyuncu o = new Oyuncu(adi, formaNo, takimi);
            LstBoxOyuncular.Items.Add(o);
        }

        private void LstBoxOyuncular_DoubleClick(object sender, EventArgs e)
        {
            Oyuncu o = (Oyuncu)LstBoxOyuncular.SelectedItem;
            MessageBox.Show(o.BilgiVer());
        }
    }
}
