// Problem 908. Smallest Range I
// Link https://leetcode.com/problems/smallest-range-i/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    int[] nums = { 0, 10 };
    int k = 2;
    int output = SmallestRangeI(nums, k);
    Console.WriteLine(output);
  }
  public static int SmallestRangeI(int[] nums, int k) {
    int min = nums[0];
    int max = nums[0];

    for (int i = 1; i < nums.Length; i++) {
      if (nums[i] < min) {
        min = nums[i];
      }

      if (nums[i] > max) {
        max = nums[i];
      }
    }

    return Math.Max(0, max - min - 2 * k);
  }
}
