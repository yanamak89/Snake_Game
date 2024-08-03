using NUnit.Framework;
using Snake_Game.Helper;

namespace SnakeGame.Tests;

[TestFixture]
public class ColorHelperTests
{
    [Test]
    [TestCase(0, ConsoleColor.White)] //Default case
    [TestCase(1, ConsoleColor.Red)]
    [TestCase(2, ConsoleColor.Green)]
    [TestCase(3, ConsoleColor.Yellow)]
    [TestCase(4, ConsoleColor.Blue)]
    [TestCase(5, ConsoleColor.Magenta)]
    [TestCase(6, ConsoleColor.White)] //Default case
    public void GetRandomColor_ShouldReturnCorrectColor(int value, ConsoleColor expectedColor)
    {
        //Act
        var result = ColorHelper.GetRandomColor(value);
        
        //Debugging output 
        Console.WriteLine($"Value: {value}, Expected: {expectedColor}, Result: {result}");
        
        //Assert
        Assert.That(result, Is.EqualTo(expectedColor));
    }




}