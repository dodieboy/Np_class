using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double bmi;
            double weight;
            double height;

            Console.Write("Please enter your weight in kg: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = weight / (height * height);

            Console.WriteLine("Your BMI is " + bmi);
            Console.Read();
        }
    }
}
