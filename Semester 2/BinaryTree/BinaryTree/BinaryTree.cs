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

        public int Height()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return CountRecursive(Root);
        }

        private int CountRecursive(Node cur)
        {
            int count = 1;
            if (cur.LeftChild != null)
                count += CountRecursive(cur.LeftChild);
            if (cur.RightChild != null)
                count += CountRecursive(cur.LeftChild);
            if (cur.LeftChild == null && cur.RightChild == null)
                return count;
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

        public void Remove(char val)
        {
            if (Search(val) == false)
            {
            }
            else
                Remove(Root, val);
        }

        private Node Remove(Node cur, char val)
        {
            if (val < cur.Value)
                cur.LeftChild = Remove(cur.LeftChild, val);
            else if (val > cur.Value)
                cur.RightChild = Remove(cur.RightChild, val);
            else
            {
                if (cur.LeftChild == null)
                    return cur.RightChild;
                else if (cur.RightChild == null)
                    return cur.LeftChild;
                Node min = cur.RightChild;
                char minValue = min.Value;
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

        public void Balance()
        {
            buildTree(Root);
        }

        public virtual void storeBSTNodes(Node cur, List<Node> nodes)
        {
            if (cur == null)
                return;

            storeBSTNodes(cur.LeftChild, nodes);
            nodes.Add(cur);
            storeBSTNodes(cur.RightChild, nodes);
        }

        public virtual Node buildTreeUtil(List<Node> nodes, int start, int end)
        {
            if (start > end)
                return null;
            int mid = (start + end) / 2;
            Node node = nodes[mid];

            node.LeftChild = buildTreeUtil(nodes, start, mid - 1);
            node.RightChild = buildTreeUtil(nodes, mid + 1, end);

            return node;
        }

        public virtual Node buildTree(Node cur)
        {
            List<Node> nodes = new List<Node>();
            storeBSTNodes(cur, nodes);

            int n = nodes.Count();
            return buildTreeUtil(nodes, 0, n - 1);
        }
    }
}
