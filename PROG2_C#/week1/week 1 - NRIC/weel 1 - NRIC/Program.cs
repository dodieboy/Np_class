using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weel_1___NRIC
{
    class Program
    {
        public static bool Nric(string inputs)
        {
            char[] IC = new char[] { 'J', 'Z', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A', };
            int temp = 0;
            temp = ((Int32.Parse(inputs[1].ToString()) * 2) + (Int32.Parse(inputs[2].ToString()) * 7) + (Int32.Parse(inputs[3].ToString()) * 6) + (Int32.Parse(inputs[4].ToString()) * 5) + (Int32.Parse(inputs[5].ToString()) * 4) + (Int32.Parse(inputs[6].ToString()) * 3) + (Int32.Parse(inputs[7].ToString()) * 2) + 4) % 11;
            if (inputs[8] == IC[temp])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the IC to be validated: ");
            string inputs = Console.ReadLine().ToUpper();
            if (inputs[0] == 'T')
            {
                Console.WriteLine("Validity of the IC: {0}", Nric(inputs));
            }
            else
            {
                Console.WriteLine("You enter a unknown IC");
            }
            Console.ReadLine();
        }
    }
}
