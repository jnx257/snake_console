using System;
using campus;

namespace Snake
{
    class CreateSnake
    {
        private int[] InitialPosition;
        private int SnakeSize;
        private List<int[]> BodyPositions;
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public CreateSnake(int initialRow, int initialColumn, Grid gameGrid)
        {
            InitialPosition = new int[] { initialRow, initialColumn };
            SnakeSize = 0;
            gameGrid.SetCell(initialRow, initialColumn, 1);
            BodyPositions = new List<int[]>();
        }

        // Display snake in Console
        public void DisplaySnake(Grid gameGrid, Food food, List<int[]> snakeBody)
        {
            gameGrid.DrawGrid(food, snakeBody);
            foreach (var bodyPart in BodyPositions)
            {
                gameGrid.SetCell(bodyPart[0], bodyPart[1], 2);
            }
        }

        public void Move(Grid gameGrid, Direction direction)
        {
            int newRow = InitialPosition[0];
            int newColumn = InitialPosition[1];

            switch (direction)
            {
                case Direction.Up:
                    newRow--;
                    break;
                case Direction.Down:
                    newRow++;
                    break;
                case Direction.Right:
                    newColumn++;
                    break;
                case Direction.Left:
                    newColumn--;
                    break;
            }


            if (newRow < 0)
            {
                newRow = gameGrid.GetRows() - 1;
            }
            else if (newRow >= gameGrid.GetRows())
            {
                newRow = 0;
            }

            if (newColumn < 0)
            {
                newColumn = gameGrid.GetColumns() - 1;
            }
            else if (newColumn >= gameGrid.GetColumns())
            {
                newColumn = 0;
            }

            gameGrid.ClearCell(InitialPosition[0], InitialPosition[1]);

            InitialPosition[0] = newRow;
            InitialPosition[1] = newColumn;

            gameGrid.SetCell(newRow, newColumn, 1);
        }
        public List<int[]> GetBodyPositions()
        {
            return BodyPositions;
        }
        public void Grow()
        {
            int[] newBodyPart = new int[] { InitialPosition[0], InitialPosition[1] };
            BodyPositions.Add(newBodyPart);
        }
        public bool Eating(Food food)
        {
            return InitialPosition[0] == food.Row && InitialPosition[1] == food.Column;
        }

    }
}
