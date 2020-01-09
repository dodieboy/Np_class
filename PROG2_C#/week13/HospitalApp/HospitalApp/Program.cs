using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HospitalApp
{
    class Program
    {
        static void IninData(List<Room> roomList, List<Doctor> doctorList)
        {
            roomList.Add(new Room("#01-01", "C"));
            roomList.Add(new Room("#02-02", "B"));
            roomList.Add(new Room("#03-03", "A"));
            roomList.Add(new Room("#04-04", "A"));
            doctorList.Add(new Doctor("S1234567A", "Tom", "Pediatrics"));
            doctorList.Add(new Doctor("S2345678A", "Champ", "Oncology"));
            doctorList.Add(new Doctor("S3456789B", "Terry", "Cardiology"));
        }
        static void displayIninList(List<Room> roomList, List<Doctor> doctorList)
        {
            Console.WriteLine("{0, -6} {1}", "Location", "Ward Class");
            foreach (Room r in roomList)
            {
                Console.WriteLine("{0, -6} {1}", r.Location, r.WardClass);
            }
            Console.WriteLine();
            Console.WriteLine("{0, -9} {1, -10} {2}", "Nric", "Name", "department");
            foreach (Room r in roomList)
            {
                Console.WriteLine("{0, -6} {1}", r.Location, r.WardClass);
            }
            Console.WriteLine();
        }
        static void CreatePatients(List<Patient> patientList, List<Room> roomList)
        {
            string[] temp = File.ReadAllText("Patients.csv").Replace("\r", string.Empty).Split('\n');
            for (int i = 1; i < temp.Length - 1; i++)
            {
                string[] temp2 = temp[i].Split(',');
                patientList.Add(new Patient(temp2[0], temp2[1], new Room(temp2[2],SearchRoom(roomList, temp2[2]).WardClass)));
            }
        }
        static Room SearchRoom(List<Room> roomList, string w)
        {
            Room result = roomList.Find(x => x.Location == w);
            return result;
        }
        static void displayPatientsList(List<Patient> patientList)
        {
            Console.WriteLine("{0, -12} {1, -15} {2}", "Patient NRIC", "Patient Name", "Ward Location");
            foreach (Patient p in patientList)
            {
                Console.WriteLine("{0, -12} {1, -15} {2}", p.Nric, p.Name, p.WardAt.Location + " Ward " + p.WardAt.WardClass);
            }
            Console.WriteLine();
        }
        static void AssignPatientsToDoctors(List<Patient> patientList, List<Doctor> doctorList)
        {
            string[] temp = File.ReadAllText("PatientsToDoctor.csv").Replace("\r", string.Empty).Split('\n');
            for (int i = 1; i < temp.Length - 1; i++)
            {
                string[] temp2 = temp[i].Split(',');
                patientList.Add(new Patient(temp2[0], temp2[1], new Room(temp2[2], SearchRoom(roomList, temp2[2]))));
            }
        }
        static Doctor SearchDoctor(List<Doctor> doctorList, string nric)
        {
            Doctor result = doctorList.Find(x => x.Nric == nric);
            return result;
        }
        static void Main(string[] args)
        {
            List<Room> roomList = new List<Room>();
            List<Patient> patientList = new List<Patient>();
            List<Doctor> doctorList = new List<Doctor>();
            IninData(roomList, doctorList);
            displayIninList(roomList, doctorList);
            CreatePatients(patientList, roomList);
            displayPatientsList(patientList);
            Console.ReadLine();
        }
    }
}
