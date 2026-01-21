// Problem 338. Counting Bits
// Link https://leetcode.com/problems/counting-bits/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 2;
      int[] output = CountBits(n);
      Console.WriteLine(string.Join(",", output));
   }
   public static int[] CountBits(int n)
   {
      int[] result = new int[n + 1];

      for (int i = 1; i <= n; i++)
      {
         result[i] = result[i >> 1] + (i & 1);
      }

      return result;
   }
}
