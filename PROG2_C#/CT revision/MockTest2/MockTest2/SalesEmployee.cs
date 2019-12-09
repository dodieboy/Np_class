using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest2
{
    class SalesEmployee:FullTimeEmployee
    {
        private double salesAmount;
        public double SalesAmount
        {
            get { return salesAmount; }
            set { salesAmount = value; }
        }
        public SalesEmployee() { }
        public SalesEmployee(int i, string n, double b, double a, double s):base(i,n,b,a)
        {
            SalesAmount = s;
        }
        public double DetermineCommissionRate()
        {
            if (salesAmount < 1000)
            {
                return 0.2;
            }
            else
            {
                return 0.5;
            }
        }
        public override double CalculatePay()
        {
            return base.CalculatePay()+(salesAmount * DetermineCommissionRate());
        }
        public override string ToString()
        {
            return String.Format("Id: {0} Name: {1} BasicPay: {2} Allowance: {3} SalesAmount {4}", Id, Name, BasicPay, Allowance, this.SalesAmount);
        }
    }
}
