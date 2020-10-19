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
    class Program
    {
        static void IninRectangle(Rectangle rect1, Rectangle rect2)
        {
            rect1.Height = 100;
            rect1.Width = 50;
            rect2.Height = 250;
            rect2.Width = 100;
        }
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();
            IninRectangle(rect1, rect2);

            Console.WriteLine("rect1 height is {0} and width is {1}", rect1.Height, rect1.Width);
            Console.WriteLine("Area of rect1 is {0}", rect1.Height * rect1.Width);
            Console.WriteLine("Perimeter of rect2 is {0}", rect2.Height * 2 + rect2.Width * 2);
            Console.ReadLine();
        }
    }
}
