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

namespace ShippingApp
{
    class ShippingAddr
    {
        private string country;
        private string street;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public ShippingAddr() { }
        public ShippingAddr(string c, string s)
        {
            Country = c;
            Street = s;
        }
        public override string ToString()
        {
            return String.Format("Country: {0} Street: {1}", this.Country, this.Street);
        }
    }
}
