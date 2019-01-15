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

        public override void DropSound() { }

        public override void StatsItem() { }
    }
}
