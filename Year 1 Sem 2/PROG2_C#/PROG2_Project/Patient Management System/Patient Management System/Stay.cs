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
    class Stay
    {
        public DateTime AdmittedDate { get; set; }

        public DateTime? DischargeDate { get; set; }

        public bool IsPaid { get; set; }

        public List<MedicalRecord> MedicalRecordList { get; set; } = new List<MedicalRecord>();

        public List<BedStay> BedstayList { get; set; } = new List<BedStay>();

        public Patient Patient { get; set; }

        public Stay(DateTime ad, Patient p)
        {
            AdmittedDate = ad;
            Patient = p;
        }

        public void AddMedicalRecord(MedicalRecord mr)
        {
            MedicalRecordList.Add(mr);
        }

        public void AddBedStay(BedStay bs)
        {
            BedstayList.Add(bs);
        }

        public override string ToString()
        {
            return string.Format("Admitted Date: {0} Discharge Date: {1}", AdmittedDate, DischargeDate);
        }
    }
}
