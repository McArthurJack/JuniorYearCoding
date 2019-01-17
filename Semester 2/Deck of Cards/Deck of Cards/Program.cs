using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Card> Hand1 = new List<Card>();
            List<Card> Hand2 = new List<Card>();

            Deck BlackJack = new Deck();
            BlackJack.Shuffle();

            Console.WriteLine("Player 1 Hand");
            Card temp;
            Hand1.Add(temp = BlackJack.Draw());
            Hand1.Add(temp);
            temp.Print();
            Hand1.Add(temp = BlackJack.Draw());
            temp.Print();
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Discard Pile");
            for (int i = 0; i < Hand1.Count; i++)
            {
                BlackJack.Discard(Hand1[i]);
                Hand1.RemoveAt(i);
            }
            BlackJack.PrintDiscard();
            Console.ReadLine();
        }

        static void GUI()
        {
            Console.WriteLine();
            Console.WriteLine("");
        }
    }
}
