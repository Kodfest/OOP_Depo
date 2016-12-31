using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari
{
    class SatisTemsilcisi : Calisan
    {
        public int satisMiktari { get; set; }

        public override double PrimliMaasHesapla(int satisAdeti)
        {
            if (satisAdeti <= 10)
                maas += satisAdeti * 10;
            else if (satisAdeti <= 20)
                maas += satisAdeti * 20;
            else
                maas += satisAdeti * 30;

            return maas;
        }
    }
}
