using Hub_de_Jogos.Entities;


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
            Console.WriteLine("\tWe have to choose some coordenates to send bombs.");
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
            GameBoardBattleShip.InitializeGameBoardPlayer1();
            //GameBoardBattleShip.InitializeGameBoardPlayer2();
            GameBoardBattleShip.DisplayGameBoardPlayer1();
            //GameBoardBattleShip.DisplayGameBoardPlayer2();

        }



    }
}
