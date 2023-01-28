using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.View
{
    public class Print
    {
        public void RedWarning(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void GreenWarning(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void WelcomeHub()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to Game Hub!\n");
            Console.ResetColor();
        }

        public void ExitHub()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nClosing Game Hub... Thanks for spending this time with us!\n");
            Console.WriteLine("Come back whenever you want to have fun!");
            Console.ResetColor();
        }

        public void ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Main Menu \n");
            Console.ResetColor();

            Console.WriteLine("\t1. Players Menu");
            Console.WriteLine("\t2. Ranking");
            Console.WriteLine("\t3. Play TicTacToe");
            Console.WriteLine("\t4. Play BattleShip");
            Console.WriteLine("\t5. Leave Game Hub\n");

            Console.Write("Enter your option: ");
        }

        public void ShowPlayersMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Players Menu \n");
            Console.ResetColor();

            Console.WriteLine("\t1. Register new player");
            Console.WriteLine("\t2. Delete player");
            Console.WriteLine("\t3. Details of a player");
            Console.WriteLine("\t4. Return to Main Menu\n");
            
            Console.Write("Enter your option: ");
        }

        public void ShowContinueMessage()
        {
            Console.WriteLine("\nPlase, press any key to continue...");
            Console.ReadKey();
        }

    }
}
