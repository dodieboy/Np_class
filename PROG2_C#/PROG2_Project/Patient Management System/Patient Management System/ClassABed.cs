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
    public class ClassABed:Bed
    {
        public bool accompanyingPerson { get; set; }
        public ClassABed(int w, int b, double d, bool ap) :base(w, b, d, ap) { }
        public override double CalculateCharges(string status, int days)
        {

            if (accompanyingPerson == true)
            {
                return (days * dailyRate) + (days * 100);
            }

            else
            {
                return dailyRate * days;
            }

        }
        public override string ToString()
        {
            return base.ToString() + " Accompanying Person: " + accompanyingPerson;
        }
    }
}
