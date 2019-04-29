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
            BinaryTree<bool> tree = new BinaryTree<bool>();
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                if (rand.Next(0, 2) == 0)
                    tree.Insert(false);
                else
                    tree.Insert(true);
                tree.Balance();
            }
            tree.Print();
        }
    }
}
