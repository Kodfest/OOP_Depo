using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart
{
    class OgrenciKart : Kart
    {
        public string okulAdi { get; set; }

        public override void Okut()
        {
            MessageBox.Show("1 ₺ alındı. Kalan Bakiye : " + (bakiye - 1));
            bakiye -= 1;
        }

        public override string ToString()
        {
            return kartID + "\t" + bakiye + "\t" + kartTuru + "\t" + okulAdi;
        }
    }
}
