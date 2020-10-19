using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT
{
    abstract class Vehicle
    {
        private string plateNumber;
        private string brand;
        private double rentalRate;
        public string PlateNumber
        {
            get { return plateNumber; }
            set { plateNumber = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }
        public Vehicle() { }
        public Vehicle(string p, string b, double r)
        {
            PlateNumber = p;
            Brand = b;
            RentalRate = r;
        }
        public abstract double CalculateRentalCost(int d);
        public override string ToString()
        {
            return string.Format("Plate Number: {0} Brand: {1} Rate: {2}", PlateNumber, Brand, RentalRate);
        }
    }
}
