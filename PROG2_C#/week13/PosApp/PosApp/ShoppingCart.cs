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
        public List<CartItem> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
        public ShoppingCart() { }
        public void AddItem(CartItem i)
        {
            itemList.Add(i);
        }
        public List<CartItem> GetItemList()
        {
            return null;
        }
        public bool RemoveItem(int q)
        {
            ItemList.Remove(itemList[q]);
            return true;
        }
        public void ClearCart()
        {
            ItemList.Clear();
            Console.WriteLine("Cart is cleared!");
        }
        public int Size()
        {
            return 1;
        }
        public bool IsEmpty()
        {
            if(ItemList.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
