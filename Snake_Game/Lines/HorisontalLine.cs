namespace Snake_Game.Lines;

public class HorisontalLine : Shape
{
    public HorisontalLine(int left, int top, char symbol, int count)
    {
        _points = new List<Point>();
        for (int i = left; i < count; i++)
        {
            Point point = new Point(i, top, symbol);
            _points.Add(point);
        }
    }
    
}