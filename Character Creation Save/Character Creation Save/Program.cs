﻿using System;
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
            Character character = new Character("4head", 10, 10, 10, 10, 10);
            int answer = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Modify a character");
                Console.WriteLine("3. Delete a character");
                Console.WriteLine("4. Loading existing character");
                Console.WriteLine("5. Print Character");
                Console.WriteLine("6. Exit");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (answer == 1)
                {
                    CreateCharacter();
                }
                if (answer == 2)
                {
                    Console.Write("Enter the name of the character you want to modify: ");
                    character = LoadCharacter(Console.ReadLine());
                    Console.WriteLine();
                    ModifyCharacter(character);
                }
                if (answer == 3)
                {
                    Console.Write("Enter the name of the character you want to delete: ");
                    if (DeleteCharacter(Console.ReadLine()) == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Character was deleted");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Character does not exist");
                    }
                }
                if (answer == 4)
                {

                    Console.Write("Enter the name of the character you want to load: ");
                    LoadCharacter(Console.ReadLine());
                }
                if (answer == 5)
                {
                    Console.Write("Enter name of the character: ");
                    character = LoadCharacter(Console.ReadLine());
                    PrintCharacter(character);
                }
                Console.WriteLine("Press anything to continue");
                Console.ReadLine();
            } while (answer != 6);
        }

        static Character CreateCharacter()
        {
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
            Character character = new Character(Name, Strength, Dexterity, Happiness, Intelligence, Wealth);
            SaveCharacter(character);
            return character;
        }

        static void ModifyCharacter(Character character)
        {
            if (File.Exists(character.Name + ".txt"))
            {
                int response = 0;
                int Points = 100 - (character.Strength + character.Dexterity + character.Happiness + character.Intelligence + character.Wealth);
                do
                {
                    Console.WriteLine("What do you want to modify about the character?");
                    Console.WriteLine("1. Name | 2. Strength | 3. Dexterity | 4. Happiness | 5. Intelligence | 6. Wealth");
                    Console.WriteLine("You have " + Points + " leftover from the original character creation");
                    Console.Write("Response: ");
                    if (Convert.ToInt32(Console.ReadLine()) == 1)
                    {
                        Console.Write("Enter new name: ");
                        string temp = character.Name;
                        character.Name = Console.ReadLine();
                        DeleteCharacter(temp);
                        SaveCharacter(character);
                        Console.WriteLine("Characters name changed");
                        Console.WriteLine();
                    }
                    if (Convert.ToInt32(Console.ReadLine()) == 2)
                    {
                        Console.Write("Enter the new strength of the character: ");
                        if ((Points + character.Strength) - Convert.ToInt32(Console.ReadLine()) < 0)
                        {
                            Points += character.Strength;
                            Points = Points - Convert.ToInt32(Console.ReadLine());
                            character.Strength = Convert.ToInt32(Console.ReadLine());
                            SaveCharacter(character);
                        }
                        else
                        {
                            Console.WriteLine("Overloading point usage");
                        }
                        Console.WriteLine();
                    }
                    if (Convert.ToInt32(Console.ReadLine()) == 3)
                    {

                    }
                    if (Convert.ToInt32(Console.ReadLine()) == 4)
                    {

                    }
                    if (Convert.ToInt32(Console.ReadLine()) == 5)
                    {

                    }
                    if (Convert.ToInt32(Console.ReadLine()) == 6)
                    {

                    }
                } while (response != 7);
            }
            else
            {
                Console.WriteLine("Character does not exist");
            }
            
        }

        static void SaveCharacter(Character character)
        {
            string Name = character.Name;
            int Strength = character.Strength;
            int Dexterity = character.Dexterity;
            int Happiness = character.Happiness;
            int Intelligence = character.Intelligence;
            int Wealth = character.Wealth;
            string path = AppDomain.CurrentDomain.BaseDirectory + Name + ".txt";
            if (File.Exists(path))
            {
                Console.Write("Would you like to overwrite?: ");
                if (Console.ReadLine()[0] == 'y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(Name);
                        sw.WriteLine(Strength);
                        sw.WriteLine(Dexterity);
                        sw.WriteLine(Happiness);
                        sw.WriteLine(Intelligence);
                        sw.WriteLine(Wealth);
                    }
                    Console.WriteLine("Overwritten");
                }
                else
                {
                    Console.WriteLine("Nothing was over written");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(Name);
                    sw.WriteLine(Strength);
                    sw.WriteLine(Dexterity);
                    sw.WriteLine(Happiness);
                    sw.WriteLine(Intelligence);
                    sw.WriteLine(Wealth);
                }
                Console.WriteLine("Character was saved");
            }
            Console.WriteLine();
        }

        static bool DeleteCharacter(string characterName)
        {
            bool delete = false;
            if (File.Exists(characterName + ".txt"))
            {
                File.Delete(characterName + ".txt");
                delete = true;
            }
            else
            {
                delete = false;
            }
            return delete;
        }

        static Character LoadCharacter(string characterName)
        {
            string Name; int Strength = 0; int Dexterity = 0; int Happiness = 0; int Intelligence = 0; int Wealth = 0;

            string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Name = sr.ReadLine();
                Strength = Convert.ToInt32(sr.ReadLine());
                Dexterity = Convert.ToInt32(sr.ReadLine());
                Happiness = Convert.ToInt32(sr.ReadLine());
                Intelligence = Convert.ToInt32(sr.ReadLine());
                Wealth = Convert.ToInt32(sr.ReadLine());
            }
            Character character = new Character(Name, Strength, Dexterity, Happiness, Intelligence, Wealth);
            return character;
        }

        static void PrintCharacter(Character character)
        {
            Console.WriteLine();
            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + ".txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine("Name: " + sr.ReadLine());
                Console.WriteLine("Strength: " + sr.ReadLine());
                Console.WriteLine("Dexterity: " + sr.ReadLine());
                Console.WriteLine("Happiness: " + sr.ReadLine());
                Console.WriteLine("Intelligence: " + sr.ReadLine());
                Console.WriteLine("Wealth: " + sr.ReadLine());
            }
        }
    }
}
