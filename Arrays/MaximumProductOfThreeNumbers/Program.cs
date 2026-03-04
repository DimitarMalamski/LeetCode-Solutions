// Problem 628. Maximum Product of Three Numbers
// Link https://leetcode.com/problems/maximum-product-of-three-numbers/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 2, 3, 4 };
    int output = MaximumProductOptimized(nums);
    Console.WriteLine(output);
  }
  public static int MaximumProduct(int[] nums)
  {
    Array.Sort(nums);

    int n = nums.Length;

    int optionOne = nums[n - 1] * nums[n - 2] * nums[n - 3];
    int optionTwo = nums[0] * nums[1] * nums[n - 1];

    return Math.Max(optionOne, optionTwo);
  }
  public static int MaximumProductOptimized(int[] nums)
  {
    int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;
    int min1 = int.MaxValue, min2 = int.MaxValue;

    foreach (int n in nums)
    {
      if (n > max1)
      {
        max3 = max2;
        max2 = max1;
        max1 = n;
      }
      else if (n > max2)
      {
        max3 = max2;
        max2 = n;
      }
      else if (n > max3)
      {
        max3 = n;
      }

      if (n < min1)
      {
        min2 = min1;
        min1 = n;
      }
      else if (n < min2)
      {
        min2 = n;
      }
    }

    return Math.Max(max1 * max2 * max3, max1 * min1 * min2);
  }
}
