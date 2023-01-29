using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.View
{
    public class Print
    {
        public static void InvalidInputWarning()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Invalid Input. Please, try again.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        
        public static void WelcomeHub()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\tWelcome to Game Hub!");
            Console.ResetColor();
        }

        public static void ExitHub()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nClosing Game Hub... Thanks for spending this time with us!\n");
            Console.WriteLine("Come back whenever you want to have fun!");
            Console.ResetColor();
        }

        public static void ShowMainMenu()
        {
            WelcomeHub();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\t Main Menu \n");
            Console.ResetColor();

            Console.WriteLine("\t1. Players Menu");
            Console.WriteLine("\t2. Ranking");
            Console.WriteLine("\t3. Play TicTacToe");
            Console.WriteLine("\t4. Play BattleShip");
            Console.WriteLine("\t5. Leave Game Hub\n");

            Console.Write("\tEnter your option: ");
        }

        public static void ShowPlayersMenu()
        {

            Console.Clear();
            WelcomeHub();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\t Players Menu \n");
            Console.ResetColor();

            Console.WriteLine("\t1. Register new player");
            Console.WriteLine("\t2. Delete player");
            Console.WriteLine("\t3. Details of a player");
            Console.WriteLine("\t4. Return to Main Menu\n");
            
            Console.Write("\tEnter your option: ");

        }

        public static void ShowContinueMessage()
        {
            Console.WriteLine("\nPlase, press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ShowTieMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tOops! It's a tie!");
            Console.ResetColor();
            Print.ShowContinueMessage();
        }

        public static void ShowVictoryMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tEnd of Match!");
            Console.WriteLine("\n\tCongratulations {0}, you win!"); //ajustar nome do player que ganhou
            Console.ResetColor();
        }
               
    }
}
