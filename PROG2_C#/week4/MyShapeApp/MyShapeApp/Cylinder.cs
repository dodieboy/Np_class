using System;
using System.Collections.Generic;
using System.Text;

namespace MyShapeApp
{
    class Cylinder:Circle
    {
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Cylinder() { }
        public Cylinder(double r, double l) : base(r)
        {
            Length = l;
        }
        public override double CalculateArea()
        {
            return ((2 * Math.PI * Radius * Length) + (2 * Math.PI * Radius * Radius));
        }
        public double CalculateVolume()
        {
            return Math.PI * Radius * Radius * Length;
        }
        public override string ToString()
        {
            return base.ToString() + ", Length: " + Length;
        }
    }
}
