using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Deck
    {
        public List<Card> DeckofCards = new List<Card>();

        public List<Card> DiscardPile = new List<Card>();

        public void Shuffle()
        {
            List<Card> temp = new List<Card>();

            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var face in Enum.GetValues(typeof(Face)))
                {
                    temp.Add(new Card((Suit)suit, (Face)face));
                }
            }
            
            for (int i = temp.Count-1; i >= 0; i--)
            {
                Random rand = new Random();
                int x = rand.Next(0, i);
                DeckofCards.Add(temp[x]);
                temp.RemoveAt(x);
            }

            for (int i = DeckofCards.Count - 1; i >= 0; i--)
            {
                Random rand = new Random();
                int x = rand.Next(0, i);
                temp.Add(DeckofCards[x]);
                DeckofCards.RemoveAt(x);
            }

            for (int i = temp.Count - 1; i >= 0; i--)
            {
                Random rand = new Random();
                int x = rand.Next(0, i);
                DeckofCards.Add(temp[x]);
                temp.RemoveAt(x);
            }
        }

        public Card Draw()
        {
            Card temp = DeckofCards[DeckofCards.Count - 1];
            DeckofCards.RemoveAt(DeckofCards.Count - 1);
            return temp;
        }

        public void Discard(Card c)
        {
            DiscardPile.Add(c);
        }

        public void PrintDeck()
        {
            foreach (var card in DeckofCards)
            {
                card.Print();
            }
        }

        public void PrintDiscard()
        {
            foreach (var card in DiscardPile)
            {
                card.Print();
            }
        }
    }
}
