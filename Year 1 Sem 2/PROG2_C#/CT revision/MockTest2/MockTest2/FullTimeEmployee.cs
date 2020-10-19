using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest2
{
    class FullTimeEmployee:Employee
    {
        private double basicPay;
        private double allowance;
        public double BasicPay
        {
            get { return basicPay; }
            set { basicPay = value; }
        }
        public double Allowance
        {
            get { return allowance; }
            set { allowance = value; }
        }
        public FullTimeEmployee() { }
        public FullTimeEmployee(int i, string n, double b, double a):base(i, n)
        {
            BasicPay = b;
            Allowance = a;
        }
        //FullTimeEmployee
        public override double CalculatePay()
        {
            return BasicPay + Allowance;
        }
        public override string ToString()
        {
            return String.Format("Id: {0} Name: {1} BasicPay: {2} Allowance: {3}", this.Id, this.Name, this.BasicPay, this.Allowance);
        }
    }
}
