// Problem 1005. Maximize Sum Of Array After K Negations
// Link https://leetcode.com/problems/maximize-sum-of-array-after-k-negations/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 4, 2, 3 };
    int k = 1;
    int output = LargestSumAfterKNegations(nums, k);
    Console.WriteLine(output);
  }
  public static int LargestSumAfterKNegations(int[] nums, int k)
  {
    Array.Sort(nums);

    for (int i = 0; i < nums.Length && k > 0; i++)
    {
      if (nums[i] < 0)
      {
        nums[i] = -nums[i];
        k--;
      }
    }

    int sum = 0;
    int minAbs = int.MaxValue;

    foreach (int num in nums)
    {
      sum += num;
      minAbs = Math.Min(minAbs, Math.Abs(num));
    }

    if (k % 2 == 1)
    {
      sum -= 2 * minAbs;
    }

    return sum;
  }
}
