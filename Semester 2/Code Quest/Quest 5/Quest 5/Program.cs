using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quest_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<int> Starting = new List<int>();
            List<int> Final = new List<int>();
            string path = "C:\\Users\\132333\\Desktop\\CodeQuest\\" + @"Prob05.in.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                int filelength = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < filelength; i++)
                {
                    int temp = Convert.ToInt32(sr.ReadLine());
                    Starting.Add(temp);
                }
            }

            for (int i = 0; i < Starting.Count; i++)
            {
                int temp1 = Starting[i];
                counter = 1;
                do
                {
                    if (temp1 % 2 == 0)
                    {
                        temp1 = temp1 / 2;
                        counter++;
                    }
                    else if (temp1 != 1)
                    {
                        temp1 = (temp1 * 3) + 1;
                        counter++;
                    }
                } while (temp1 != 1);
                Final.Add(counter);
            }

            for (int i = 0; i < Starting.Count; i++)
            {
                Console.WriteLine(Starting[i] + ":" + Final[i]);
            }
            Console.ReadLine();
        }
    }
}
