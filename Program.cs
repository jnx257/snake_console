using System;
using System.Threading;
using campus;
using Snake;


namespace SnakeGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Grid myGrid = new Grid(20, 40);
            CreateSnake snake = new CreateSnake(10, 20, myGrid);
            CreateSnake.Direction currentDir = CreateSnake.Direction.Right;
            Random random = new Random();
            Food food = GenerateRandomFood(myGrid, random);

            Console.Clear();

            Console.WriteLine("________________________________________");
            Console.WriteLine("__________Jnx_lucca_SnakeGame___________");
            Console.WriteLine("________________________________________");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(intercept: true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            currentDir = CreateSnake.Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            currentDir = CreateSnake.Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            currentDir = CreateSnake.Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            currentDir = CreateSnake.Direction.Right;
                            break;
                    }
                }

                snake.Move(myGrid, currentDir);

                if (snake.Eating(food))
                {
                    snake.Grow();
                    food = GenerateRandomFood(myGrid, random);
                }


                Console.Clear();
                myGrid.DrawGrid(food, snake.GetBodyPositions());
                Thread.Sleep(80);
            }
        }

        static Food GenerateRandomFood(Grid grid, Random random)
        {
            int maxRow = grid.GetRows() - 2;
            int maxCol = grid.GetColumns() - 2;

            int randomRow = random.Next(1, maxRow);
            int randomCol = random.Next(1, maxCol);

            return new Food(randomRow, randomCol);
        }
    }
}
