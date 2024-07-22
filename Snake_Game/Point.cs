namespace Snake_Game;

public class Point
{
    private int _left;
    private int _top;
    private char _symbol;

    public Point(int left, int top, char symbol)
    {
        _left = left;
        _top = top;
        _symbol = symbol;
    }

    public void DrawPoint()
    {
        Console.SetCursorPosition(_left, _top);
        Console.Write(_symbol);
    }
}