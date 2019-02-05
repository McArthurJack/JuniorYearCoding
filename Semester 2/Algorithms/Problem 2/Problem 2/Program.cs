using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Prob2 = new List<string>();
            List<int> Work = new List<int>();
            string result;
            string temp;
            string temp2;
            int counter = 0;
            string path = "..\\..\\..\\..\\Problems\\" + @"Prob02.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while ((result = sr.ReadLine()) != null)
                {
                    Prob2.Add(sr.ReadLine());
                }
            }

            temp = Prob2[0];
            for (int i = 0; i < temp.Length-1; i++)
            {
                if (temp[i] == ' ')
                {
                    counter++;
                    temp = temp.Substring(0, counter);
                    Work.Add(Convert.ToInt32(temp));
                }
                else
                    counter++;
            }

            Console.ReadLine();
        }
    }
}
