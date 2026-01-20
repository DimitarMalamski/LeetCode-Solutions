// Problem 70. Climbing Stairs
// Link https://leetcode.com/problems/climbing-stairs/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 2;
      int output = ClimbStairs(n);
      Console.WriteLine(output);
   }
   static int ClimbStairs(int n)
   {
      if (n <= 2) return n;

      int prev2 = 1;
      int prev1 = 2;

      for (int i = 3; i <= n; i++)
      {
         int current = prev1 + prev2;
         prev2 = prev1;
         prev1 = current;
      }

      return prev1;
   }
}
