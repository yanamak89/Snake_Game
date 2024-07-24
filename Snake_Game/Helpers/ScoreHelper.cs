namespace Snake_Game.Helper;

public class ScoreHelper
{
    public static void GetScore(int score)
    {
        Console.SetCursorPosition(2,27);
        Console.WriteLine($"Score: {score}");
    }
}