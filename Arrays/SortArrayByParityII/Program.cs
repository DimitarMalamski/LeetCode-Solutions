// Problem 922. Sort Array By Parity II
// Link https://leetcode.com/problems/sort-array-by-parity-ii/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 4, 2, 5, 7 };
    int[] output = SortArrayByParityII(nums);
    Console.WriteLine(string.Join(", ", output));
  }
  public static int[] SortArrayByParityII(int[] nums)
  {
    int[] result = new int[nums.Length];

    int evenIndex = 0;
    int oddIndex = 1;

    foreach (int num in nums)
    {
      if (num % 2 == 0)
      {
        result[evenIndex] = num;
        evenIndex += 2;
      }
      else
      {
        result[oddIndex] = num;
        oddIndex += 2;
      }
    }

    return result;
  }
}
