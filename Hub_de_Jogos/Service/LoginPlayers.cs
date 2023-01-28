using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hub_de_Jogos.View;
using Hub_de_Jogos.Entities;

namespace Hub_de_Jogos.Service
{
    public class LoginPlayers
    {
        public static void ManipulatePlayers()
        {
            int option;

            do
            {
                Print.ShowPlayersMenu();
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        //TODO register player
                        break;
                    case 2:
                        //TODO delete player
                        break;
                    case 3:
                        //TODO details
                        break;
                    case 4:
                        Print.ShowContinueMessage();
                        break;
                    default:
                        Print.InvalidInputWarning();
                        break;
                }

            } while (option != 4);
        }

        public static void RegisterPlayer()
        {
            Player newPlayer = new Player(string nicname, string password); //como fazer para adicionar o nome e senha do player? no construtor?
        }
    }
}
