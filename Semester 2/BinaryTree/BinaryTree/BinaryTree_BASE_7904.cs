using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node Root;
        public int Height;
        public int count = 0;
        public int Count()
        {
            return CountRecursive(Root);
        }

        private int CountRecursive(Node cur)
        {
            if (cur.LeftChild == null && cur.RightChild == null)
                return count + 1;
            if (cur.LeftChild != null)
                CountRecursive(cur.LeftChild);
            if (cur.RightChild != null)
                CountRecursive(cur.RightChild);
            return count;
        }

        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }

        public void Insert(char val)
        {
            if (Root == null)
                Root = new Node(val);
            else
            {
                Insert(Root, val);
            }
        }

        private void Insert(Node cur, char val)
        {
            if (val >= cur.Value && cur.RightChild == null)
            {
                cur.RightChild = new Node(val);
                return;
            }
            if (val < cur.Value && cur.LeftChild == null)
            {
                cur.LeftChild = new Node(val);
                return;
            }

            if (val >= cur.Value)
            {
                Insert(cur.RightChild, val);
            }
            else if (val < cur.Value)
            {
                Insert(cur.LeftChild, val);
            }
        }

        public bool Remove(char val)
        {
            if (Root == null)
                return false;
            else
                return Remove(Root, val);
        }

        private bool Remove(Node cur, char val)
        {
            throw new NotImplementedException();
        }

        public bool Search(char val)
        {
            if (Root == null)
                return false;
            else
                return Search(Root, val);
        }

        private bool Search(Node cur, char val)
        {
            if (val == cur.Value)
            {
                return true;
            }
            if (val >= cur.Value && cur.RightChild != null)
            {
                Search(cur.RightChild, val);
            }
            if (val < cur.Value && cur.LeftChild != null)
            {
                Search(cur.LeftChild, val);
            }
            return false;
        }

        public void Balance()
        {

        }

        public void PreOrderPrint()
        {
            PreOrderPrint(Root);
        }

        private void PreOrderPrint(Node cur)
        {
            if (cur == null)
                return;
            Console.Write(cur.Value + " | ");
            PreOrderPrint(cur.LeftChild);
            PreOrderPrint(cur.RightChild);
        }

        public void InOrderPrint()
        {
            InOrderPrint(Root);
        }

        private void InOrderPrint(Node cur)
        {
            if (cur == null)
                return;
            InOrderPrint(cur.LeftChild);
            Console.Write(cur.Value + " | ");
            InOrderPrint(cur.RightChild);
        }

        public void PostOrderPrint()
        {
            PostOrderPrint(Root);
        }

        private void PostOrderPrint(Node cur)
        {
            if (cur == null)
                return;
            PostOrderPrint(cur.LeftChild);
            PostOrderPrint(cur.RightChild);
            Console.Write(cur.Value + " | ");
        }
    }
}
