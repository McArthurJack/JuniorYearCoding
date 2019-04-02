using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            do
            {
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2. Add 2 Integers together");
                Console.WriteLine("3. Calculate the Area of a Circle");
                Console.WriteLine("4. Calculated the Area of a Triangle");
                Console.WriteLine("5. Draw a Square with X's");
                Console.WriteLine("6. Draw a Hollow Square with X's");
                Console.WriteLine("7. Switch 2 Variables values");
                Console.WriteLine("8. Reverse a string");
                Console.WriteLine("9. End Program");
                ans = Convert.ToInt32(Console.ReadLine());
                switch(ans)
                {
                    case 1:
                        Console.WriteLine("Hello World");
                        break;
                    case 2:
                        Console.Write("Enter Integer 1: ");
                        int one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Enter Integer 2: ");
                        int two = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(one + two);
                        break;
                    case 3:
                        Console.Write("Enter the Radius of the Circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.PI * Math.Pow(radius, 2));
                        break;
                    case 4:
                        Console.Write("Enter the Value of the first side: ");
                        float oneT = float.Parse(Console.ReadLine());
                        Console.Write("Enter the Value of the second side: ");
                        float twoT = float.Parse(Console.ReadLine());
                        Console.Write("Enter the Value of the third side: ");
                        float threeT = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        float p = (oneT + twoT + threeT) / 2;
                        Console.WriteLine(Math.Sqrt(p * (p - oneT) * (p - twoT) * (p - threeT)));
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Write("Enter the side Length: ");
                        int side = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < side; i++)
                        {
                            for (int j = 0; j < side; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        Console.Write("Enter the side Length: ");
                        int sideHollow = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < sideHollow; i++)
                        {
                            for (int j = 0; j < sideHollow; j++)
                            {
                                if (i == 0 || j == 0)
                                    Console.Write("X");
                                else if (i == sideHollow-1 || j == sideHollow-1)
                                    Console.Write("X");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        Console.Write("Enter value 1: ");
                        int Value1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter value 2: ");
                        int Value2 = Convert.ToInt32(Console.ReadLine());
                        int temp = Value1;
                        Value1 = Value2;
                        Value2 = temp;
                        Console.WriteLine("Value 1: " + Value1 + " | Value 2: " + Value2);
                        break;
                    case 8:
                        Console.Write("Enter a string you want reversed: ");
                        string response = Console.ReadLine();
                        for (int i = response.Length-1; i >= 0; i--)
                        {
                            Console.Write(response[i]);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Enter a real Value");
                        break;
                }
            } while (ans != 9);
        }
    }
}
