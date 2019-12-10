using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT
{
    class SportsCar:Car
    {
        public SportsCar() { }
        public SportsCar(string p, string b, double r, double e) : base(p, b, r, e) { }
        public double CalculateDeposit()
        {
            if(EngineCapacity < 3.0)
            {
                return 2000;
            }
            else if (EngineCapacity < 4.5)
            {
                return 4000;
            }
            else
            {
                return 5000;
            }
        }
    }
}
