using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>();
            string temp = "";
            string path = "C:\\Users\\132333\\Desktop\\CodeQuest\\" + @"Prob03.in.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                for (int i = 0; i < 7; i++)
                {
                    temp = sr.ReadLine();
                    str.Add(temp);
                }
            }

            for (int i = 0; i < str.Count; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i].Substring(0, str[i].Length -2) == "11")
                    {
                        str[i] = str[i].Substring(0, str[i].Length - 2);
                        str[i] += "th";
                        break;
                    }
                    else if (str[i].Substring(0, str[i].Length - 2) == "12")
                    {
                        str[i] = str[i].Substring(0, str[i].Length - 2);
                        str[i] += "th";
                        break;
                    }
                    else if (str[i].Substring(0, str[i].Length - 2) == "12")
                    {
                        str[i] = str[i].Substring(0, str[i].Length - 2);
                        str[i] += "th";
                        break;
                    }
                    else if (str[i][j] == '0')
                    {
                        str[i] = str[i].Replace("st", "th");
                        str[i] = str[i].Replace("nd", "th");
                        str[i] = str[i].Replace("rd", "th");
                    }
                    else if (str[i][j] == '1')
                    {
                        str[i] = str[i].Replace("th", "st");
                        str[i] = str[i].Replace("nd", "st");
                        str[i] = str[i].Replace("rd", "st");
                    }
                    else if (str[i][j] == '2')
                    {
                        str[i] = str[i].Replace("st", "nd");
                        str[i] = str[i].Replace("rd", "nd");
                        str[i] = str[i].Replace("th", "nd");
                    }
                    else if (str[i][j] == '3')
                    {
                        str[i] = str[i].Replace("nd", "rd");
                        str[i] = str[i].Replace("st", "rd");
                        str[i] = str[i].Replace("th", "rd");
                    }
                    else if (str[i][j] == '4')
                    {
                        str[i] = str[i].Replace("st", "th");
                        str[i] = str[i].Replace("nd", "th");
                        str[i] = str[i].Replace("rd", "th");
                    }
                    else if (str[i][j] == '5')
                    {
                        str[i] = str[i].Replace("st", "th");
                        str[i] = str[i].Replace("nd", "th");
                        str[i] = str[i].Replace("rd", "th");
                    }
                    else if (str[i][j] == '6')
                    {
                        str[i] = str[i].Replace("st", "th");
                        str[i] = str[i].Replace("nd", "th");
                        str[i] = str[i].Replace("rd", "th");
                    }
                    else if (str[i][j] == '7')
                    {
                        str[i] = str[i].Replace("st", "th");
                        str[i] = str[i].Replace("nd", "th");
                        str[i] = str[i].Replace("rd", "th");
                    }
                    else if (str[i][j] == '8')
                    {
                        str[i] = str[i].Replace("st", "th");
                        str[i] = str[i].Replace("nd", "th");
                        str[i] = str[i].Replace("rd", "th");
                    }
                    else if (str[i][j] == '9')
                    {
                        str[i] = str[i].Replace("st", "th");
                        str[i] = str[i].Replace("nd", "th");
                        str[i] = str[i].Replace("rd", "th");
                    }
                }
            } 

            for (int i = 0; i < str.Count; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadLine();
        }
    }
}
