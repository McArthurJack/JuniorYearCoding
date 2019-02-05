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
            string temp3;
            int counter = 0;
            string path = "..\\..\\..\\..\\Problems\\" + @"Prob02.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while ((result = sr.ReadLine()) != null)
                {
                    Prob2.Add(result);
                }
            }

            for (int i = 0; i < Prob2.Count; i++)
            {
                counter = 0;
                for (int j = 0; j < Prob2[i].Length-1; j++)
                {
                    temp2 = " ";
                    if (temp2.Contains(' '))
                    {

                    }
                    else
                        break;
                    temp = Prob2[i];
                    if (temp[j] == ' ')
                    {
                        temp2 = temp.Substring(0, counter);
                        counter++;
                        temp = temp.Substring(counter);
                        Work.Add(Convert.ToInt32(temp2));
                        temp2 = "";
                    }
                    else
                        counter++;
                }
                for (int j = 0; j < Work.Count-1; j++)
                {
                    if (Work[j] < Work[j+1])
                    {
                        counter++;
                    }
                    if (counter == Work.Count())
                    {
                        Console.WriteLine("The numbers are in ascending order");
                    }
                }
                for (int j = 0; j < Work.Count-1; j++)
                {
                    counter = 0;
                    if (Work[j] > Work[j + 1])
                    {
                        counter++;
                    }
                    if (counter == Work.Count())
                    {
                        Console.WriteLine("The numbers are in descending order");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
