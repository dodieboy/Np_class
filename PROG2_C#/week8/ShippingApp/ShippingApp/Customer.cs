using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApp
{
    class Customer
    {
        private string name;
        private string tel;
        private ShippingAddr addr;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public ShippingAddr Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        public Customer() { }
        public Customer(string n, string t, ShippingAddr a)
        {
            Name = n;
            Tel = t;
            Addr = a;
        }
        public override string ToString()
        {
            return String.Format("Name: {0} Tel: {1} Address: ({2})", this.Name, this.Tel, this.Addr);
        }
    }
}
