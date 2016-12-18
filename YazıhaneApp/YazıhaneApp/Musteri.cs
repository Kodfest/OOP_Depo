using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazıhaneApp
{
    class Musteri
    {
        public string Adi;
        public string Cinsiyet;
        public string OtobusTuru;

        public override string ToString()
        {
            return this.Adi + "\t" + this.Cinsiyet + "\t" + this.OtobusTuru;
        }
    }
}
