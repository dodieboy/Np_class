using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest2
{
    class PartTimeEmployee:Employee
    {
        private double dailyRate;
        private int daysWorked;
        public double DailyRate
        {
            get { return dailyRate; }
            set { dailyRate = value; }
        }
        public int DaysWorked
        {
            get { return daysWorked; }
            set { daysWorked = value; }
        }
        public PartTimeEmployee() { }
        public PartTimeEmployee(int i, string n, double r, int w):base(i, n)
        {
            DailyRate = r;
            DaysWorked = w;
        }
        //PartTimeEmployee
        public override double CalculatePay()
        {
            return DaysWorked * DailyRate;
        }
    }
}
