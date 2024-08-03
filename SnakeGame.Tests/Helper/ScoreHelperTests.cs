using NUnit.Framework.Legacy;

namespace SnakeGame.Tests;
using NUnit.Framework;
using Snake_Game.Helper;
using System;
using System.IO;

[TestFixture]
public class ScoreHelperTests
{
    private StringWriter _stringWriter;

    [SetUp]
    public void SetUp()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }

    [TearDown]
    public void TearDown()
    {
        _stringWriter.Dispose();
    }

    [Test]
    public void GetScore_ShouldSetCursorPOsitionAndPrintScore()
    {
        //Arrange
        int score = 10;
        
        //Act
        ScoreHelper.GetScore(score);
        
        //Assert
        var output = _stringWriter.ToString();
        Console.WriteLine($"Captured Output: {output}");

        StringAssert.Contains($"Score: {score}", output);
    }
}