// Problem 1013. Partition Array Into Three Parts With Equal Sum
// Link https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr = { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 };
    bool output = CanThreePartsEqualSum(arr);
    Console.WriteLine(output);
  }
  public static bool CanThreePartsEqualSum(int[] arr)
  {
    int totalSum = 0;

    foreach (int num in arr)
    {
      totalSum += num;
    }

    if (totalSum % 3 != 0) return false;

    int target = totalSum / 3;
    int currentSum = 0;
    int parts = 0;

    foreach (int num in arr)
    {
      currentSum += num;

      if (currentSum == target)
      {
        parts++;
        currentSum = 0;
      }
    }

    return parts >= 3;
  }
}
