using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            RevString();
            Console.WriteLine();
            Console.ReadLine();
        }

        static void RevString()
        {
            string string1 = "";
            do
            {
                Console.WriteLine("Test to see if this string is a Palindrome");
                Console.WriteLine("");
                string1 = Console.ReadLine();
                //Punctuation Removing. Creates a string array of the Punctuation, foreach item in the array it removes it and puts nothing instead.
                string[] punc = new string[] { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "[", "{", "]", "}", ":", ";", "'", "'", ",", "<", ".", ">", "/", "?", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "_"};
                foreach (string item in punc)
                {
                    string1 = string1.Replace(item, "");
                }
                string1 = string1.ToLower();
                Console.WriteLine();
                string string2 = "";
                for (int i = string1.Length - 1; i >= 0; i--)
                {
                    string2 = string2 + (string1.Substring(i, 1));
                }
                if (string1 == string2)
                {
                    Console.WriteLine("This is a palindrome");
                }
                else
                {
                    Console.WriteLine("This is not a palindrome");
                }
            } while (string1 != "");
        }
    }
}
