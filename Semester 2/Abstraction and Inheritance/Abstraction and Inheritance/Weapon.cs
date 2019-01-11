using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    abstract class Weapon
    {
        protected int weight;
        protected int size;
        protected bool isMetal;

        public Weapon(int weight, int size)
        {
            this.weight = weight;
            this.size = size;
        }

        public abstract void DropSound();
    }
}
