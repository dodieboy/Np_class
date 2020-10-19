using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT
{
    class Van:Vehicle
    {
        private int numberOfSeats;
        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }
        }
        public Van(): base() { }
        public Van(string p, string b, double r, int s) : base(p, b, r)
        {
            NumberOfSeats = s;
        }
        public override double CalculateRentalCost(int d)
        {
            return (d*RentalRate);
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(" NO.Seats: {0}", NumberOfSeats);
        }
    }
}
