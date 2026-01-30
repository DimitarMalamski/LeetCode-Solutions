// Problem 463. Island Perimeter
// Link https://leetcode.com/problems/island-perimeter/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] grid = [[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]];
    int output = IslandPerimeter(grid);
    Console.WriteLine(output);
  }
  public static int IslandPerimeter(int[][] grid)
  {
    int rows = grid.Length;
    int cols = grid[0].Length;
    int perimeter = 0;

    for (int r = 0; r < rows; r++)
    {
      for (int c = 0; c < cols; c++)
      {
        if (grid[r][c] == 1)
        {
          if (r == 0 || grid[r - 1][c] == 0)
          {
            perimeter++;
          }

          if (r == rows - 1 || grid[r + 1][c] == 0)
          {
            perimeter++;
          }

          if (c == 0 || grid[r][c - 1] == 0)
          {
            perimeter++;
          }

          if (c == cols - 1 || grid[r][c + 1] == 0)
          {
            perimeter++;
          }
        }
      }
    }

    return perimeter;
  } 
}
