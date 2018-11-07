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
            int number = 0;
            float numberf = 0;
            int counter = 0;
            int prime = 0;
            bool breakshit = false;
            List<int> primenumbers = new List<int>();
            for (int i = 2; i < 10; i++)
            {
                number = i;
                numberf = i;
                for (int j = 2; j < 10; j++)
                {
                    counter++;
                    if (number / j == numberf / j)
                    {
                        breakshit = true;
                        break;
                    }
                    else
                        prime++;
                }
                for (int j = 0; j < primenumbers.Count; j++)
                {
                    if (breakshit == true)
                        break;
                    if (Math.Sqrt(numberf) < primenumbers[j])
                        break;
                    counter++;
                    if (number / primenumbers[j] == numberf / primenumbers[j])
                    {

                    }
                    else
                        prime++;
                }
                if (prime == counter)
                    primenumbers.Add(i);
                breakshit = false;
                prime = 0;
                counter = 0;
            }
            //for (int i = 0; i < primenumbers.Count; i++)
            //    Console.Write("| " + primenumbers[i] + " |");
            int Count = primenumbers.Count();
            Console.Write(Count);
            Console.ReadLine();
        }
    }
}
