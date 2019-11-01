using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareCalculationApp
{
    class Fare
    {
        private double upToDistance;
        private int amount;

        public double UpToDistance
        {
            get { return upToDistance; }
            set { upToDistance = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Fare(double u, int a)
        {
            UpToDistance = u;
            Amount = a;
        }
        public override string ToString()
        {
            return "WIP";
        }
    }
}
