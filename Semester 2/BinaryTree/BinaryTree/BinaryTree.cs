using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree <T> where T : IComparable<T>
    {
        private Node<T> Root;

        public int Height()
        {
            return Root.Height;
        }

        public int Count()
        {
            return CountRecursive(Root);
        }

        private int CountRecursive(Node<T> cur)
        {
            int count = 1;
            if (cur.LeftChild != null)
                count = count + CountRecursive(cur.LeftChild);
            if (cur.RightChild != null)
                count += CountRecursive(cur.LeftChild);
            if (cur.LeftChild == null && cur.RightChild == null)
                return count;
            return count;
        }

        public void Print()
        {
            BinaryTreePrinter<T>.printNode(Root);
        }

        public void Insert(T val)
        {
            if (Root == null)
                Root = new Node<T>(val);
            else
            {
                Insert(Root, val);
            }
        }

        private void Insert(Node<T> cur, T val)
        {
            if (val.CompareTo(cur.Value) >= 0 && cur.RightChild == null)
            {
                cur.RightChild = new Node<T>(val);
                return;
            }
            if (val.CompareTo(cur.Value) < 0 && cur.LeftChild == null)
            {
                cur.LeftChild = new Node<T>(val);
                return;
            }

            if (val.CompareTo(cur.Value) >= 0)
            {
                Insert(cur.RightChild, val);
            }
            else if (val.CompareTo(cur.Value) < 0)
            {
                Insert(cur.LeftChild, val);
            }
        }

        public void Remove(T val)
        {
            if (Search(val) == false)
            {
            }
            else
                Remove(Root, val);
        }

        private Node<T> Remove(Node<T> cur, T val)
        {
            if (val.CompareTo(cur.Value) < 0)
                cur.LeftChild = Remove(cur.LeftChild, val);
            else if (val.CompareTo(cur.Value) > 0)
                cur.RightChild = Remove(cur.RightChild, val);
            else
            {
                if (cur.LeftChild == null)
                    return cur.RightChild;
                else if (cur.RightChild == null)
                    return cur.LeftChild;
                Node<T> min = cur.RightChild;
                T minValue = min.Value;
                while (min.LeftChild != null)
                {
                    minValue = min.LeftChild.Value;
                    min = min.LeftChild;
                }
                cur.Value = minValue;
                cur.RightChild = Remove(Root.RightChild, Root.Value);
            }
            return cur;
        }

        public bool Search(T val)
        {
            if (Root == null)
                return false;
            else
                return Search(Root, val);
        }

        private bool Search(Node<T> cur, T val)
        {
            if (val.CompareTo(cur.Value) == 0)
            {
                return true;
            }
            if (val.CompareTo(cur.Value) >= 0 && cur.RightChild != null)
            {
                Search(cur.RightChild, val);
            }
            if (val.CompareTo(cur.Value) < 0 && cur.LeftChild != null)
            {
                Search(cur.LeftChild, val);
            }
            return false;
        }

        public void PreOrderPrint()
        {
            PreOrderPrint(Root);
        }

        private void PreOrderPrint(Node<T> cur)
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

        private void InOrderPrint(Node<T> cur)
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

        private void PostOrderPrint(Node<T> cur)
        {
            if (cur == null)
                return;
            PostOrderPrint(cur.LeftChild);
            PostOrderPrint(cur.RightChild);
            Console.Write(cur.Value + " | ");
        } 

        public void Balance()
        {
            Root = buildTree(Root);
        }

        public virtual void storeBSTNodes(Node<T> cur, List<Node<T>> nodes)
        {
            if (cur == null)
                return;

            storeBSTNodes(cur.LeftChild, nodes);
            nodes.Add(cur);
            storeBSTNodes(cur.RightChild, nodes);
        }

        public virtual Node<T> buildTreeUtil(List<Node<T>> nodes, int start, int end)
        {
            if (start > end)
                return null;
            int mid = (start + end) / 2;
            Node<T> node = nodes[mid];

            node.LeftChild = buildTreeUtil(nodes, start, mid - 1);
            node.RightChild = buildTreeUtil(nodes, mid + 1, end);

            return node;
        }

        public virtual Node<T> buildTree(Node<T> cur)
        {
            List<Node<T>> nodes = new List<Node<T>>();
            storeBSTNodes(cur, nodes);

            int n = nodes.Count();
            return buildTreeUtil(nodes, 0, n - 1);
        }
    }
}
