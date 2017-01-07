using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart
{
    public partial class Form2 : Form
    {
        Kart gelenYolcu = new Kart();
        public Form2(Kart yolcu)
        {
            InitializeComponent();
            gelenYolcu = yolcu;
        }

        private void BtnYukle_Click(object sender, EventArgs e)
        {
            gelenYolcu.bakiye += Convert.ToDouble(TxtYuklemeMiktari.Text);

            Form1 frm = new Form1(gelenYolcu);
            frm.Show();
            this.Hide();
        }
    }
}
