using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Player1();
            Player2();
            Console.ReadLine();
        }

        public static void Player1()
        {
            Watergun Player1 = new Watergun();
            int Input = 0;
            Console.WriteLine("Player 1 Turn");
            Console.WriteLine("1. Shoot Watergun");
            Console.WriteLine("2. Refill Watergun");
            Input = Convert.ToInt32(Console.ReadLine());
            if (Input == 1)
            {
                Console.Write("Enter the amount you want to shoot: ");
                Player1.amount = float.Parse(Console.ReadLine());
                Console.WriteLine();
                Player1.Shoot(Player1.amount);
                bool Play1 = Player1.IsWet;
            }
            else if (Input == 2)
            {
                Player1.Refill(Player1.Capacity);
            }
        }

        public static void Player2()
        {
            Watergun Player2 = new Watergun();
            int Input = 0;
            Console.WriteLine("Player 2 Turn");
            Console.WriteLine("1. Shoot Watergun");
            Console.WriteLine("2. Refill Watergun");
            Input = Convert.ToInt32(Console.ReadLine());
            if (Input == 1)
            {
                Console.Write("Enter the amount you want to shoot: ");
                Player2.amount = float.Parse(Console.ReadLine());
                Console.WriteLine();
                Player2.Shoot(Player2.amount);
            }
            else if (Input == 2)
            {
                Player2.Refill(Player2.Capacity);
            }
            
        }

        public void Tests(Player1, Player2)
        {
            if (Player1.IsWet == true)
            {
                Console.WriteLine("Player 1 soaked Player 2");
            }
            else if (Player1.IsWet == false)
            {
                Console.WriteLine("Player 2 wasn't hit.");
            }
            else if (Player2.IsWet == true)
            {
                Console.WriteLine("Player 2 soaked Player 1");
            }
            else if (Player2.IsWet == false)
            {
                Console.WriteLine("Player 2 wasn't hit.");
            }
        }
    }
}