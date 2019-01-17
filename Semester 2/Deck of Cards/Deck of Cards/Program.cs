using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Program
    {
        public int player1count = 0;
        public int player2count = 0;

        static void Main(string[] args)
        {
            List<Card> Hand1 = new List<Card>();
            List<Card> Hand2 = new List<Card>();
            Deck BlackJack = new Deck();
            BlackJack.Shuffle();
            int decksize = BlackJack.DeckofCards.Count();
            do
            {
                decksize = BlackJack.DeckofCards.Count();
            } while (decksize != 0);

            Console.ReadLine();
        }

        static void GUI(int playernumber)
        {
            Console.WriteLine("Player " + playernumber + " turn");

        }
    }
}
