using System;
using Hub_de_Jogos.View;
using Hub_de_Jogos.Entities;
using Hub_de_Jogos.Service;
using System.Diagnostics.Metrics;


namespace Hub_de_Jogos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int option;

            do
            {
                Print.ShowMainMenu();
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        LoginPlayers.ManipulatePlayers();
                        break;
                    case 2:
                        //TODO ranking
                        break;
                    case 3:
                        TicTacToe.WelcomeTicTacToe();
                        break;
                    case 4:
                        //TODO BattleShip
                        break;
                    case 5:
                        Print.ExitHub();
                        break;
                    default:
                        Print.InvalidInputWarning();
                        break;
                }
            } while (option != 5);      
        }
    }
}