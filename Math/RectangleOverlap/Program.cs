// Problem 836. Rectangle Overlap
// Link https://leetcode.com/problems/rectangle-overlap/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] rec1 = { 0, 0, 2, 2 }, rec2 = { 1, 1, 3, 3 };
    bool output = IsRectangleOverlap(rec1, rec2);
    Console.WriteLine(output);
  }
  public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
  {
    if (rec1[2] <= rec2[0] || rec2[2] <= rec1[0] ||
        rec1[3] <= rec2[1] || rec2[3] <= rec1[1])
    {
      return false;
    }

    return true;
  }
}
