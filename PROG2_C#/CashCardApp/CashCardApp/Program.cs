using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CashCardApp.CashCard;

namespace CashCardApp
{
    class Program
    {
        static void InitCardList(List<CashCard> cardList)
        {
            cardList.Add(new CashCard("001", 25));
            cardList.Add(new CashCard("002", 25));
            cardList.Add(new CashCard("003", 30));
            cardList.Add(new CashCard("004", 30));
            cardList.Add(new CashCard("005", 50));
        }
        static void Main(string[] args)
        {
            List<CashCard> cardlist = new List<CashCard> {};
            InitCardList(cardlist);

            Console.WriteLine("{0, 3} {1, 3}", "ID", "Balance");
            for (int i = 0; i < cardlist.Count; i++)
            {
                Console.WriteLine("{0, 3} {1, 3}",cardlist[i].Id, cardlist[i].Balance);
            }

            Console.WriteLine("\nEnter Cash Card ID: ");
            string cardId = Console.ReadLine();
            CashCard cardFind = cardlist.Find(x => x.Id == cardId);
            if(cardFind == null)
            {
                Console.WriteLine("You have key a invaild Cash Card ID");
            }
            else
            {
                Console.WriteLine("There is ${0} in this Cash Card", cardFind.Balance);

                Console.WriteLine("Amount to topup: ");
                int topUp = Int32.Parse(Console.ReadLine());

                cardFind.TopUp(topUp);
                cardFind = cardlist.Find(x => x.Id == cardId);
                Console.WriteLine("\n${0} is added to your card.\nThere is ${1} in this Cash Card now", topUp.ToString(), cardFind.Balance);
            }
            Console.ReadLine();
        }
    }
}
