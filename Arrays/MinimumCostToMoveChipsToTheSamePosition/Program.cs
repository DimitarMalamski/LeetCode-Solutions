// Problem 1217. Minimum Cost to Move Chips to The Same Position
// Link https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] position = { 1, 2, 3 };
    int output = MinCostToMoveChips(position);
    Console.WriteLine(output);
  }
  public static int MinCostToMoveChips(int[] position)
  {
    int odd = 0;
    int even = 0;

    foreach (int pos in position)
    {
      if (pos % 2 == 0)
      {
        even++;
      }
      else
      {
        odd++;
      }
    }

    return Math.Min(odd, even);
  }
}
