// Problem 1047. Remove All Adjacent Duplicates In String
// Link https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "abbaca";
    string output = RemoveDuplicates(s);
    Console.WriteLine(output);
  }
  public static string RemoveDuplicates(string s)
  {
    Stack<char> stack = new Stack<char>();

    foreach (char current in s)
    {
      if (stack.Count > 0 && stack.Peek() == current)
      {
        stack.Pop();
      }
      else
      {
        stack.Push(current);
      }
    }

    char[] result = stack.ToArray();
    Array.Reverse(result);

    return new string(result);
  }
}
