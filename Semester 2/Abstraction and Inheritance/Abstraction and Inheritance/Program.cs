using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_and_Inheritance.WeaponClasses;

namespace Abstraction_and_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> inventory = new List<Weapon>();
            inventory.Add(new Firearm(5, 1, true, 100, true, 100, true, ".45 ACP"));
            inventory.Add(new Bow(1, 1, false, 100, false, 1, false, true, true));
            inventory.Add(new RangedMelee(2, 10, true, 10000000, true, 100000, true, 100000, true, 0));
            inventory.Add(new Sword(2, 2, true, 999999999, true, 2, false, 1000, true, 10));

            Console.WriteLine("Press any key to drop a mysterious weapon");
            Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            for (int i = 0; i < inventory.Count; i++)
            {
                inventory[i].DropSound();
                inventory[i].StatsItem();
                Console.WriteLine();
                Console.WriteLine("Press any key to move onto the next item");
                Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
