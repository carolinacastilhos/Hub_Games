using Hub_de_Jogos.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Hub_de_Jogos.Service
{
    public class BattleShip
    {
        public static void WelcomeBattleShip()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tWelcome to BattleShip!\n");
            Console.ResetColor();
            Console.WriteLine("\tThe enemy is attacking us by the sea!");
            Console.WriteLine("\tWe have to choose some coordenates to drop bombs on their positions.");

            Console.WriteLine("\nhey, we need to be smart... We only have 10 bombs and they have 5 ships there!");
            Console.WriteLine("\tIf we're lucky, we'll hit one of their battleships.");                     

            Console.WriteLine("\n\tSo let's go!\n");                        
            Console.Write("\n\tPress any key to start... ");
            Console.ReadKey();
            Console.Clear();

            StartBattleShip();
        }

        public static void ShowBattleShipTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("________________________________________");
            Console.WriteLine("                BATTLESHIP!             ");
            //Console.WriteLine("________________________________________\n");
            Console.ResetColor();
        }

        public static void StartBattleShip()
        {

            ShowBattleShipTitle();
                        
            Player player1 = new Player();
            player1.Nickname = "Carol";
            Player player2 = new Player();
            player2.Nickname = "Bruno";
            Player currentPlayer = player1;


            Console.Write("\n{0}, enter the position you want to drop a bomb: ", currentPlayer.Nickname);
            int.TryParse(Console.ReadLine(), out int playerMove);
            Console.WriteLine();





            /*int shipPlayer1Position;
            int shipPlayer2Position;

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                shipPlayer1Position = random.Next(1, 64);

            }*/

        }

        
        

    }
}
