// Problem 455. Assign Cookies
// Link https://leetcode.com/problems/assign-cookies/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] g = { 1, 2, 3 };
    int[] s = { 1, 1, };
    int output = FindContentChildren(g, s);
    Console.WriteLine(output);
  }
  public static int FindContentChildren(int[] g, int[] s)
  {
    Array.Sort(g);
    Array.Sort(s);

    int i = 0;
    int j = 0;
    int contentChildren = 0;

    while (i < g.Length && j < s.Length)
    {
      if (s[j] >= g[i])
      {
        contentChildren++;
        i++;
        j++;
      }
      else
      {
        j++;
      }
    }

    return contentChildren;
  }
}
