// Problem 594. Longest Harmonious Subsequence
// Link https://leetcode.com/problems/longest-harmonious-subsequence/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 3, 2, 2, 5, 2, 3, 7 };
    int output = FindLHS(nums);
    Console.WriteLine(output);
  }
  public static int FindLHS(int[] nums)
  {
    Dictionary<int, int> freq = new Dictionary<int, int>();

    foreach (int num in nums)
    {
      if (freq.ContainsKey(num))
      {
        freq[num]++;
      }
      else
      {
        freq[num] = 1;
      }
    }

    int longest = 0;

    foreach (var pair in freq)
    {
      int num = pair.Key;

      if (freq.ContainsKey(num + 1))
      {
        int length = freq[num] + freq[num + 1];
        longest = Math.Max(longest, length);
      }
    }

    return longest;
  }
}