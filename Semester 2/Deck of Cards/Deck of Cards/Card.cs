using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    enum Suit { Hearts, Diamonds, Spades, Clubs };

    enum Face { Ace, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    class Card
    {
        public static Dictionary<Face, int> cardValue = new Dictionary<Face, int>()
        {
            {Face.Ace, 11},
            {Face.Two, 2},
            {Face.Three, 3},
            {Face.Four, 4},
            {Face.Five, 5},
            {Face.Six, 6},
            {Face.Seven, 7},
            {Face.Eight, 8},
            {Face.Nine, 9},
            {Face.Ten, 10},
            {Face.Jack, 10},
            {Face.Queen, 10},
            {Face.King, 10},
        };

        Suit suit;
        Face face;

        public Card(Suit Suit, Face Face)
        {
            this.suit = Suit;
            this.face = Face;
        }

        public void Print()
        {
            string hyp = "";
            string CardDisplay = "| " + face + " of " + suit + " |";
            foreach (Char c in CardDisplay)
            {
                hyp += "-";
            }
            Console.WriteLine(hyp);
            Console.WriteLine(CardDisplay);
            Console.WriteLine(hyp);
        }
    }
}
