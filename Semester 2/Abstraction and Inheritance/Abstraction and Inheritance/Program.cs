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
            
            for (int i = 0; i < inventory.Count; i++)
            {
                inventory[i].DropSound();
                inventory[i].StatsItem();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
