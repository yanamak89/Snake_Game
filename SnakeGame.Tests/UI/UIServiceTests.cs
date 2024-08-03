using NSubstitute;
using NUnit.Framework;
using Snake_Game;
using Snake_Game.UI;
using Snake_Game.UserService;
using Snake_Game.UserServices;

namespace SnakeGame.Tests.UI;

[TestFixture]
public class UIServiceTests
{
    private UIService _uiService;
    private GamePlay _gamePlay;
    private UserService _userService;
    private User _user;

    [SetUp]
    public void SetUp()
    {
        _gamePlay = Substitute.For<GamePlay>();
        _userService = Substitute.For<UserService>();
        _uiService = new UIService(_gamePlay, _userService);
        _user = new User { Name = "TestUser", Score = 0 };
        Console.WriteLine("SetUp complete. User initialized.");
    }

    [Test]
    public void GameMenu_ShouldClearConsoleAndDisplayMenu()
    {
        //Arrange
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        //Console.WriteLine("Testing GameMenu...");

        //Act
        _uiService.GameMenu();
        
        //Assert
        var output = stringWriter.ToString();
        Console.WriteLine($"GameMane output: {output}");
        Assert.That(output, Contains.Substring("||---------------------------------------------------||"));
        Assert.That(output, Contains.Substring("||                                                   ||"));
        Assert.That(output, Contains.Substring("||               Welcome to Snake Game               ||"));
        Assert.That(output, Contains.Substring("||                                                   ||"));
        Assert.That(output, Contains.Substring("||-------------------------------------------------- ||"));
        Assert.That(output, Contains.Substring("||                                                   ||"));
        Assert.That(output, Contains.Substring("||            Press Enter to start the game          ||"));
        Assert.That(output, Contains.Substring("||                                                   ||"));
        Assert.That(output, Contains.Substring("||            Use arrows to move the snake           ||"));
        Assert.That(output, Contains.Substring("||            Press C to create the user             ||"));
        Assert.That(output, Contains.Substring("||            Press S to get all scores              ||"));
        Assert.That(output, Contains.Substring("||            Press ESC to quit the game             ||"));
        Assert.That(output, Contains.Substring("||                                                   ||"));
        Assert.That(output, Contains.Substring("||---------------------------------------------------||"));
    }
}