// Problem 1025. Divisor Game
// Link https://leetcode.com/problems/divisor-game/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 2;
    bool output = DivisorGame(n);
    Console.WriteLine(output);
  }
  public static bool DivisorGame(int n)
  {
    return n % 2 == 0;
  }
}
