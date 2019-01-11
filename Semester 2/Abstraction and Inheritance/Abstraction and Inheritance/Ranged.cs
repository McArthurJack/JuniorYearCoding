using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Ranged : Weapon
    {
        protected bool isAutomatic;
        protected int AmmoCapacity;
        protected bool isBullet;

        public Ranged(int weight, int size, bool isAutomatic, int AmmoCapacity, bool isBullet)
            : base(weight, size)
        {
            this.isAutomatic = isAutomatic;
            this.AmmoCapacity = AmmoCapacity;
            this.isBullet = isBullet;
        }
        //Need to make that go down. Ryan said he would help next class.
        public virtual void DropSound() { }
    }
}
