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
            Character character = new Character("4head", 10, 10, 10, 10, 10);
            int answer = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Create a Character");
                Console.WriteLine("2. Modify a Character");
                Console.WriteLine("3. Delete a Character");
                Console.WriteLine("4. Load Character");
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
                if (answer != 6)
                {
                    Console.WriteLine("Press anything to continue");
                    Console.ReadLine();
                }
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
                    Console.WriteLine("1. Name | 2. Strength | 3. Dexterity | 4. Happiness | 5. Intelligence | 6. Wealth | 7. Exit");
                    Console.WriteLine("You have " + Points + " leftover");
                    Console.Write("Response: ");
                    response = Convert.ToInt32(Console.ReadLine());
                    if (response == 1)
                    {
                        Console.Write("Enter new name: ");
                        string temp = character.Name;
                        character.Name = Console.ReadLine();
                        DeleteCharacter(temp);
                        SaveCharacter(character);
                        Console.WriteLine("Characters name changed");
                        Console.WriteLine();
                    }
                    if (response == 2)
                    {
                        Console.Write("Enter the new strength of the character: ");
                        int result = Convert.ToInt32(Console.ReadLine());
                        if (((Points + character.Strength) - result) >= 0)
                        {
                            Points += character.Strength;
                            Points = Points - result;
                            character.Strength = result;
                            SaveCharacter(character);
                        }
                        else
                        {
                            Console.WriteLine("Overloading point usage");
                        }
                    }
                    if (response == 3)
                    {
                        Console.Write("Enter the new Dexterity of the character: ");
                        int result = Convert.ToInt32(Console.ReadLine());
                        if (((Points + character.Dexterity) - result) >= 0)
                        {
                            Points += character.Dexterity;
                            Points = Points - result;
                            character.Dexterity = result;
                            SaveCharacter(character);
                        }
                        else
                        {
                            Console.WriteLine("Overloading point usage");
                        }
                    }
                    if (response == 4)
                    {
                        Console.Write("Enter the new Happiness of the character: ");
                        int result = Convert.ToInt32(Console.ReadLine());
                        if (((Points + character.Happiness) - result) >= 0)
                        {
                            Points += character.Happiness;
                            Points = Points - result;
                            character.Happiness = result;
                            SaveCharacter(character);
                        }
                        else
                        {
                            Console.WriteLine("Overloading point usage");
                        }
                    }
                    if (response == 5)
                    {
                        Console.Write("Enter the new Intelligence of the character: ");
                        int result = Convert.ToInt32(Console.ReadLine());
                        if (((Points + character.Intelligence) - result) >= 0)
                        {
                            Points += character.Intelligence;
                            Points = Points - result;
                            character.Intelligence = result;
                            SaveCharacter(character);
                        }
                        else
                        {
                            Console.WriteLine("Overloading point usage");
                        }
                    }
                    if (response == 6)
                    {
                        Console.Write("Enter the new Wealth of the character: ");
                        int result = Convert.ToInt32(Console.ReadLine());
                        if (((Points + character.Wealth) - result) >= 0)
                        {
                            Points += character.Wealth;
                            Points = Points - result;
                            character.Wealth = result;
                            SaveCharacter(character);
                        }
                        else
                        {
                            Console.WriteLine("Overloading point usage");
                        }
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
            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + ".txt";
            if (File.Exists(path))
            {
                Console.Write("Would you like to overwrite?: ");
                if (Console.ReadLine()[0] == 'y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(character.Name);
                        sw.WriteLine(character.Strength);
                        sw.WriteLine(character.Dexterity);
                        sw.WriteLine(character.Happiness);
                        sw.WriteLine(character.Intelligence);
                        sw.WriteLine(character.Wealth);
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
                    sw.WriteLine(character.Name);
                    sw.WriteLine(character.Strength);
                    sw.WriteLine(character.Dexterity);
                    sw.WriteLine(character.Happiness);
                    sw.WriteLine(character.Intelligence);
                    sw.WriteLine(character.Wealth);
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
            if (File.Exists(characterName + ".txt"))
            {
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
            else
            {
                Name = "Delete";
                Console.WriteLine("Character Doesn't exist");
                Character character = new Character(Name, Strength, Dexterity, Happiness, Intelligence, Wealth);
                return character;
            }
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
            Console.WriteLine();
        }
    }
}
