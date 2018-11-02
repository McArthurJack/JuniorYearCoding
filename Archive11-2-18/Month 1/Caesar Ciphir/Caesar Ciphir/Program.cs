using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Ciphir
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuInput = -2;
            do
            {
                Console.WriteLine("1. Writes out the Alphabet in Ascii numbers");
                Console.WriteLine("2. Displays 13000 characters");
                Console.WriteLine("3. Shifts e by 3 letters backwards");
                Console.WriteLine("4. Encrpyts a word of your choice");
                Console.WriteLine("5. Decrypt");
                Console.WriteLine("6. Decrypt with brute force");
                Console.WriteLine("-1. Exit the program");
                menuInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (menuInput == 1)
                {
                    string alphabet = "abcdefghijklmnopqrstuvwxyz";
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        int num = alphabet[i];
                        Console.WriteLine(num);
                    }
                    Console.WriteLine();
                }
                else if (menuInput == 2)
                    Thousand();
                else if (menuInput == 3)
                    Caesar();
                else if (menuInput == 4)
                {
                    CaesarInput();
                    Console.WriteLine();
                }
                else if (menuInput == 5)
                {
                    CaesarDecrypt();
                }
                else if (menuInput == 6)
                    CaesarDecryptBruteForce();
            } while (menuInput != -1);
        }

        static void Thousand()
        {
            for (int i = 0; i < 13000; i++)
            {
                char myChar = (char)i;
                Console.Write(myChar + " ");
            }
            Console.WriteLine();
        }

        static void Caesar()
        {
            char e = 'e';
            int shift = -3;
            char shifted = (char)(e + shift);
            Console.WriteLine(shifted);
            Console.WriteLine();
        }

        static void CaesarInput()
        {
            Console.Write("Input a string to be encrypted: ");
            string input = Console.ReadLine();
            Console.Write("Enter a shift value: ");
            int shift = Convert.ToInt32(Console.ReadLine());
            string[] punc = new string[] { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "[", "{", "]", "}", ":", ";", "'", "'", ",", "<", ".", ">", "/", "?", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "_" };
            foreach (string item in punc)
            {
                input = input.Replace(item, "");
            }
            for (int i = 0; i < input.Length; i++)
            {
                char partInput = input[i];
                string upper = Convert.ToString(partInput);
                upper = upper.ToUpper();
                char capitalpart = Convert.ToChar(upper);
                if (partInput == capitalpart)
                {
                    char shifted = (char)(partInput + shift);
                    int shiftInt = (shifted);
                    if (shifted < 65)
                    {
                        shifted = (char)(shiftInt + 26);
                    }
                    else if (shifted > 90)
                    {
                        shifted = (char)(shiftInt - 26);
                    }
                    Console.Write(shifted);
                }
                else
                {
                    upper = upper.ToLower();
                    capitalpart = Convert.ToChar(upper);
                    char shifted = (char)(partInput + shift);
                    int shiftInt = (shifted);
                    if (shifted < 97)
                    {
                        shifted = (char)(shiftInt + 26);
                    }
                    else if (shifted > 122)
                    {
                        shifted = (char)(shiftInt - 26);
                    }
                    Console.Write(shifted);
                }
            }
            Console.WriteLine();
        }

        static void CaesarDecrypt()
        {
            Console.Write("Input a string to decrypt: ");
            string input = Console.ReadLine();
            Console.Write("Decrypt by how many shifts: ");
            int shift = Convert.ToInt32(Console.ReadLine());
            string[] punc = new string[] { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "[", "{", "]", "}", ":", ";", "'", "'", ",", "<", ".", ">", "/", "?", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "_" };
            foreach (string item in punc)
            {
                input = input.Replace(item, "");
            }
            for (int i = 0; i < input.Length; i++)
            {
                char partInput = input[i];
                string upper = Convert.ToString(partInput);
                upper = upper.ToUpper();
                char capitalpart = Convert.ToChar(upper);
                if (partInput == capitalpart)
                {
                    char shifted = (char)(partInput - shift);
                    int shiftInt = (shifted);
                    if (shifted < 65)
                    {
                        shifted = (char)(shiftInt + 26);
                    }
                    else if (shifted > 90)
                    {
                        shifted = (char)(shiftInt - 26);
                    }
                    Console.Write(shifted);
                }
                else
                {
                    upper = upper.ToLower();
                    capitalpart = Convert.ToChar(upper);
                    char shifted = (char)(partInput - shift);
                    int shiftInt = (shifted);
                    if (shifted < 97)
                    {
                        shifted = (char)(shiftInt + 26);
                    }
                    else if (shifted > 122)
                    {
                        shifted = (char)(shiftInt - 26);
                    }
                    Console.Write(shifted);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
        static void CaesarDecryptBruteForce()
        {
            Console.Write("Enter a string to decrypt by brute force: ");
            string input = Console.ReadLine();
            int shift = 0;
            string[] punc = new string[] { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "[", "{", "]", "}", ":", ";", "'", "'", ",", "<", ".", ">", "/", "?", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "_" };
            foreach (string item in punc)
            {
                input = input.Replace(item, "");
            }
            do
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char partInput = input[i];
                    string upper = Convert.ToString(partInput);
                    upper = upper.ToUpper();
                    char capitalpart = Convert.ToChar(upper);
                    if (partInput == capitalpart)
                    {
                        char shifted = (char)(partInput - shift);
                        int shiftInt = (shifted);
                        if (shifted < 65)
                        {
                            shifted = (char)(shiftInt + 26);
                        }
                        else if (shifted > 90)
                        {
                            shifted = (char)(shiftInt - 26);
                        }
                        Console.Write(shifted);
                    }
                    else
                    {
                        upper = upper.ToLower();
                        capitalpart = Convert.ToChar(upper);
                        char shifted = (char)(partInput - shift);
                        int shiftInt = (shifted);
                        if (shifted < 97)
                        {
                            shifted = (char)(shiftInt + 26);
                        }
                        else if (shifted > 122)
                        {
                            shifted = (char)(shiftInt - 26);
                        }
                        Console.Write(shifted);
                    }
                }
                Console.WriteLine();
                shift++;
            } while (shift != 26);
            Console.WriteLine();
        }
    }
}
