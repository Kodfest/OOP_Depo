using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
    public class Porsche : Araba
    {
        public Porsche()
        {
            seri = "GT";
            model = "911";
            motorHacmi = 3000;
            motorGucu = 300;
        }

        public override string Calistir()
        {
            return "Vrom Vrom Vrom";
        }
    }
}
