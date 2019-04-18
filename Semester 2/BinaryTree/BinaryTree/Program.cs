using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert('h');
            tree.Insert('b');
            tree.Insert('j');
            tree.Insert('x');
            tree.Insert('q');
            tree.Insert('r');
            tree.Insert('g');
            tree.Print();
            Console.WriteLine(tree.Count());
        }
    }
}
