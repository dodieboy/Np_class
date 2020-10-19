using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT
{
    class Car:Vehicle
    {
        private double engineCapacity;
        public double EngineCapacity
        {
            get { return engineCapacity; }
            set { engineCapacity = value; }
        }
        public Car() { }
        public Car(string p, string b, double r, double e) : base(p, b, r)
        {
            EngineCapacity = e;
        }
        public override double CalculateRentalCost(int d)
        {
            return (10 + (d * RentalRate));
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(" Engine Capacity: {0}", EngineCapacity);
        }
    }
}
