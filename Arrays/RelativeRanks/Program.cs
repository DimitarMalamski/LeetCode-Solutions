// Problem 506. Relative Ranks
// Link https://leetcode.com/problems/relative-ranks/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] score = { 5, 4, 3, 2, 1 };
    string[] output = FindRelativeRanks(score);
    Console.WriteLine(string.Join(",", output));
  }
  public static string[] FindRelativeRanks(int[] score)
  {
    int n = score.Length;

    int[] sorted = (int[])score.Clone();
    Array.Sort(sorted);
    Array.Reverse(sorted);

    Dictionary<int, string> rankMap = new Dictionary<int, string>();

    for (int i = 0; i < n; i++)
    {
      if (i == 0)
        rankMap[sorted[i]] = "Gold Medal";
      else if (i == 1)
        rankMap[sorted[i]] = "Silver Medal";
      else if (i == 2)
        rankMap[sorted[i]] = "Bronze Medal";
      else
        rankMap[sorted[i]] = (i + 1).ToString();
    }

    string[] result = new string[n];
    for (int i = 0; i < n; i++)
    {
      result[i] = rankMap[score[i]];
    }

    return result;
  }
}
