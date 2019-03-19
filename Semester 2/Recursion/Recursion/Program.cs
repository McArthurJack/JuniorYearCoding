using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
                integers.Add(rand.Next(0, 1000));
            integers.Sort();
            Console.WriteLine(SearchIntList(integers, 1));
            Console.WriteLine(CheckForPrime(97));
        }

        public static bool SearchIntList(List<int> integers, int n)
        {
            return SearchIntListRecursive(integers, n, 0, integers.Count - 1);
        }

        private static bool SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
        {
            if (lowerBound >= upperBound)
                return false;
            int midpoint = (upperBound + lowerBound) / 2;
            if (integers[midpoint] == n)
                return true;
            if (lowerBound + 1 == upperBound)
                return false;
            if (integers[midpoint] > n)
                return SearchIntListRecursive(integers, n, lowerBound, midpoint);
            if (integers[midpoint] < n)
                return SearchIntListRecursive(integers, n, midpoint, upperBound);
            return false;
        }

        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static bool CheckForPrime(int n, int divisor = 3)
        {
            if (n % 2 == 0)
                return false;
            if (n % divisor == 0)
                return false;
            else if (divisor >= n-1)
                return true;
            return CheckForPrime(n, divisor + 2);
        }
    }
}
