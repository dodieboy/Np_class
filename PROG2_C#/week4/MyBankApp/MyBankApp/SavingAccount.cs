using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    class SavingAccount: BankAccount
    {
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public SavingAccount():base() { }
        public SavingAccount(string no, string name, double bal, double r):base(no, name, bal)
        {
            rate = r;
        }
        public double CalculateInterest()
        {
            return (Balance * Rate / 100);
        }
        public override string ToString()
        {
            return base.ToString() + ", Rate: " + Rate;
        }
    }
}
