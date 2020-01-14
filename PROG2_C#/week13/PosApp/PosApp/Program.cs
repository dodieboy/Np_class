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

namespace PosApp
{
    class Program
    {
        static int Menu()
        {
            Console.Write("---------------- M E N U -----------------\n[1] List all products and prices\n[2] Add item to cart\n[3] View cart items\n[4] Remove item from cart\n[5] Clear cart items\n[0] Exit\n------------------------------------------\nEnter option: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void displayProduct(List<Product> pList)
        {
            Console.WriteLine("{0, -4} {1, -15} {2}", "No." , "Name", "Price");
            foreach (Product p in pList)
            {
                Console.WriteLine("{0, -4} {1, -15} ${2}", p.Code, p.Name, p.Price);
            }
        }
        static void displayCart(ShoppingCart cList, bool total)
        {
            if (cList.IsEmpty())
            {
                Console.WriteLine("Cart is empty.");
            }
            else
            {
                double gTotal = 0;
                Console.WriteLine("{0, -3} {1, -15} {2, -9} {3, -3} {4}", "No.", "Name", "Price", "Qty", "Total");
                for (int i = 0; i < cList.GetItemList().Count; i++)
                {
                    gTotal += cList.GetItemList()[i].Price * cList.GetItemList()[i].Qty;
                    Console.WriteLine("{0, -3} {1, -15} ${2, -8:N2} {3, -3} ${4:N2}", i + 1, cList.GetItemList()[i].Name, cList.GetItemList()[i].Price, cList.GetItemList()[i].Qty, (cList.GetItemList()[i].Price * cList.GetItemList()[i].Qty));
                }
                if (total) //if total == true
                {
                    Console.WriteLine("------------------------------------------\nGrand Total: ${0:N2}", gTotal);
                }
            }
        }
        static void addItem(ShoppingCart cList, List<Product> pList)
        {
            displayProduct(pList);
            Console.Write("Please enter Item Number: ");
            string code = Console.ReadLine();
            if (pList.Find(x => x.Code == code) == null)
            {
                Console.WriteLine("Invaild Item number, Please try again");
                addItem(cList, pList); //rerun the method
            }
            else
            {
                Product p = pList.Find(x => x.Code == code);
                Console.Write("Please enter quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());
                CartItem item = new CartItem(p.Code, p.Name, p.Price, qty);
                cList.AddItem(item);
                Console.WriteLine("Item added to cart!");
            }
        }
        static void removeItem(ShoppingCart cList)
        {
            displayCart(cList, false);
            Console.Write("Please enter Cart No.: ");
            int no = Convert.ToInt32(Console.ReadLine())-1;
            cList.RemoveItem(no);
            Console.WriteLine("Item Removed from cart!");
        }
            static void Main(string[] args)
        {
            List<Product> productList = new List<Product> { };
            productList.Add(new Product("1001", "Apple iPhone", 1088));
            productList.Add(new Product("1005", "HTC Sensation", 880));
            productList.Add(new Product("1013", "LG Optimus 2X", 788));
            productList.Add(new Product("1022", "Motorola Atrix", 958));
            productList.Add(new Product("1027", "Samsung Galaxy", 988));

            ShoppingCart cartList = new ShoppingCart();

            while (true)
            {
                int option = Menu();
                if (option == 0)
                {
                    break;
                }
                else if (option == 1)
                {
                    displayProduct(productList);
                }
                else if (option == 2)
                {
                    addItem(cartList, productList);
                }
                else if (option == 3)
                {
                    displayCart(cartList, true);
                }
                else if (option == 4)
                {
                    removeItem(cartList);
                }
                else if (option == 5)
                {
                    cartList.ClearCart();
                }
            }
        }
    }
}
