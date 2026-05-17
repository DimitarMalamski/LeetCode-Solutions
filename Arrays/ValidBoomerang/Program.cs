// Problem 1037. Valid Boomerang
// Link https://leetcode.com/problems/valid-boomerang/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] points =
    {
        new int[] { 1, 1 },
        new int[] { 2, 3 },
        new int[] { 3, 2 }
    };

    Solution solution = new Solution();

    bool output = solution.IsBoomerang(points);
    Console.WriteLine(output);
  }
  public bool IsBoomerang(int[][] points)
  {
    int x1 = points[0][0];
    int y1 = points[0][1];

    int x2 = points[1][0];
    int y2 = points[1][1];

    int x3 = points[2][0];
    int y3 = points[2][1];

    int area = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);

    return area != 0;
  }
}
