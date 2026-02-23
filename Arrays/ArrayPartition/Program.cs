// Problem 561. Array Partition
// Link https://leetcode.com/problems/array-partition/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 4, 3, 2 };
    int output = ArrayPairSum(nums);
    Console.WriteLine(output);
  }
  public static int ArrayPairSum(int[] nums)
  {
    Array.Sort(nums);

    int sum = 0;

    for (int i = 0; i < nums.Length; i += 2)
    {
      sum += nums[i];
    }

    return sum;
  }
}
