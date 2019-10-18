using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1___Distance_Based_Fares
{
    class Program
    {
        static void Main(string[] args)
        {
            string busFile = "bus_174.csv";
            string distanceFile = "distance-based-fare.csv";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", busFile);
            string[] tempBus = File.ReadAllText(path).Replace("\r", string.Empty).Split('\n');
            string[,] bus = new string[tempBus.Length-2, 4];
            for(int i = 1; i < tempBus.Length-1; i++)
            {
                string[] temp = tempBus[i].Split(',');
                for (int j = 0; j < 4; j++)
                {
                    bus[i-1, j] = temp[j];
                }
            }
            path = Path.Combine(Environment.CurrentDirectory, @"Data\", distanceFile);
            string[] tempFare = File.ReadAllText(path).Replace("\r", string.Empty).Split('\n');
            string[,] fare = new string[tempFare.Length - 2, 2];
            for(int i = 1; i < tempFare.Length - 1; i++)
            {
                string[] temp = tempFare[i].Split(',');
                for (int j = 0; j < 2; j++)
                {
                    fare[i - 1, j] = temp[j];
                }
            }

            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-20} {3,-30}", "Distance (KM)", "Bus Stop Code", "Road", "Bus Stop Description"));
            for(int i = 0; i < bus.Length/4; i++)
            {
                Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-20} {3,-30}", bus[i,0], bus[i, 1], bus[i, 2], bus[i, 3]));
            }

            Console.Write("Enter boarding bus stop: ");
            string boarding = Console.ReadLine();
            Console.Write("Enter alighting bus stop: ");
            string alighting = Console.ReadLine();
            double distance = 0;
            for(int i = 0; i < bus.Length/4; i++)
            {
                if(bus[i, 1] == alighting)
                {
                    distance += double.Parse(bus[i, 0]);
                }
                else if (bus[i, 1] == boarding)
                {
                    distance -= double.Parse(bus[i, 0]);
                }
            }
            Console.WriteLine("Distance travelled: {0}km", distance);
            for(int i = 0; i < fare.Length/2 -2; i++)
            {
                if (distance < double.Parse(fare[i, 0].ToString()))
                {
                    Console.WriteLine("Fare to pay: ${0}", double.Parse(fare[i,1])/100);
                    break;
                }
            }

            Console.WriteLine("Estimated duration: {0}mins", distance * 4);
            Console.Read();
        }
    }
}
