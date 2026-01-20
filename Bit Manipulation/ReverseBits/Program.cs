// Problem 190. Reverse Bits
// Link https://leetcode.com/problems/reverse-bits/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 43261596;
      int output = ReverseBits(n);
      Console.WriteLine(output);
   }
   static int ReverseBits(int n)
   {
      int result = 0;

      for (int i = 0; i < 32; i++)
      {
         int bit = n & 1;
         result = (result << 1) | bit;
         n >>= 1;
      }

      return result;
   }
}
