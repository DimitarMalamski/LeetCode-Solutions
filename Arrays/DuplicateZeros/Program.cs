// Problem 1089. Duplicate Zeros
// Link https://leetcode.com/problems/duplicate-zeros/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };
    DuplicateZeros(arr);
    Console.WriteLine(string.Join(",", arr));
  }
  public static void DuplicateZeros(int[] arr)
  {
    int[] copy = (int[])arr.Clone();

    int read = 0;
    int write = 0;

    while (write < arr.Length && read < copy.Length)
    {
      if (copy[read] == 0)
      {
        arr[write] = 0;
        write++;

        if (write < arr.Length)
        {
          arr[write] = 0;
          write++;
        }
      }
      else
      {
        arr[write] = copy[read];
        write++;
      }

      read++;
    }
  }
}
