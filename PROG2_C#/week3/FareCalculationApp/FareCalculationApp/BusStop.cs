﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareCalculationApp
{
    class BusStop
    {
        private double distance;
        private string code;
        private string road;
        private string description;
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Road
        {
            get { return road; }
            set { road = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public BusStop(double d, string c, string r, string de)
        {
            Distance = d;
            Code = c;
            Road = r;
            Description = de;
        }
        public override string ToString()
        {
            return "WIP";
        }
    }
}
