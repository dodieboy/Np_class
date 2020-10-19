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
    public class ShoppingCart
    {
        private List<CartItem> itemList = new List<CartItem>();
        public ShoppingCart() { }
        public void AddItem(CartItem i)
        {
            itemList.Add(i);
        }
        public List<CartItem> GetItemList()
        {
            return itemList;
        }
        public bool RemoveItem(int q)
        {
            itemList.Remove(itemList[q]);
            return true;
        }
        public void ClearCart()
        {
            itemList.Clear();
            Console.WriteLine("Cart is cleared!");
        }
        public int Size()
        {
            return itemList.Count();
        }
        public bool IsEmpty()
        {
            if(itemList.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
