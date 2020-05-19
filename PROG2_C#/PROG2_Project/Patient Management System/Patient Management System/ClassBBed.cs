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
    public class ClassBBed:Bed
    {
        public bool AirCon { get; set; }
        public ClassBBed(int w, int b, double d, bool ac) : base(w, b, d, ac) { }
        public override double CalculateCharges(string status, int days)
        {
            double total = 0;
            double subsidy = 0;
            if (status == "SC")
            {
                subsidy = 0.3;
            }

            else if (status == "PR")
            {
                subsidy = 0.6;
            }

            else if (status == "Foreigner")
            {
                subsidy = 1;
            }

            double weeks = Math.Ceiling((Convert.ToDouble(days / 7)));
            total = (days * dailyRate * subsidy) + (weeks * 50);
            return total;
        }
        public override string ToString()
        {
            return base.ToString() + " AirCon: " + AirCon;
        }
    }
}
