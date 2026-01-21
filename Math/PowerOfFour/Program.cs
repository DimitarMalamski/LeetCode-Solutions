// Problem 342. Power of Four
// Link https://leetcode.com/problems/power-of-four/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 15;
      bool output = IsPowerOfFour(n);
      Console.WriteLine(output);
   }
   public static bool IsPowerOfFour(int n)
   {
      if (n <= 0) return false;
      while (n % 4 == 0)
      {
         n /= 4;
      }

      return n == 1;
   }
}
