// Problem 892. Surface Area of 3D Shapes
// Link https://leetcode.com/problems/surface-area-of-3d-shapes/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] grid = new int[][]
    {
      new int[] { 1, 2 },
      new int[] { 3, 4 }
    };

    Solution sol = new Solution();
    int output = sol.SurfaceArea(grid);
    Console.WriteLine(output);
  }
  public int SurfaceArea(int[][] grid)
  {
    int n = grid.Length;
    int surfaceArea = 0;

    for (int i = 0; i < n; i++)
    {
      for (int j = 0; j < n; j++)
      {
        int h = grid[i][j];

        if (h == 0) continue;

        surfaceArea += 2;

        surfaceArea += 4 * h;

        if (i > 0)
        {
          surfaceArea -= 2 * Math.Min(h, grid[i - 1][j]);
        }

        if (j > 0)
        {
          surfaceArea -= 2 * Math.Min(h, grid[i][j - 1]);
        }
      }
    }
    return surfaceArea;
  }
}