using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quest_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>();
            List<Choice> match = new List<Choice>();
            string path = "C:\\Users\\132333\\Desktop\\CodeQuest\\" + @"Prob04.in.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                int length = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < length; i++)
                {
                    string temp = sr.ReadLine();
                    str.Add(temp);
                }
            }

            for (int i = 0; i < str.Count; i++)
            {
                str[i] = str[i].Replace(" ", "");
            }

            for (int i = 0; i < str.Count; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    match.Add(new Choice(str[i][j]));
                }

                for (int o = 0; o < match.Count; o++)
                {
                    if (Choice )
                }

                match.RemoveRange(0, match.Count - 1);
            }
        }
    }
}
