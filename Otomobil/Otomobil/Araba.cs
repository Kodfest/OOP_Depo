using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil
{
    public abstract class Araba
    {
        public string seri { get; set; }
        public string model { get; set; }
        public int motorHacmi { get; set; }
        public int motorGucu { get; set; }

        public string Yazdir()
        {
            return string.Format("Seri \t\t: {0} \nModel \t\t: {1} \nMotor Hacmi \t: {2} \nMotor Gücü \t: {3}", seri, model, motorHacmi, motorGucu);
        }

        //public virtual string Calistir()
        //{
        //    return "Araba Çalıştı";
        //}

        public abstract string Calistir();
    }
}
