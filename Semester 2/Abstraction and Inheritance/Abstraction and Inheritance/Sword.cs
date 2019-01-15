using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance.WeaponClasses
{
    class Sword : Melee
    {
        protected bool isRelic;
        protected int AgilityRequired;

        public Sword(int weight, int size, bool isMetal, int damage, bool isPosion, int bladelength, bool isDual, int sharpness, bool isRelic, int AgilityRequired)
            : base (weight, size, isMetal, damage, isPosion, bladelength, isDual, sharpness)
        {
            this.isRelic = isRelic;
            this.AgilityRequired = AgilityRequired;
        }

        public override void DropSound()
        {
            Console.WriteLine("COOL SWORD DROPPED");
            MeleeStats();
            string temp;
            if (isRelic == false)
                temp = "is not";
            else
                temp = "is";
            Console.WriteLine("The melee weapon " + temp +" a relic.");
            Console.WriteLine("The agility required is " + AgilityRequired + ".");
        }
    }
}
