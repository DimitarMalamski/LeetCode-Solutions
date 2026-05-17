// Problem 1030. Matrix Cells in Distance Order
// Link https://leetcode.com/problems/matrix-cells-in-distance-order/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int rows = 1, cols = 2, rCenter = 0, cCenter = 0;
    int[][] output = AllCellsDistOrder(rows, cols, rCenter, cCenter);

    foreach (int[] cell in output)
    {
      Console.WriteLine($"[{cell[0]}, {cell[1]}]");
    }
  }
  public static int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
  {
    List<int[]> cells = new List<int[]>();

    for (int r = 0; r < rows; r++)
    {
      for (int c = 0; c < cols; c++)
      {
        cells.Add(new int[] { r, c, });
      }
    }

    cells.Sort((a, b) =>
    {
      int distanceA = Math.Abs(a[0] - rCenter) + Math.Abs(a[1] - cCenter);
      int distanceB = Math.Abs(b[0] - rCenter) + Math.Abs(b[1] - cCenter);

      return distanceA.CompareTo(distanceB);
    });

    return cells.ToArray();
  }
}
