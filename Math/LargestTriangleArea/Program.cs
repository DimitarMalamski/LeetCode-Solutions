// Problem 812. Largest Triangle Area
// Link https://leetcode.com/problems/largest-triangle-area/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] points = new int[][]
    {
        new int[] {0, 0},
        new int[] {0, 1},
        new int[] {1, 0},
        new int[] {0, 2},
        new int[] {2, 0}
    };

    double result = LargestTriangleArea(points);

    Console.WriteLine(result);
  }
  public static double LargestTriangleArea(int[][] points)
  {
    double maxArea = 0.0;
    int n = points.Length;

    for (int i = 0; i < n; i++)
    {
      for (int j = i + 1; j < n; j++)
      {
        for (int k = j + 1; k < n; k++)
        {
          double area = GetTriangleArea(points[i], points[j], points[k]);
          maxArea = Math.Max(maxArea, area);
        }
      }
    }

    return maxArea;
  }
  public static double GetTriangleArea(int[] a, int[] b, int[] c)
  {
    return Math.Abs(
      a[0] * (b[1] - c[1]) +
      b[0] * (c[1] - a[1]) +
      c[0] * (a[1] - b[1])
    ) / 2.0;
  }
}
