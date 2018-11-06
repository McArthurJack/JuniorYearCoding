using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeList = new List<int>();
            int prime = 0;
            int number = 0;
            float numberf = number;
            primeList.Add(2);
            for (int i = 2; i < 200; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    number = i;
                    numberf = i;
                    if (number/j == numberf/j)
                    {

                    }
                    else
                    {
                        prime++;
                    }
                    if (prime == i-2)
                        primeList.Add(i);
                }
                prime = 0;
            }
            
            for (int i = 0; i < primeList.Count; i++)
            {
                Console.Write(primeList[i] + " | ");
            }
            Console.ReadLine();
        }
    }
}
