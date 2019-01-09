using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Watergun
    {
        public float Capacity = 0.8f;
        public bool IsWet = false;
        public Random rand = new Random();
        public float amount = 0f;

        public bool Shoot(float amount)
        {
            if (Capacity > 0)
            {
                Capacity -= amount;
                float percentChance = (amount * .2f) * .2f;
                if (rand.NextDouble() < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Refill(float Capacity)
        {
            if (Capacity >= 100)
            {
                Console.WriteLine("You can't refill your water gun is full.");
            }
            else
            {
                Capacity = Capacity + 0.2f;
            }
            if (Capacity > .8f)
                Capacity = .8f;
        }
    }
}
