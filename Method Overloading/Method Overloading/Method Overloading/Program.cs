using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int[] array = new int[5];
            int[,] TwoArray = new int[3, 4];
            int[][] jagged = new int[5][];
            double f = Math.PI;
            Print(a);
            Print(array);
            Print(TwoArray);
            Print(jagged);
            Print(f);
            Console.ReadKey();
        }

        static void Print(int a)
        {
            Console.WriteLine("Integer 5");
            Console.WriteLine();
        }
        
        static void Print(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                array[i] = rand.Next(0,10);
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("| " + array[i] + " ");
            Console.WriteLine("|");
            Console.WriteLine();
        }

        static void Print(int[,] TwoArray)
        {
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    TwoArray[i, j] = rand.Next(0, 10);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("| " + TwoArray[i, j] + " ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Print(int[][] jagged)
        {
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                jagged[i] = new int[i * 4];
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = (i * j) * 3;
                }
            }
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Print(double f, float percision = 2)
        {
            string Val = "0.";
            for (int i = 0; i < percision; i++)
            {
                Val += "#";
            }
            Console.WriteLine(f.ToString(Val));
        }
    }
}
