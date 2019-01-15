using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        List<int> holder = new List<int>();

        public int Pop()
        {
            try
            {
                int temp;
                int count = holder.Count();
                temp = holder[count-1];
                holder.Remove(temp);
                return temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }

        public void Push(int val)
        {
            holder.Add(val);
        }

        public int peek()
        {
            try
            {
                int count = holder.Count();
                int temp = holder[count - 1];
                return temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                throw e;
            }
        }

        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.Write(holder[i] + ", ");
            }
        }
    }
}
