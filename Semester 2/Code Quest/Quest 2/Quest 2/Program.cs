using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quest_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Liststring = new List<string>();
            int counter = 0;
            string temp = "";
            string path = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\..\\CodeQuest\\" + "Prob02.in.txt";
            using (StreamReader sr = new StreamReader(path)) 
            {
                int useless = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < 3; i++)
                {
                    temp = sr.ReadLine();
                    Liststring.Add(temp);
                }
            }

            for (int i = 0; i < Liststring.Count; i++)
            {
                for (int j = 0; j < Liststring[i].Length; j++)
                {
                    if (Liststring[i][j] == 'a')
                    {
                        counter++;
                    }
                    else if (Liststring[i][j] == 'e')
                    {
                        counter++;
                    }
                    else if (Liststring[i][j] == 'i')
                    {
                        counter++;
                    }
                    else if (Liststring[i][j] == 'o')
                    {
                        counter++;
                    }
                    else if (Liststring[i][j] == 'u')
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
                counter = 0;
            }
            Console.ReadLine();
        }
    }
}
