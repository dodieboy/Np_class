using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class SalesEmployee
    {
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
        private double basicSalary;
        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
        private double sales;
        public Double Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        public SalesEmployee(int d, string n, double bSalary, double s)
        {
            Id = d;
            Name = n;
            BasicSalary = bSalary;
            Sales = s;
        }
    }
}
