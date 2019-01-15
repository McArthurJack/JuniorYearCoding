using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance.WeaponClasses
{
    class Bow : Ranged
    {
        protected bool isArrowOnFire;
        protected bool isStone;

        public Bow(int weight, int size, bool isMetal, int damage, bool isAutomatic, int AmmoCapacity, bool isBullet, bool isArrowOnFire, bool isStone)
            :base (weight, size, isMetal, damage, isAutomatic, AmmoCapacity, isBullet)
        {
            this.isArrowOnFire = isArrowOnFire;
            this.isStone = isStone;
        }

        public override void DropSound()
        {
            Console.WriteLine("SHINY BOW DROPPED");
        }

        public override void StatsItem()
        {
            RangedStats();
            string temp = "";
            if (isArrowOnFire == false)
                temp = "not ";
            Console.WriteLine("Your arrow is " + temp + "on fire.");
            temp = "";
            if (isStone == false)
                temp = "not ";
            Console.WriteLine("The arrow is " + temp + "made of stone.");
        }
    }
}
