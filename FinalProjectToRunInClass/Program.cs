using System;
using System.Collections.Generic;
using System.Linq;
namespace ThreeCardPoker 
{
    class Program
    {
        static void Main(string[] args)
        {
            //START:variables and instances required
            Deck deckA = new Deck();

            //each group of cards represents a hand of 3 cards, aka 1 player
            List<GroupOfCards> listOfGroupOfCards = new List<GroupOfCards>();

            int numberOfPlayers = 10, randomNumber = 0;
            Random r = new Random();

            GroupOfCards winner;
            //END: variables and instances required
            //max of 17 players. 


            //START: Give 3 cards to each player 
            for (int i = 0; i < numberOfPlayers; i++)
            {
                randomNumber = r.Next(0, deckA.getCards().Count - 1);
                Card card1 = deckA.getCards().ElementAt(randomNumber);
                deckA.getCards().RemoveAt(randomNumber);

                randomNumber = r.Next(0, deckA.getCards().Count - 1);
                Card card2 = deckA.getCards().ElementAt(randomNumber);
                deckA.getCards().RemoveAt(randomNumber);

                randomNumber = r.Next(0, deckA.getCards().Count - 1);
                Card card3 = deckA.getCards().ElementAt(randomNumber);
                deckA.getCards().RemoveAt(randomNumber);

                GroupOfCards tempGroupOfCards = new GroupOfCards(card1, card2, card3);

                listOfGroupOfCards.Add(tempGroupOfCards);
            }

            //END:Give 3 cards to each player
            
            //temporary placeholder
            winner = listOfGroupOfCards.ElementAt(0);

            //SETUP the display
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            //START:Display the hands we have created, and calculate the winner in the same iteration

            Console.WriteLine("The Cards we got");
            Console.WriteLine();
            foreach (var groupOfCards in listOfGroupOfCards)
            {
                groupOfCards.Display();
                if (winner.CompareTo(groupOfCards) < 0)
                {
                    winner = groupOfCards;
                }
            }
            Console.WriteLine();
            //END:Display the hands we have created, and calculate the winner in the same iteration

            //Show the winner
            Console.WriteLine("The Winner is");
            winner.Display();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
