using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weel_1___NRIC
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs;
            List<char> IC = new List<char>() {'J','Z','I','H','G','F','E','D','C','B','A',};
            Console.Write("Enter the IC to be validated: ");
            inputs = Console.ReadLine();
            if (inputs[0] == 'T')
            {
                int temp = 0;
                Console.WriteLine(Int32.Parse(inputs[1].ToString())*7);
                temp = (Int32.Parse(inputs[1].ToString()) * 2) + (Int32.Parse(inputs[2].ToString()) * 7) + (Int32.Parse(inputs[3].ToString()) * 6) + (Int32.Parse(inputs[4].ToString()) * 5) + (Int32.Parse(inputs[5].ToString()) * 4) + (Int32.Parse(inputs[6].ToString()) * 3) + (Int32.Parse(inputs[7].ToString()) * 2) + 4;
                temp = temp % 11;
                if (inputs[8] == IC[temp])
                {
                    Console.WriteLine("Validity of the IC: True");
                }
                else
                {
                    Console.WriteLine("Validity of the IC: False");
                }
            }
            Console.ReadLine();
        }
    }
}
