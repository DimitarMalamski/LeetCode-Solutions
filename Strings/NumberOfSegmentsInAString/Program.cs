// Problem 434. Number of Segments in a String
// Link https://leetcode.com/problems/number-of-segments-in-a-string/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "Hello, my name is John";
    int output = CountSegments(s);
    Console.WriteLine(output);
  }
  public static int CountSegments(string s)
  {
    int count = 0;

    for (int i = 0; i < s.Length; i++)
    {
      if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
      {
        count++;
      }
    }

    return count;
  }
}
