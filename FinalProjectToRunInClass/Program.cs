using System;
using System.Collections.Generic;
using System.Linq;
namespace ThreeCardPoker 
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deckA = new Deck();


            List<GroupOfCards> listOfGroupOfCards = new List<GroupOfCards>();


            int numberOfPlayers = 10, randomNumber = 0;
            Random r = new Random();
            //max of 17 players. 
            for (int i = 0; i < numberOfPlayers; i++)
            {
                randomNumber = r.Next(0, deckA.getCards().Count - 1);
                Card card1 = deckA.getCards().ElementAt(randomNumber);//make this random
                deckA.getCards().RemoveAt(randomNumber);

                randomNumber = r.Next(0, deckA.getCards().Count - 1);
                Card card2 = deckA.getCards().ElementAt(randomNumber);//make this random
                deckA.getCards().RemoveAt(randomNumber);

                randomNumber = r.Next(0, deckA.getCards().Count - 1);
                Card card3 = deckA.getCards().ElementAt(randomNumber);//make this random
                deckA.getCards().RemoveAt(randomNumber);

                GroupOfCards tempGroupOfCards = new GroupOfCards(card1, card2, card3);

                listOfGroupOfCards.Add(tempGroupOfCards);
            }

            GroupOfCards winner = listOfGroupOfCards.ElementAt(0);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("The Cards we got");
            Console.WriteLine();
            foreach (var groupOfCards in listOfGroupOfCards)
            {
                groupOfCards.Display();
                //Console.WriteLine();
                if (winner.CompareTo(groupOfCards) < 0)
                {
                    winner = groupOfCards;
                }
            }
            Console.WriteLine();

            Console.WriteLine("The Winner is");
            winner.Display();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
