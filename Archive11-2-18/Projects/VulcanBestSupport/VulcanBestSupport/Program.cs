using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulcan_best_support
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("Who is the best Flex Support on the team?");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "vulcan")
                    Console.WriteLine("You are correct!");
                else
                    Console.WriteLine("You are wrong retard. Guess again");
            } while (answer != "vulcan");
            Console.ReadLine();
        }
    }
}
