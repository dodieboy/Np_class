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

namespace RectangleApp
{
    class Rectangle
    {
        private double width;
        private double height;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Rectangle() {}
        public Rectangle(double w, double h)
        {
            Height = h;
            Width = w;
        }
        public double FindArea()
        {
            return 0;
        }
        public double FindPerimeter()
        {
            return 0;
        }
        
    }
}
