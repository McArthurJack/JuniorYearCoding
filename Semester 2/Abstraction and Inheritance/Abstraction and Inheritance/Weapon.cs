using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance.WeaponClasses
{
    abstract class Weapon
    {
        protected int weight;
        protected int size;
        protected bool isMetal;
        protected int damage;

        public Weapon(int weight, int size, bool isMetal, int damage)
        {
            this.weight = weight;
            this.size = size;
            this.isMetal = isMetal;
            this.damage = damage;
        }

        public abstract void DropSound();

        public abstract void StatsItem();
    }
}
