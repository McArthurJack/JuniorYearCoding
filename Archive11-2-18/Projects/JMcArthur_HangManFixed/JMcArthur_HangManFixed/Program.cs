using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMcArthur_HangManFixed
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings and random generator
            Random rand = new Random();
            string[] word = new string[20] { "billy", "nut", "creepy", "saw", "wish", "acceptable", "rock", "examine", "gleaming", "jam", "quince", "handsome", "finger", "previous", "gruesome", "charge", "adorable", "battle","downtown", "keen"};
            string randWord = word[rand.Next(0, 20)];
            string[] randWordArray = new string[randWord.Length];
            string[] GuessArray = new string[randWord.Length];
            List<string> incorrectList = new List<string>();
            for (int n = 0; n < randWord.Length; n++)
            {
                GuessArray[n] = "_ ";
            }
            for (int p = 0; p < randWord.Length; p++)
            {
                randWordArray[p] = randWord.Substring(p, 1);
            }
            string randWordcon = "";
            string GuessCon = "";
            //Numbers
            int incorrect = 0;
            do
            {
                if (incorrect > 6)
                {
                    break;
                }
                randWordcon = "";
                GuessCon = "";
                for (int i = 0; i < GuessArray.Length; i++)
                {
                    Console.Write(GuessArray[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Incorrect letters: ");
                for (int i = 0; i < incorrectList.Count; i++)
                {
                    Console.Write(incorrectList[i] + " ");
                }
                Console.Write(incorrect);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Input a guess: ");
                string input = Console.ReadLine();
                for (int i = 0; i < GuessArray.Length; i++)
                {
                    if (randWordArray[i].Contains(input))
                    {
                        GuessArray[i] = input + " ";
                    }
                    else if (randWordArray.Contains(input))
                    {
                    }
                    else
                        if (incorrectList.Contains(input))
                    {
                    }
                    else
                    {
                        incorrectList.Add(input);
                        incorrect++;
                    }
                }

                for (int i = 0; i < randWordArray.Length; i++)
                {
                    randWordcon = randWordcon + randWordArray[i];
                }
                for (int i = 0; i < GuessArray.Length; i++)
                {
                    GuessCon = GuessCon + GuessArray[i];
                }
                GuessCon = GuessCon.Replace(" ", "");
                Console.WriteLine();
            } while (randWordcon != GuessCon);
            if (randWordcon == GuessCon)
                Console.WriteLine("You guessed the word!");
            else if (incorrect > 6)
                Console.WriteLine("The man was hung.");
            Console.ReadLine();
        }
    }
}
