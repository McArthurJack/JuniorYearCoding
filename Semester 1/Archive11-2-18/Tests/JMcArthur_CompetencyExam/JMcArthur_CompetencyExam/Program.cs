using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMcArthur_CompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int grade = 0;
            int readgrade = 0;
            int count = 0;
            int countupto = 0;
            int whileinput = -1;
            int sum = 0;
            int[] array = new int[10];
            int arrayinput = 0;
            List<string> stringlist = new List<string>();
            string stringinput = "";
            do
            {
                Console.WriteLine("***********************************************************");
                Console.WriteLine("Enter a number cooresponding to the action you want to make");
                Console.WriteLine("** 1. Conditionals");
                Console.WriteLine("** 2. For Loops");
                Console.WriteLine("** 3. While Loops");
                Console.WriteLine("** 4. Arrays");
                Console.WriteLine("** 5. Lists");
                Console.WriteLine("** -1. End the program");
                Console.WriteLine("***********************************************************");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.Write("Enter your grade: ");
                    grade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your reading grade level: ");
                    readgrade = Convert.ToInt32(Console.ReadLine());
                    if (grade >= 6 && grade <= 8)
                    {
                        if (grade <= readgrade)
                        {
                            Console.WriteLine("You are in middle school and you read at an appropriate level.");
                        }
                        else
                        {
                            Console.WriteLine("You don't read at an appropriate level. Go Study.");
                        }
                        Console.WriteLine();
                    }
                    if (grade >= 1 && grade <= 5)
                    {
                        if (grade <= readgrade)
                        {
                            Console.WriteLine("You are in elementary school and you read at an appropriate level.");
                        }
                        else
                        {
                            Console.WriteLine("You don't read at an appropriate level. Go Study.");
                        }
                        Console.WriteLine();
                    }
                    if (grade >= 9)
                    {
                        if (grade <= readgrade)
                        {
                            Console.WriteLine("You are in highschool school and you read at an appropriate level.");
                        }
                        else
                        {
                            Console.WriteLine("You don't read at an appropriate level. Go Study.");
                        }
                        Console.WriteLine();
                    }
                }
                else if (input == 2)
                {
                    Console.Write("Enter a number to count by: ");
                    count = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a number to count up to by " + count + ":");
                    countupto = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= countupto; i += count)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("Our sum starts at 0. Enter integer values to add to, and print the sum. Enter 0 to stop adding.");
                    while (whileinput != 0)
                    {
                        Console.Write("Enter a value: ");
                        whileinput = Convert.ToInt32(Console.ReadLine());
                        sum = sum + whileinput;
                        Console.WriteLine("New sum = " + sum);
                    }
                    Console.WriteLine("Exiting loop, your final sum = " + sum);
                }
                else if (input == 4)
                {
                    Console.WriteLine("You have an array of size 10 and of type int. Enter values to populate the array.");
                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayinput = Convert.ToInt32(Console.ReadLine());
                        array[i] = arrayinput;
                        Console.WriteLine("1 Successfully added!");
                    }
                    Console.WriteLine("All array values added. Here they are!");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("index " + i + " = " + array[i]);
                    }
                }
                else if (input == 5)
                {
                    Console.WriteLine("You have a list of type string. Enter values to add to the list.");
                    Console.WriteLine("Type end to stop adding and to print out your list.");
                    do
                    {
                        Console.Write("Enter a string: ");
                        stringinput = Console.ReadLine();
                        if (stringinput != "end")
                            stringlist.Add(stringinput);
                        else
                            break;
                    } while (stringinput != "end");
                    for (int i = 0; i < stringlist.Count(); i++)
                    {
                        Console.WriteLine("index " + i + " = " + stringlist[i]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            } while (input >= 0 && input < 6);
        }
    }
}
