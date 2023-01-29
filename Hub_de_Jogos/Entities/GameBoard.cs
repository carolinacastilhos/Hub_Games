using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.Entities
{
    public class GameBoard //ver sobre abstrata
    {
        public string[,] board;

        public virtual void DisplayGameBoard()
        {
            Console.WriteLine("Display GameBoard");
        }

        public virtual void PlayersMove() 
        {
            Console.WriteLine("Put character in a position on the gameboard");
        }
        

    }
}
