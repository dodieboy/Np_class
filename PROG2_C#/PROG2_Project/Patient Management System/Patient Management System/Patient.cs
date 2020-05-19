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
    abstract class Patient
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public string CitizenStatus { get; set; }

        public string Status { get; set; }

        public Stay Stay { get; set; }

        public Patient(string id, string n, int a, char g, string cs, string s)
        {
            ID = id;
            Name = n;
            Gender = g;
            Age = a;
            CitizenStatus = cs;
            Status = s;
        }

        public virtual double CalculateCharges()
        {
            double total = 0;
            foreach (BedStay bs in Stay.BedstayList)
            {
                Bed b = bs.bed;
                if (b is ClassABed)
                {
                    b = (ClassABed)b;
                    if (bs.endBedstay == null)
                    {
                        Console.WriteLine("Patient not discharged");
                    }

                    else
                    {
                        int? days = (int?)(bs.endBedstay - bs.startBedstay)?.TotalDays;
                        if (days != null)
                        {
                            int total_days = Convert.ToInt32(days);
                            total += b.CalculateCharges(CitizenStatus, total_days);
                        }
                    }
                }

                else if (b is ClassBBed)
                {
                    b = (ClassBBed)b;

                    if (bs.endBedstay == null)
                    {
                        Console.WriteLine("Patient not discharged");
                    }

                    else
                    {
                        int? days = (int?)(bs.endBedstay - bs.startBedstay)?.TotalDays;
                        if (days != null)
                        {
                            int total_days = Convert.ToInt32(days);
                            total += b.CalculateCharges(CitizenStatus, total_days);
                        }

                    }
                }

                else if (b is ClassCBed)
                {
                    b = (ClassCBed)b;

                    if (bs.endBedstay == null)
                    {
                        Console.WriteLine("Patient not discharged");
                    }

                    else
                    {
                        int? days = (int?)(bs.endBedstay - bs.startBedstay)?.TotalDays;
                        if (days != null)
                        {
                            int total_days = Convert.ToInt32(days);
                            total += b.CalculateCharges(CitizenStatus, total_days);
                        }

                    }

                }
            }
            return total;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} ID No.: {1} Age: {2} Gender: {3} Citizenship: {4} Status: {5}", Name, ID, Age, Gender, CitizenStatus, Status);
        }
    }
}
