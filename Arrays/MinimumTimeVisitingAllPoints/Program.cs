// Problem 1266. Minimum Time Visiting All Points
// Link https://leetcode.com/problems/minimum-time-visiting-all-points/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] points = {
      new int[] { 1,1 },
      new int[] { 3,4},
      new int[] { -1,0}
    };

    int output = MinTimeToVisitAllPoints(points);
    Console.WriteLine(output);
  }
  public static int MinTimeToVisitAllPoints(int[][] points)
  {
    int totalTime = 0;

    for (int i = 1; i < points.Length; i++)
    {
      int x1 = points[i - 1][0];
      int y1 = points[i - 1][1];

      int x2 = points[i][0];
      int y2 = points[i][1];

      int dx = Math.Abs(x2 - x1);
      int dy = Math.Abs(y2 - y1);

      totalTime += Math.Max(dx, dy);
    }

    return totalTime;
  }
}
