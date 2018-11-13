using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Framework_with_small_game
{
    class Deck
    {
        List<Card> Pile = new List<Card>();

        List<Card> Discard = new List<Card>();

        static void Shuffle(List<Card> Pile)
        {
            Random rand = new Random();
            for (int i = 0; i < 52; i++)
            {
                int random = rand.Next(0, 53);
                Pile.Add(Pile[random]);
                Pile.Remove(Pile[random]);
            }
        }

        //static Card Draw()
        //{

        //    return Card;
        //}

        static void Reset(List<Card> Pile)
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card temp = new Card((Face)i,(Suit) j);
                    Pile.Add(temp);
                }
            }
            for (int i = 0; i < 52; i++)
            {
                Console.Write(Pile[i] + " ");
            }
        }
    }
}
