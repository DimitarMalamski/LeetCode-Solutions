// Problem 905. Sort Array By Parity
// Link https://leetcode.com/problems/sort-array-by-parity/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    int[] nums = {3,1,2,4};
    int[] output = SortArrayByParity(nums);
    Console.WriteLine(string.Join(", ", output));
  }

  public static int[] SortArrayByParity(int[] nums) {
    int[] result = new int[nums.Length];
    int index = 0;

    for (int i = 0; i < nums.Length; i++) {
      if (nums[i] % 2 == 0) {
        result[index] = nums[i];
        index++;
      }
    }

    for (int i = 0; i < nums.Length; i++) {
      if (nums[i] % 2 != 0) {
        result[index] = nums[i];
        index++;
      }
    }

    return result;
  }
}
