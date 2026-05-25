// Problem 1128. Number of Equivalent Domino Pairs
// Link https://leetcode.com/problems/number-of-equivalent-domino-pairs/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] dominoes = {
      new int[] { 1,2},
      new int[] { 2,1},
      new int[] { 3,4},
      new int[] { 5,6},
    };

    int output = NumEquivDominoPairs(dominoes);
    Console.WriteLine(output);
  }
  public static int NumEquivDominoPairs(int[][] dominoes)
  {
    int[] count = new int[100];
    int result = 0;

    foreach (int[] domino in dominoes)
    {
      int a = domino[0];
      int b = domino[1];

      int min = Math.Min(a, b);
      int max = Math.Max(a, b);

      int key = min * 10 + max;

      result += count[key];

      count[key]++;
    }

    return result;
  }
}
