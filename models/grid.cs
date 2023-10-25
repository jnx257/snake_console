using System;
using System.Collections.Generic;

namespace campus
{
    public class Grid
    {
        private int rows;
        private int columns;
        private int[,] grid;

        public Grid(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            grid = new int[rows, columns];
        }

        // public void Clear()
        // {
        //     
        //  Console.Clear();
        // }

        public int GetRows()
        {
            return rows;
        }

        public int GetColumns()
        {
            return columns;
        }

        public void DrawGrid(Food food, List<int[]> snakeBody)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (row == food.Row && col == food.Column)
                    {
                        Console.Write("F");
                    }
                    else if (row == 0 || row == rows - 1 || col == 0 || col == columns - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {

                        int cellValue = grid[row, col];
                        if (cellValue == 1)
                        {
                            Console.Write("■");
                        }
                        else if (cellValue == 2)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public void SetCell(int row, int col, int value)
        {
            if (row < 0)
            {
                row = GetRows() - 1;
            }
            else if (row >= GetRows())
            {
                row = 0;
            }

            if (col < 0)
            {
                col = GetColumns() - 1;
            }
            else if (col >= GetColumns())
            {
                col = 0;
            }

            grid[row, col] = value;
        }

        public int GetCell(int row, int col)
        {
            if (row >= 0 && row < rows && col >= 0 && col < columns)
            {
                return grid[row, col];
            }
            return -1;
        }

        public void ClearCell(int row, int col)
        {
            if (row >= 0 && row < rows && col >= 0 && col < columns)
            {
                grid[row, col] = 0;
            }
        }
    }
}
