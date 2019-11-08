using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyBankApp
{
    class Program
    {
        static int menu()
        {
            Console.Write("Menu\n[1] Display all accounts\n[2] Deposit\n[3] Withdraw\n[0] Exit\n[4] Display all accounts with interest\nEnter option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static void DisplayAll(List<SavingAccount> sList)
        {
            foreach (SavingAccount s in sList)
            {
                Console.WriteLine("Acc No: {0} Acc Name: {1} Balance: ${2} Rate: {3}%", s.AccNo, s.AccName, s.Balance, s.Rate);
            }
            Console.WriteLine();
        }
        static void DisplayAllWInterest(List<SavingAccount> sList)
        {
            foreach (SavingAccount s in sList)
            {
                Console.WriteLine("Acc No: {0} Acc Name: {1} Balance: ${2} Rate: {3}% Interest: ${4}", s.AccNo, s.AccName, s.Balance, s.Rate, s.CalculateInterest());
            }
            Console.WriteLine();
        }
        static SavingAccount SearchAcc(List<SavingAccount> sList, string accNo)
        {
            SavingAccount accountFind = sList.Find(x => x.AccNo == accNo);
            if (accountFind != null)
            {
                return accountFind;
            }
            return null;
        }
        static void Main(string[] args)
        {
            List<SavingAccount> savingsAccList  = new List<SavingAccount>();
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", "savings_account.csv");
            string[] temp = File.ReadAllText(path).Replace("\r", string.Empty).Split('\n');
            for (int i = 1; i < temp.Length - 1; i++)
            {
                string[] temp2 = temp[i].Split(',');
                savingsAccList.Add(new SavingAccount(temp2[0], temp2[1], Convert.ToDouble(temp2[2]), Convert.ToDouble(temp2[3])));
            }

            while(true) {
                int option = menu();
                if (option == 0)
                {
                    break;
                }
                else if (option == 1)
                {
                    DisplayAll(savingsAccList);
                }
                else if (option == 2)
                {
                    SavingAccount account = null;
                    while (true)
                    {
                        Console.Write("Enter the Account Number: ");
                        string accNo = Console.ReadLine();
                        account = SearchAcc(savingsAccList, accNo);
                        if (account != null)
                        {
                            break;
                        }
                        Console.WriteLine("Invaild account number. Please try again");
                    }
                    Console.Write("\nAccount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(deposit);
                    Console.WriteLine("${0} deposited successful\nAcc No: {1} Acc Name: {2} Balance: {3} Rate: {4}", deposit, account.AccNo, account.AccName, account.Balance, account.Rate);
                }
                else if (option == 3)
                {
                    SavingAccount account = null;
                    while (true)
                    {
                        Console.Write("Enter the Account Number: ");
                        string accNo = Console.ReadLine();
                        account = SearchAcc(savingsAccList, accNo);
                        if (account != null)
                        {
                            break;
                        }
                        Console.WriteLine("Error: Invaild account number. Please try again");
                    }
                    Console.Write("\nAccount to withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(withdraw);
                    Console.WriteLine("${0} deposited successful\nAcc No: {1} Acc Name: {2} Balance: {3} Rate: {4}", withdraw, account.AccNo, account.AccName, account.Balance, account.Rate);
                }
                else if (option == 4)
                {
                    DisplayAllWInterest(savingsAccList);
                }
                else
                {
                    Console.WriteLine("Error: invaild input!");
                }
            }
        }
    }
}
