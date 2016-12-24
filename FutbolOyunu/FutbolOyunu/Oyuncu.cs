using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    class Oyuncu
    {
        public string ad;
        public byte no;
        public string takim;

        // Constructor
        public Oyuncu()
        {

        }
        public Oyuncu(string adi, byte formaNo, string takimi)
        {
            this.ad = adi;
            this.no = formaNo;
            this.takim = takimi;
        }

        public string BilgiVer()
        {
            return "Adı: " + this.ad + "\nNumarası: " + this.no + "\nTakımı: " + this.takim;
        }
        public override string ToString()
        {
            return this.ad;
        }
    }
}
