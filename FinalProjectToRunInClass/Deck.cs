using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCardPoker   
{
    class Deck
    {
        private List<Card> cards;
        private const int numberOfCards = 52;
        private Face face;
        public Deck()
        {
            //initialize 52 cards
            initializeDeck();
        }

        public List<Card> getCards()
        {
            return cards;
        }

        private void initializeDeck()
        {
            cards = new List<Card>();
            Card card;
            //initialize faces
            Face[] faces = new Face[]
            {
                Face.two, Face.three, Face.four, Face.five, Face.six, Face.seven, Face.eight, Face.nine, Face.ten, Face.J, Face.Q, Face.K, Face.A
            };

            Suit[] suits = new Suit[]
            {
                Suit.club, Suit.diamond, Suit.hearts, Suit.spades
            };

            for (int faceCounter = 0; faceCounter < 13; faceCounter++)
            {
                for (int suitCounter = 0; suitCounter < 4; suitCounter++)
                {
                    card = new Card(faces[faceCounter], suits[suitCounter]);
                    cards.Add(card);
                }
            }
        }
    }
}
