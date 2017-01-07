using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
    public class Tofas : Araba
    {
        //yapıcı metod
        public Tofas()
        {
            seri = "Serçe";
            model = "Murat 131";
            motorGucu = 30;
            motorHacmi = 1400;
        }

        public override string Calistir()
        {
            return "tır tır tır";
        }
    }
}
