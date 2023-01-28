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
        
        public void ShowTicTacToeTitle()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("________________________________________");
            Console.WriteLine("                TIC TAC TOE!             ");
            Console.WriteLine("________________________________________\n");
            Console.ResetColor();
        }
        
        public void StartTicTacToe()
        {
            GameBoardTicTacToe board = new GameBoardTicTacToe();

            ShowTicTacToeTitle();
            board.DisplayGameBoard();
                        
           // bool endOfGame = false;
                        
            Console.WriteLine();
            Console.Write("{0}, in which position do you want to put your character? ", player);
            string move = Console.ReadLine();
            Console.WriteLine();


            while (!endOfGame)
            {

            }
            

        }

    }
}
