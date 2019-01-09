using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Help
{
    class Program
    {
        static int input = 0;
        static void Main(string[] args)
        {
            do
            {
                DisplayMenuToUserAndGetInput();
                if (input == 1)
                {
                    Shape(3, 3);
                }
                else if (input == 2)
                {
                    Shape(3, 6);
                }
                else if (input == 3)
                {
                    Shape(6, 3);
                }
                else if (input == 4)
                {
                    Console.WriteLine("Enter the exponent.");
                    int exponent = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("2^" + exponent + " = " + Math.Pow(2, exponent));
                    Console.WriteLine();
                }
            } while (input != 5);
            Console.ReadLine();
        }

        static void DisplayMenuToUserAndGetInput()
        {
            Console.WriteLine("1. Prints a 3x3 Square");
            Console.WriteLine("2. Prints a 6x3 Rectangle");
            Console.WriteLine("3. Prints a 3x6 Rectangle");
            Console.WriteLine("4. Enter a number to be the exponent you put 2 into.");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        static void Shape(int first, int second)
        {
            for (int i = 0; i < first; i++)
            {
                for (int j = 0; j < second; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
