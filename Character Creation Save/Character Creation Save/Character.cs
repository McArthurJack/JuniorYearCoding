using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Character_Creation_Save
{
    class Character
    {
        public string Name;
        public int Strength;
        public int Dexterity;
        public int Happiness;
        public int Intelligence;
        public int Wealth;
        public int Points = 100;
        public int answer = 0;

        public Character(string Name, int Strength, int Dexterity, int Happiness, int Intelligence, int Wealth)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Happiness = Happiness;
            this.Intelligence = Intelligence;
            this.Wealth = Wealth;
        }
    }
}
