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
        static void displayPatientsList(List<Patient> patientList)
        {
            Console.WriteLine("{0, -12} {1, -15} {2}", "Patient NRIC", "Patient Name", "Ward Location");
            foreach (Patient p in patientList)
            {
                Console.WriteLine("{0, -12} {1, -15} {2}", p.Nric, p.Name, p.WardAt.Location + " Ward " + p.WardAt.WardClass);
            }
            Console.WriteLine();
        }
        static void displayPatientsToDoctorList(List<Doctor> doctorList)
        {
            foreach (Doctor data in doctorList)
            {
                foreach (Patient info in data.PatientList)
                {
                    Console.WriteLine(info);
                }
            }
            Console.WriteLine();
        }

        static Room SearchRoom(List<Room> roomList, string w)
        {
            Room result = roomList.Find(x => x.Location == w);
            return result;
        }
        static Doctor SearchDoctor(List<Doctor> doctorList, string nric)
        {
            Doctor result = doctorList.Find(x => x.Nric == nric);
            return result;
        }
        static Patient SearchPatient(List<Patient> patientrList, string nric)
        {
            Patient result = patientrList.Find(x => x.Nric == nric);
            return result;
        }

        static void CreatePatients(List<Patient> patientList, List<Room> roomList)
        {
            string[] raw = File.ReadAllText("Patients.csv").Replace("\r", string.Empty).Split('\n');
            for (int i = 1; i < raw.Length - 1; i++)
            {
                string[] temp = raw[i].Split(',');
                patientList.Add(new Patient(temp[0], temp[1], new Room(temp[2], SearchRoom(roomList, temp[2]).WardClass)));
            }
        }
        static void AssignPatientsToDoctors(List<Patient> patientList, List<Doctor> doctorList)
        {
            string[] raw = File.ReadAllText("PatientsToDoctor.csv").Replace("\r", string.Empty).Split('\n');
            for (int i = 1; i < raw.Length; i++)
            {
                string[] temp = raw[i].Split(',');
                SearchDoctor(doctorList, temp[1]).AddPatient(patientList.Find(x => x.Nric == temp[0]));
            }
        }
        static void RemovePatientFromDoctor(List<Doctor> doctorList)
        {
            Console.Write("Please key the NRIC of the doctor: ");
            string doctor = Console.ReadLine();
            Console.Write("Please key the NRIC of the patient: ");
            string patient = Console.ReadLine();
            Doctor info = SearchDoctor(doctorList, doctor);
            info.RemovePatient(SearchPatient(info.PatientList, patient));
        }

        static void AddNewPatient(List<Patient> patientList, List<Room> roomList)
        {
            Console.Write("Please enter patient NRIC: ");
            string nric = Console.ReadLine();
            Console.Write("Please enter patient name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter location of room: ");
            string room = Console.ReadLine();

            patientList.Add(new Patient(nric, name, new Room(room, SearchRoom(roomList, room).WardClass)));

            //add to Patients.csv
            File.AppendAllText("Patients.csv", "\r\n" + nric + "," + name + "," + room);
            Console.WriteLine("Patient Added!");
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

            AssignPatientsToDoctors(patientList, doctorList);
            displayPatientsToDoctorList(doctorList);

            RemovePatientFromDoctor(doctorList);
            displayPatientsToDoctorList(doctorList);

            AddNewPatient(patientList, roomList);

            Console.ReadLine();
        }
    }
}
