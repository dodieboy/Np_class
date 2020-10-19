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

namespace ShippingApp
{
    class Program
    {
        static void InitCustomerList(List<Customer> cList)
        {
            cList.Add(new Customer("John Tan", "98501111", new ShippingAddr("Singapore", "Clementi Rd")));
            cList.Add(new Customer("Amy Lim", "99991111", new ShippingAddr("Hong Kong", "Mong Kok Rd")));
            cList.Add(new Customer("Tony Tay", "91112222", new ShippingAddr("Malaysia", "Malacca Rd")));
        }
        static void ListCustomers(List<Customer> cList)
        {
            Console.WriteLine("{0, -12} {1, -12} {2, -12} {3}", "Name", "Tel", "Country", "Street");
            for (int i = 0; i < cList.Count; i++)
            {
                Console.WriteLine("{0, -12} {1, -12} {2, -12} {3}", cList[i].Name, cList[i].Tel, cList[i].Addr.Country, cList[i].Addr.Street);
            }
        }
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            InitCustomerList(customerList);
            ListCustomers(customerList);
            Console.ReadLine();
        }
    }
}
