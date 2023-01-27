using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.Entities
{
    public class Player
    {
        public string Nickname { get; private set; } = null!;
        public string Password { get; private set; } = null!;
        public int Victories { get; private set; }
        public int Defeats { get; private set; }
        public int Ties { get; private set; }
        public int Match { get; private set; }

        public Player(string nickname, string password)
        {
            Nickname = nickname;
            Password = password;
            Victories = 0;
            Defeats = 0;
            Ties = 0;
            Match = 0;
        }

        //métodos
        public int WinMatches()
        {
            Victories++;
            return Victories;
        }

        public int LoseMatches()
        {
            Defeats++;
            return Defeats;
        }

        public int TieMatches()
        {
            Ties++;
            return Ties;
        }

        public int AddPlayedMatches()
        {
            Match++;
            return Match;
        }

    }
}
