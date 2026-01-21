// Problem 231. Power of Two
// Link https://leetcode.com/problems/power-of-two/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 0;
      bool output = IsPowerOfTwo(n);
      Console.WriteLine(output);
   }
   public static bool IsPowerOfTwo(int n)
   {
      return n > 0 && (n & (n - 1)) == 0;  
   }
}
