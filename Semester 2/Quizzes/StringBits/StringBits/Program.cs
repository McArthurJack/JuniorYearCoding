using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBits
{
    class Program
    {
        static void Main(string[] args)
        {
            stringBits("Hello");
            stringBits("Hi");
            stringBits("Heeololeo");
        }

        static string stringBits(string input)
        {
            string export = "";
            for (int i = 0; i < input.Length; i+=2)
            {
                export += input[i];
            }
            return export;
        }
    }
}
