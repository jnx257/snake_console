using System;
using campus;

namespace Snake
{
    class CreateSnake
    {
        private int[] InitalPosition;
        private int SnakeSize;

        public CreateSnake(int initalRow, int initialColumn, Grid gameGrid)
        {
            InitalPosition = new int[] { initalRow, initialColumn };
            SnakeSize = 0;
            gameGrid.SetCell(initalRow, initialColumn, 1);
        }

        // Display snake in Console
        public void DisplaySnake(Grid gameGrid)
        {
            gameGrid.DrawGrid();
        }

        
        public void Move(Grid gameGrid)
        {
            //soon I'm going to creat moving method.
        }
    }
}
