using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Decodes = new List<string>();
            string cipher = "";
            string jj = "";
            string result;
            string path = "..\\..\\..\\..\\Problems\\" + @"Prob03.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                cipher = sr.ReadLine();
                while ((result = sr.ReadLine()) != null)
                {
                    Decodes.Add(result);
                }
            }

            for (int i = 0; i < Decodes.Count; i++)
            {
                for (int j = cipher.Length; j >= 0; j--)
                {
                    jj = Convert.ToString(j);
                    if (Decodes[i].Contains(jj))
                    {
                        Decodes[i] = Decodes[i].Replace(jj, Convert.ToString(cipher[j - 1]));
                    }
                }
                Decodes[i] = Decodes[i].Replace("-", "");
            }

            for (int i = 0; i < Decodes.Count; i++)
            {
                Console.WriteLine(Decodes[i]);
            }

            Console.ReadLine();
        }
    }
}
