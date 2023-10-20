using System;
using System.Dynamic;

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
            grid = new int [rows,columns];
        }
    
    public void Clear()
    {
        Console.Clear();
    
    }

    public void DrawGrid()
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < columns; col++)
        {
            if (row == 0 || row == rows - 1 || col == 0 || col == columns - 1)
            {
        Console.Write("#");
            }
            else
            {
                int cellValue = grid[row, col];

                switch (cellValue)
                {
                    case 0: 
                        Console.Write(" ");
                        break;
                    case 1: 
                        Console.Write("■");
                        break;
                    case 2: 
                        Console.Write("F");
                        break;
                    
                }
            }
        }
        Console.WriteLine(); // Move to the next row
    }
}


    public void SetCell(int row, int col, int value)
    {
        if(row>=0 && row < rows && col >= 0 && col< columns)
        {
                grid[row,col] = value;
        }
    }

    public int GetCell(int row, int col)
    {
        if(row >= 0 && row < rows && col >= 0 && col <columns )
        {
            return grid[row,col];
        }
        return -1;
    }
   }
   
}