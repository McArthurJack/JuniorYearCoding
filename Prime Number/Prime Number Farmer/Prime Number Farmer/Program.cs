using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Farmer
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int number = 0;
            double numberf = 0;
            int counter = 0;
            int prime = 0;
            List<int> primenumbers = new List<int>();

            for (int i = 0; i < answer; i++)
            {
                CoreMain();
                Core1();
                Core2();
                Core3();
                Core4();
                Core5();
            }


            Console.Write("Enter a value to search for all the prime numbers from 0 to that number: ");
            answer = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < answer; i++)
            {
                number = i;
                numberf = i;
                for (int j = 0; j < primenumbers.Count; j++)
                {
                    if (Math.Sqrt(numberf) < primenumbers[j])
                        break;
                    counter++;
                    if (number / primenumbers[j] == numberf / primenumbers[j])
                    {
                        break;
                    }
                    else
                        prime++;
                }
                if (prime == counter)
                    primenumbers.Add(i);
                prime = 0;
                counter = 0;
            }
            //for (int i = 0; i < primenumbers.Count; i++)
            //    Console.Write(primenumbers[i] + " |");
            //Console.WriteLine();
            Console.Write(primenumbers.Count);
            Console.ReadLine();
        }

        static void CoreMain()
        {

        }

        static void Core1()
        {

        }

        static void Core2()
        {

        }

        static void Core3()
        {

        }
        
        static void Core4()
        {

        }

        static void Core5()
        {

        }
    }
}
