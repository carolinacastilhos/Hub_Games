using Hub_de_Jogos.View;
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
            Console.WriteLine(" ___  ___  ___ ");            

            for (int row = 0; row < 3; row++)
            {                
                for (int col = 0; col < 3; col++)
                {                    
                    Console.Write("| ");
                    Console.Write($"{board[row, col]}");
                    Console.Write(" |");
                }

                Console.WriteLine();
                Console.WriteLine("|---||---||---|");                
            }
        }

        public override void PlayersMove()
        {
            
        }

        public static void CheckConditionsToWin(string[,] board)
        {
            //check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] || board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                //Print.ShowVictoryMessage();
            }

            //check rows
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] || board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] || board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                //Print.ShowVictoryMessage();
            }

            //check columns
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] || board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] || board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
               // Print.ShowVictoryMessage();
            }
        }
    }
}
