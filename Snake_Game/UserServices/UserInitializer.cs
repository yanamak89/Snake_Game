using Snake_Game.UserService;
namespace Snake_Game.UserServices;

public class UserInitializer
{
    public static List<User> GetSampleUserData()
    {
        List<User> users = new List<User>();
        users.Add(new User {Name = "Some name", Score = 123});
        users.Add(new User {Name = "Some name2", Score = 124});
        users.Add(new User {Name = "Simple user", Score = 3});
        users.Add(new User {Name = "Professional user", Score = 500});
        return users;
    }
}