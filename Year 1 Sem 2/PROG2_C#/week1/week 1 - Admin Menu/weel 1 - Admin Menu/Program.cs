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

namespace weel_1_Admin_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string option = null;
                Console.WriteLine("ADMIN MENU");
                Console.WriteLine("==========");
                Console.WriteLine("[1] Read bicycle info from file");
                Console.WriteLine("[2] Display all bicycle info with servicing indication");
                Console.WriteLine("[3] Display selected bicycle info");
                Console.WriteLine("[4] Add a bicycle");
                Console.WriteLine("[5] Perform bicycle maintenance");
                Console.WriteLine("[0] Exit");
                Console.Write("Enter your option: ");
                option = Console.ReadLine();

                if (option != "0")
                {
                    Console.WriteLine("You have selected option: {0}", option);
                }
                else
                {
                    Console.WriteLine("Thank you. Bye-bye");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
