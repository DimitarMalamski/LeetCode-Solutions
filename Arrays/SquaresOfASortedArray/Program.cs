// Problem 977. Squares of a Sorted Array
// Link https://leetcode.com/problems/squares-of-a-sorted-array/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { -4, -1, 0, 3, 10 };
    int[] output = SortedSquares(nums);
    Console.WriteLine(string.Join(", ", output));
  }
  public static int[] SortedSquares(int[] nums)
  {
    int n = nums.Length;
    int[] result = new int[n];

    int left = 0;
    int right = n - 1;
    int position = n - 1;

    while (left <= right)
    {
      int leftSquare = nums[left] * nums[left];
      int rightSquare = nums[right] * nums[right];

      if (leftSquare > rightSquare)
      {
        result[position] = leftSquare;
        left++;
      }
      else
      {
        result[position] = rightSquare;
        right--;
      }

      position--;
    }

    return result;
  }
}
