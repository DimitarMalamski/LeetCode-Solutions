// Problem 521. Longest Uncommon Subsequence I
// Link https://leetcode.com/problems/longest-uncommon-subsequence-i/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string a = "aba", b = "cdc";
    int output = FindLUSlength(a, b);
    Console.WriteLine(output);
  }
  public static int FindLUSlength(string a, string b)
  {
    return a == b ? -1 : Math.Max(a.Length, b.Length);
  }
}
