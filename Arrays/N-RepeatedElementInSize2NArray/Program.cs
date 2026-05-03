// Problem 961. N-Repeated Element in Size 2N Array
// Link https://leetcode.com/problems/n-repeated-element-in-size-2n-array/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 2, 3, 3 };
    int output = RepeatedNTimes(nums);
    Console.WriteLine(output);
  }
  public static int RepeatedNTimes(int[] nums)
  {
    HashSet<int> seen = new HashSet<int>();

    foreach (int num in nums)
    {
      if (seen.Contains(num))
      {
        return num;
      }

      seen.Add(num);
    }

    return -1;
  } 
}
