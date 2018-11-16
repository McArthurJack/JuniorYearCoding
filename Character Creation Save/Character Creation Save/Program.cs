using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Character_Creation_Save
{
    class Program
    {
        public string Name;
        public int Strength;
        public int Dexterity;
        public int Happiness;
        public int Intelligence;
        public int Wealth;
        public int Points = 100;
        public int answer = 0;
        public List<Character> Characters = new List<Character>();

        static void Main(string[] args)
        {
            int answer;
            do
            {
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Modify a character");
                Console.WriteLine("3. Delete a character");
                Console.WriteLine("4. Loading existing characters");
                Console.WriteLine("5. List characters");
                Console.WriteLine("6. Exit");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    CreateCharacter();
                }
                if (answer == 2)
                {

                }
                if (answer == 3)
                {

                }
                if (answer == 4)
                {

                }
                if (answer == 5)
                {

                }
            } while (answer != 6);
        }

        Character CreateCharacter()
        {
            Console.Write("Create name of your Character");
            Name = Console.ReadLine();
            do
            {
                Points = Points + answer;
                Console.WriteLine("You have 100 Stat points for all of your 5 Attributes");
                Thread.Sleep(1000);
                Console.Write("Set the Strength of " + Name);
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer >= 0);
            Points = Points - answer;
            Strength = answer;
            do
            {
                if (Points - answer > 0)
                    Points += answer;
                Console.WriteLine("Set the Dexterity of " + Name);
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer >= 0);
            Points -= answer;
            Dexterity = answer;
            do
            {
                if (Points - answer > 0)
                    Points += answer;
                Console.WriteLine("Set the Happiness of " + Name);
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer >= 0);
            Points -= answer;
            Happiness = answer;
            do
            {
                if (Points - answer > 0)
                    Points += answer;
                Console.WriteLine("Set the Intelligence of " + Name);
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer >= 0);
            do
            {
                if (Points - answer > 0)
                    Points += answer;
                Console.WriteLine("Set the Wealth of " + Name);
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer >= 0);
            Console.WriteLine("You have " + Points + " unused.");
            Character Wow = new Character(Name, Strength, Dexterity, Happiness, Intelligence, Wealth);
            SaveCharacter(Wow);
            Characters.Add(Wow);
            return Wow;
        }

        void ModifyCharacter(Character character)
        {

        }

        void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "@" + Name + ".txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(Name);
                sw.WriteLine(Strength);
                sw.WriteLine(Dexterity);
                sw.WriteLine(Happiness);
                sw.WriteLine(Intelligence);
                sw.WriteLine(Wealth);
            }
        }

        bool DeleteCharacter(List<Character> characters, string characterName)
        {
            bool delete = false;

            if (File.Exists(Name + ".txt"))
                delete = true;
            else
                delete = false;
            return delete;
        }

        Character LoadCharacter(string characterName)
        {

            return ;
        }

        List<Character> LoadCharacters()
        {

        }

        void ListCharacters(List<Character> characters)
        {

        }
    }
}
