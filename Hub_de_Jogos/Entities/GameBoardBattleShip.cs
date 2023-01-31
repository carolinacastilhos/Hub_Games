using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    gameBoardPlayer1[row, col] += "~";                                                            
                }
            }
            return gameBoardPlayer1;                                
        }

        public static string[,] InitializeGameBoardPlayer2()
        {                        
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    gameBoardPlayer2[row, col] += "~";
                }
            }
            return gameBoardPlayer2;
        }

        public static void DisplayGameBoardPlayer1()
        {
            Console.WriteLine("    0   1   2   3   4   5   6   7   ");
            Console.WriteLine("   ___ ___ ___ ___ ___ ___ ___ ___ ");
            for (int row = 0; row < 8; row++)
            {
                if (row == 0)
                {
                    Console.Write($"0 | ");
                }
                if (row == 1)
                {
                    Console.Write($"1 | ");
                }
                if (row == 2)
                {
                    Console.Write($"2 | ");
                }
                if (row == 3)
                {
                    Console.Write($"3 | ");
                }
                if (row == 4)
                {
                    Console.Write($"4 | ");
                }
                if (row == 5)
                {
                    Console.Write($"5 | ");
                }
                if (row == 6)
                {
                    Console.Write($"6 | ");
                }
                if (row == 7)
                {
                    Console.Write($"7 | ");
                }              
                
                for (int col = 0; col < 8; col++)
                {                  
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"{gameBoardPlayer1[row, col]}");
                    Console.ResetColor();
                    Console.Write(" | ");
                }                
                Console.WriteLine();
                Console.WriteLine("  |---|---|---|---|---|---|---|---|");
            }   
        }

        public static void DisplayGameBoardPlayer2()
        {
            Console.WriteLine("    0   1   2   3   4   5   6   7   ");
            Console.WriteLine("   ___ ___ ___ ___ ___ ___ ___ ___ ");
            for (int row = 0; row < 8; row++)
            {
                if (row == 0)
                {
                    Console.Write($"0 | ");
                }
                if (row == 1)
                {
                    Console.Write($"1 | ");
                }
                if (row == 2)
                {
                    Console.Write($"2 | ");
                }
                if (row == 3)
                {
                    Console.Write($"3 | ");
                }
                if (row == 4)
                {
                    Console.Write($"4 | ");
                }
                if (row == 5)
                {
                    Console.Write($"5 | ");
                }
                if (row == 6)
                {
                    Console.Write($"6 | ");
                }
                if (row == 7)
                {
                    Console.Write($"7 | ");
                }

                for (int col = 0; col < 8; col++)
                {
                    if (gameBoardPlayer2[row, col] == "N")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"{gameBoardPlayer2[row, col]}");
                        Console.ResetColor();
                    }
                    else if (gameBoardPlayer1[row, col] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{gameBoardPlayer2[row, col]}");
                        Console.ResetColor();
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"{gameBoardPlayer2[row, col]}");
                    Console.ResetColor();
                    Console.Write(" | ");
                }
                Console.WriteLine();
                Console.WriteLine("  |---|---|---|---|---|---|---|---|");
            }
        }
    }

    
}
