using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<string> Values = new List<string>();
                string result;
                double amount = 0;
                string path = "..\\..\\..\\..\\Problems\\" + @"Prob01.in_.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((result = sr.ReadLine()) != null)
                    {
                        Values.Add(result);
                    }
                }

                for (int i = 0; i < Values.Count; i++)
                {
                    if (Values[i].Contains("HALFDOLLAR"))
                    {
                        Values[i] = Values[i].Replace("HALFDOLLAR", "");
                        Values[i] = Values[i].Replace("=", "");
                        amount += Convert.ToInt32(Values[i]) * 0.5;
                    }
                    if (Values[i].Contains("QUARTER"))
                    {
                        Values[i] = Values[i].Replace("QUARTER", "");
                        Values[i] = Values[i].Replace("=", "");
                        amount += Convert.ToInt32(Values[i]) * 0.25;
                    }
                    if (Values[i].Contains("DIME"))
                    {
                        Values[i] = Values[i].Replace("DIME", "");
                        Values[i] = Values[i].Replace("=", "");
                        amount += Convert.ToInt32(Values[i]) * 0.1;
                    }
                    if (Values[i].Contains("NICKEL"))
                    {
                        Values[i] = Values[i].Replace("NICKEL", "");
                        Values[i] = Values[i].Replace("=", "");
                        amount += Convert.ToInt32(Values[i]) * 0.05;
                    }
                    if (Values[i].Contains("PENNY"))
                    {
                        Values[i] = Values[i].Replace("PENNY", "");
                        Values[i] = Values[i].Replace("=", "");
                        amount += Convert.ToInt32(Values[i]) * 0.01;
                    }
                }
                amount = Math.Round(amount, 2);
                Console.WriteLine("$" + amount);
                Console.ReadLine();
            }
        }
    }
}
