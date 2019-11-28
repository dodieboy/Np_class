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
        static void InitShapeList(List<Shape> sList)
        {
            Circle shape1 = new Circle("Red", 20);
            Circle shape2 = new Circle("Red", 10);
            Circle shape3 = new Circle("Green", 10);
            Square shape4 = new Square("Green", 10);
            Circle shape5 = new Circle("Blue", 30);
            Square shape6 = new Square("Blue", 30);
            sList.Add(shape1);
            sList.Add(shape2);
            sList.Add(shape3);
            sList.Add(shape4);
            sList.Add(shape5);
            sList.Add(shape6);
        }
        static int Menu()
        {
            Console.Write("---------------- M E N U --------------------\n[1] List all the shapes\n[2] Display the areas of the shapes\n[3] Display the perimeters of the shapes\n[4] Add a new circle\n[5] Delete a circle\n[6] Change the sizes of the shapes\n[7] Display shapes sorted by area\n[0] Exit\n---------------------------------------------\nEnter your option:");
            int inputs = Convert.ToInt32(Console.ReadLine());
            return inputs;
        }
        static void DispalyShape(List<Shape> sList)
        {
            if (sList.Count == 0)
            {
                Console.WriteLine("There is no shape in the system");
            }
            else
            {
                for (int i = 0; i < sList.Count; i++)
                {
                    Console.WriteLine("[{0}] {1}", i+1, sList[i].ToString());
                }
            }
        }
        static void DispalyShapeArea(List<Shape> sList)
        {
            if (sList.Count == 0)
            {
                Console.WriteLine("There is no shape in the system");
            }
            else
            {
                for (int i = 0; i < sList.Count; i++)
                {
                    Console.WriteLine("{0} Area: {1:N2}", sList[i].ToString(), sList[i].FindArea());
                }
            }
        }
        static void DispalyShapePerimeter(List<Shape> sList)
        {
            if (sList.Count == 0)
            {
                Console.WriteLine("There is no shape in the system");
            }
            else
            {
                for (int i = 0; i < sList.Count; i++)
                {
                    Console.WriteLine("{0} Perimeter: {1:N2}", sList[i].ToString(), sList[i].FindPerimeter());
                }
            }
        }
        static void CircleAdd(List<Shape> sList)
        {
            Console.Write("Circle color: ");
            string color = Console.ReadLine();
            Console.Write("Circle radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            sList.Add(new Circle(color, radius));
            Console.WriteLine("New black circle with radius {0} added.", radius);
        }
        static void CircleDelete(List<Shape> sList)
        {
            DispalyShape(sList);
            if(sList.Find(x => x.Type == "Circle") != null)
            {
                Console.Write("Enter circle number: ");
                int delete = Convert.ToInt32(Console.ReadLine());
                sList.RemoveAt(delete - 1);
            }
            else
            {
                Console.WriteLine("There is no circle in the list to delete.");
            }
        }
        static void changeShape(List<Shape> sList)
        {
            DispalyShape(sList);
            Console.Write("Enter shape number: ");
            int shape = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Enter new unit: ");
            int unit = Convert.ToInt32(Console.ReadLine());
            if(sList[shape].Type == "Circle")
            {
                Circle c = (Circle) sList[shape];
                c.Radius = unit;
            }
            else
            {
                Square s = (Square)sList[shape];
                s.Length = unit;
            }
            Console.WriteLine("Radius successfully changed");
        }
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            InitShapeList(shapeList);
            while (true)
            {
                int inputs = Menu();
                if (inputs == 1)
                {
                    DispalyShape(shapeList);
                }
                else if (inputs == 2)
                {
                    DispalyShapeArea(shapeList);
                }
                else if (inputs == 3)
                {
                    DispalyShapePerimeter(shapeList);
                }
                else if (inputs == 4)
                {
                    CircleAdd(shapeList);
                }
                else if (inputs == 5)
                {
                    CircleDelete(shapeList);
                }
                else if (inputs == 6)
                {
                    changeShape(shapeList);
                }
                else if (inputs == 7)
                {
                    shapeList.Sort();
                    DispalyShapeArea(shapeList);
                }
                else if (inputs == 0)
                {
                    break;
                }
            }
        }
    }
}
