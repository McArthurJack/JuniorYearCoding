using System;

public class Program
{
    public static void Main()
    {
        string answer = "";
        //Console.WriteLine("What is your name:");
        //string Firstname = Console.ReadLine();
        //Console.WriteLine("What is your last name:");
        //string Lastname = Console.ReadLine();
        //Console.WriteLine("Welcome " + Firstname + " " + Lastname + "!");
        do
        {
            Random rand = new Random();
            Console.WriteLine("*********************************************************");
            Console.WriteLine("** Enter the value for the action you want to perform! **");
            Console.WriteLine("** 1. Ride in random seat                              **");
            Console.WriteLine("** 2. List available seats                             **");
            Console.WriteLine("** 3. How many people are on the ride                  **");
            Console.WriteLine("** 4. Exit                                             **");
            Console.WriteLine("*********************************************************");
            answer = Console.ReadLine();
            int[] roller = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            // FIRST ANSWER ************************************************************************************
            if (answer == "1")
            {
                while (roller[rand.Next(0, 10)] != 1)
                {
                    
                }
            }
            // SECOND ANSWER ************************************************************************************
            if (answer == "2")
            {
                Console.WriteLine("-1 = seat available");
                foreach (int i in roller)
                {
                    Console.WriteLine(i + " is available!");
                }
            }
            // THIRD ANSWER ************************************************************************************
            if (answer == "3")
            {
                //if (roller[] == "-1")
                //{

                //}

            }
            Console.WriteLine();
        } while (answer != "4");
    }
}