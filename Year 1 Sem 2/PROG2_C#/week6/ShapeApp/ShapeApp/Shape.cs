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
    abstract class Shape
    {
        private string type;
        private string color;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Shape() {}
        public Shape(string t, string c)
        {
            Type = t;
            Color = c;
        }
        public abstract double FindArea();
        public abstract double FindPerimeter();
        public override string ToString()
        {
            return String.Format("Type: {0} Color: {1}", Type, Color);
        }
    }
}
