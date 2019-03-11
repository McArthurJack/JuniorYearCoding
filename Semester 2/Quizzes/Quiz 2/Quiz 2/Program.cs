using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            stringSplosion("Code");
            stringSplosion("abc");
            stringSplosion("ab");
            Console.ReadLine();
        }

        static void stringSplosion(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(value[j]);
                }
            }
        }
    }
}
