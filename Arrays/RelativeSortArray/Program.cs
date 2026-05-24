// Problem 1122. Relative Sort Array
// Link https://leetcode.com/problems/relative-sort-array/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr1 = { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
    int[] arr2 = { 2, 1, 4, 3, 9, 6 };
    int[] output = RelativeSortArray(arr1, arr2);
    Console.WriteLine(string.Join(",", output));
  }
  public static int[] RelativeSortArray(int[] arr1, int[] arr2)
  {
    int[] frequency = new int[1001];

    foreach (int num in arr1)
    {
      frequency[num]++;
    }

    int index = 0;

    foreach (int num in arr2)
    {
      while (frequency[num] > 0)
      {
        arr1[index] = num;
        index++;
        frequency[num]--;
      }
    }

    for (int num = 0; num <= 1000; num++)
    {
      while (frequency[num] > 0)
      {
        arr1[index] = num;
        index++;
        frequency[num]--;
      }
    }

    return arr1;
  }
}
