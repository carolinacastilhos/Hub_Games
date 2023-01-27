using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.Entities
{
    public class GameBoardTicTacToe : GameBoard
    {
        public string[,] board = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        public override void DisplayGameBoard()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ___  ___  ___ ");
            Console.ResetColor();

            for (int row = 0; row < 3; row++)
            {                
                for (int col = 0; col < 3; col++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("| ");
                    Console.ResetColor();
                    Console.Write($"{board[row, col]}");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(" |");
                    Console.ResetColor();
                }

                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("|---||---||---|");
                Console.ResetColor();
            }
        }
        
    }
}
