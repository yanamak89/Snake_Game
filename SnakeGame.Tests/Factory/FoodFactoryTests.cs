using System.Drawing;
using NUnit.Framework;
using Snake_Game.Factory;
using Point = Snake_Game.Point;

namespace SnakeGame.Tests;

[TestFixture]
public class FoodFactoryTests
{
    [Test]
    public void GetRandomFood_ShouldReturnPointWithinBounds()
    {
        //Arrange
        int spaceWidth = 100;
        int spaceHeight = 100;
        char symbol = '+';
        
        //Act
        Point food = FoodFactory.GetRandomFood(spaceWidth, spaceHeight, symbol);
        
        // Debugging output
        Console.WriteLine($"Generated Point: X = {food.Left}, Y = {food.Top}, Symbol = {food.Symbol}");

        //Assert
        Assert.That(food.Left, Is.InRange(1, spaceWidth - 2), "X coordinate out of range");
        Assert.That(food.Top, Is.InRange(1, spaceHeight - 2), "Y coordinate out of range");
        Assert.That(food.Symbol, Is.EqualTo(symbol), "Symbol mismatch");   }

    [Test]
    public void GetRandomFood_ShouldReturnDifferentPointsOnSubsequentCalls()
    {
        //Arrange
        int spaceWidth = 100;
        int spaceHeight = 100;
        char symbol = '+';
        
        //Act
        Point food1 = FoodFactory.GetRandomFood(spaceWidth, spaceHeight, symbol);
        Point food2 = FoodFactory.GetRandomFood(spaceWidth, spaceHeight, symbol);
        
        //Debugging output 
        Console.WriteLine($"Generated Point 1: Left = {food1.Left}, Top = {food1.Top}, Symbol = {food1.Symbol}");
        Console.WriteLine($"Generated Point 2: Left = {food2.Left}, Top = {food2.Top}, Symbol = {food2.Symbol}");
       
        //Assert
        Assert.That(food1.Left, Is.Not.EqualTo(food2.Left));
        Assert.That(food1.Top, Is.Not.EqualTo(food2.Top));

    }
    
    
    
}