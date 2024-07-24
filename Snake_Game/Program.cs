﻿using Snake_Game;
using Snake_Game.Enums;
using Snake_Game.Factory;
using Snake_Game.Helper;
using Snake_Game.Installers;
using Snake_Game.Lines;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int score = 0;
        
        LineInstaller line = new LineInstaller();
        line.DrawShapes();

        Point food = FoodFactory.GetRandomFood(119, 19, '+'); // Use dimensions that match the drawing
        Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
        food.DrawPoint();
        
        Console.ResetColor();

        Snake snake = new Snake();
        snake.CreateSnake(
            5, new Point(5, 5, '~'), 
            DirectionEnum.Right);
        snake.DrawLine();
        
        ScoreHelper.GetScore(score);
        

        while (true)
        {
            if (line.Collision(snake))
            {
                break;
            }

            if (snake.Eat(food))
            {
                score++;
                ScoreHelper.GetScore(score);
                
                food = FoodFactory.GetRandomFood(119, 19, '+'); // Use dimensions that match the drawing
                Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
                food.DrawPoint();
                Console.ResetColor();
            }
            Thread.Sleep(100);
            snake.Move();
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.PressKey(key.Key);
            }
        }
        Console.WriteLine("Game over");
    }
}