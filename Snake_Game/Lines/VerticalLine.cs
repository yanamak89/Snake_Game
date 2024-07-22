namespace Snake_Game.Lines;

public class VerticalLine : Shape
{

    public VerticalLine(int left, int top, char symbol, int count)
    {
        _points = new List<Point>();
        for (int i = top; i < top + count; i++)
        {
            Point point = new Point(left, i, symbol);
            _points.Add(point);
        }
    }
    
}