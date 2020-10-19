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

namespace HospitalApp
{
    public class Person
    {
        private string nric;
        private string name;

        public string Nric
        {
            get { return nric; }
            set { nric = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person() { }
        public Person(string ic, string n)
        {
            nric = ic;
            name = n;
        }
        public override string ToString()
        {
            return String.Format("Nric: {0} Name: {1}", this.Nric, this.Name);
        }
    }
}
