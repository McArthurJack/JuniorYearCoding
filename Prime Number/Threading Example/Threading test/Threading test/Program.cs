using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task1 = Task.Factory.StartNew(A);
        Task task2 = Task.Factory.StartNew(B);
        Parallel.Invoke(A, B);
        Console.ReadKey();
    }

    static void A()
    {
        List<int> prime1 = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            prime1.Add(i);
        }
        for (int i = 0; i < 50; i++)
        {
            Console.Write(prime1[i] + ", ");
        }
    }

    static void B()
    {
        List<int> prime2 = new List<int>();
        for (int i = 1; i < 101; i++)
        {
            prime2.Add(i);
        }
        for (int i = 51; i < 100; i++)
        {
            Console.Write(prime2[i] + ", ");
        }
    }
}