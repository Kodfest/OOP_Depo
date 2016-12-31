using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
    public class Mercedes : Araba
    {
        public Mercedes()
        {
            seri = "C";
            model = "180";
            motorGucu = 2500;
            motorHacmi = 100;
        }

        public override string Calistir()
        {
            return "Vuuu Vuuu";
        }
    }
}
