// Problem 448. Find All Numbers Disappeared in an Array
// Link https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
    List<int> output = FindDisappearedNumbers(nums);
    Console.WriteLine(string.Join(",", output));
  }
  public static List<int> FindDisappearedNumbers(int[] nums)
  {
    for (int i = 0; i < nums.Length; i++)
    {
      int index = Math.Abs(nums[i]) - 1;
      nums[index] = -Math.Abs(nums[index]);
    }

    List<int> result = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] > 0)
      {
        result.Add(i + 1);
      }
    }

    return result;
  }
}
