using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Framework_with_small_game
{
    enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    enum Suit
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds,
    }
    class Card
    {
        public Card(Face f, Suit s)
        {
            Card card = new Card((Face)f, (Suit)s);
        }

        public string GetFace(List<string> Face)
        {
            string face = Face[0];
            return face;
        }
    }
}
