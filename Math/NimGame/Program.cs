// Problem 292. Nim Game
// Link https://leetcode.com/problems/nim-game/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 4;
      bool output = CanWinNim(n);
      Console.WriteLine(output);
   }
   public static bool CanWinNim(int n)
   {
      return n % 4 != 0;
   }
}
