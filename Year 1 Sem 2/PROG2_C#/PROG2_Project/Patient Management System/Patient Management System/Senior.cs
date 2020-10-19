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
    class Senior:Patient
    {
        public Senior(string id, string n, int a, char g, string cs, string s) : base(id, n, a, g, cs, s) { }

        public override double CalculateCharges()
        {
            double charges = base.CalculateCharges();
            double cash_pay = charges * 0.5;
            return cash_pay;
        }
    }
}
