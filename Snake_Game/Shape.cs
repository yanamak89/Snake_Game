namespace Snake_Game;

public class Shape
{
    protected List<Point> _points;

    public void DrawLine()
    {
        foreach (Point point in _points)
        {
            point.DrawPoint();
        }
    }
}