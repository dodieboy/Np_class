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
    public class BedStay
    {
        public DateTime startBedstay { get; set; }
        public DateTime? endBedstay { get; set; }
        public Bed bed { get; set; }
        public BedStay(DateTime s, Bed b)
        {
            startBedstay = s;
            bed = b;
        }
        public override string ToString()
        {
            return string.Format("Start: {0} End: {1} Bed: {2}", startBedstay, endBedstay, bed);
        }
    }
}
