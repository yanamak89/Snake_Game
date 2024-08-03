using Snake_Game.UserService;

namespace Snake_Game.UI;

public class UIService
{
    private GamePlay _gamePlay = new GamePlay();
    private UserServices.UserService _userService = new UserServices.UserService();
    private User _user = new User();
    
    public UIService(GamePlay gamePlay, UserServices.UserService userService)
    {
        _gamePlay = gamePlay;
        _userService = userService;
    }
    public void GameMenu()
    {
        Console.Clear();
        Console.SetCursorPosition(30,5);
        Console.WriteLine("||---------------------------------------------------||");
        Console.SetCursorPosition(30,6);
        Console.WriteLine("||                                                   ||");
        Console.SetCursorPosition(30,7);
        Console.WriteLine("||               Welcome to Snake Game               ||");
        Console.SetCursorPosition(30,8);
        Console.WriteLine("||                                                   ||");
        Console.SetCursorPosition(30,9);
        Console.WriteLine("||-------------------------------------------------- ||");
        Console.SetCursorPosition(30,10);
        Console.WriteLine("||                                                   ||");
        Console.SetCursorPosition(30,11);
        Console.WriteLine("||            Press Enter to start the game          ||");
        Console.SetCursorPosition(30,12);
        Console.WriteLine("||                                                   ||");
        Console.SetCursorPosition(30,13);
        Console.WriteLine("||            Use arrows to move the snake           ||");
        Console.SetCursorPosition(30,14);
        Console.WriteLine("||            Press C to create the user             ||");
        Console.SetCursorPosition(30,15);
        Console.WriteLine("||            Press S to get all scores              ||");
        Console.SetCursorPosition(30,16);
        Console.WriteLine("||            Press ESC to quit the game             ||");
        Console.SetCursorPosition(30,17);
        Console.WriteLine("||                                                   ||");
        Console.SetCursorPosition(30,18);
        Console.WriteLine("||---------------------------------------------------||");
    }

    public void GetCommand(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.Enter:
                StartGame();
                break;
            case ConsoleKey.C:
                CreateUserForm();
                break;
            case ConsoleKey.S:
                ScoreBoard();
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
            default:
                GameMenu();
                break;
        }
        
    }

    private void StartGame()
    {
        Console.Clear();
        _gamePlay.StartGame(_user);
        Concede();
    }
    
    private void CreateUserForm()
    {
        Console.Clear();
        Console.WriteLine("Create User Form");
        
        Label:
        Console.WriteLine("Enter your name please: ");
        string userName = Console.ReadLine();
        
        try
        {
            _user = _userService.CreateUser(userName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            goto Label;
        }
        
        Console.WriteLine("The new user was saved");
        
        Console.WriteLine("Press Backspace to return");
    }
    private void ScoreBoard()
    {
        Console.Clear();
        Console.WriteLine("Score Board");
        
        IEnumerable<User> users = _userService.GetAllUsers();
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Name} with score: {user.Score}");
        }

        Console.WriteLine("Press Backspace to return");
    }

    private void Concede()
    {
        Console.Clear();
        Console.WriteLine("Game over");
        Console.WriteLine("To try again press Enter");
        Console.WriteLine("Back to menu press Backspace");
    }

}