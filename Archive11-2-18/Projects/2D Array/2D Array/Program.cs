using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] multiDimensionalArray = new int[10, 5];
            //for (int i = 0; i < multiDimensionalArray.GetLength(0);i++)
            //{
            //    for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
            //    {
            //        multiDimensionalArray[i, j] = i * j;
            //    }
            //}
            //for (int i = 0; i < (multiDimensionalArray.GetLength(1)*5-1); i++)
            //{
            //    Console.Write("_");
            //}
            //Console.WriteLine();
            //PrintArray(multiDimensionalArray);
            //for (int i = 0; i < (multiDimensionalArray.GetLength(1) * 5 - 1); i++)
            //{
            //    Console.Write("_");
            //}

            int[][] jaggedArray = new int[15][];
            for (int i = 0; i < jaggedArray.GetLength(0); i++) //Jonny has big dumnb
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }
            }
            PrintJagged(jaggedArray);
            Console.ReadLine();
        }

        static void PrintJagged(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    if (jaggedArray[i][j] < 10)
                    {
                        Console.Write(jaggedArray[i][j] + "   | ");
                    }
                    else if (jaggedArray[i][j] < 100)
                    {
                        if (jaggedArray[i][j] > 9)
                        Console.Write(jaggedArray[i][j] + "  | ");
                    }
                    else
                    {
                        Console.Write(jaggedArray[i][j] + " | ");
                    }
                }
                Console.WriteLine();
            }
        }




        static void PrintArray(int[,] multiDimensionalArray)
        {
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    if (multiDimensionalArray[i, j] < 10)
                    {
                        Console.Write(" " + multiDimensionalArray[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(multiDimensionalArray[i, j] + " | ");
                    }      
                }
                Console.WriteLine();
            }
        }
    }
}
