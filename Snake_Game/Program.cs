using Snake_Game.UI;
using Snake_Game.UserService;

namespace Snake_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamePlay = new GamePlay();
            var userService = new UserServices.UserService();
            var uiService = new UIService(gamePlay, userService);

            uiService.GameMenu();
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                uiService.GetCommand(key);
            }
        }
    }
}