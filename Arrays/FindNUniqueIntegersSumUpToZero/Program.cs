// Problem 1304. Find N Unique Integers Sum up to Zero
// Link https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 5;
    int[] output = SumZero(n);
    Console.WriteLine(string.Join(", ", output));
  }
  public static int[] SumZero(int n)
  {
    int[] result = new int[n];
    int index = 0;

    for (int i = 1; i <= n / 2; i++)
    {
      result[index] = i;
      index++;

      result[index] = -i;
      index++;
    }

    if (n % 2 == 1)
    {
      result[index] = 0;
    }

    return result;
  }
}
