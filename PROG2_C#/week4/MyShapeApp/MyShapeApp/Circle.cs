/*
(c) 2019 Alan Tan
This code is licensed under MIT license (See LICENSE.txt for details)
SPDX-Short-Identifier: MIT
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace MyShapeApp
{
    class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle() { }
        public Circle(double r)
        {
            Radius = r;
        }
        public virtual double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return String.Format("Radius: {0}", Radius);
        }
    }
}
