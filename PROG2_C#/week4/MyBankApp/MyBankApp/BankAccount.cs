using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    class BankAccount
    {
        private string accNo;
        private string accName;
        private double balance;
        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public BankAccount() { }
        public BankAccount(string no, string name, double bal)
        {
            AccNo = no;
            AccName = name;
            Balance = bal;
        }
        public void Deposit(double amount) {
            Balance += amount;
        }
        public bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("AccNo: {0}, AccName: {1}, Bal: {2}", AccNo, AccName, Balance);
        }
    }
}
