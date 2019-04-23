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
            Random rand = new Random();
            for (int i = 0; i < 64; i++)
            {
                tree.Insert((char)rand.Next(65, 91));
            }
            tree.Balance();
            tree.Print();
            tree.PreOrderPrint();
        }
    }
}
