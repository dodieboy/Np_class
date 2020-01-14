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

namespace PosApp
{
    public class Product
    {
        private string code;
        private string name;
        private double price;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Product() { }
        public Product(string c, string n, double p)
        {
            Code = c;
            Name = n;
            Price = p;
        }
        public override string ToString()
        {
            return String.Format("Code: {0} Name: {1} Price: {2}", this.Code, this.Name, this.Price);
        }
    }
}
