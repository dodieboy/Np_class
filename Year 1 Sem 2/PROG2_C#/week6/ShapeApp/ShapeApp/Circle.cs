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

namespace ShapeApp
{
    class Circle:Shape,IComparable<Circle>
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle() { }
        public Circle(string c, double r)
        {
            Type = "Circle";
            Radius = r;
            Color = c;
        }
        public override double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double FindPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return String.Format("Color: {0} Radius: {1}", Color, Radius);
        }

        public int CompareTo(Circle obj)
        {
            if(Radius > obj.Radius)
            {
                return 1;
            }
            else if (Radius == obj.Radius)
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
