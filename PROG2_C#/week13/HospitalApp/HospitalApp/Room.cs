using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class Room
    {
        private string location;
        private string wardClass;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string WardClass
        {
            get { return wardClass; }
            set { wardClass = value; }
        }
        public Room() { }
        public Room(string l, string w)
        {
            Location = l;
            WardClass = w;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(" Location: {0} Ward Class: {1}", this.Location, this.WardClass);
        }
    }
}
