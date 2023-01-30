using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.Entities
{
    public class GameBoardBattleShip
    {
        public static string[,] gameBoardPlayer1 = new string[8, 8];
        public static string[,] gameBoardPlayer2 = new string[8, 8];

        public static string[,] InitializeGameBoardPlayer1()
        {
            int counter = 1;
            
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    gameBoardPlayer1[row, col] = $"{counter}";
                    counter++;                   
                }
            }
            return gameBoardPlayer1;
        }

        public static string[,] InitializeGameBoardPlayer2()
        {
            int counter = 1;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    gameBoardPlayer2[row, col] = $"{counter}";
                    counter++;
                }
            }
            return gameBoardPlayer2;
        }

        public static void DisplayGameBoardPlayer1()
        {
            Console.WriteLine(" ____  ____  ____  ____  ____  ____  ____  ____ ");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.Write("| ");
                    if (gameBoardPlayer1[row, col] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write($"{gameBoardPlayer1[row, col]}");
                        Console.ResetColor();
                    }
                    else if (gameBoardPlayer1[row, col] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{gameBoardPlayer1[row, col]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{gameBoardPlayer1[row, col]}");
                    }                    
                    Console.Write(" |");
                }
                Console.WriteLine();
                Console.WriteLine("|----||----||----||----||----||----||----||----|");
            }   
        }

        public static void DisplayGameBoardPlayer2()
        {
            Console.WriteLine(" ____  ____  ____  ____  ____  ____  ____  ____ ");
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.Write("| ");
                    if (gameBoardPlayer2[row, col] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write($"{gameBoardPlayer2[row, col]}");
                        Console.ResetColor();
                    }
                    else if (gameBoardPlayer1[row, col] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{gameBoardPlayer2[row, col]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{gameBoardPlayer2[row, col]}");
                    }
                    Console.Write(" |");
                }
                Console.WriteLine();
                Console.WriteLine("|----||----||----||----||----||----||----||----|");
            }
        }
    }

    
}
