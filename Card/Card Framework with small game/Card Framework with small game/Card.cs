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
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card f[i]+s[j] = new Card(); 
                }
            }
        }

        public string GetFace(List<string> Face)
        {

            return Face[];
        }
    }
}
