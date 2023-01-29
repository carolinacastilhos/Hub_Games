using Hub_de_Jogos.Entities;
using Hub_de_Jogos.View;

namespace Hub_de_Jogos.Service
{
    public class TicTacToe

    {
        public static void WelcomeTicTacToe()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\tWelcome to Tic Tac Toe!\n");
            Console.ResetColor();
            Console.Write("\tPlayer1, your character is ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("X");
            Console.ResetColor();
            Console.WriteLine(", okay?\n");
            Console.Write("\tAnd Player2, your character is ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("O");
            Console.ResetColor();
            Console.WriteLine("!\n");
            Console.WriteLine("\tAre you both ready? So let's get started!");
            Console.Write("\n\tPress any key to start... ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ShowTicTacToeTitle()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("________________________________________");
            Console.WriteLine("                TIC TAC TOE!             ");
            //Console.WriteLine("________________________________________\n");
            Console.ResetColor();
        }

        public static void StartTicTacToe()
        {
            GameBoardTicTacToe board = new GameBoardTicTacToe();

            WelcomeTicTacToe();
            ShowTicTacToeTitle();

            Player player1 = new Player();
            player1.Character = 'X';
            Player player2 = new Player();
            player2.Character = 'O';
            Player currentPlayer = player1;

            int turnCounter = 0;
            bool play = true;            

            while (play)
            {

                board.DisplayGameBoard();
                Console.Write("\n{0}, in which position do you want to put your character {1}? ", currentPlayer, currentPlayer.Character);
                int.TryParse(Console.ReadLine(), out int playerMove);
                Console.WriteLine();

                if (board[row, col] == playerMove)
                {
                    board[row, col] = currentPlayer.Character;
                }

                /*if (playerMove < 1 || playerMove > 9)
                {
                    Print.InvalidInputWarning();
                }*/


                ChangeCurrentPlayer(currentPlayer, player1, player2);
                turnCounter++;


                if (turnCounter == 9)
                {
                    TictactoeTie(player1, player2);
                    play = false;
                }
                
                /*if ()
                {
                    TictactoeWin(player1, player2, currentPlayer);
                    play = false;
                }*/
            }
        }

        public void ChangingGameBoard(GameBoardTicTacToe[,] board, int playerMove)
        {
            
        }

        public static void PlayersMoves(Player currentPlayer, Player player1, Player player2)
        {
            Console.Write("\n{0}, in which position do you want to put your character {1}? ", currentPlayer, currentPlayer.Character);
            int.TryParse(Console.ReadLine(), out int playerMove);
            Console.WriteLine();

            /*if (playerMove < 1 || playerMove > 9)
            {
                Print.InvalidInputWarning();
            }*/


        }

        public static Player ChangeCurrentPlayer(Player currentPlayer, Player player1, Player player2)
        {
            return currentPlayer == player1 ? player2 : player1;
        }

        public static void TictactoeTie(Player player1, Player player2)
        {
            player1.TieMatches();
            player1.AddPlayedMatches();
            player2.TieMatches();
            player2.AddPlayedMatches();
            Print.ShowTieMessage();
        }

        public static void TictactoeWin(Player player1, Player player2, Player currentPlayer)
        {
            player1.AddPlayedMatches();
            player2.AddPlayedMatches();
            currentPlayer.WinMatches();
            
            if (currentPlayer == player1)
            {
                player2.LoseMatches();
            }
            else if (currentPlayer == player2)
            {
                player1.LoseMatches();
            }

            Print.ShowVictoryMessage(); //TODO botar nome do currentplayer na mensagem de vitoria
        }        
                       
    }
}
