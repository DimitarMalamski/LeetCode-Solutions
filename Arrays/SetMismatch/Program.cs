// Problem 645. Set Mismatch
// Link https://leetcode.com/problems/set-mismatch/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 2, 2, 4 };
    int[] output = FindErrorNums(nums);
    Console.WriteLine(string.Join(",", output));
  }
  public static int[] FindErrorNums(int[] nums)
  {
    int n = nums.Length;
    int[] count = new int[n + 1];

    foreach (int num in nums)
    {
      count[num]++;
    }

    int duplicate = -1;
    int missing = -1;

    for (int i = 1; i <= n; i++)
    {
      if (count[i] == 2) duplicate = i;
      if (count[i] == 0) missing = i;
    }

    return [duplicate, missing];
  } 
}
