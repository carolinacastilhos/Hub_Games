using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.Service
{
    public class TicTacToe
    {
        public bool EndOfGame; //no construtor será false. Virará true ao terminar as jogadas totais ou terminar as verificações. 

        public void TicTacToeTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("________________________________________");
            Console.WriteLine("                TIC TAC TOE!             ");
            Console.WriteLine("________________________________________\n");
            Console.ResetColor();
        }
        
        public void InitializeTicTacToe()
        {


        }

    }
}
