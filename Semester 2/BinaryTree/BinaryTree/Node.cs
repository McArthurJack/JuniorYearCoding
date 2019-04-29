using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node <T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }
        public int Height
        {
            get
            {
                int leftTreeHeight = 0;
                int rightTreeHeight = 0;

                if (LeftChild != null)
                    leftTreeHeight = LeftChild.Height + 1;
                if (RightChild != null)
                    rightTreeHeight = RightChild.Height + 1;

                if (leftTreeHeight > rightTreeHeight)
                    return leftTreeHeight;
                else
                    return rightTreeHeight;
            }
        }

        public Node(T val)
        {
            Value = val;
        }
    }
}
