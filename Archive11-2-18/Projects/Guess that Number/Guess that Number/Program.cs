using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_that_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a random number
            //sets the answer to null
            //creates a int variable that is the amount of guesses
            //creates a do while loop
            //Asks you if to guess a number between 1-1000
            //set the int answer = to the users input
            //adds 1 to the amount of guess everytime it runs the do while loop.
            //starts an if statement that if the ansewr is < the random number
            //writes a line telling you that the number is higher
            //creates an else if that the number is > the random number
            //Writes a line telling you the number is lower
            //while the answer doesn't equal the random number
            //writes a line saying that you guessed the random number and the amount of guesses it took
            //Makes the program stay open

            //Made this after I got it checked.

            //int amountofguess = 0;
            //Random random = new Random();
            //int randomN = random.Next(1, 1001);
            //int answer = -1;
            //do
            //{
            //    Console.WriteLine("Guess a random number between 1 and 1000");
            //    answer = Convert.ToInt32(Console.ReadLine());
            //    amountofguess++;
            //    if (answer < randomN)
            //        Console.WriteLine("The number is greater");
            //    else if (answer > randomN)
            //        Console.WriteLine("The number is lower");
            //} while (randomN != answer);
            //Console.WriteLine("You guessed the random number! It took you " + amountofguess + " times.");
            //Console.ReadLine();

            Console.WriteLine("Enter a value for the computer to guess in a range of 1-1000");
            int answer = Convert.ToInt32(Console.ReadLine());
            int max = 1024;
            int min = 0;
            int compans = max / 2;
            int numbofG = 0;
            do
            {
                numbofG++;
                Console.WriteLine(min + " min " + max + " max");
                if (answer < compans)
                {
                    Console.Write("Guess of " + compans + " ");
                    Console.WriteLine("is too High");
                    max = compans;
                    compans = max - ((max-min)/2);
                    Console.WriteLine();
                }
                else if (answer > compans)
                {
                    Console.Write("Guess of " + compans + " ");
                    Console.WriteLine("is too low");
                    min = compans;
                    compans = min + ((max - min) / 2);
                    Console.WriteLine();
                }
            } while (compans != answer);
            Console.WriteLine("The computer guessed your number of " + compans);
            Console.WriteLine();

            Console.WriteLine("It took you this many guesses " + numbofG);
            Console.ReadLine();
        }
        //MAKE IT SO YOU INPUT # AND THE COMPUTER GUESSES IT
    }
}
