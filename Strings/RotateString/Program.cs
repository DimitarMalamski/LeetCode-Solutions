// Problem 796. Rotate String
// Link https://leetcode.com/problems/rotate-string/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "abcde", goal = "cdeab";
    bool output = RotateString(s, goal);
    Console.WriteLine(output);
  }
  public static bool RotateString(string s, string goal)
  {
    if (s.Length != goal.Length) return false;

    string doubled = s + s;
    return doubled.Contains(goal);
  }
}