using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Reverse = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                Reverse.Add(i);
            }

            for (int i = 0; i < Reverse.Count; i++)
                Console.Write(Reverse[i] + ", ");
            Console.WriteLine();


            for (int i = Reverse.Count-2; i >= 0; i--)
            {
                int temp = Reverse[i];
                Reverse.RemoveAt(i);
                Reverse.Add(temp);
            }

            for (int i = 0; i < Reverse.Count; i++)
                Console.Write(Reverse[i] + ", ");
            Console.ReadLine();
        }
    }
}
