/*
(c) 2019 Alan Tan
This code is licensed under MIT license (See LICENSE.txt for details)
SPDX-Short-Identifier: MIT
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp_S10198161
{
    class Customer
    {
        private string name;
        private double loanAmount;
        private int repaymentPeriod;
        private int interestRate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }
        public int RepaymentPeriod
        {
            get { return repaymentPeriod; }
            set { repaymentPeriod = value; }
        }
        public int InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public Customer(string n, double l, int r, int i)
        {
            Name = n;
            LoanAmount = l;
            RepaymentPeriod = r;
            InterestRate = i;
        }
        public double CalculateAmountDue()
        {
            double interest = LoanAmount * InterestRate/100 * RepaymentPeriod;
            return (loanAmount + interest);
        }
        public override string ToString()
        {
            return String.Format("Name: {0}  Loan: {1}  Repayment Period: {2} Interest Rate:  {3}", Name, LoanAmount, RepaymentPeriod, InterestRate);
        }
    }
}
