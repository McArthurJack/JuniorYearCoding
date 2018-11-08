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
            double numberf = 0;
            int counter = 0;
            int prime = 0;
            bool stop = false;
            List<int> primenumbers = new List<int>();
            primenumbers.Add(2);
            primenumbers.Add(3);
            primenumbers.Add(5);
            primenumbers.Add(7);
            for (int i = 2; i < 10000000000; i++)
            {
                number = i;
                numberf = i;
                for (int j = 2; j < 10; j++)
                {
                    counter++;
                    if (number / j == numberf / j)
                    {
                        stop = true;
                        break;
                    }
                    else
                        prime++;
                }
                for (int j = 0; j < primenumbers.Count; j++)
                {
                    if (stop == true)
                        break;
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
                stop = false;
            }
            for (int i = 0; i < primenumbers.Count; i++)
                Console.Write("| " + primenumbers[i] + " |");
            Console.WriteLine();
            Console.Write(primenumbers.Count);
            Console.ReadLine();
        }
    }
}
