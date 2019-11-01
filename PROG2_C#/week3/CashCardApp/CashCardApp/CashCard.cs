using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCardApp
{
    class CashCard
    {
        private string id;
        private double balance;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public CashCard(string i, double b)
        {
            Id = i;
            Balance = b;
        }
        public void TopUp(double b)
        {
            Balance += b;
        }
        public bool Deduct(double b)
        {
            if (Balance - b < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            return String.Format("ID: {0}, Balance: {1}", Id, Balance);
        }
    }
}
