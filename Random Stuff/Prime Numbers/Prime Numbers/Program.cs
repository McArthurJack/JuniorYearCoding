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
            Console.Write("Enter a range to find prime numbers(starts at 0): ");
            int answer = Convert.ToInt32(Console.ReadLine());
            List<int> primeList = new List<int>();
            int prime = 0;
            int number = 0;
            float numberf = number;
            int divisions = 0;
            primeList.Add(2);
            primeList.Add(3);
            primeList.Add(5);
            primeList.Add(7);
            for (int i = 2; i < answer; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    number = i;
                    numberf = i;
                    divisions++;
                    if (number/j == numberf/j)
                    {

                    }
                    else
                        prime++;
                }
                for (int j = 0; j < primeList.Count; j++)
                {
                    divisions++;
                    if (primeList.Count == 0)
                        break;
                    if (number / primeList[j] == numberf / primeList[j])
                    {

                    }
                    else
                        prime++;
                }
                if (prime == divisions)
                    primeList.Add(i);
                prime = 0;
                divisions = 0;
            }
            
            for (int i = 0; i < primeList.Count; i++)
            {
                Console.Write(primeList[i] + " | ");
            }
            Console.ReadLine();
        }
    }
}
