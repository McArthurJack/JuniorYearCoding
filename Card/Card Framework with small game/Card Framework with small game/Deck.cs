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

        static void Shuffle()
        {

        }

        static Card Draw()
        {

            return Card;
        }

        static void Reset(List<Card> Pile)
        {
            Pile = new List<Card>();
            
        }
    }
}
