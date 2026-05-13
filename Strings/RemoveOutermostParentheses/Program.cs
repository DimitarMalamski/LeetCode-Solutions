// Problem 1021. Remove Outermost Parentheses
// Link https://leetcode.com/problems/remove-outermost-parentheses/description/
// Difficulty: Easy
using System.Text;
class Solution
{
  static void Main(string[] args)
  {
    string s = "(()())(())";
    string output = RemoveOuterParentheses(s);
    Console.WriteLine(output);
  }
  public static string RemoveOuterParentheses(string s)
  {
    int depth = 0;
    StringBuilder result = new StringBuilder();

    foreach (char c in s)
    {
      if (c == '(')
      {
        if (depth > 0)
        {
          result.Append(c);
        }

        depth++;
      }
      else
      {
        depth--;

        if (depth > 0)
        {
          result.Append(c);
        }
      }
    }

    return result.ToString();
  }
}
