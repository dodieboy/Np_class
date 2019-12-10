using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT
{
    class Program
    {
        //static void DisplayVansWithNoSeats(List<Van> vList, int noOfSeats)
        //{
        //    Console.WriteLine("{0, -9} {1, -15} {2, -12} {3, -4}", "Plate", "Brand", "Rental Rate", "No. Seats");
        //    int count = 0;
        //    foreach (Van v in vList)
        //    {
        //        if (v.NumberOfSeats == noOfSeats)
        //        {
        //            Console.WriteLine("{0, -9} {1, -15} {2, -12} {3, -4}", v.PlateNumber, v.Brand, v.RentalRate, v.NumberOfSeats);
        //            count += 1;
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        Console.WriteLine("No van was found");
        //    }
        //    Console.WriteLine();
        //}
        static void DisplayVansWithNoSeats(List<Vehicle> vList, int noOfSeats)
        {
            Console.WriteLine("{0, -9} {1, -15} {2, 12} {3, 4}", "Plate", "Brand", "Rental Rate", "No. Seats");
            int count = 0;
            foreach (Van v in vList)
            {
                if(v.NumberOfSeats == noOfSeats)
                {
                    Console.WriteLine("{0, -9} {1, -15} {2, 12} {3, 4}", v.PlateNumber, v.Brand, v.RentalRate, v.NumberOfSeats);
                    count += 1;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No van was found");
            }
            Console.WriteLine();
        }
        static void DisplayCars(List<Vehicle> vehicleList)
        {
            Console.WriteLine("{0, -13} {1, -10} {2, -12} {3, -15} {4,-12}", "Plate Number", "Brand", "Rental Rate", "Engine Capacity", "Deposit");
            foreach (Vehicle v in vehicleList)
            {

                if (v.GetType().Name == "SportsCar")
                {
                    SportsCar c = (SportsCar)v;
                    Console.WriteLine("{0, -13} {1, -10} {2, 12} {3, 15} {4,-12}", c.PlateNumber, c.Brand, c.RentalRate, c.EngineCapacity, c.CalculateDeposit());
                }
                else if (v.GetType().Name == "Car")
                {
                    Car c = (Car)v;
                    Console.WriteLine("{0, -13} {1, -10} {2, 12} {3, 15} {4,-12}", c.PlateNumber, c.Brand, c.RentalRate, c.EngineCapacity, "Not required");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //List<Van> vanList = new List<Van> { };
            List<Vehicle> vanList = new List<Vehicle> { };
            string[] temp = File.ReadAllText("van.csv").Replace("\r", string.Empty).Split('\n');
            for (int i = 1; i < temp.Length - 1; i++)
            {
                string[] temp2 = temp[i].Split(',');
                vanList.Add(new Van(temp2[0], temp2[1], Convert.ToDouble(temp2[2]), Convert.ToInt32(temp2[3])));
            }
            DisplayVansWithNoSeats(vanList, 15);

            while (true)
            {
                Console.Write("Enter the vehicle type (Car/SportsCar/Van): ");
                string type = Console.ReadLine();
                if(type == "Exit")
                {
                    break;
                }
                Console.Write("Enter the plate number: ");
                string plate = Console.ReadLine();
                Console.Write("Enter the brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter the rental rate: ");
                double rate = Convert.ToDouble(Console.ReadLine());
                if(type == "Van")
                {
                    Console.Write("Enter the number of seats: ");
                    int seats = Convert.ToInt32(Console.ReadLine());
                    vanList.Add(new Van(plate, brand, rate, seats));
                    Console.WriteLine("A {0} object created", type);
                }
                else if (type == "SportsCar")
                {
                    Console.Write("Enter the engine capacity: ");
                    double engine = Convert.ToDouble(Console.ReadLine());
                    vanList.Add(new SportsCar(plate, brand, rate, engine));
                    Console.WriteLine("A {0} object created", type);
                }
                else if (type == "Car")
                {
                    Console.Write("Enter the engine capacity: ");
                    double engine = Convert.ToDouble(Console.ReadLine());
                    vanList.Add(new Car(plate, brand, rate, engine));
                    Console.WriteLine("A {0} object created", type);
                }
            }
            DisplayCars(vanList);
            Console.ReadLine();
        }
    }
}
