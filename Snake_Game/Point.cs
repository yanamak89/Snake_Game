using Snake_Game.Enums;

namespace Snake_Game;

public class Point
{
    private int _left;
    private int _top;
    private char _symbol;

    public int Left
    {
        get { return _left; }
    } 
    public int Top
    {
        get { return _top; }
    }

    public char Symbol
    {
        get { return _symbol;}
        set { _symbol = value; }
    }

    public Point(Point snakeTail)
    {
        _left = snakeTail._left;
        _top = snakeTail._top;
        _symbol = snakeTail._symbol;
    }

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

    public void SetDirection(int i, DirectionEnum direction)
    {
        switch (direction)
        {
            case DirectionEnum.Right:
                _left = _left + i;
                break;
            case DirectionEnum.Left:
                _left = _left - i;
                break;
            case DirectionEnum.Up:
                _top = _top - i;
                break;
            case DirectionEnum.Down:
                _top = _top + i;
                break;
        }
    }

    public void ClearPoint()
    {
        _symbol = ' ';
        DrawPoint();
    }

    public bool ComparePoints(Point point)
    {
        return point._left == _left && point._top == _top;
    }
}