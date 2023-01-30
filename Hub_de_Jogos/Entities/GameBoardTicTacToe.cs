using Hub_de_Jogos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.Entities
{
    public class GameBoardTicTacToe 
    {
        public static string[,] board = new string[3, 3];
        
        public static string[,] InititalizeGameBoard()
        {
            int counter = 1;

            for (int row = 0; row < 3; row++)
            {                
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = $"{counter}";
                    counter++;
                }                              
            }
            return board;
        }

        public static void DisplayGameBoard()
        {
            Console.WriteLine(" ___  ___  ___ ");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("| ");
                    if (board[row, col] == "X")
                    {
                        ConsoleColor atual = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"{board[row, col]}");
                        Console.ForegroundColor = atual;
                    }
                    else if (board[row, col] == "O")
                    {
                        ConsoleColor atual = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"{board[row, col]}");
                        Console.ForegroundColor = atual;
                    }
                    else
                    {
                        Console.Write($"{board[row, col]}");
                    }                    
                    Console.Write(" |");                    
                }
                Console.WriteLine();
                Console.WriteLine("|---||---||---|");
            }
        }
        
    }
}
