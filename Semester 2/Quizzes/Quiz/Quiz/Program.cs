using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringTimes("ABC", 10));
        }

        static string stringTimes(string mult, int amount)
        {
            string result = "error";
            if (amount < 0)
            {
                result = "";
                char[] array = mult.ToCharArray();
                Array.Reverse(array);
                mult = new string(array);
                for (int i = 0; i < Math.Abs(amount); i++)
                {
                    result += mult;
                }
            }
            else
            {
                result = "";
                for (int i = 0; i < amount; i++)
                {
                    result += mult;
                }
            }
            return result;
        }
    }
}
