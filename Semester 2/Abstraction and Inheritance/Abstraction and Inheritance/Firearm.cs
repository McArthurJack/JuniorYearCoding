using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance.WeaponClasses
{
    class Firearm : Ranged
    {
        protected string caliber;

        public Firearm(int weight, int size, bool isMetal, int damage, bool isAutomatic, int AmmoCapacity, bool isBullet, string caliber)
            :base (weight, size, isMetal, damage,isAutomatic, AmmoCapacity, isBullet)
        {
            this.caliber = caliber;
        }

        public override void DropSound()
        {
            Console.WriteLine("Wow. Pepega Firearm dropped.");
        }

        public override void StatsItem()
        {
            RangedStats();
            Console.WriteLine("The caliber is " + caliber);
        }
    }
}
