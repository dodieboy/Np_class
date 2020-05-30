//============================================================
// Student Number	: S10194833D, S10198161D
// Student Name	: Do Li Fang Sarah, Tan Jia Shun
// Module  Group	: P07 //============================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Management_System
{
    class Adult:Patient
    {
        public double MedisaveBalance { get; set; }

        public Adult(string id, string n, int a, char g, string cs, string s, double msb) : base(id, n, a, g, cs, s)
        {
            MedisaveBalance = msb;
        }

        public override double CalculateCharges()
        {
            double charges = base.CalculateCharges();

            if (Status == "SC" || Status == "PR")
            {
                double balance = MedisaveBalance - charges;

                if (balance < 0)
                {
                    double cash_pay = balance * -1;
                    return cash_pay;
                }

                else
                {
                    return balance;
                }

            }

            else
            {
                return charges;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\tMedisave Balance: $" + MedisaveBalance;
        }
    }
}
