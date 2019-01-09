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
        List<int> Number = new List<int>();
        //Task task1 = Task.Factory.StartNew(A);
        //Task task2 = Task.Factory.StartNew(B);
        A(Number);
        //Parallel.Invoke(A, B);
        Console.ReadKey();
    }

    static void A(List<int> Number)
    {
        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.Write(Number[i] + ", ");
        //    }
        Parallel.For(0, 1000, k =>
        {
            Console.Write(k + ", ");
        });
    }
}

//    static void B(List<int> number )
//    {
//        for (int i = 51; i < 100; i++)
//        {
//            Console.Write(prime2[i] + ", ");
//        }
//    }
//}