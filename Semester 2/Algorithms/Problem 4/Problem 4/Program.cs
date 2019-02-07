using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Factorials = new List<int>();
            string result;
            string path = "..\\..\\..\\..\\Problems\\" + @"Prob04.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while((result = sr.ReadLine()) != null)
                {
                    Factorials.Add(Convert.ToInt32(result));
                }
            }

            for (int i = 0; i < Factorials.Count; i++)
            {
                for (int j = Factorials[i]-1; j > 0; j--)
                {
                    Factorials[i] = Factorials[i] * j;
                }
            }

            for (int i = 0; i < Factorials.Count; i++)
            {
                Console.WriteLine(Factorials[i]);
            }

            Console.ReadLine();
        }
    }
}
