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

namespace Practical2
{
    class Student
    {
        //Question 1
        //Complete the missing attributes & Properties

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public Student(int i, string n, string hp, DateTime dob)
        {
            Id = i;
            Name = n;
            Phone = hp;
            DateOfBirth = dob;
        }
    }
}
