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
    public class CartItem:Product
    {
        private int qty;
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public CartItem() { }
        public CartItem(string c, string n, double p, int q):base(c, n, p)
        {
            Qty = q;
        }
        public override string ToString()
        {
            return base.ToString()+ String.Format(" Qty: {0}", this.Qty);
        }
    }
}
