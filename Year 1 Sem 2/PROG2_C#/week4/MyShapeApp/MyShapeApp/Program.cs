/*
(c) 2019 Alan Tan
This code is licensed under MIT license (See LICENSE.txt for details)
SPDX-Short-Identifier: MIT
*/

using System;

namespace MyShapeApp
{ 
    class Program
    {
        static int Menu()
        {
            Console.Write("-------------------MENU-------------------\n[1] Change the radius of circle\n[2] Change the radius of cylinder\n[3] Change the length of cylinder\n[4] Display the area of circle\n[5] Display the surface area of cylinder\n[6] Display the volume of cylinder\n[0] Exit\n-------------------------------------------\nEnter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Cylinder cylinder1 = new Cylinder(5, 10);
            while (true)
            {
                int option = Menu();
                if (option == 0)
                {
                    break;
                }
                else if (option == 1)
                {
                    Console.WriteLine("Current circle radius: {0}", circle1.Radius);
                    Console.Write("Enter new radius: ");
                    circle1.Radius = Convert.ToDouble(Console.ReadLine());
                }
                else if (option == 2)
                {
                    Console.WriteLine("Current cylinder radius: {0}", cylinder1.Radius);
                    Console.Write("Enter new radius: ");
                    cylinder1.Radius = Convert.ToDouble(Console.ReadLine());
                }
                else if (option == 3)
                {
                    Console.WriteLine("Current cylinder radius: {0}", cylinder1.Length);
                    Console.Write("Enter new length: ");
                    cylinder1.Length = Convert.ToDouble(Console.ReadLine());
                }
                else if (option == 4)
                {
                    Console.WriteLine("Area of circle: {0}\n", circle1.CalculateArea());
                }
                else if (option == 5)
                {
                    Console.WriteLine("Surface area of cylinder: {0}\n", cylinder1.CalculateArea());
                }
                else if (option == 6)
                {
                    Console.WriteLine("Volume of cylinder: {0}\n", cylinder1.CalculateVolume());
                }
                else
                {
                    Console.WriteLine("Error: invaild input!\n");
                }
            }
        }
    }
}
