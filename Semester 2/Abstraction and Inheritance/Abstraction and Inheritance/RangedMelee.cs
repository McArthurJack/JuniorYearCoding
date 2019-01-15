using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance.WeaponClasses
{
    class RangedMelee : Melee
    {
        protected bool isReuseable;
        protected int StrengthRequired;

        public RangedMelee(int weight, int size, bool isMetal, int damage, bool isPosion, int bladelength, bool isDual, int sharpness, bool isReuseable, int StrengthRequired)
            : base(weight, size, isMetal, damage, isPosion, bladelength, isDual, sharpness)
        {
            this.isReuseable = isReuseable;
            this.StrengthRequired = StrengthRequired;
        }

        public override void DropSound()
        {
            Console.WriteLine("RANGED MELEE WEAPON DROPPED");
        }

        public override void StatsItem()
        {
            MeleeStats();
            string temp = "";
            if (isReuseable == false)
                temp = "is not";
            else
                temp = "is";
            Console.WriteLine("The ranged melee weapon " + temp + " reusable.");
            Console.WriteLine("The strength required to use the melee weapon " + StrengthRequired + ".");
        }
    }
}
