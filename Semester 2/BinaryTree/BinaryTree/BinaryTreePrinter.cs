using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTreePrinter <T> where T : IComparable<T>
    {
        public static void printNode(Node<T> root)
        {
            int maxLevel = BinaryTreePrinter<T>.maxLevel(root);

            printNodeInternal(new List<Node<T>>() { root }, 1, maxLevel);
        }

        private static void printNodeInternal(List<Node<T>> nodes, int level, int maxLevel)
        {
            if (nodes.Count == 0 || BinaryTreePrinter<T>.isAllElementsNull(nodes))
                return;

            int floor = maxLevel - level;
            int endgeLines = (int)Math.Pow(2, (Math.Max(floor - 1, 0)));
            int firstSpaces = (int)Math.Pow(2, (floor)) - 1;
            int betweenSpaces = (int)Math.Pow(2, (floor + 1)) - 1;

            BinaryTreePrinter<T>.printWhitespaces(firstSpaces);

            List<Node<T>> newNodes = new List<Node<T>>();
            foreach (var node in nodes)
            {
                if (node != null)
                {
                    Console.Write(node.Value);
                    newNodes.Add(node.LeftChild);
                    newNodes.Add(node.RightChild);
                }
                else
                {
                    newNodes.Add(null);
                    newNodes.Add(null);
                    Console.Write(" ");
                }

                BinaryTreePrinter<T>.printWhitespaces(betweenSpaces);
            }
            Console.WriteLine("");

            for (int i = 1; i <= endgeLines; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    BinaryTreePrinter<T>.printWhitespaces(firstSpaces - i);
                    if (nodes[j] == null)
                    {
                        BinaryTreePrinter<T>.printWhitespaces(endgeLines + endgeLines + i + 1);
                        continue;
                    }

                    if (nodes[j].LeftChild != null)
                        Console.Write("/");
                    else
                        BinaryTreePrinter<T>.printWhitespaces(1);

                    BinaryTreePrinter<T>.printWhitespaces(i + i - 1);

                    if (nodes[j].RightChild != null)
                        Console.Write("\\");
                    else
                        BinaryTreePrinter<T>.printWhitespaces(1);

                    BinaryTreePrinter<T>.printWhitespaces(endgeLines + endgeLines - i);
                }

                Console.WriteLine("");
            }

            printNodeInternal(newNodes, level + 1, maxLevel);
        }

        private static void printWhitespaces(int count)
        {
            for (int i = 0; i < count; i++)
                Console.Write(" ");
        }

        private static int maxLevel(Node<T> node)
        {
            if (node == null)
                return 0;

            return Math.Max(BinaryTreePrinter<T>.maxLevel(node.LeftChild), BinaryTreePrinter<T>.maxLevel(node.RightChild)) + 1;
        }

        private static bool isAllElementsNull(List<Node<T>> list)
        {
            foreach (var node in list)
            {
                if (node != null)
                    return false;
            }
            return true;
        }
    }
}
