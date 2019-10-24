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
            double distance = 0;

            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", busFile); //set the path to bus_174.csv
            string[] tempBus = File.ReadAllText(path).Replace("\r", string.Empty).Split('\n'); //read the csv and write it into a array, using '\n' to split. And remove "/r" from the csv. eg. [clementi ave kdfkje, jurongwesgv]
            string[,] bus = new string[tempBus.Length-2, 4]; //declare a array in a array. eg.[[clementi,road 5,rgr,gre],[jurong,geg,adwfd,addw]]
            for(int i = 1; i < tempBus.Length-1; i++) //format tempBus to bus format
            {
                string[] temp = tempBus[i].Split(',');
                for (int j = 0; j < 4; j++)
                {
                    bus[i-1, j] = temp[j];
                }
            }

            path = Path.Combine(Environment.CurrentDirectory, @"Data\", distanceFile); //set the path to distance-based-fare.csv
            string[] tempFare = File.ReadAllText(path).Replace("\r", string.Empty).Split('\n'); //read the csv and write it into a array, using '\n' to split. And remove "/r" from the csv. eg. [clementi ave kdfkje, jurongwesgv]
            string[,] fare = new string[tempFare.Length - 2, 2]; //declare a array in a array. eg.[[clementi,road 5,rgr,gre],[jurong,geg,adwfd,addw]]
            for (int i = 1; i < tempFare.Length - 1; i++) //format tempBus to bus format
            {
                string[] temp = tempFare[i].Split(',');
                for (int j = 0; j < 2; j++)
                {
                    fare[i - 1, j] = temp[j];
                }
            }

            //to print all bus stop
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-20} {3,-30}", "Distance (KM)", "Bus Stop Code", "Road", "Bus Stop Description"));
            for(int i = 0; i < bus.Length/4; i++)
            {
                Console.WriteLine(String.Format("{0,-15} {1,-15} {2,-20} {3,-30}", bus[i,0], bus[i, 1], bus[i, 2], bus[i, 3]));
            }

            //ask input
            Console.Write("Enter boarding bus stop: ");
            string boarding = Console.ReadLine();
            bool check1 = false;
            bool check2 = false;

            Console.Write("Enter alighting bus stop: ");
            string alighting = Console.ReadLine();

            //calculate distance
            for(int i = 0; i < bus.Length/4; i++)
            {
                if(bus[i, 1] == alighting)
                {
                    distance += double.Parse(bus[i, 0]);
                    check1 = true;
                }
                else if (bus[i, 1] == boarding)
                {
                    distance -= double.Parse(bus[i, 0]);
                    check2 = true;
                }
            }
            if(check1 && check2) //check is the bus stop can be found
            {
                distance = Math.Abs(distance); //check distance to postive number if it is negetive
                Console.WriteLine("Distance travelled: {0}km", distance);

                //calculate fare
                for (int i = 0; i < fare.Length / 2 - 2; i++)
                {
                    if (distance < double.Parse(fare[i, 0].ToString()))
                    {
                        Console.WriteLine("Fare to pay: ${0}", double.Parse(fare[i, 1]) / 100);
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
