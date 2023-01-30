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

        public static void InitializeGameBoard()
        {
            /*for (int row = 0; row < 8; row++)
             {
                 for (int col = 0; col < 8; col++)
                 {
                     gameBoardPlayer1[row, col] += "~";
                     gameBoardPlayer2[row, col] += "~";
                 }
             }*/
            for (int row = 0; row < 8; row++)
            {
                
                for (int col = 0; col < 8; col++)
                {
                    gameBoardPlayer1[row, col] += "~";
                    gameBoardPlayer2[row, col] += "~";
                }
                Console.WriteLine();
            }
            

        }

        public static void DisplayGameBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                Console.Write(row);
                for (int col = 0; col < 8; col++)
                {
                    Console.Write($" | {gameBoardPlayer1[row, col]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("    1     2     3     4     5     6     7     8");
        }
    }

    
}
