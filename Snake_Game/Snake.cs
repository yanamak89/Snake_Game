using Snake_Game.Enums;

namespace Snake_Game;

public class Snake : Shape
{
     //Realize with singletone


     public Snake()
     {
          _points = new List<Point>();
     }
     public Snake CreateSnake(int length,  Point snakeTail,
          DirectionEnum direction)
     {
          for (int i = 0; i < length; i++)
          {
               Point point = new Point(snakeTail);
               point.SetDirection(i, direction);
               _points.Add(point);
          }
          return new Snake();
     }
}