using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        List<int> holder = new List<int>();

        public int DeQueue()
        {
            try
            {
                int temp = holder[0];
                holder.RemoveAt(0);
                return temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }

        public void EnQueue (int val)
        {
            holder.Add(val);
        }

        public int Peek()
        {
            try
            {
                int temp = holder[0];
                return temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }

        public void Print()
        {
            try
            {
                for (int i = holder.Count-1; i >= 0; i--)
                {
                    Console.Write(holder[i] + ", ");
                }
                Console.WriteLine();
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }

        public int Search(int val)
        {
            try
            {
                int temp = -1;
                int counter = 0;
                for (int i = 0; i < holder.Count; i++)
                {
                    if (val == holder[i])
                    {
                        temp = holder.Count()-counter-1;
                        break;
                    }
                    counter++;
                }
                return temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }
    }
}
