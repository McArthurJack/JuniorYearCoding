﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFinderSQL();
            Console.ReadLine();
        }

        static void Intersect()
        {
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            List<int> l3 = new List<int>();

            l3 = l1.Intersect(l2).ToList();

            l3.ForEach(t =>
            {
                Console.Write(t + " ");
            });
        }

        static void Greater()
        {
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = new List<int>();

            l2 = l1.Where(t => t >= 5).ToList();
            l2 = l2.OrderByDescending(t => t).ToList();

            l2.ForEach(t =>
            {
                Console.Write(t + " ");
            });
        }

        static void Palindrome()
        {
            string wow = "tacocat";
            wow = wow.ToLower();

            if (wow == Convert.ToString(wow.Reverse()))
                Console.WriteLine("Its a palindrome.");
            else
                Console.WriteLine("Its not a palindrome.");
        }

        static void PrimeFinderSQL()
        {
            List<int> Prime = new List<int>() { 2, 3, 5, 7, 11};
            List<int> Test = new List<int>();

            for (int j = 0; j < 3; j++)
            {
                for (int i = Prime[Prime.Count-1] + 1; i < Math.Pow(Prime[Prime.Count - 1], 2); i++)
                    Test.Add(i);
                Test = Test.Where(t => !Prime.Any(b => t % b == 0)).ToList();
                Prime = Prime.Concat(Test).ToList();
            }

            //Prime.ForEach(t =>
            //{
            //    Console.Write(t + " ");
            //});
            Console.WriteLine(Prime[Prime.Count - 1]);
            Console.WriteLine(Prime.Count);
        }

        static void PrimeFinder()
        {

            List<int> Prime = new List<int>() { 2, 3, 5, 7, 11 };
            List<int> Test = new List<int>();
            int counter = 0;
            int counter1 = 0;

            for (int j = 0; j < 2; j++)
            {
                Test.Clear();
                for (int i = Prime[Prime.Count - 1] + 1; i < Math.Pow(Prime[Prime.Count - 1], 2); i++)
                    Test.Add(i);
                for (int i = 0; i < Test.Count; i++)
                {
                    for (int p = 0; p < Prime.Count; p++)
                    {
                        if (Test[i] % Prime[p] != 0)
                        {
                            counter++;
                            counter1++;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    if (counter == counter1)
                        Prime.Add(Test[i]);
                }
            }

            Prime.ForEach(t =>
            {
                Console.Write(t + " ");
            });
        }
    }
}
