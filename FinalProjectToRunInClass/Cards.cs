using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCardPoker
{
    class Card : IComparable
    {
        public Face face { get; set; }
        public Suit suit { get; set; }

        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return this.face - (obj as Card).face;
        }

        public override string ToString()
        {
            string suitInUnicode = "";
            switch (this.suit)
            {
                case Suit.spades:
                    suitInUnicode = "\u2663";
                    break;
                case Suit.club:
                    suitInUnicode = "\u2660";
                    break;
                case Suit.diamond:
                    suitInUnicode = "\u2666";
                    break;
                case Suit.hearts:
                    suitInUnicode = "\u2665";
                    break;

                default:
                    suitInUnicode = "";
                    break;
            }




            if ((int)face > 10)
            {

                return face + "-" + suitInUnicode;
            }
            return (int)face + "-" + suitInUnicode;
        }

        public void Display()
        {
            string suitInUnicode = "";
            switch (this.suit)
            {
                case Suit.spades:
                    suitInUnicode = "\u2663";
                    break;
                case Suit.club:
                    suitInUnicode = "\u2660";
                    break;
                case Suit.diamond:
                    suitInUnicode = "\u2666";
                    break;
                case Suit.hearts:
                    suitInUnicode = "\u2665";
                    break;

                default:
                    suitInUnicode = "";
                    break;
            }


            if (suit == Suit.club || suit == Suit.spades)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
            }


            if ((int)face > 10)
            {
                Console.Write(face + "-" + suitInUnicode);
            }
            else
            {
                Console.Write((int)face + "-" + suitInUnicode);
            }
        }


    }

}
