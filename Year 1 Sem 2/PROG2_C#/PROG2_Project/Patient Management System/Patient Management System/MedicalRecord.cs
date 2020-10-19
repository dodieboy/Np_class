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
    public class MedicalRecord
    {
        public string diagnosis { get; set; }
        public double temperature { get; set; }
        public DateTime datetimeEntered { get; set; }
        public MedicalRecord(string d, double t, DateTime e)
        {
            diagnosis = d;
            temperature = t;
            datetimeEntered = e;
        }
        public override string ToString()
        {
            return string.Format("Diagnosis: {0} Temperature: {1} Datetime Entered: {2}", diagnosis, temperature, datetimeEntered);
        }
    }
}
