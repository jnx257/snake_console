using System;
using campus;
using Snake;

namespace SnakeGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Grid myGrid = new Grid(20, 40);
            myGrid.Clear();

            Console.WriteLine("________________________________________");
            Console.WriteLine("__________Jnx_lucca_SnakeGame___________");
            Console.WriteLine("________________________________________");

            CreateSnake snake = new CreateSnake(10, 20, myGrid);

            snake.DisplaySnake(myGrid);
            
            // snake.Move(); 

        }
    }
}
