
using Hub_de_Jogos.View;
using Hub_de_Jogos.Entities;
using Newtonsoft.Json;

namespace Hub_de_Jogos.Service
{
    public class LoginPlayers
    {
        private static string _pathPlayersData = @"../../../Repository/PlayersData.json";

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
                        RegisterPlayer();
                        break;
                    case 2:
                        DeletePlayer();
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
            Console.Write("\n\tWhat is your nickname? ");
            string nickname = Console.ReadLine()!;
            Console.Write("\n\tChoose a password: ");
            string password = Console.ReadLine()!;

            Player player = new Player (nickname, password);

            string jsonPlayers = File.ReadAllText(_pathPlayersData);

            var playersData = JsonConvert.DeserializeObject<List<Player>>(jsonPlayers);
            playersData.Add(player);
            jsonPlayers = JsonConvert.SerializeObject(playersData);
            File.WriteAllText(_pathPlayersData, jsonPlayers);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlayer successfully registered.");
            Console.ResetColor();
            Print.ShowContinueMessage();
            //Thread.Sleep(5000);
        }

        public static void DeletePlayer()
        {

        }
    }
}
