using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2012_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 4;
            string path = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\..\\CodeQuest12\\CodeQuest\\2012\\Solutions\\" + @"Prob03.in.txt";
            List<string> lines = new List<string>();
            using (StreamReader SR = new StreamReader(path))
            {
                string line = "";
                while ((line = SR.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            for (int i = 0; i < lines.Count; i++)
            {
                int count = 0;
                List<string> Load = new List<string>();
                List<int> Line = new List<int>();
                List<int> test = new List<int>();
                Load = lines[i].Split(' ').ToList();
                for (int j = 0; j < Load.Count; j++)
                {
                    if (Int32.TryParse(Load[j], out int temp) == true)
                    {
                        Line.Add(temp);
                    }
                    else
                    {
                        caseSwitch = 1;
                        break;
                    }
                }
                for (int j = 0; j < Line.Count; j++)
                {
                    Console.WriteLine(Line[j]);
                }
                test = Line;
                test = test.OrderBy(x => x).ToList();
                for (int j = 0; j < Line.Count; j++)
                {
                    if (Line[j] == test[j])
                        count++;
                    else
                        break;
                    if (count == Line.Count)
                        caseSwitch = 2;
                }
                test = test.OrderByDescending(x => x).ToList();
                count = 0;
                for (int j = 0; j < Line.Count; j++)
                {
                    if (Line[j] == test[j])
                        count++;
                    else
                        break;
                    if (count == Line.Count)
                        caseSwitch = 3;
                }
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("The input was invalid");
                        break;
                    case 2:
                        Console.WriteLine("The numbers are in ascending order");
                        break;
                    case 3:
                        Console.WriteLine("The numbers are in descending order");
                        break;
                    case 4:
                        Console.WriteLine("The numbers are in random order");
                        break;
                }
            }
        }
    }
}
