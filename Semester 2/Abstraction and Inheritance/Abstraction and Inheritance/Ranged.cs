using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance.WeaponClasses
{
    abstract class Ranged : Weapon
    {
        protected bool isAutomatic;
        protected int AmmoCapacity;
        protected bool isBullet;

        public Ranged(int weight, int size, bool isMetal, int damage, bool isAutomatic, int AmmoCapacity, bool isBullet)
            : base(weight, size, isMetal, damage)
        {
            this.isAutomatic = isAutomatic;
            this.AmmoCapacity = AmmoCapacity;
            this.isBullet = isBullet;
        }

        public virtual void RangedStats()
        {
            string temp;
            if (isMetal == false)
                temp = "is not";
            else
                temp = "is";
            Console.WriteLine("The weight of your ranged weapon is " + weight + ".");
            Console.WriteLine("The size of your ranged weapon is " + size + ".");
            Console.WriteLine("The ranged weapon " + temp + " metal.");
            Console.WriteLine("The damage of your ranged weapon is " + damage + ".");
            temp = "";
            if (isAutomatic == false)
                temp = "is not";
            else
                temp = "is";
            Console.WriteLine("The ranged weapon " + temp + " metal.");
            Console.WriteLine("The ranged weapons Ammo capacity is " + AmmoCapacity);
            if (isBullet == false)
                temp = "does not";
            else
                temp = "does";
            Console.WriteLine("The ranged weapon " + temp + " use bullets.");
        }

        public override void DropSound() { }

        public override void StatsItem() { }
    }
}
