//============================================================
// Student Number	: S10194833D, S10198161D
// Student Name	: Do Li Fang Sarah, Tan Jia Shun
// Module  Group	: P07 //============================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;

namespace Patient_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST & INITIALIZING
            Console.Title = "Singa Hospital";
            List<Bed> bedList = new List<Bed>();
            InitBedList(bedList);
            List<Patient> patientList = new List<Patient>();
            InitPatientList(patientList);
            // MENU
            while (true)
            {
                Console.Clear();
                string option = Menu();
                Console.Clear();
                if (option == "1")
                {
                    Console.WriteLine("Option 1. View All Patients");
                    DisplayPatient(patientList);
                }

                else if (option == "2")
                {
                    Console.WriteLine("Option 2. View All Beds");
                    DisplayBeds(bedList);
                }

                else if (option == "3")
                {
                    Console.WriteLine("Option 3. Register Patient");
                    RegisterPatient(patientList);
                }

                else if (option == "4")
                {
                    Console.WriteLine("Option 4. Add new bed");
                    AddNewBed(bedList);
                }

                else if (option == "5")
                {
                    Console.WriteLine("Option 5. Register a hospital stay");
                    RegisterHospitalStay(patientList, bedList);
                }

                else if (option == "6")
                {
                    Console.WriteLine("Option 6. Retrieve Patient Details");
                    DisplayPatient(patientList);
                    DisplayPatientDetails(patientList);
                    Console.WriteLine("\nReturning to Menu...");
                }

                else if (option == "7")
                {
                    Console.WriteLine("Option 7.Add Medical Record Entry");
                    DisplayPatient(patientList);
                    AddMedicalRecord(patientList);
                }

                else if (option == "8")
                {
                    Console.WriteLine("Option 8. View medical records");
                    DisplayPatient(patientList);
                    DisplayMedicalRecord(patientList);
                }

                else if (option == "9")
                {
                    Console.WriteLine("Option 9. Transfer Patient to Another Bed");
                    TransferBed(patientList, bedList);
                }

                else if (option == "10")
                {
                    Console.WriteLine("Option 10. Discharge and payment");
                    DischargePayment(patientList);
                }

                else if (option == "11")
                {
                    Console.WriteLine("Option 11. Display currencies exchange rate");
                    currenciesRate();
                }

                else if (option == "12")
                {
                    Console.WriteLine("Option 12. Display the PM 2.5 information");
                    DisplayPMInfo();
                }

                else if (option == "0")
                {
                    Console.WriteLine("System shuting down...\nGoodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Try Again.");
                }
                Console.WriteLine("<Press any key to continue>");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
        static string Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+--------------------------------------------------------------------+\n|   _____ _                     _    _                 _ _        _  |\n|  / ____(_)                   | |  | |               (_) |      | | |\n| | (___  _ _ __   __ _  __ _  | |__| | ___  ___ _ __  _| |_ __ _| | |\n|  \\___ \\| | '_ \\ / _` |/ _` | |  __  |/ _  / __| '_ \\| | __/ _` | | |\n|  ____) | | | | | (_| | (_| | | |  | | (_) \\__ \\ |_) | | || (_| | | |\n| |_____/|_|_| |_|\\__, |\\__,_| |_|  |_|\\___ |___/ .__/|_|\\__\\__,_|_| |\n|                  __/ |                        | |                  |\n|                 |___/                         |_|                  |\n|                                                                    |\n+--------------------------------------------------------------------+");
            Console.ResetColor();
            Console.WriteLine("\nMENU\n=====");
            Console.WriteLine("1.View all patients");
            Console.WriteLine("2.View all beds");
            Console.WriteLine("3.Register patient");
            Console.WriteLine("4.Add new bed");
            Console.WriteLine("5.Register a hospital stay");
            Console.WriteLine("6.Retrieve patient details");
            Console.WriteLine("7.Add medical record entry");
            Console.WriteLine("8.View medical records");
            Console.WriteLine("9.Transfer patient to another bed");
            Console.WriteLine("10.Discharge and payment");
            Console.WriteLine("11.Display currencies exchange rate");
            Console.WriteLine("12.Display PM 2.5 information");
            Console.WriteLine("0.Exit\n");
            Console.Write("Enter your option: ");
            return Console.ReadLine();
        }

        static double StringToDoubleValidation(string input, string variable)
        {
            try
            {
                return Convert.ToDouble(input);
            }

            catch (FormatException)
            {
                Console.WriteLine("{0}: {1} is an Invalid Input!", variable, input);
                return 10000;
            }

            catch (OverflowException)
            {
                Console.WriteLine("{0}: {1} is too big", variable, input);
                return -10000;
            }
        }

        static int StringToIntValidation(string input, string variable)
        {
            try
            {
                return Convert.ToInt32(input);
            }

            catch (FormatException)
            {
                Console.WriteLine("{0}: {1} is an Invalid Input!", variable, input);
                return 10000;
            }

            catch (OverflowException)
            {
                Console.WriteLine("{0}: {1} is too big", variable, input);
                return -10000;
            }
        }

        static DateTime? StringToDateTimeValidation(string input, string variable)
        {
            try
            {
                return DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            catch (FormatException)
            {
                Console.WriteLine("{0}: {1} is an Invalid Input!", variable, input);
                return null;
            }
        }

        static bool CheckInputString(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            foreach(Char c in input)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckID(string id)
        {
            if(id.Length == 9) {
                char[] ids = id.ToCharArray();
                if(Char.IsLetter(ids[0]) && Char.IsLetter(ids[8]))
                {
                    for (int i = 1; i < ids.Length-1; i++)
                    {
                        if (Char.IsDigit(ids[i]))
                        {
                            return true;
                        }
                    }
                }
                
            }
            return false;
        }

        static void InitPatientList(List<Patient> pList)
        {
            List<string> temp = File.ReadAllText("Patients.csv").Replace("\r", string.Empty).Split('\n').ToList<string>();

            for (int i = 1;i < temp.Count;i++)
            {
                List<string> patientDetails = temp[i].Split(',').ToList<string>();
                if (patientDetails.Count == 5)
                {
                    patientDetails.Add("0");
                }
                int age = Convert.ToInt32(patientDetails[2]);
                if (age >= 65)
                {
                    pList.Add(new Senior(patientDetails[1], patientDetails[0], age, Convert.ToChar(patientDetails[3]), patientDetails[4], "Registered"));
                }
                else if (age > 12)
                {
                    pList.Add(new Adult(patientDetails[1], patientDetails[0], age, Convert.ToChar(patientDetails[3]), patientDetails[4], "Registered", Convert.ToDouble(patientDetails[5])));
                }
                else
                {
                    pList.Add(new Child(patientDetails[1], patientDetails[0], age, Convert.ToChar(patientDetails[3]), patientDetails[4], "Registered", Convert.ToDouble(patientDetails[5])));
                }
            }
        }

        static void InitBedList(List<Bed> bList)
        {
            string[] temp = File.ReadAllLines("beds.csv");

            for (int i = 1;i < temp.Length;i++)
            {
                string[] bed_details = temp[i].Split(',');

                string type = bed_details[0];
                int ward_no = Convert.ToInt32(bed_details[1]);
                int bed_no = Convert.ToInt32(bed_details[2]);
                bool availability = false;
                if (bed_details[3].ToUpper() == "YES")
                {
                    availability = true;
                }

                else
                {
                    availability = false;
                }
                double dailyrate = Convert.ToDouble(bed_details[4]);

                if (type.ToUpper() == "A")
                {
                    bList.Add(new ClassABed(ward_no, bed_no, dailyrate, availability));
                }

                else if (type.ToUpper() == "B")
                {
                    bList.Add(new ClassBBed(ward_no, bed_no, dailyrate, availability));
                }

                else
                {
                    bList.Add(new ClassCBed(ward_no, bed_no, dailyrate, availability));
                }
            }
        }

        static void DisplayPatient(List<Patient> pList)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-4} {3,-6} {4,-11} {5,-11}", "Name", "ID No.", "Age", "Gender", "Citizenship", "Status");

            foreach (Patient p in pList)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-4} {3,-6} {4,-11} {5,-11}", p.Name, p.ID, p.Age, p.Gender, p.CitizenStatus, p.Status);
            }
        }
        static void DisplayPatientNotAdmitted(List<Patient> pList)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-4} {3,-6} {4,-11} {5,-11}", "Name", "ID No.", "Age", "Gender", "Citizenship", "Status");

            foreach (Patient p in pList)
            {
                if (p.Status != "Admitted")
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,-4} {3,-6} {4,-11} {5,-11}", p.Name, p.ID, p.Age, p.Gender, p.CitizenStatus, p.Status);
                }
            }
        }

        static void DisplayPatientAdmitted(List<Patient> pList)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-4} {3,-6} {4,-11} {5,-11}", "Name", "ID No.", "Age", "Gender", "Citizenship", "Status");

            foreach (Patient p in pList)
            {
                if (p.Status == "Admitted")
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,-4} {3,-6} {4,-11} {5,-11}", p.Name, p.ID, p.Age, p.Gender, p.CitizenStatus, p.Status);
                }
            }
        }

        static bool CheckAdmitted(List<Patient> pList)
        {
            foreach (Patient p in pList)
            {
                if (p.Status == "Admitted")
                {
                    return true;
                }
            }
            return false;
        }
        static bool CheckRegistered(List<Patient> pList)
        {
            foreach (Patient p in pList)
            {
                if (p.Status == "Registered")
                {
                    return true;
                }
            }
            return false;
        }

        static void DisplayBeds(List<Bed> bList)
        {
            Console.WriteLine("{0,-5} {1,-10} {2,-15} {3,-10} {4,-20} {5,-15}", "Name", "Type", "Ward No", "Bed No", "Daily Rate", "Available");

            for (int i = 0;i < bList.Count;i++)
            {

                string type = "";
                if (bList[i] is ClassABed)
                {
                    type = "A";
                }

                else if (bList[i] is ClassBBed)
                {
                    type = "B";
                }

                else
                {
                    type = "C";
                }

                Console.WriteLine("{0,-5} {1,-10} {2,-15} {3,-10} {4,-20} {5,-15}", i + 1, type, bList[i].wardNo, bList[i].bedNo, bList[i].dailyRate, bList[i].available);
            }
        }

        static void RegisterPatient(List<Patient> pList)
        {
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();
            Console.Write("Enter patient ID Number: ");
            string id = Console.ReadLine().ToUpper();
            if(!CheckID(id))
            {
                Console.WriteLine("\nInvalid patient ID\n" + name + " is not registered successful.\n\nReturning to Menu...");
                return;
            }
            else if(pList.Find(x => x.ID == id) != null)
            {
                Console.WriteLine("\nPatient ID already exits\n" + name + " is not registered successful.\n\nReturning to Menu...");
                return;
            }
            Console.Write("Enter patient age: ");
            string preAge = Console.ReadLine();
            int age = StringToIntValidation(preAge, "number");
            if (age == 10000 || age == -10000 || age < 0)
            {
                Console.WriteLine("\nInvalid Age \n" + name + " is not registered successful.\n\nReturning to Menu...");
                return;
            }
            Console.Write("Enter patient gender [M/F]: ");
            string preGender = Console.ReadLine().ToUpper();
            char gender = new char();
            if (preGender != "M" && preGender != "F")
            {
                Console.WriteLine("\nInvalid gender\n" + name + " is not registered successful.\n\nReturning to Menu...");
                return;
            }
            else
            {
                gender = Convert.ToChar(preGender);
            }
            Console.Write("Enter patient citizenship status [SC/PR/Foreigner]: ");
            string citizenship = Console.ReadLine();
            if(citizenship == "sc" || citizenship == "pr")
            {
                citizenship = citizenship.ToUpper();
            }
            if (citizenship != "SC" && citizenship != "PR" && citizenship != "Foreigner")
            {
                Console.WriteLine("\n" + name + " is not registered successful.\n\nReturning to Menu...");
                return;
            }
            else if (age >= 65)
            {
                pList.Add(new Senior(id, name, age, gender, citizenship, "Registered"));
                File.AppendAllText("patients.csv", "\r\n" + name + "," + id + "," + age + "," + gender + "," + citizenship);
            }
            else if (age >= 13)
            {
                Console.Write("Enter patient medisave balance: ");
                string preMedisave = Console.ReadLine();
                double medisave = StringToDoubleValidation(preMedisave, "Medisave");
                if (medisave == 10000 || medisave == -10000 || medisave < 0)
                {
                    Console.WriteLine("\nInvalid Medisave amount \n" + name + " is not registered successful.\n\nReturning to Menu...");
                    return;
                }
                pList.Add(new Adult(id, name, age, gender, citizenship, "Registered", medisave));
                File.AppendAllText("patients.csv", "\r\n" + name + "," + id + "," + age + "," + gender + "," + citizenship + "," + medisave);
            }
            else
            {
                Console.Write("Enter patient Child Development Account balance: ");
                string preCdab = Console.ReadLine();
                double cdab = StringToDoubleValidation(preCdab, "Medisave");
                if (cdab == 10000 || cdab == -10000 || cdab < 0)
                {
                    Console.WriteLine("\nInvalid cdab amount \n" + name + " is not registered successful.\n\nReturning to Menu...");
                    return;
                }
                pList.Add(new Child(id, name, age, gender, citizenship, "Registered", cdab));
                File.AppendAllText("patients.csv", "\r\n" + name + "," + id + "," + age + "," + gender + "," + citizenship + "," + cdab);
            }
            Console.WriteLine("\n" + name + " is registered successful!\n\nReturning to Menu...");
        }

        static void AddNewBed(List<Bed> bList)
        {
            // Ward Type, Input Validation Below
            Console.Write("Enter Ward Type [A/B/C]: ");
            string ward_type = Console.ReadLine().ToUpper();
            if (CheckInputString(ward_type) == false)
            {
                Console.WriteLine("\nInvalid Ward Type! Only letters allowed");
                Console.WriteLine("Bed Not Registered");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }

            else
            {
                if ((ward_type != "A") && (ward_type != "B") && (ward_type != "C"))
                {
                    Console.WriteLine("\nWard Type only can be A, B or C.");
                    Console.WriteLine("Bed Not Registered");
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                Console.Write("Enter Ward No.: ");
                int ward_no = StringToIntValidation(Console.ReadLine(), "Ward No.");
                if (ward_no == 10000 || ward_no == -10000)
                {
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                if (ward_no <= 0)
                {
                    Console.WriteLine("\nWard Number less than or equals to 0");
                    Console.WriteLine("Bed not registered");
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                Console.Write("Enter Bed No.: ");
                int bed_no = StringToIntValidation(Console.ReadLine(), "Bed No.");
                if (bed_no == 10000 || bed_no == -10000)
                {
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                if (bed_no <= 0)
                {
                    Console.WriteLine("\nBed Number does not exist");
                    Console.WriteLine("Bed not registered");
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                Console.Write("Enter Daily Rate: $");
                double dailyrate = StringToDoubleValidation(Console.ReadLine(), "DailyRate");
                if (dailyrate == 10000 || dailyrate == -10000)
                {
                    Console.WriteLine("Bed not registered");
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                if (dailyrate <= 0)
                {
                    Console.WriteLine("\nDaily Rate cannot be less than or equals to 0");
                    Console.WriteLine("Bed not registered");
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                Console.Write("Enter Availability [Y/N]: ");
                string pre_avail = Console.ReadLine().ToUpper();
                if (CheckInputString(pre_avail) == false)
                {
                    Console.WriteLine("\nAvailability only accepts Y or N. Try Again.");
                    Console.WriteLine("Bed not registered");
                    Console.WriteLine("\nReturning to Menu...");
                    return;              
                }

                else
                {
                    bool availability = false;
                    if (pre_avail != "Y" && pre_avail != "N")
                    {
                        Console.WriteLine("\nAvailability only accepts Y or N. Try Again.");
                        Console.WriteLine("Bed not registered.");
                        Console.WriteLine("\nReturning to Menu...");
                        return;
                    }
                    if (pre_avail == "Y")
                    {
                        availability = true;
                        pre_avail = "Yes";
                    }
                    else if (pre_avail == "N")
                    {
                        availability = false;
                        pre_avail = "No";
                    }

                    if (ward_type == "A")
                    {
                        ClassABed classabed_chk = new ClassABed(ward_no, bed_no, dailyrate, availability);
                        if (bList.Find(b => b.wardNo == classabed_chk.wardNo && b.bedNo == classabed_chk.bedNo) == null)
                        {
                            bList.Add(classabed_chk);
                        }

                        else
                        {
                            Console.WriteLine("\nBed already exists");
                            Console.WriteLine("Bed not registered");
                            Console.WriteLine("\nReturning to Menu");
                            return;

                        }

                    }

                    else if (ward_type == "B")
                    {
                        ClassBBed classbbed_chk = new ClassBBed(ward_no, bed_no, dailyrate, availability);

                        if (bList.Find(b => b.wardNo == classbbed_chk.wardNo && b.bedNo == classbbed_chk.bedNo) == null)
                        {
                            bList.Add(classbbed_chk);
                        }

                        else
                        {
                            Console.WriteLine("\nBed already exists");
                            Console.WriteLine("Bed not registered");
                            Console.WriteLine("\nReturning to Menu");
                            return;

                        }

                    }

                    else if (ward_type == "C")
                    {
                        ClassCBed classcbed_chk = new ClassCBed(ward_no, bed_no, dailyrate, availability);

                        if (bList.Find(b => b.wardNo == classcbed_chk.wardNo && b.bedNo == classcbed_chk.bedNo) == null)
                        {
                            bList.Add(classcbed_chk);
                        }

                        else
                        {
                            Console.WriteLine("\nBed already exists");
                            Console.WriteLine("Bed not registered");
                            Console.WriteLine("\nReturning to Menu");
                            return;

                        }

                    }


                    string data = ward_type + ',' + ward_no.ToString() + ',' + bed_no.ToString() + ',' + pre_avail.ToString() + ',' + Convert.ToString(dailyrate);
                    File.AppendAllText("beds.csv", "\r\n" + data);

                    Console.WriteLine("\nBed successfully registered!");
                }
            }

        }
        static void RegisterHospitalStay(List<Patient> pList, List<Bed> bList)
        {
            if (CheckRegistered(pList))
            {
                DisplayPatientNotAdmitted(pList);
                Console.Write("Enter patient ID number: ");
                string id = Console.ReadLine().ToUpper();
                if (pList.Find(x => x.ID == id) == null)
                {
                    Console.WriteLine("Invalid patient ID");
                    Console.WriteLine("Stay registration unsuccessful!\n\nReturning to Menu...");
                    return;
                }
                else
                {
                    Patient patient = pList.Find(x => x.ID == id);
                    DisplayBeds(bList);
                    Console.Write("Select bed to stay: ");
                    int bedNo = StringToIntValidation(Console.ReadLine(), "Bed No.");
                    if (bList.Count < bedNo || bedNo < 0 || bedNo == 10000 || bedNo == -10000)
                    {
                        Console.WriteLine("Invalid bed");
                        Console.WriteLine("Stay registration unsuccessful!\n\nReturning to Menu...");
                        return;
                    }
                    else if (bList[bedNo - 1].available == false)
                    {
                        Console.WriteLine("Bed is not available");
                        Console.WriteLine("Stay registration unsuccessful!\n\nReturning to Menu...");
                        return;
                    }
                    else
                    {
                        Bed bed = bList[bedNo - 1];
                        Console.Write("Enter date of admission (DD/MM/YYYY): ");
                        DateTime? preAdmission = StringToDateTimeValidation(Console.ReadLine(), "Admission date");
                        DateTime admission = new DateTime();
                        if (preAdmission == null)
                        {
                            Console.WriteLine("\nReturning to Menu...");
                            return;
                        }
                        else
                        {
                            admission = Convert.ToDateTime(preAdmission);
                        }
                        string type = bed.GetType().Name;
                        string preAddon;
                        if (type == "ClassABed")
                        {
                            Console.Write("Any accompanying guest? (Additional $100 per day) [Y/N] : ");
                            preAddon = Console.ReadLine().ToUpper();
                            if (preAddon == "Y")
                            {
                                ClassABed a = (ClassABed)bed;
                                a.accompanyingPerson = true;
                            }
                        }
                        else if (type == "ClassBBed")
                        {
                            Console.Write("Want to upgrade to air-con room? (Additional $50 per week) [Y/N] : ");
                            preAddon = Console.ReadLine().ToUpper();
                            if (preAddon == "Y")
                            {
                                ClassBBed b = (ClassBBed)bed;
                                b.AirCon = true;
                            }
                        }
                        else
                        {
                            Console.Write("Want to request for a portable TV? (Additional one time cost of $30) [Y/N] : ");
                            preAddon = Console.ReadLine().ToUpper();
                            if (preAddon == "Y")
                            {
                                ClassCBed c = (ClassCBed)bed;
                                c.PortableTV = true;
                            }
                        }
                        if (preAddon != "N" && preAddon != "Y")
                        {
                            Console.WriteLine("\nError: only Y or N is allow. Pls try Again.\nStay registration unsuccessful!\n\nReturning to Menu...");
                            return;
                        }
                        Stay stay = new Stay(admission, patient);
                        if (patient.Stay != null && patient.Stay.BedstayList.Count != 0)
                        {
                            stay = patient.Stay;
                        }
                        bed.available = false;
                        BedStay bedStay = new BedStay(admission, bed);
                        stay.AddBedStay(bedStay);
                        patient.Stay = stay;
                        patient.Status = "Admitted";
                        Console.WriteLine("Stay registration successful!\n\nReturning to Menu...");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nError: there is no patient to admit to hospital\n\nReturning to Menu...");
            }
        }

        static void DisplayPatientDetails(List<Patient> pList)
        {
            Console.Write("Enter patient ID number: ");
            string id = Console.ReadLine().ToUpper();
            Patient patient = pList.Find(x => x.ID == id);
            if (patient == null)
            {
                Console.WriteLine("\nInvalid patient ID");
                return;
            }
            else
            {
                Console.WriteLine("\nName of patient: {0}\nID number: {1}\nCitizenship status: {2}\nGender: {3}\nStatus: {4}", patient.Name, patient.ID, patient.CitizenStatus, patient.Gender, patient.Status);
                if (patient.Stay != null)
                {
                    Console.WriteLine("\n\nAdmission date: {0}\nDischarge date: {1}\nPayment status: {2}", patient.Stay.AdmittedDate.ToString("dd/MM/yyyy"), patient.Stay.DischargeDate.HasValue ? patient.Stay.DischargeDate.Value.ToString("dd/MM/yyyy") : "", patient.Stay.IsPaid);
                    foreach (BedStay b in patient.Stay.BedstayList)
                    {
                        string type = "";
                        if (b.GetType().Name == "ClassABed")
                        {
                            type = "A";
                        }

                        else if (b.GetType().Name == "ClassBBed")
                        {
                            type = "B";
                        }

                        else
                        {
                            type = "C";
                        }
                        Console.WriteLine("\n======\nWard number: {0}\nBed number: {1}\nWard class: {2}\nStart of bed stay: {3}\nEnd of bed stay: {4}", b.bed.wardNo, b.bed.bedNo, type, b.startBedstay.ToString("dd/MM/yyyy"), b.endBedstay.HasValue ? b.endBedstay.Value.ToString("dd/MM/yyyy") : "");
                    }
                }
            }

        }

        static void AddMedicalRecord(List<Patient> pList)
        {
            Console.Write("\nEnter in patient ID number: ");
            string patient_id = Console.ReadLine().ToUpper();
            if (CheckID(patient_id) == false)
            {
                Console.WriteLine("\nInvalid ID Format. Try Again");
                Console.WriteLine("\nReturning to Menu...\n");
                return;
            }

            string rec_pid = "";

            for (int i = 0;i < pList.Count;i++)
            {
                if (patient_id == pList[i].ID)
                {
                    rec_pid = pList[i].ID;
                }

                else if (pList.Find(x => x.ID == patient_id) == null)
                {
                    Console.WriteLine("Patient ID not found.");
                    Console.WriteLine("Medical Entry Not Successful");
                    Console.WriteLine("Returning to Menu...");
                    return;
                }
            }

            Patient p = SearchPatient(pList, rec_pid);

            if (p.Stay != null)
            {
                Console.Write("Patient Temperature: ");
                double temp = StringToDoubleValidation(Console.ReadLine(), "Patient Temperature");

                if (temp == 10000 || temp == -10000)
                {
                    Console.WriteLine("\nInvalid Input. Try Again");
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }

                Console.Write("Patient Observations: ");
                string observe = Console.ReadLine();

                DateTime datetimeEntered = DateTime.Now;

                MedicalRecord mr = new MedicalRecord(observe, temp, datetimeEntered);

                p.Stay.AddMedicalRecord(mr);

                Console.WriteLine("Medical Record Entered Successfully!");
                return;

            }

            else
            {
                Console.WriteLine("\nUnsuccessful Medical Entry");
                Console.WriteLine("============================");
                Console.WriteLine("Patient not registered for hospital stay");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }


        }

        static Patient SearchPatient(List<Patient> pList, string id)
        {
            foreach (Patient p in pList)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }

            return null;
        }

        static void DisplayMedicalRecord(List<Patient> pList)
        {
            Console.Write("\nEnter Patient ID number: ");
            string patient_id = Console.ReadLine().ToUpper();
            if (CheckID(patient_id) == false)
            {
                Console.WriteLine("\nInvalid ID Format. Try Again");
                Console.WriteLine("\nReturning to Menu...\n");
                return;
            }

            string rec_pid = "";

            for (int i = 0;i < pList.Count;i++)
            {
                if (patient_id == pList[i].ID)
                {
                    rec_pid = pList[i].ID;
                }

                else if (pList.Find(x => x.ID == patient_id) == null)
                {
                    Console.WriteLine("Patient ID not found.");
                    Console.WriteLine("Unable to View Medical Records");
                    Console.WriteLine("\nReturning to Menu...");
                    return;
                }
            }

            Patient p = SearchPatient(pList, patient_id);
            Console.WriteLine("Name of patient: " + p.Name);
            Console.WriteLine("ID Number: " + p.ID);
            Console.WriteLine("Citizenship Status: " + p.CitizenStatus);
            Console.WriteLine("Gender: " + p.Gender);
            Console.WriteLine("Status: " + p.Status);


            if (p.Stay != null)
            {
                Console.WriteLine("\n======Stay======");
                Console.WriteLine("Admission Date: " + p.Stay.AdmittedDate.ToString("dd/MM/yyyy"));

                // DischargeDate NULL
                if (p.Stay.DischargeDate != null)
                {
                    Console.WriteLine("Discharge Date: " + p.Stay.DischargeDate.Value.ToString("dd/MM/yyyy"));
                }

                else
                {
                    Console.WriteLine("Discharge Date: ");
                }


            }

            else
            {
                Console.WriteLine("\nUnable to View Medical Entry");
                Console.WriteLine("Patient not registered for hospital stay");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }


            bool isEmpty = !p.Stay.MedicalRecordList.Any();
            if (isEmpty)
            {
                Console.WriteLine("No Medical Records Yet");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }
            else
            {
                for (int i = 0;i < p.Stay.MedicalRecordList.Count;i++)
                {
                    Console.WriteLine("\n======Record #  " + (i + 1) + " ====== ");
                    Console.WriteLine("Date/Time: " + p.Stay.MedicalRecordList[i].datetimeEntered.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Temperature: " + p.Stay.MedicalRecordList[i].temperature + " deg. cel.");
                    Console.WriteLine("Diagnosis: " + p.Stay.MedicalRecordList[i].diagnosis);
                }
            }

        }

        static void TransferBed(List<Patient> pList, List<Bed> bList)
        {
            if (CheckAdmitted(pList))
            {
                DisplayPatientAdmitted(pList);
                Console.Write("Enter patient ID number: ");
                string id = Console.ReadLine().ToUpper();
                if (pList.Find(x => x.ID == id) == null || pList.Find(x => x.ID == id).Status != "Admitted")
                {
                    Console.WriteLine("Invalid patient ID");
                    Console.WriteLine("Bed transfer unsuccessful!");
                    return;
                }
                else
                {
                    Patient patient = pList.Find(x => x.ID == id);
                    DisplayBeds(bList);
                    Console.Write("Select bed to transfer to: ");
                    int bedNo = StringToIntValidation(Console.ReadLine(), "Bed No.");
                    if (bedNo == 10000 || bedNo == -10000 || bList.Count < bedNo || bedNo < 0)
                    {
                        Console.WriteLine("Invalid bed");
                        Console.WriteLine("Bed transfer unsuccessful!\n\nReturning to Menu...");
                        return;
                    }
                    else if (bList[bedNo - 1].available == false)
                    {
                        Console.WriteLine("Bed is not available");
                        Console.WriteLine("Stay registration unsuccessful!\n\nReturning to Menu...");
                        return;
                    }
                    else
                    {
                        Bed bed = bList[bedNo - 1];
                        Console.Write("Enter date of tranfer (DD/MM/YYYY): ");
                        DateTime? preTranfer = StringToDateTimeValidation(Console.ReadLine(), "Admission date");
                        DateTime tranfer = new DateTime();
                        if (preTranfer == null)
                        {
                            Console.WriteLine("\nReturning to Menu...");
                            return;
                        }
                        else
                        {
                            tranfer = Convert.ToDateTime(preTranfer);
                        }
                        if (tranfer < patient.Stay.BedstayList[patient.Stay.BedstayList.Count - 1].startBedstay)
                        {
                            Console.WriteLine("\nInvalid tranfer date. Pls try Again.\nStay registration unsuccessful!\n\nReturning to Menu...");
                            return;
                        }
                        string type = bed.GetType().Name;
                        string preAddon;
                        if (type == "ClassABed")
                        {
                            Console.Write("Any accompanying guest? (Additional $100 per day) [Y/N] : ");
                            preAddon = Console.ReadLine().ToUpper();
                            if (preAddon == "Y")
                            {
                                ClassABed a = (ClassABed)bed;
                                a.accompanyingPerson = true;
                            }
                        }
                        else if (type == "ClassBBed")
                        {
                            Console.Write("Want to upgrade to air-con room? (Additional $50 per week) [Y/N] : ");
                            preAddon = Console.ReadLine().ToUpper();
                            if (preAddon == "Y")
                            {
                                ClassBBed b = (ClassBBed)bed;
                                b.AirCon = true;
                            }
                        }
                        else
                        {
                            Console.Write("Want to request for a portable TV? (Additional one time cost of $30) [Y/N] : ");
                            preAddon = Console.ReadLine().ToUpper();
                            if (preAddon == "Y")
                            {
                                ClassCBed c = (ClassCBed)bed;
                                c.PortableTV = true;
                            }
                        }
                        if (preAddon != "N" && preAddon != "Y")
                        {
                            Console.WriteLine("\nError: only Y or N is allow. Pls try Again.\nStay registration unsuccessful!\n\nReturning to Menu...");
                            return;
                        }
                        Stay stay = patient.Stay;
                        bed.available = false;
                        BedStay bedStay = new BedStay(tranfer, bed);
                        patient.Stay.BedstayList[patient.Stay.BedstayList.Count() - 1].endBedstay = tranfer;
                        patient.Stay.BedstayList[patient.Stay.BedstayList.Count() - 1].bed.available = true;
                        stay.AddBedStay(bedStay);
                        patient.Stay = stay;
                        Console.WriteLine("Adrian will be transferred to Ward {0} Bed {1} on {2}.", bed.wardNo, bed.bedNo, tranfer.ToString("dd/MM/yyyy"));
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNo patient admitted\n\nReturning to Menu...");
            }
        }

        static void DischargePayment(List<Patient> pList)
        {
            if (CheckAdmitted(pList) == false)
            {
                Console.WriteLine("\nNo patient admitted");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }

            DisplayPatientAdmitted(pList);

            Console.Write("\nEnter patient ID number to discharge: ");
            string patient_id = Console.ReadLine().ToUpper();
            Patient patient = pList.Find(x => x.ID == patient_id);
            if (CheckID(patient_id) == false)
            {
                Console.WriteLine("\nInvalid ID Format. Try Again");
                Console.WriteLine("\nReturning to Menu...\n");
                return;
            }

            if (pList.Find(x => x.ID == patient_id) == null)
            {
                Console.WriteLine("\nPatient ID does not exist. Try Again");
                Console.WriteLine("\nReturning to Menu...\n");
                return;

            }

            if (patient.Status != "Admitted")
            {
                Console.WriteLine("\nPatient not Admitted");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }

            Console.Write("\nDate of Discharge (DD/MM/YYYY): ");
            DateTime? discharge_validation = StringToDateTimeValidation(Console.ReadLine(), "Discharge Date");
            DateTime discharge = new DateTime();
            if (discharge_validation == null)
            {
                Console.WriteLine("\nInvalid Date. Try Again.");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }

            else
            {
                discharge = Convert.ToDateTime(discharge_validation);
            }

            if (discharge < patient.Stay.AdmittedDate)
            {
                Console.WriteLine("\nInput Date before Admitted Date");
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }

            else
            {
                patient.Stay.DischargeDate = discharge;
            }



            Console.WriteLine("\nName of patient: {0}\nID number: {1}\nCitizenship status: {2}\n Gender: {3}\n Status: {4}", patient.Name, patient.ID, patient.CitizenStatus, patient.Gender, patient.Status);



            Console.WriteLine("\n======Stay======");
            Console.WriteLine("Admission Date: " + patient.Stay.AdmittedDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Discharge Date: " + discharge.ToString("dd/MM/yyyy"));

            string payment = "";
            if (patient.Stay.IsPaid == true)
            {
                payment = "Paid";
                Console.WriteLine("\nPatient has paid already.");
                Console.WriteLine("\nReturning to Menu...");
                return;
            }
            else
            {
                payment = "Unpaid";
            }

            Console.WriteLine("Payment Status: " + payment);


            int bed_no = 1;
            foreach (BedStay bs in patient.Stay.BedstayList)
            {
                Console.WriteLine("\n======Bed #  {0} ======", bed_no);
                Console.WriteLine("Ward number: " + bs.bed.wardNo);
                Console.WriteLine("Bed number: " + bs.bed.bedNo);

                string ward_type = "";

                if (bs.bed is ClassABed)
                {
                    ward_type = "A";
                }

                else if (bs.bed is ClassBBed)
                {
                    ward_type = "B";
                }

                else if (bs.bed is ClassCBed)
                {
                    ward_type = "C";
                }

                Console.WriteLine("Ward Class: " + ward_type);
                Console.WriteLine("Start of Bed Stay: " + bs.startBedstay.ToString("dd/MM/yyyy"));
                if (bs.endBedstay == null)
                {
                    bs.endBedstay = discharge;
                }


                Console.WriteLine("End of Bed Stay: " + String.Format("{0:dd/MM/yyyy}", bs.endBedstay));

                if (ward_type == "A")
                {
                    ClassABed classABed = (ClassABed)bs.bed;
                    Console.WriteLine("Accompanying Person: " + classABed.accompanyingPerson);
                }

                else if (ward_type == "B")
                {
                    ClassBBed classBbed = (ClassBBed)bs.bed;
                    Console.WriteLine("AirCon: " + classBbed.AirCon);
                }

                else if (ward_type == "C")
                {
                    ClassCBed classCBed = (ClassCBed)bs.bed;
                    Console.WriteLine("Portable TV: " + classCBed.PortableTV);
                }

                //int? is nullable
                int? stay_day = (int?)(bs.endBedstay - bs.startBedstay)?.TotalDays;
                Console.WriteLine("\nNumber of Days Stayed: " + stay_day);

                bed_no += 1;

            }

            Console.WriteLine("\n==========\n");

            double total = patient.CalculateCharges();
            Console.WriteLine("Total Charges Pending: $" + total);

            if (patient.CitizenStatus == "Foreigner")
            {
                patient.Stay.IsPaid = true;
                patient.Status = "Discharged";
                foreach (BedStay bs in patient.Stay.BedstayList)
                {
                    bs.bed.available = true;
                }

                patient.Stay.BedstayList.Clear();

            }

            if (patient is Child && patient.CitizenStatus == "SC")
            {
                Child cp = (Child)patient;
                Console.WriteLine("CDA Balance: $" + cp.CDABalance);
                if (cp.CDABalance < total)
                {
                    Console.WriteLine("To deduct from CDA Balance: ${0}", cp.CDABalance);
                    Console.WriteLine("\nSub-total: ${0}", total - cp.CDABalance);

                    Console.WriteLine("\n[Press any key to proceed with payment]");
                    Console.ReadKey();

                    Console.WriteLine("\nCommencing Payment....");

                    Console.WriteLine("${0} has been deducted from CDA Balance", cp.CDABalance);
                    Console.WriteLine("New CDA Balance: $0");
                    cp.CDABalance = 0;
                    Console.WriteLine("Sub-total: ${0} has been paid in cash", total - cp.CDABalance);

                    Console.WriteLine("\nPayment Successful!\n");

                    patient.Status = "Discharged";
                    patient.Stay.IsPaid = true;
                    
                    
                    foreach (BedStay bs in patient.Stay.BedstayList)
                    {
                        bs.bed.available = true;
                    }

                    patient.Stay.BedstayList.Clear();

                }

                else
                {
                    Console.WriteLine("To deduct from CDA Balance: ${0}", total);
                    Console.WriteLine("\nSub-total: $0");


                    Console.WriteLine("\n[Press any key to proceed with payment]");
                    Console.ReadKey();

                    Console.WriteLine("\nCommencing Payment....");

                    Console.WriteLine("${0} has been deducted from CDA Balance", total);
                    Console.WriteLine("New CDA Balance: ${0}", total - cp.CDABalance);
                    cp.CDABalance = total - cp.CDABalance;

                    Console.WriteLine("\nPayment Successful!\n");

                    patient.Stay.IsPaid = true;
                    patient.Status = "Discharged";

                    foreach (BedStay bs in patient.Stay.BedstayList)
                    {
                        bs.bed.available = true;
                    }

                    patient.Stay.BedstayList.Clear();

                }

            }

            else if (patient is Adult && (patient.CitizenStatus == "SC" || patient.CitizenStatus == "PR"))
            {
                Adult ap = (Adult)patient;
                Console.WriteLine("Medisave Balance: ${0}", ap.MedisaveBalance);
                if (ap.MedisaveBalance < total)
                {
                    Console.WriteLine("To deduct from Medisave Balance: ${0}", ap.MedisaveBalance);
                    Console.WriteLine("\nSub-total: ${0}", total - ap.MedisaveBalance);

                    Console.WriteLine("\n[Press any key to proceed with payment]");
                    Console.ReadKey();

                    Console.WriteLine("\nCommencing Payment....");

                    Console.WriteLine("${0} has been deducted from Medisave Balance", ap.MedisaveBalance);
                    Console.WriteLine("New Medisave Balance: $0");
                    ap.MedisaveBalance = 0;
                    Console.WriteLine("Sub-total: ${0} has been paid in cash", total - ap.MedisaveBalance);

                    Console.WriteLine("\nPayment Successful!\n");

                    patient.Stay.IsPaid = true;
                    patient.Status = "Discharged";

                    foreach (BedStay bs in patient.Stay.BedstayList)
                    {
                        bs.bed.available = true;
                    }

                    patient.Stay.BedstayList.Clear();


                }

                else
                {
                    Console.WriteLine("To deduct from Medisave Balance: ${0}", total);
                    Console.WriteLine("\nSub-total: $0");


                    Console.WriteLine("\n[Press any key to proceed with payment]");
                    Console.ReadKey();

                    Console.WriteLine("\nCommencing Payment....");

                    Console.WriteLine("${0} has been deducted from Medisave Balance", total);
                    Console.WriteLine("New Medisave Balance: ${0}", total - ap.MedisaveBalance);
                    ap.MedisaveBalance = total - ap.MedisaveBalance;

                    Console.WriteLine("\nPayment Successful!\n");

                    patient.Stay.IsPaid = true;
                    patient.Status = "Discharged";

                    foreach (BedStay bs in patient.Stay.BedstayList)
                    {
                        bs.bed.available = true;
                    }

                    patient.Stay.BedstayList.Clear();


                }
            }

            else if (patient is Senior)
            {
                Senior sp = (Senior)patient;
                Console.WriteLine("Sub-total: ${0}", total);

                Console.WriteLine("\n[Press any key to proceed with payment]");
                Console.ReadKey();

                Console.WriteLine("\nCommencing Payment....");

                Console.WriteLine("\nSub-total: ${0} has been paid in cash", total);
                Console.WriteLine("\nPayment Successful!\n");

                patient.Stay.IsPaid = true;
                patient.Status = "Discharged";

                foreach (BedStay bs in patient.Stay.BedstayList)
                {
                    bs.bed.available = true;
                }

                patient.Stay.BedstayList.Clear();

            }

        }

        static void currenciesRate()
        {
            Currency currencyList;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.exchangeratesapi.io/");
                Task<HttpResponseMessage> responseTask = client.GetAsync("/latest?base=SGD");
                responseTask.Wait();

                HttpResponseMessage result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    string data = readTask.Result;
                    currencyList = JsonConvert.DeserializeObject<Currency>(data);
                    Rates rate = currencyList.rates;
                    PropertyInfo[] properties = typeof(Rates).GetProperties();
                    Console.WriteLine("Base currency: {0}\n==================", currencyList.@base);
                    Console.WriteLine("{0} {1}", "Currency", "Rate");
                    foreach (PropertyInfo property in properties)
                    {
                        Console.WriteLine(property.Name + " " + property.GetValue(rate, null));
                    }
                }
                else
                {
                    Console.WriteLine("Error: cannot connect to currency API\nPlease contact the a administrator\n\nReturning to Menu...");
                }
            }
        }

        static void DisplayPMInfo()
        {
            Rootobject APISTD2 = new Rootobject();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.data.gov.sg");
                Task<HttpResponseMessage> responseTask = client.GetAsync("/v1/environment/pm25");
                responseTask.Wait();

                HttpResponseMessage result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    string data = readTask.Result;
                    APISTD2 = JsonConvert.DeserializeObject<Rootobject>(data);
                }
                else
                {
                    Console.WriteLine("Error: cannot connect to currency API\nPlease contact the a administrator\n\nReturning to Menu...");
                    return;
                }
            }
            foreach (Region_Metadata rm in APISTD2.region_metadata)
            {
                Console.WriteLine("Location: " + "\nName: " + rm.name + " Longitude: " + rm.label_location.longitude + " Latitude: " + rm.label_location.latitude);
                Console.WriteLine();
            }
            foreach (Item i in APISTD2.items)
            {
                Console.WriteLine("Items:" + "\nTimeStamp: " + i.timestamp + "\nUpdate Timestamp: " + i.update_timestamp + "\nNorth: " + i.readings.pm25_one_hourly.north + "\nSouth: " + i.readings.pm25_one_hourly.south + "\nEast: " + i.readings.pm25_one_hourly.east + "\nWest: " + i.readings.pm25_one_hourly.west);
            }
        }
    }
}

