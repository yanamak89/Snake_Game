using Snake_Game.UserService;

namespace Snake_Game.UserServices;

//Add inteface IUserServece 

public class UserService
{
    List<User> _users;
    
    public UserService()
    {
        _users = UserInitializer.GetSampleUserData();
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _users.OrderByDescending(x => x.Score);
    }

    public User CreateUser(string name)
    {
        User user = new User();
        var exitUser = _users.Select(x => x.Name);

        try
        {
            if (name == "")
                throw new ArgumentException("Name is empty");
            
            if(exitUser.Contains(name))
                throw new ArgumentException("The user already exists");
        }
        catch (Exception ex)
        {
            throw ex;
        }

        user.Name = name;
        
        _users.Add(user);
        return user;
    }

    public void SaveScore(User user)
    {
        if(user.Name == null)
            return;
        
        _users.Add(user);
    }
}