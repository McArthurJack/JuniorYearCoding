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
            double answer = 0;
            int number = 0;
            double numberf = 0;
            int counter = 0;
            int prime = 0;
            List<int> primenumbers = new List<int>();

            //for (int i = 0; i < answer; i++)
            //{
            //    CoreMain();
            //    Core1();
            //    Core2();
            //    Core3();
            //    Core4();
            //    Core5();
            //}


            Console.Write("Enter a value to search for all the prime numbers from 0 to that number: ");
            answer = Convert.ToDouble(Console.ReadLine());
            double checker = 0;
            int primeIndex = 0;
            primenumbers.Add(2);
            primenumbers.Add(3);
            for (int i = 5; i< answer; i+=2)
            {
                number = i;
                numberf = i;
                if (Math.Sqrt(numberf) > primenumbers[primeIndex])
                    primeIndex++;
                for (int j = 0; j < primeIndex; j++)
                {
                    checker++;
                    counter++;
                    if (number / primenumbers[j] == numberf / primenumbers[j])
                    {
                        j = primeIndex;
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
            
            Console.Write(primenumbers.Count);
            Console.WriteLine();
            Console.WriteLine("Checks:" + checker);
            Console.WriteLine("Continue........");
            Console.ReadLine();
            for (int i = 0; i < primenumbers.Count; i++)
                Console.Write(primenumbers[i] + " |");
            Console.ReadLine();
        }

        //static void CoreMain()
        //{

        //}

        //static void Core1()
        //{

        //}

        //static void Core2()
        //{

        //}

        //static void Core3()
        //{

        //}
        
        //static void Core4()
        //{

        //}

        //static void Core5()
        //{

        //}
    }
}
