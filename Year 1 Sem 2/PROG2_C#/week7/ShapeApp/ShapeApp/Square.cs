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
    class Square:Shape, IComparable<Square>
    {
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Square() { }
        public Square(string c, double l)
        {
            Type = "Square";
            Length = l;
            Color = c;
        }
        public override double FindArea()
        {
            return Length * Length;
        }
        public override double FindPerimeter()
        {
            return Length * 4;
        }
        public override string ToString()
        {
            return String.Format("Type: {0, -10} Color: {1, -10} Length: {2, -10}", this.Type, this.Color, this.Length);
        }

        public int CompareTo(Square obj)
        {
            if (Length > obj.Length)
            {
                return 1;
            }
            else if (Length == obj.Length)
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
