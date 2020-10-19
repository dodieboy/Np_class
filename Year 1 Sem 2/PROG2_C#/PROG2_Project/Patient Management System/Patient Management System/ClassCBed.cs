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
    public class ClassCBed:Bed
    {
        public bool PortableTV { get; set; }
        public ClassCBed(int w, int b, double d, bool ptv) : base(w, b, d, ptv) { }
        public override double CalculateCharges(string status, int days)
        {
            double subsidy = 0;
            double adhoc_tv = 0;

            if (PortableTV == true)
            {
                adhoc_tv = 30;
            }

            else
            {
                adhoc_tv = 0;
            }

            if (status == "SC")
            {
                subsidy = 0.2;
            }

            else if (status == "PR")
            {
                subsidy = 0.4;
            }

            else if (status == "Foreigner")
            {
                subsidy = 1;
            }

            return (days * dailyRate * subsidy) + adhoc_tv;
        }
        public override string ToString()
        {
            return base.ToString() + " Portable TV: " + PortableTV;
        }
    }
}
