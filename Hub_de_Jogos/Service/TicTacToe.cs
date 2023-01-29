using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Hub_de_Jogos.Entities;


namespace Hub_de_Jogos.Service
{
    public class TicTacToe
    {
        //no construtor será false. Virará true ao terminar as jogadas totais ou terminar as verificações. 

        public static void WelcomeTicTacToe()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("\n\tWelcome to Tic Tac Toe!\n");
            Console.ResetColor();
            Console.Write("\tPlayer1, your character is ");
            Console.ForegroundColor= ConsoleColor.DarkYellow;
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
            board.DisplayGameBoard();
                        
            // bool endOfGame = false;
                        
            Console.WriteLine();
            Console.Write("{0}, in which position do you want to put your character? ");
            string move = Console.ReadLine();
            Console.WriteLine();

            
            

        }

    }
}
