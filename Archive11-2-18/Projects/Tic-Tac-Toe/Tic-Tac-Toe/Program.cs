using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int Collumn1 = 0;
            int Row1 = 0;
            int Collumn2 = 0;
            int Row2 = 0;
            char[,] board = new char[3, 3];
            int answer = 0;
            do
            {
                Console.Clear();
                DrawBoard(board);
                Player1Turn(Collumn1, Row1, board);
                answer = VerifyBoard1(board, answer);
                if (answer == 3)
                    break;
                if (answer == 9)
                {
                    Console.WriteLine("\nTie, Press any key to reset.");
                    board = new char[3, 3];
                    Console.ReadLine();
                    continue;
                }
                Console.Clear();
                DrawBoard(board);
                Player2Turn(Collumn2, Row2, board);
                answer = VerifyBoard2(board, answer);
                Console.Clear();
            } while (answer != 3);
            Console.Clear();
            DrawBoard(board);
            if (answer == 3)
                Console.WriteLine("\nCongratulations you won!");
            Console.ReadLine();
        }

        static void DrawBoard(char[,] board)
        {
            Console.WriteLine("   0  1  2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + board[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        static void Player1Turn(int Collumn1, int Row1, char[,] board)
        {
            do
            {
                Console.Write("Enter the Collumn number Player 1: ");
                Row1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter the Row number Player 1: ");
                Collumn1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            } while (board[Collumn1, Row1] == 'O');
            board[Collumn1, Row1] = 'X';
        }

        static void Player2Turn(int Collumn2, int Row2, char[,] board)
        {
            do
            {
                Console.Write("Enter the Collumn number Player 2: ");
                Row2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter the Row number Player 2: ");
                Collumn2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            } while (board[Collumn2, Row2] == 'X');
            board[Collumn2, Row2] = 'O';
        }

        static int VerifyBoard1(char[,] board, int answer)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == 'X')
                    {
                        answer += 1;
                    }
                    if (answer == 3)
                        return answer;
                }
                answer = 0;
            }

            answer = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 'X')
                    {
                        answer += 1;
                    }
                    if (answer == 3)
                        return answer;
                }
                answer = 0;
            }

            answer = 0;

            for (int i = 0; i < 3; i++)
            {
                if (board[i, i] == 'X')
                {
                    answer++;
                }
                if (answer == 3)
                    return answer;
            }

            answer = 0;

            for (int i = 0; i < 3; i++)
            {
                if (board[i, 2-i] == 'X')
                {
                    answer++;
                }
                if (answer == 3)
                    return answer;
            }
            answer = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 'X')
                    {
                        answer += 1;
                    }
                    if (board[i, j] == 'O')
                        answer += 1;
                    if (answer == 9)
                        return answer;
                }
            }
            answer = 0;
            return answer;
        }

        static int VerifyBoard2(char[,] board, int answer)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == 'O')
                    {
                        answer += 1;
                    }
                    if (answer == 3)
                        return answer;
                }
                answer = 0;
            }

            answer = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 'O')
                    {
                        answer += 1;
                    }
                    if (answer == 3)
                        return answer;
                }
                answer = 0;
            }

            answer = 0;

            for (int i = 0; i < 3; i++)
            {
                if (board[i, i] == 'O')
                {
                    answer++;
                }
                if (answer == 3)
                    return answer;
            }

            answer = 0;

            for (int i = 0; i < 3; i++)
            {
                if (board[i, 2 - i] == 'O')
                {
                    answer++;
                }
                if (answer == 3)
                    return answer;
            }
            answer = 0;
            return answer;
        }
    }
}
