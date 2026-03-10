// Problem 674. Longest Continuous Increasing Subsequence
// Link https://leetcode.com/problems/longest-continuous-increasing-subsequence/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 3, 5, 4, 7 };
    int output = FindLengthOfLCIS(nums);
    Console.WriteLine(output);
  }
  public static int FindLengthOfLCIS(int[] nums)
  {
    if (nums == null || nums.Length == 0) return 0;

    int current = 1;
    int longest = 1;

    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] > nums[i - 1])
      {
        current++;
      }
      else
      {
        current = 1;
      }

      longest = Math.Max(longest, current);
    }

    return longest;
  }
}
