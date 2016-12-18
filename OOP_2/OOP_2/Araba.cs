using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Araba
    {
        int _motorGucu;
        public int MotorGucu
        {
            get
            {
                return _motorGucu;
            }
            set
            {
                if (value > 800 && value < 5000)
                {
                    _motorGucu = value;
                }
            }
        }
    }
}
