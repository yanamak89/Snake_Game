using Snake_Game;
using Snake_Game.Enums;
using Snake_Game.Factory;
using Snake_Game.Helper;
using Snake_Game.Installers;
using Snake_Game.Lines;
using Snake_Game.UI;
using Snake_Game.UserService;


class Program
{
    // update with solid
    static void Main(string[] args)
    {
        UIService uiService = new UIService();
        uiService.GameMenu();
        
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            
            uiService.GetCommand(key.Key);
            
        }
    }
}