using System;

namespace Day17NumberOfIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] grid = new char[4][];
            grid[0] = new char[5] { '1', '1', '1', '1', '0' };
            grid[1] = new char[5] { '0', '0', '0', '0', '0' };
            grid[2] = new char[5] { '0', '0', '1', '0', '0' };
            grid[3] = new char[5] { '0', '0', '0', '1', '1' };

            int numOfIslands = NumIslands(grid);
            Console.WriteLine(numOfIslands);
        }
        public static int NumIslands(char[][] grid)
        {
            int numIslands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if( grid[i][j] == '1')
                    {
                        numIslands++;
                        dfs(grid, i, j);

                    }
                    
                }

            }
            return numIslands;

        }
        public static void dfs(char[][] grid, int row, int column)
        {
            if (row < 0 || row > grid.Length - 1 || column < 0 || column > grid[row].Length - 1 || grid[row][column] =='0')
            {
                return;
            }
            grid[row][column] = '0';
            dfs(grid, row, column - 1);
            dfs(grid, row - 1, column);
            dfs(grid, row + 1, column);
            dfs(grid, row, column + 1);
        }
    }
}
