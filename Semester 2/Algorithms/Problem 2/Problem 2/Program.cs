using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "..\\..\\..\\..\\Problems\\" + @"Prob02.in_.txt";
            string result;
            int temp = 0;
            int counter = 0;
            int oldcounter = 0;
            int caseSwitch = 0;
            bool check = false;
            List<char> Error = new List<char>() { '=', '(', '%', '_', '^' };
            List<int> work = new List<int>();

            using (StreamReader sr = new StreamReader(path))
            {
                while ((result = sr.ReadLine()) != null)
                {
                    work.Clear();
                    counter = 0;
                    for (int i = 0; i < Error.Count; i++)
                    {
                        if (result.Contains(Error[i]))
                        {
                            caseSwitch = 1;
                            break;
                        }
                    }
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[j] == '-')
                        {
                            if (result[j - 1] == ' ')
                            {
                                if (result[j + 1] == ' ')
                                    caseSwitch = 1;
                                break;
                            }
                        }
                    }

                    if (caseSwitch != 1)
                    {
                        for (int i = 0; i < result.Length; i++)
                        {
                            if (result[i] == ' ')
                            {
                                if (result.Substring(counter + 1) == "")
                                {
                                    temp = Convert.ToInt32(result.Substring(oldcounter));
                                    check = true;
                                }
                                if (check == false)
                                {
                                    temp = Convert.ToInt32(result.Substring(oldcounter, counter));
                                }
                                oldcounter = counter;
                                check = false;
                                work.Add(temp);
                            }
                            else
                                counter++;
                        }
                    }

                    if (caseSwitch != 1)
                    {
                        counter = 0;
                        for (int i = 0; i < work.Count-1; i++)
                        {
                            if (work[i] < work[i + 1])
                                counter++;
                            if (counter == work.Count)
                                caseSwitch = 2;
                        }
                        counter = 0;
                        for (int i = 0; i < work.Count-1; i++)
                        {
                            if (work[i] > work[i + 1])
                                counter++;
                            if (counter == work.Count)
                                caseSwitch = 3;
                        }
                    }

                    switch (caseSwitch)
                    {
                        case 1:
                            Console.WriteLine("The input is invalid");
                            break;
                        case 2:
                            Console.WriteLine("The numbers are in ascending order");
                            break;
                        case 3:
                            Console.WriteLine("The numbers are in descending order");
                            break;
                        default:
                            Console.WriteLine("The numbers are in a random order");
                            break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
