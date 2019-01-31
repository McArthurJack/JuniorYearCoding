using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader();
            Console.ReadLine();
        }

        static void StreamReader()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\..\\CodeQuest\\" + "Prob01.in.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                int length = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < length; i++)
                {
                    int Grade = Convert.ToInt32(sr.ReadLine());
                    if (Grade >= 70)
                    {
                        Console.WriteLine("Passed");
                    }
                    else
                    {
                        Console.WriteLine("Failed");
                    }
                }
            }
        }
    }
}
