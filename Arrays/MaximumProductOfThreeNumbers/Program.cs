// Problem 628. Maximum Product of Three Numbers
// Link https://leetcode.com/problems/maximum-product-of-three-numbers/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 2, 3, 4 };
    int output = MaximumProduct(nums);
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
}
