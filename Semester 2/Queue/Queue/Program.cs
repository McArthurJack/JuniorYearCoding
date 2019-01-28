using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            Queue myQueue = new Queue();

            myQueue.EnQueue(8);
            myQueue.EnQueue(6);
            myInt = myQueue.Peek();
            myQueue.EnQueue(7);
            myInt = myQueue.DeQueue();
            myQueue.EnQueue(5);
            myQueue.EnQueue(3);
            myInt = myQueue.Peek();
            myQueue.EnQueue(0);
            myQueue.EnQueue(9);
            myInt = myQueue.DeQueue();
            myQueue.Print();
            myInt = myQueue.Search(9);
            Console.WriteLine(myInt);
        }
    }
}
