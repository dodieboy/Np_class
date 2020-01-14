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
    public class Patient:Person
    {
        private Room wardAt;
        public Room WardAt
        {
            get { return wardAt; }
            set { wardAt = value; }
        }
        public Patient() { }
        public Patient(string ic, string n, Room wa):base(ic, n)
        {
            WardAt = wa;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(" Ward At: {0}", this.WardAt);
        }
    }
}
