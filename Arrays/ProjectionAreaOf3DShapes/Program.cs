// Problem 883. Projection Area of 3D Shapes
// Link https://leetcode.com/problems/projection-area-of-3d-shapes/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] grid = new int[][]
    {
        new int[] {1, 2},
        new int[] {3, 4}
    };

    Solution sol = new Solution();
    int result = sol.ProjectionArea(grid);

    Console.WriteLine(result);
  }
  public int ProjectionArea(int[][] grid)
  {
    int n = grid.Length;
    int area = 0;

    for (int i = 0; i < n; i++)
    {
        int rowMax = 0;
        int colMax = 0;

        for (int j = 0; j < n; j++)
        {
            if (grid[i][j] > 0)
            {
              area++;
            }

            rowMax = Math.Max(rowMax, grid[i][j]);

            colMax = Math.Max(colMax, grid[j][i]);
        }

        area += rowMax + colMax;
    }

    return area;
  }
}
