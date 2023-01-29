using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.Entities
{
    public class GameBoardBattleShip : GameBoard
    {
        public string[,] board = new string[8, 8];
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

    }
}
