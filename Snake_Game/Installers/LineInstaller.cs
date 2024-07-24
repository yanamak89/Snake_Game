using Snake_Game.Lines;

namespace Snake_Game.Installers;

public class LineInstaller
{
    private List<Shape> _shapes;

    public LineInstaller()
    {
        _shapes = new List<Shape>();
        
        HorisontalLine upLine = new HorisontalLine(0, 0, '-', 120);
        HorisontalLine downLine = new HorisontalLine(0, 20, '-', 120);
        
        VerticalLine leftLine = new VerticalLine(0, 1, '|', 19);
        VerticalLine rightLine = new VerticalLine(119, 1, '|', 19);
        
        _shapes.AddRange(new List<Shape>{upLine, downLine, leftLine, rightLine});
    }

    public void DrawShapes()
    {
        foreach (var item in _shapes)
        {
            item.DrawLine();
        }
    }

    public bool Collision(Shape shape)
    {
        foreach (var item in _shapes)
        {
            if (item.Collision(shape))
                return true;
        }

        return false;
    }
}