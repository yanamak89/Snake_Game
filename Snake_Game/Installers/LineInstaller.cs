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
        
        VerticalLine leftLine = new VerticalLine(0, 1, '|', 20);
        VerticalLine rightLine = new VerticalLine(119, 1, '|', 20);
        
        _shapes.AddRange(new List<Shape>{upLine, downLine, leftLine, rightLine});
    }

    public void DrawShapes()
    {
        foreach (var item in _shapes)
        {
            item.DrawLine();
        }
    }
}