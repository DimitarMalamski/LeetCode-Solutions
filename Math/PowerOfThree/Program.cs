// Problem 326. Power of Three
// Link https://leetcode.com/problems/power-of-three/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 27;
      bool output = IsPowerOfThree(n);
      Console.WriteLine(output);
   }
   public static bool IsPowerOfThree(int n)
   {
      return n > 0 && 1162261467 % n == 0;
   }
}
