// Problem 414. Third Maximum Number
// Link https://leetcode.com/problems/third-maximum-number/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr = { 3, 2, 1 };
    int output = ThirdMax(arr);
    Console.WriteLine(output);
  }

  public static int ThirdMax(int[] nums)
  {
    long? max1 = null;
    long? max2 = null;
    long? max3 = null;

    foreach (int num in nums)
    {
      if (num == max1 || num == max2 || num == max3) continue;

      if (max1 == null || num > max1)
      {
        max3 = max2;
        max2 = max1;
        max1 = num;
      }
      else if (max2 == null || num > max2)
      {
        max3 = max2;
        max2 = num;
      }
      else if (max3 == null || num > max3)
      {
        max3 = num;
      }
    }

    return max3 != null ? (int)max3 : (int)max1;
  }
}
