using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Character_Creation_Save
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Player = new Character("4head", 10, 10, 10, 10, 10);
            int answer = 0;
            do
            {
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Modify a character");
                Console.WriteLine("3. Delete a character");
                Console.WriteLine("4. Loading existing character");
                Console.WriteLine("5. Print Character");
                Console.WriteLine("5. Exit");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    CreateCharacter();
                }
                if (answer == 2)
                {
                    ModifyCharacter(Player);
                }
                if (answer == 3)
                {
                    
                }
                if (answer == 4)
                {

                }
                if (answer == 5)
                {
                    PrintCharacter(Player);
                }
                Console.WriteLine();
            } while (answer != 6);
        }

        static Character CreateCharacter()
        {
            Console.WriteLine();
        string Name;
        int Strength = 0;
        int Dexterity = 0;
        int Happiness = 0;
        int Intelligence = 0;
        int Wealth = 0;
        int Points = 100;
        int answer = 0;
        Console.Write("Create name of your Character: ");
            Name = Console.ReadLine();
            do
            {
                Points = Points - answer;
                Console.WriteLine("You have 100 Stat points for all of your 5 Attributes");
                Console.Write("Set the Strength of " + Name + ": ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer < 0);
            Points = Points - answer;
            Strength = answer;
            do
            {
                Console.WriteLine("You have " + Points + " remaining");
                Console.Write("Set the Dexterity of " + Name + ": ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer < 0);
            Points -= answer;
            Dexterity = answer;
            do
            {
                Console.WriteLine("You have " + Points + " remaining");
                Console.Write("Set the Happiness of " + Name + ": ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer < 0);
            Points -= answer;
            Happiness = answer;
            do
            {
                Console.WriteLine("You have " + Points + " remaining");
                Console.Write("Set the Intelligence of " + Name + ": ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer < 0);
            Points -= answer;
            do
            {
                Console.WriteLine("You have " + Points + " remaining");
                Console.Write("Set the Wealth of " + Name + ": ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (Points - answer < 0);
            Points -= answer;
            Console.WriteLine("You have " + Points + " unused.");
            Character Player = new Character(Name, Strength, Dexterity, Happiness, Intelligence, Wealth);
            SaveCharacter(Player);
            return Player;
        }

        static void ModifyCharacter(Character character)
        {

        }

        static void SaveCharacter(Character character)
        {
            string Name = character.Name;
            int Strength = character.Strength;
            int Dexterity = character.Dexterity;
            int Happiness = character.Happiness;
            int Intelligence = character.Intelligence;
            int Wealth = character.Wealth;

            string path = AppDomain.CurrentDomain.BaseDirectory + "@" + Name + ".txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Name: " + Name);
                sw.WriteLine("Strength: " + Strength);
                sw.WriteLine("Dexterity: " + Dexterity);
                sw.WriteLine("Happiness: " + Happiness);
                sw.WriteLine("Intelligence: " + Intelligence);
                sw.WriteLine("Wealth: " + Wealth);
            }
        }

        bool DeleteCharacter(string characterName)
        {
            bool delete = false;

            if (File.Exists(characterName + ".txt"))
                delete = true;
            else
                delete = false;
            return delete;
        }

        //Character LoadCharacter(string characterName)
        //{

        //}

        static void PrintCharacter(Character character)
        {
            Console.WriteLine();
            string path = AppDomain.CurrentDomain.BaseDirectory + "@" + character.Name + ".txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
