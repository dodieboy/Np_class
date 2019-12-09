using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest2
{
    class Program
    {
        static void DisplayOutput(List<Employee> eList)
        {
            Console.WriteLine("{0,-6} {1,-11} {2,-10:0.00}", "ID", "Name", "Pay");
            Console.WriteLine("{0,-6} {1,-11} {2,-10:0.00}", "=====", "==========", "==========");
            for (int i = 0; i < eList.Count; i++)
            {
                Console.WriteLine("{0,-6} {1,-11} {2,10:0.00}",eList[i].Id, eList[i].Name, eList[i].CalculatePay());
            }
            Console.WriteLine("");
        }
        static void IncreasePay(List<Employee> eList)
        {
            for (int i = 0; i < eList.Count; i++)
            {
                if(eList[i].GetType().Name == "FullTimeEmployee")
                {
                    FullTimeEmployee f = (FullTimeEmployee)eList[i];
                    f.BasicPay = f.BasicPay * 1.1;
                }
            }
        }
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee> { };
            FullTimeEmployee employee1 = new FullTimeEmployee(103, "John", 1500, 100);
            PartTimeEmployee employee2 = new PartTimeEmployee(101, "Mary", 50, 10);
            SalesEmployee employee3 = new SalesEmployee(102, "Apple", 1000, 50, 10000);

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);

            DisplayOutput(employeeList);
            IncreasePay(employeeList);
            DisplayOutput(employeeList);
            employeeList.Sort();
            DisplayOutput(employeeList);
            Console.ReadLine();
        }
    }
}
