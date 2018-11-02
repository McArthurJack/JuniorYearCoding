using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_Thing
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number to be divided: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int Radix = 1;
                RadixAns(number, Radix);
            } while (true);
        }

        static void AnyRadixPrint(int number, int Radix)
        {
            int Q = number / Radix;
            int R = number % Radix;
            if (Q != 0)
                AnyRadixPrint(Q, Radix);
            R = Math.Abs(R);
            char Remainder = (char)(R);
            Console.Write(0 + Remainder);
        }

        static void RadixAns(int number, int Radix)
        {
            bool and = false;
            do
            {
                Console.Write("Enter a number to divide by that is a range from 2 to 36: ");
                Radix = Convert.ToInt32(Console.ReadLine());
                if (Radix < 2)
                {
                    Console.Write("Enter a number to divide by that is a range from 2 to 36: ");
                    Radix = Convert.ToInt32(Console.ReadLine());
                }
                else if (Radix > 36)
                {
                    Console.Write("Enter a number to divide by that is a range from 2 to 36: ");
                    Radix = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    if (number < 0)
                        Console.Write('-');
                    AnyRadixPrint(number, Radix);
                    and = true;
                }
                Console.WriteLine();
                Console.WriteLine();
            } while (and != true);
        }
    }
}
