using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramo
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int i = 0;
                int[] arr = new int[1000];
                Random rand = new Random();
                int num = rand.Next(0, 9);
                arr[i] = num;
                i++;
                Console.Write("I'll ddos ur toaster ");
            } while (true);
        }
    }
}
