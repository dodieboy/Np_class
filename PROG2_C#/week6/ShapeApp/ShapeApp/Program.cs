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
    class Program
    {
        static void InitCircleList(List<Circle> cList)
        {
            Circle circle1 = new Circle("Red", 20);
            Circle circle2 = new Circle("Green", 10);
            Circle circle3 = new Circle("Blue", 30);
            cList.Add(circle1);
            cList.Add(circle2);
            cList.Add(circle3);
        }
        static int Menu()
        {
            Console.Write("---------------- M E N U --------------------\n[1] List all the circles\n[2] Display the areas of the circles\n[3] Display the perimeters of the circles\n[4] Change the size of a circle\n[5] Add a new circle\n[6] Delete a circle\n[7] Display circles sorted by area\n[0] Exit\n---------------------------------------------\nEnter your option:");
            int inputs = Convert.ToInt32(Console.ReadLine());
            return inputs;
        }
        static void DispalyCircle(List<Circle> cList)
        {
            if(cList.Count == 0)
            {
                Console.WriteLine("There is no circle in the system");
            }
            else
            {
                for (int i = 0; i < cList.Count; i++)
                {
                    Console.WriteLine("[{0}] Type: {1,-15} Color: {2,-8} Radius: {3}", i + 1, cList[i].Type, cList[i].Color, cList[i].Radius);
                }
            }
        }
        static void DispalyCircleArea(List<Circle> cList)
        {
            if (cList.Count == 0)
            {
                Console.WriteLine("There is no circle in the system");
            }
            else
            {
                for (int i = 0; i < cList.Count; i++)
                {
                    Console.WriteLine("Type: {0,-15} Color: {1,-8} Radius: {2: 4} Area: {3.##}", cList[i].Type, cList[i].Color, cList[i].Radius, cList[i].FindArea());
                }
            }
        }
        static void DispalyCirclePerimeter(List<Circle> cList)
        {
            if (cList.Count == 0)
            {
                Console.WriteLine("There is no circle in the system");
            }
            else
            {
                for (int i = 0; i < cList.Count; i++)
                {
                    Console.WriteLine("Type: {0,-15} Color: {1,-8} Radius: {2: 4} Perimeter: {3.##}", cList[i].Type, cList[i].Color, cList[i].Radius, cList[i].FindPerimeter());
                }
            }
        }
        static void CircleEdit(List<Circle> cList)
        {
            DispalyCircle(cList);
            Console.Write("Enter circle number: ");
            int circle = Convert.ToInt32(Console.ReadLine()) -1;
            Console.Write("Enter new radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            cList[circle].Radius = radius;
            Console.WriteLine("Radius successfully changed");
        }
        static void CircleAdd(List<Circle> cList)
        {
            Console.Write("Circle color: ");
            string color = Console.ReadLine();
            Console.Write("Circle radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            cList.Add(new Circle(color, radius));
            Console.WriteLine("New black circle with radius {0} added.", radius);
        }
        static void CircleDelete(List<Circle> cList)
        {
            DispalyCircle(cList);
            Console.Write("Enter circle number: ");
            int delete = Convert.ToInt32(Console.ReadLine());
            cList.RemoveAt(delete-1);
        }
        static void Main(string[] args)
        {
            List<Circle> circleList = new List<Circle>();
            InitCircleList(circleList);
            while(true){
                int inputs = Menu();
                if(inputs == 1)
                {
                    DispalyCircle(circleList);
                }
                else if(inputs == 2)
                {
                    DispalyCircleArea(circleList);
                }
                else if(inputs == 3)
                {
                    DispalyCirclePerimeter(circleList);
                }
                else if(inputs == 4)
                {
                    CircleEdit(circleList);
                }
                else if(inputs == 5)
                {
                    CircleAdd(circleList);
                }
                else if(inputs == 6)
                {
                    CircleDelete(circleList);
                }
                else if(inputs == 7)
                {
                    circleList.Sort();
                    DispalyCircle(circleList);
                }
                else if(inputs == 0)
                {
                    exit();
                }
            }
        }
    }
}
