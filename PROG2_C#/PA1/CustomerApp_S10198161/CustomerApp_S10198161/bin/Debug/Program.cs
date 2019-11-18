using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomerApp_S10198161
{
    class Program
    {
        static void InitCustomerList(List<Customer> cList)
        {
            string[] temp = File.ReadAllText("loans.csv").Replace("\r", string.Empty).Split('\n');
            for (int i = 0; i < temp.Length-1; i++)
            {
                string[] temp2 = temp[i].Split(',');
                cList.Add(new Customer(temp2[0], Convert.ToDouble(temp2[1]), Convert.ToInt32(temp2[2]), Convert.ToInt32(temp2[3])));
            }
        }
        static void DisplayOutput(List<Customer> cList)
        {
            Console.WriteLine("{0, -10} {1, -11} {2, -15} {3, -13} {4, -16}", "Name", "Loan Amount", "Repayment Period", "Interest Rate", "Total Amount Due");
            Console.WriteLine("{0, -10} {1, -11} {2, -15} {3, -13} {4, -16}", "========", "===========", "================", "=============", "================");
            foreach (Customer c in cList)
            {
                Console.WriteLine("{0, -10} {1, 11} {2, 15} {3, 13} {4, 16:N3}", c.Name, c.LoanAmount, c.RepaymentPeriod, c.InterestRate, c.CalculateAmountDue());
            }
            Console.WriteLine();
        }
        static Customer AddCustomer()
        {
            Console.WriteLine("Add new customer");
            Console.Write("Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Customer loan amount: ");
            double loan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Customer repayment period: ");
            int repayment = Convert.ToInt32(Console.ReadLine());
            Console.Write("Customer interest rate: ");
            int interest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer {0} is added to the system\n", name);
            return new Customer(name, loan, repayment, interest);
        }
        static Customer SearchCustomer(List<Customer> cList, string name)
        {
            foreach (Customer c in cList)
            {
                if(c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            InitCustomerList(customerList);
            DisplayOutput(customerList);
            customerList.Add(AddCustomer());
            DisplayOutput(customerList);
            Console.Write("Enter the name of the customer: ");
            string name = Console.ReadLine();
            Customer search = SearchCustomer(customerList, name);
            if(search == null)
            {
                Console.WriteLine("{0} is not found!", name);
            }
            else
            {
                Console.WriteLine(search.ToString());
            }
            Console.ReadLine();
        }
    }
}
