// Problem 747. Largest Number At Least Twice of Others
// Link https://leetcode.com/problems/largest-number-at-least-twice-of-others/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 3, 6, 1, 0 };
    int output = DominantIndex(nums);
    Console.WriteLine(output);
  }
  public static int DominantIndex(int[] nums)
  {
    int maxNum = -1;
    int secondMax = -1;
    int maxIndex = -1;

    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] > maxNum)
      {
        secondMax = maxNum;
        maxNum = nums[i];
        maxIndex = i;
      }
      else if (nums[i] > secondMax)
      {
        secondMax = nums[i];
      }
    }

    return maxNum >= 2 * secondMax ? maxIndex : -1;
  }
}
