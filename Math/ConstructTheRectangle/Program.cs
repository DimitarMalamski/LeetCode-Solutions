// Problem 492. Construct the Rectangle
// Link https://leetcode.com/problems/construct-the-rectangle/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int area = 4;
    int[] output = ConstructRectangle(area);
    Console.WriteLine(string.Join(" ", output));
  }
  public static int[] ConstructRectangle(int area)
  {
    int w = (int)Math.Sqrt(area);

    while (area % w != 0)
    {
      w--;
    }

    int l = area / w;
    return [l, w];
  }
}
