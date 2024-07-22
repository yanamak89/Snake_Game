namespace Snake_Game.Factory;

public static class FoodFactory
{
    private static Random _random = new Random();

    public static Point GetRandomFood(int spaceWidth, int spaceHeight, char symbol)
    {
        spaceWidth = _random.Next(1, spaceWidth - 1);
        spaceHeight = _random.Next(1, spaceHeight - 1);
        return new Point(spaceWidth, spaceHeight, symbol);
    }
}