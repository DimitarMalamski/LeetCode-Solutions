// Problem 1260. Shift 2D Grid
// Link https://leetcode.com/problems/shift-2d-grid/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] grid = {
      new int[] { 1,2,3},
      new int[] { 4,5,6},
      new int[] { 7,8,9}
    };

    int k = 1;

    IList<IList<int>> output = ShiftGrid(grid, k);

    foreach (IList<int> list in output)
    {
      Console.WriteLine(string.Join(", ", list));
    }
  }
  public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
  {
    int m = grid.Length;
    int n = grid[0].Length;
    int totalCells = m * n;

    k = k % totalCells;

    int[][] result = new int[m][];

    for (int i = 0; i < m; i++)
    {
      result[i] = new int[n];
    }

    for (int row = 0; row < m; row++)
    {
      for (int col = 0; col < n; col++)
      {
        int oldIndex = row * n + col;
        int newIndex = (oldIndex + k) % totalCells;

        int newRow = newIndex / n;
        int newCol = newIndex % n;

        result[newRow][newCol] = grid[row][col];
      }
    }

    IList<IList<int>> answer = new List<IList<int>>();

    for (int i = 0; i < m; i++)
    {
      answer.Add(result[i].ToList());
    }

    return answer;
  }
}