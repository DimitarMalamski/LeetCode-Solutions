// Problem 441. Arranging Coins
// Link https://leetcode.com/problems/arranging-coins/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 5;
    int output = ArrangeCoins(n);
    Console.WriteLine(output);
  }
  public static int ArrangeCoins(int n)
  {
    return (int)((Math.Sqrt(1 + 8L * n) - 1) / 2);
  }
}
