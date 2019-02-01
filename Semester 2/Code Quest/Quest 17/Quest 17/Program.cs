using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quest_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Board = new List<string>();
            int length = 0;
            bool wow = false;
            string path = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\..\\CodeQuest\\" + "Prob17.in.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                length = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < length; i++)
                {
                    string temp = sr.ReadLine();
                    Board.Add(temp);
                }
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (Board[i][0] == 'X' && Board[i][1] == 'X' && Board[i][2] == 'X')
                    {
                        Console.WriteLine(Board[i] + " = X WINS");
                        break;
                    }
                    if (Board[i][3] == 'X' && Board[i][4] == 'X' && Board[i][5] == 'X')
                    {
                        Console.WriteLine(Board[i] + " = X WINS");
                        break;
                    }
                    if (Board[i][6] == 'X' && Board[i][7] == 'X' && Board[i][8] == 'X')
                    {
                        Console.WriteLine(Board[i] + " = X WINS");
                        break;
                    }
                    else if (Board[i][0] == 'X' && Board[i][4] == 'X' && Board[i][8] == 'X')
                    {
                        Console.WriteLine(Board[i] + " = X WINS");
                        break;
                    }
                    for (int p = 0; p < 3; p++)
                    {
                        if (Board[i][0 + p] == 'X' && Board[i][3 + p] == 'X' && Board[i][6 + p] == 'X')
                        {
                            Console.WriteLine(Board[i] + " = X WINS");
                            wow = true;
                            break;
                        }
                        wow = false;
                    }
                    if (Board[i][2] == 'X' && Board[i][4] == 'X' && Board[i][6] == 'X')
                    {
                        Console.WriteLine(Board[i] + " = X WINS");
                        break;
                    }
                    if (Board[i][0] == 'O' && Board[i][1] == 'O' && Board[i][2] == 'O')
                    {
                        Console.WriteLine(Board[i] + " = O WINS");
                        break;
                    }
                    else if (Board[i][3] == 'O' && Board[i][4] == 'O' && Board[i][5] == 'O')
                    {
                        Console.WriteLine(Board[i] + " = O WINS");
                        break;
                    }
                    else if (Board[i][6] == 'O' && Board[i][7] == 'O' && Board[i][8] == 'O')
                    {
                        Console.WriteLine(Board[i] + " = O WINS");
                        break;
                    }
                    else if (Board[i][0] == 'O' && Board[i][4] == 'O' && Board[i][8] == 'O')
                    {
                        Console.WriteLine(Board[i] + " = O WINS");
                        break;
                    }
                    for (int p = 0; p < 3; p++)
                    {
                        if (Board[i][0 + p] == 'O' && Board[i][3 + p] == 'O' && Board[i][6 + p] == 'O')
                        {
                            Console.WriteLine(Board[i] + " = O WINS");
                            wow = true;
                            break;
                        }
                    }
                    if (Board[i][2] == 'O' && Board[i][4] == 'O' && Board[i][6] == 'O')
                    {
                        Console.WriteLine(Board[i] + " = O WINS");
                        break;
                    }
                    if (wow == false)
                        Console.WriteLine(Board[i] + " = TIE");
                }
            }
            Console.ReadLine();
        }
    }
}
