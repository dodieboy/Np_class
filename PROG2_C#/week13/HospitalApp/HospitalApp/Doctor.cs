using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class Doctor:Person
    {
        private string department;
        private List<Patient> patientList;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public List<Patient> PatientList
        {
            get { return patientList; }
            set { patientList = value; }
        }
        public Doctor() { }
        public Doctor(string ic, string n, string d) : base(ic, n)
        {
            department = d;
        }
        public void AddPatient(Patient p)
        {
            PatientList.Add(p);
        }
        public void RemovePatient(Patient p)
        {
            
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(" department: {0}", this.department);
        }
    }
}
