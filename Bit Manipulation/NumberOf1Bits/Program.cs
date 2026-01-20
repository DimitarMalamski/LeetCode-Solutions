// Problem 191. Number of 1 Bits
// Link https://leetcode.com/problems/number-of-1-bits/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 11;
      int output = HammingWeight(n);
      Console.WriteLine(output);
   }
   static int HammingWeight(int n)
   {
      int count = 0;

      while (n > 0)
      {
         count += (int)(n & 1);
         n >>= 1;
      }

      return count;
   }
}
