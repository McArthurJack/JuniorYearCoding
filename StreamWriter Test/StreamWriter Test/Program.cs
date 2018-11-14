using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            Random rand = new Random();
            do
            {
                Console.Clear();
                Console.WriteLine("1. Save a random Array to a file");
                Console.WriteLine("2. Save a random 2D Array to a file");
                Console.WriteLine("3. Load a random Array from a file");
                Console.WriteLine("4. Load a random 2D Array from a file");
                Console.WriteLine("5. End the program....");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                    SingleArray(rand);
                if (answer == 2)
                    DoubleArray(rand);
                if (answer == 3)
                    LoadArray();
                if (answer == 4)
                    LoadDouble();
            } while (answer != 5);
        }

        static void SingleArray(Random rand)
        {
            int[] intArray = new int[10];
            string path = AppDomain.CurrentDomain.BaseDirectory + @"WrittenFile.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = rand.Next(10,100);
                    sw.WriteLine(intArray[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("File Saved! Press any key to continue");
            Console.ReadLine();
        }

        static void DoubleArray(Random rand)
        {
            string path2 = AppDomain.CurrentDomain.BaseDirectory + @"WrittenFile2.txt";
            using (StreamWriter sw2 = new StreamWriter(path2))
            {
                int[,] TwoArray = new int[10, 10];
                for (int i = 0; i < TwoArray.GetLength(0); i++)
                {
                    for (int j = 0; j < TwoArray.GetLength(1); j++)
                    {
                        TwoArray[i, j] = rand.Next(10, 100);
                        sw2.Write(TwoArray[i, j] + "\n");
                    }
                    sw2.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("File Saved! Press any key to continue");
            Console.ReadLine();
        }

        static void LoadArray()
        {
            int[] array = new int[10];
            Console.WriteLine();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"WrittenFile.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Convert.ToInt32(sr.ReadLine());
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press anything to continue");
            Console.ReadLine();
        }

        static void LoadDouble()
        {
            int[,] DoubleArray = new int[10, 10];
            Console.WriteLine();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"WrittenFile2.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        DoubleArray[i, j] = Convert.ToInt32(sr.ReadLine());
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(DoubleArray[i, j]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press anything to continue");
            Console.ReadLine();
        }
    }
}