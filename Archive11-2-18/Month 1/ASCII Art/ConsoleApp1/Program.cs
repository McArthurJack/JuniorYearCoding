using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string answer = "";
            do
            {
                Console.WriteLine("*********************************");
                Console.WriteLine("*1. 1 by 1 Square               *");
                Console.WriteLine("*2. 3 by 3 Square               *");
                Console.WriteLine("*3. 5 by 5 Square               *");
                Console.WriteLine("*4. Left Triangle               *");
                Console.WriteLine("*5. Right Triangle              *");
                Console.WriteLine("*6. Start a loading Screen      *");
                Console.WriteLine("*7. Special 1                   *");
                Console.WriteLine("*8. Special 2                   *");
                Console.WriteLine("*9. Special 3                   *");
                Console.WriteLine("*10. Another Square             *");
                Console.WriteLine("*11. Indented Square            *");
                Console.WriteLine("*12. Exit the program           *");
                Console.WriteLine("*********************************");
                answer = Console.ReadLine();
                Console.WriteLine();
                if (answer == "1")
                    Console.WriteLine("X");
                else if (answer == "2")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == "3")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == "4")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j-1 < i; j++)
                            Console.Write("X");
                            Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                else if (answer == "5")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                            if (j+i+1 < 5)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                else if (answer == "6")
                {
                    for (int i = 0; i < 60; i++)
                    {
                        for (int j = 0; j < 60-i; j++)
                        { 
                            Console.Write(" ");
                        }
                        for (int k = 0; i * 2 + 1 > k; k++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == "7")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == "8")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == "9")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == j || 4 - j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == "10")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0;j < 13; j++)
                        {
                            if (i == 0 || i == 6 || j == 0 || j == 12)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == "11")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 13; j++)
                        {
                            if (i == 0 || i == 6 || j == 0 || j == 12)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            } while (answer != "12");
        }
    }
}