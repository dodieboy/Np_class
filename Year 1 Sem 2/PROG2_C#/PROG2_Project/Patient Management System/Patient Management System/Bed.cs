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
    public abstract class Bed
    {
        public int wardNo { get; set; }
        public int bedNo { get; set; }
        public double dailyRate { get; set; }
        public bool available { get; set; }

        public Bed(int w, int b, double d, bool a)
        {
            wardNo = w;
            bedNo = b;
            dailyRate = d;
            available = a;
        }
        public abstract double CalculateCharges(string status, int days);

        public override string ToString()
        {
            return string.Format("Ward No.: {0} Bed: {1} Daily Rate: {2} Available: {3}", wardNo, bedNo, dailyRate, available);
        }
    }
}
