using System;

namespace Max_Area_of_Island
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public class Solution
    {
      int currentMaxCount = 0;
      public int MaxAreaOfIsland(int[][] grid)
      {
        if (grid == null || grid.Length == 0) return 0;
        int maxCount = 0;
        for (int i = 0; i < grid.Length; i++)
        {
          for (int j = 0; j < grid[0].Length; j++)
          {
            if (grid[i][j] == 1)
            {
              DFS(grid, i, j, ref currentMaxCount);
              maxCount = Math.Max(maxCount, currentMaxCount);
              currentMaxCount = 0;
            }
          }
        }
        return maxCount;
      }

      private void DFS(int[][] grid, int i, int j, ref int cMaxCount)
      {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == 0)
          return;
        grid[i][j] = 0;
        cMaxCount++;
        DFS(grid, i + 1, j, ref cMaxCount);
        DFS(grid, i - 1, j, ref cMaxCount);
        DFS(grid, i, j + 1, ref cMaxCount);
        DFS(grid, i, j - 1, ref cMaxCount);
      }
    }
  }
}
