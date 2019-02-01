using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue<T> : IEmptyable, IPrintable, ICountable where T : IComparable
    {
        List<T> holder = new List<T>();

        public int Count()
        {
            return holder.Count();
        }

        public void Empty()
        {
            holder.Clear();
        }

        public void Print()
        {
            try
            {
                for (int i = holder.Count - 1; i >= 0; i--)
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

        public void EnQueue (T val)
        {
            holder.Add(val);
        }

        public T DeQueue()
        {
            try
            {
                T temp = holder[0];
                holder.RemoveAt(0);
                return temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }

        public T Peek()
        {
            try
            {
                T temp = holder[0];
                return temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }

        public int Search(T val)
        {
            try
            {
                int temp = -1;
                int counter = 0;
                for (int i = 0; i < holder.Count; i++)
                {
                    if (val.CompareTo(holder[i]) == 0)
                    {
                        temp = holder.Count() - counter - 1;
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
