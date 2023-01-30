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

            StartTicTacToe();
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

            ShowTicTacToeTitle();
            GameBoardTicTacToe.InititalizeGameBoard();
            GameBoardTicTacToe.DisplayGameBoard();

            Player player1 = new Player();
            player1.Character = "X";
            player1.Nickname = "Carol";
            Player player2 = new Player();
            player2.Character = "O";
            player2.Nickname = "Bruno";
            Player currentPlayer = player1;

            int turnCounter = 1;

            Console.Write("\n{0}, in which position do you want to put your character {1}? ", currentPlayer.Nickname, currentPlayer.Character);
            int.TryParse(Console.ReadLine(), out int playerMove);
            Console.WriteLine();

            Console.Clear();

            while (turnCounter < 9)
            {
                ShowTicTacToeTitle();

                int counter = 1;
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (counter == playerMove)
                        {
                            if (GameBoardTicTacToe.board[row, col] == "X" || GameBoardTicTacToe.board[row, col] == "O")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n This position is taken. Please, choose another one.");
                                Console.ResetColor();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                GameBoardTicTacToe.board[row, col] = currentPlayer.Character;

                            }
                        }
                        counter++;
                    }
                }

                GameBoardTicTacToe.DisplayGameBoard();

                //check diagonals
                if (GameBoardTicTacToe.board[0, 0] == GameBoardTicTacToe.board[1, 1] && GameBoardTicTacToe.board[1, 1] == GameBoardTicTacToe.board[2, 2]
                 || GameBoardTicTacToe.board[0, 2] == GameBoardTicTacToe.board[1, 1] && GameBoardTicTacToe.board[1, 1] == GameBoardTicTacToe.board[2, 0])
                {
                    TictactoeWin(player1, player2, currentPlayer);
                    break;
                }

                //check rows
                if (GameBoardTicTacToe.board[0, 0] == GameBoardTicTacToe.board[0, 1] && GameBoardTicTacToe.board[0, 1] == GameBoardTicTacToe.board[0, 2]
                    || GameBoardTicTacToe.board[1, 0] == GameBoardTicTacToe.board[1, 1] && GameBoardTicTacToe.board[1, 1] == GameBoardTicTacToe.board[1, 2]
                    || GameBoardTicTacToe.board[2, 0] == GameBoardTicTacToe.board[2, 1] && GameBoardTicTacToe.board[2, 1] == GameBoardTicTacToe.board[2, 2])
                {
                    TictactoeWin(player1, player2, currentPlayer);
                    break;
                }

                //check columns
                if (GameBoardTicTacToe.board[0, 0] == GameBoardTicTacToe.board[1, 0] && GameBoardTicTacToe.board[1, 0] == GameBoardTicTacToe.board[2, 0]
                    || GameBoardTicTacToe.board[0, 1] == GameBoardTicTacToe.board[1, 1] && GameBoardTicTacToe.board[1, 1] == GameBoardTicTacToe.board[2, 1]
                    || GameBoardTicTacToe.board[0, 2] == GameBoardTicTacToe.board[1, 2] && GameBoardTicTacToe.board[1, 2] == GameBoardTicTacToe.board[2, 2])
                {
                    TictactoeWin(player1, player2, currentPlayer);
                    break;
                }

                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }                    
                else
                {
                    currentPlayer = player1;
                }                    

                Console.Write("\n{0}, in which position do you want to put your character {1}? ", currentPlayer.Nickname, currentPlayer.Character);
                int.TryParse(Console.ReadLine(), out playerMove);
                Console.WriteLine();

                turnCounter++;
                Console.Clear();
            }

            if (turnCounter == 9)
            {
                ShowTicTacToeTitle();
                GameBoardTicTacToe.DisplayGameBoard();
                TictactoeTie(player1, player2);
            }
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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tEnd of Match!");
            Console.WriteLine("\n\tCongratulations {0}, you win!", currentPlayer.Nickname);
            Console.ResetColor();
            Print.ShowContinueMessage();
        }       

    }
} 
