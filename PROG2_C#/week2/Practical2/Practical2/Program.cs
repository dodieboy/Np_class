/*
(c) 2019 Alan Tan
This code is licensed under MIT license (See LICENSE.txt for details)
SPDX-Short-Identifier: MIT
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practical2
{
    class Program
    {
        public static void DisplayOutput(List<Student> aList)
        {
            Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}", "ID", "Name", "Phone", "Date of Birth"); //display title
            for (int i = 0; i < aList.Count; i++) //loop thought the list
            {
                Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}", aList[i].Id, aList[i].Name, aList[i].Phone, aList[i].DateOfBirth.ToString("dd/MM/yyyy")); //formant and print the data in the list
            }
            Console.WriteLine();
        }
        public static void DisplayOutputSales(List<SalesEmployee> eList)
        {
            Console.WriteLine("{0, -3} {1, -16} {2, -13} {3, -6}", "ID", "Name", "Basic Salary", "Sales"); //display title
            for (int i = 0; i < eList.Count; i++) //loop thought the list
            {
                Console.WriteLine("{0, -3} {1, -16} {2, -13} {3, -6}", eList[i].Id, eList[i].Name, eList[i].BasicSalary, eList[i].Sales); //formant and print the data in the list
            }
            Console.WriteLine();
        }
        public static Student GetStudent() //method to formant input to match student.cs
        {
            //declare var use
            bool error = true;
            int StudentID = 0;
            string StudentName = "";
            string StudentPhone = "";
            DateTime StudentDOB = DateTime.Now;

            while (error)
            {
                try
                {
                    //ask for data and convert to corrent type
                    Console.WriteLine("Please enter the student ID: ");
                    StudentID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the student name: ");
                    StudentName = Console.ReadLine();
                    Console.WriteLine("Please enter the student phone number: ");
                    StudentPhone = Console.ReadLine();
                    Console.WriteLine("Please enter the student date of birth (yyyy/mm/dd): ");
                    StudentDOB = Convert.ToDateTime(Console.ReadLine());
                    error = false; //end the loop since there is no error
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: You have enter a invaild input, please try again");
                }
            }
            return new Student(StudentID, StudentName, StudentPhone, StudentDOB); //return formanted data
        }
        static void Main(string[] args)
        {
            //Creating Student object
            DateTime dob = new DateTime(2000, 10, 13);
            Student s1 = new Student(1, "John Tan", "88552211", dob);
            dob = new DateTime(2001, 11, 01);
            Student s2 = new Student(2, "Peter Lim", "85678141", dob);
            dob = new DateTime(2000, 01, 03);
            Student s3 = new Student(3, "David Chan", "88555461", dob);
            dob = new DateTime(2000, 05, 07);
            Student s4 = new Student(4, "Muhammand Faizal", "98762211", dob);
            dob = new DateTime(2000, 08, 09);
            Student s5 = new Student(5, "Ester Eng", "83352245", dob);

            //Print Student object
            Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}", "ID", "Name", "Phone", "Date of Birth");
            Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}", s1.Id, s1.Name, s1.Phone, s1.DateOfBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}", s2.Id, s2.Name, s2.Phone, s2.DateOfBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}", s3.Id, s3.Name, s3.Phone, s3.DateOfBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}", s4.Id, s4.Name, s4.Phone, s4.DateOfBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("{0, -3} {1, -16} {2, -10} {3, -14}\n", s5.Id, s5.Name, s5.Phone, s5.DateOfBirth.ToString("dd/MM/yyyy"));

            //Add Student object to List
            List<Student> studentList = new List<Student>(); //create "studentList" list
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            studentList.Add(s5);

            //print Student object in List
            DisplayOutput(studentList);

            //add new Student object to List and print all
            studentList.Add(GetStudent());
            DisplayOutput(studentList);

            List<Student> studentList2 = new List<Student>(); //create "studentList2" list
            string fileName = "Students.csv";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\" + fileName); //set the path to csv file
            try
            {
                foreach (var line in File.ReadLines(path))
                {
                    string[] temp = line.Split(',');
                    if (temp[0] == "ID") //remove the type in csv file
                    {
                        continue;
                    }
                    else //add the data from csv file to "studentList2" list
                    {
                        Student studentInput = new Student(int.Parse(temp[0]), temp[1], temp[2], Convert.ToDateTime(temp[3]));
                        studentList2.Add(studentInput);
                    }
                }
                DisplayOutput(studentList2); //run DisplayOutput method and pass studentList2 to method
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("ERROR: CSV file ({0}) is not found ", fileName);
            }

            //challenge
            List<SalesEmployee> employeeList = new List<SalesEmployee>(); //create "employeeList" list
            //add data to "employeeList" list
            employeeList.Add(new SalesEmployee(101, "Angie", 1200, 15000));
            employeeList.Add(new SalesEmployee(105, "Cindy", 1000, 12000));
            employeeList.Add(new SalesEmployee(108, "David ", 1500, 20000));
            employeeList.Add(new SalesEmployee(112, "Jason ", 3000, 30000));
            employeeList.Add(new SalesEmployee(127, "Vivian ", 2000, 25000));

            DisplayOutputSales(employeeList); //run DisplayOutput method and pass employeeList to method

            Console.Read();
        }
    }
}
