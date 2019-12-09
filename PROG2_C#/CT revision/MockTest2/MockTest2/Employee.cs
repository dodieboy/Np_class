using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest2
{
    abstract class Employee:IComparable<Employee>
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Employee() { }
        public Employee(int i, string n)
        {
            id = i;
            name = n;
        }
        public abstract double CalculatePay();
        public override string ToString()
        {
            return String.Format("Id: {0} Name: {1}", this.Id, this.Name);
        }
        public int CompareTo(Employee obj)
        {
            if (Id > obj.Id)
            {
                return 1;
            }
            else if (Id == obj.Id)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
