using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> CharString = new List<char>();
            string Pal = "";
            string PalReverse = "";

            Console.Write("Test for a Palindrome: ");
            Pal = Console.ReadLine();
            Pal = Pal.ToLower();

            for (int i = 0; i < Pal.Length; i++)
            {
                CharString.Add(Pal[i]);
            }

            for (int i = 0; i < CharString.Count; i++)
            {
                if (CharString[i] == ' ')
                {
                    CharString.RemoveAt(i);
                }
            }

            Pal = "";

            for (int i = 0; i < CharString.Count; i++)
            {
                Pal += CharString[i];
            }

            for (int i = CharString.Count-1; i >= 0; i--)
            {
                char temp = CharString[i];
                PalReverse += temp;
            }

            Console.WriteLine("Your orignial text: " + Pal);
            Console.WriteLine("Backwards the word is: " + PalReverse);
            Console.WriteLine();
            if (Pal == PalReverse)
                Console.WriteLine("The text is a Palindrome");
            else
                Console.WriteLine("The text is not a Palindrome");
            Console.ReadLine();
        }
    }
}
