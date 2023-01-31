using Hub_de_Jogos.Entities;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Hub_de_Jogos.Service
{
    public class BattleShip
    {
        public static void WelcomeBattleShip()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tWelcome to BattleShip!\n");
            Console.ResetColor();
            Console.WriteLine("\tThe enemy is attacking us by the sea!");
            Console.WriteLine("\tWe have to choose some coordenates to drop bombs on their positions.");

            Console.WriteLine("\n\they, we need to be smart... We only have 10 bombs and they have 5 ships there!");
            Console.WriteLine("\tIf we're lucky, we'll hit one of their battleships.");                     

            Console.WriteLine("\n\tSo let's go!\n");                        
            Console.Write("\n\tPress any key to start... ");
            Console.ReadKey();
            Console.Clear();

            StartBattleShip();
        }

        public static void ShowBattleShipTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("________________________________________");
            Console.WriteLine("                BATTLESHIP!             ");
            //Console.WriteLine("________________________________________\n");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void StartBattleShip()
        {

            ShowBattleShipTitle();
                        
            Player player1 = new Player();
            player1.Nickname = "Carol";
            Player player2 = new Player();
            player2.Nickname = "Bruno";
            Player currentPlayer = player1;

            GameBoardBattleShip.InitializeGameBoardPlayer1();
            GameBoardBattleShip.DisplayGameBoardPlayer1();

            Console.WriteLine("\n{0}, what are the coordenates you want to drop a bomb?", currentPlayer.Nickname);
            Console.Write("Please, enter the row: ");
            int.TryParse(Console.ReadLine(), out int destinationRow);
            Console.Write("Enter the column: ");
            int.TryParse(Console.ReadLine(), out int destinationCol);
            Console.WriteLine();
                        
            /*
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
                    if (GameBoardBattleShip.gameBoardPlayer1[destinationRow, destinationCol] == GameBoardBattleShip.gameBoardPlayer1[4, 8] || GameBoardBattleShip.gameBoardPlayer1[destinationRow, destinationCol] == GameBoardBattleShip.gameBoardPlayer1[5, 2] ||
                        GameBoardBattleShip.gameBoardPlayer1[destinationRow, destinationCol] == GameBoardBattleShip.gameBoardPlayer1[2, 7] || GameBoardBattleShip.gameBoardPlayer1[destinationRow, destinationCol] == GameBoardBattleShip.gameBoardPlayer1[8, 0] ||
                        GameBoardBattleShip.gameBoardPlayer1[destinationRow, destinationCol] == GameBoardBattleShip.gameBoardPlayer1[0, 1])
                    {
                        GameBoardBattleShip.gameBoardPlayer1[row, col] = "N";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"{GameBoardBattleShip.gameBoardPlayer1[row, col]}"); 
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Wow! You hit a ship, {0}!", currentPlayer.Nickname);
                        Console.ResetColor();                                               
                    }
                    else
                    {
                        GameBoardBattleShip.gameBoardPlayer1[row, col] = "X";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{GameBoardBattleShip.gameBoardPlayer1[row, col]}");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Oops! You miss the ship, {0}...", currentPlayer.Nickname);
                        Console.ResetColor();                        
                    }                    
                }
                Console.WriteLine();
                Console.WriteLine("  |---|---|---|---|---|---|---|---|");
            }    */      

        }




    }
}
