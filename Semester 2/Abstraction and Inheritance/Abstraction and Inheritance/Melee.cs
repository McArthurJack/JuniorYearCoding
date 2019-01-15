using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance.WeaponClasses
{
    abstract class Melee : Weapon
    {
        protected bool isPosion;
        protected int bladelength;
        protected bool isDual;
        protected int sharpness;

        public Melee(int weight, int size, bool isMetal, int damage, bool isPosion, int bladelength, bool isDual, int sharpness)
            : base(weight, size, isMetal, damage)
        {
            this.isPosion = isPosion;
            this.bladelength = bladelength;
            this.isDual = isDual;
            this.sharpness = sharpness;
        }

        public virtual void MeleeStats()
        {
            string temp;
            if (isMetal == false)
                temp = "is not";
            else
                temp = "is";
            Console.WriteLine("The weight of your melee weapon is " + weight + ".");
            Console.WriteLine("The size of your melee weapon is " + size + ".");
            Console.WriteLine("The melee weapon " + temp + " metal.");
            Console.WriteLine("The damage of your melee weapon is " + damage + ".");
            if (isPosion == false)
                temp = "is not";
            else
                temp = "is";
            Console.WriteLine("The melee weapon " + temp + " posioned.");
            Console.WriteLine("The lenght of the blade is " + bladelength);
            if (isDual == false)
                temp = "is not";
            else
                temp = "is";
            Console.WriteLine("The melee weapon " + temp + " dual wield.");
            Console.WriteLine("The sharpness of the melee weapon is " + sharpness + ".");
        }

        public override void DropSound() { }

        public override void StatsItem() { }
    }
}
