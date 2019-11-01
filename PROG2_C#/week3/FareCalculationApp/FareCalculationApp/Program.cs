using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FareCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string busFile = "bus_174.csv";
            string distanceFile = "distance-based-fare.csv";
            double distance = 0;

            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", busFile); //set the path to bus_174.csv
            string[] tempBus = File.ReadAllText(path).Replace("\r", string.Empty).Split('\n'); //read the csv and write it into a array, using '\n' to split. And remove "/r" from the csv. eg. [clementi ave kdfkje, jurongwesgv]
            List<BusStop> bus = new List<BusStop> ();
            for (int i = 1; i < tempBus.Length - 1; i++) //format tempBus to bus format
            {
                string[] temp = tempBus[i].Split(',');
                bus.Add(new BusStop(Convert.ToDouble(temp[0]), temp[1], temp[1], temp[3]));
            }

            path = Path.Combine(Environment.CurrentDirectory, @"Data\", distanceFile); //set the path to distance-based-fare.csv
            string[] tempFare = File.ReadAllText(path).Replace("\r", string.Empty).Split('\n'); //read the csv and write it into a array, using '\n' to split. And remove "/r" from the csv. eg. [clementi ave kdfkje, jurongwesgv]
            List<Fare> fare = new List<Fare>();
            for (int i = 1; i < tempFare.Length - 1; i++) //format tempBus to bus format
            {
                string[] temp = tempFare[i].Split(',');
                fare.Add(new Fare(Convert.ToDouble(temp[0]), Convert.ToInt32(temp[1])));
            }

            //to print all bus stop
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-20} {3,-30}", "Distance (KM)", "Bus Stop Code", "Road", "Bus Stop Description"));
            for (int i = 0; i < bus.Count; i++)
            {
                Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-20} {3,-30}", bus[i].Distance, bus[i].Code, bus[i].Road, bus[i].Description));
            }

            //ask input
            Console.Write("Enter boarding bus stop: ");
            string boarding = Console.ReadLine();
            bool check1 = false;
            bool check2 = false;

            Console.Write("Enter alighting bus stop: ");
            string alighting = Console.ReadLine();

            //calculate distance
            for (int i = 0; i < bus.Count; i++)
            {
                if (bus[i].Code == alighting)
                {
                    distance += bus[i].Distance;
                    check1 = true;
                }
                else if (bus[i].Code == boarding)
                {
                    distance -= bus[i].Distance;
                    check2 = true;
                }
            }
            if (check1 && check2) //check is the bus stop can be found
            {
                distance = Math.Abs(distance); //check distance to postive number if it is negetive
                Console.WriteLine("Distance travelled: {0}km", distance);

                //calculate fare
                for (int i = 0; i < fare.Count; i++)
                {
                    if (distance < fare[i].UpToDistance)
                    {
                        Console.WriteLine("Fare to pay: ${0}", Convert.ToDouble(fare[i-1].Amount) / 100);
                        break;
                    }
                }

                //calcute duration
                Console.WriteLine("Estimated duration: {0}mins", distance * 4);
            }
            else
            {
                Console.WriteLine("You have key in a invalid boarding or alighting bus stop");
            }
            Console.Read();
        }
    }
}
