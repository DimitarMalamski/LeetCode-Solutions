// Problem 1051. Height Checker
// Link https://leetcode.com/problems/height-checker/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] heights = { 1, 1, 4, 2, 1, 3 };
    int output = HeightChecker(heights);
    Console.WriteLine(output);
  }
  public static int HeightChecker(int[] heights)
  {
    int[] expected = (int[])heights.Clone();
    Array.Sort(expected);

    int count = 0;

    for (int i = 0; i < heights.Length; i++)
    {
      if (heights[i] != expected[i])
      {
        count++;
      }
    }

    return count;
  }
}
