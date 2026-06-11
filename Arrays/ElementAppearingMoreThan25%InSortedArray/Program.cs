// Problem 1287. Element Appearing More Than 25% In Sorted Array
// Link https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr = { 1, 2, 2, 6, 6, 6, 6, 7, 10 };
    int output = FindSpecialInteger(arr);
    Console.WriteLine(output);
  }
  public static int FindSpecialInteger(int[] arr)
  {
    int count = 1;
    int limit = arr.Length / 4;

    for (int i = 1; i < arr.Length; i++)
    {
      if (arr[i] == arr[i - 1])
      {
        count++;
      }
      else
      {
        count = 1;
      }

      if (count > limit) return arr[i];
    }

    return arr[0];
  }
}
