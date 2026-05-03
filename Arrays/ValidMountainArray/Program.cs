// Problem 941. Valid Mountain Array
// Link https://leetcode.com/problems/valid-mountain-array/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr = { 2, 1 };
    bool output = ValidMountainArray(arr);
    Console.WriteLine(output);
  }
  public static bool ValidMountainArray(int[] arr)
  {
    if (arr.Length < 3)
    {
      return false;
    }

    int i = 0;

    while (i + 1 < arr.Length && arr[i] < arr[i + 1])
    {
      i++;
    }

    if (i == 0 || i == arr.Length - 1)
    {
      return false;
    }

    while (i + 1 < arr.Length && arr[i] > arr[i + 1])
    {
      i++;
    }

    return i == arr.Length - 1;
  }
}
