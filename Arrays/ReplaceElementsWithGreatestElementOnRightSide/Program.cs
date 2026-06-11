// Problem 1299. Replace Elements with Greatest Element on Right Side
// Link https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr = { 17, 18, 5, 4, 6, 1 };
    int[] output = ReplaceElements(arr);
    Console.WriteLine(string.Join(", ", output));
  }
  public static int[] ReplaceElements(int[] arr)
  {
    int greatestRight = -1;

    for (int i = arr.Length - 1; i >= 0; i--)
    {
      int current = arr[i];

      arr[i] = greatestRight;

      if (current > greatestRight)
      {
        greatestRight = current;
      }
    }

    return arr;
  }
}