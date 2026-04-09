// Problem 844. Backspace String Compare
// Link https://leetcode.com/problems/backspace-string-compare/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "ab#c", t = "ad#c";
    bool output = BackspaceCompare(s, t);
    Console.WriteLine(output);
  }
  public static bool BackspaceCompare(string s, string t)
  {
    int i = s.Length - 1;
    int j = t.Length - 1;

    while (i >= 0 || j >= 0)
    {
      i = GetNextValidIndex(s, i);
      j = GetNextValidIndex(t, j);

      if (i >= 0 && j >= 0)
      {
        if (s[i] != t[j]) return false;
      }
      else if (i >= 0 || j >= 0)
      {
        return false;
      }

      i--;
      j--;
    }

    return true;
  }
  private static int GetNextValidIndex(string str, int index)
  {
    int skip = 0;

    while (index >= 0)
    {
      if (str[index] == '#')
      {
          skip++;
          index--;
      }
      else if (skip > 0)
      {
          skip--;
          index--;
      }
      else
      {
          break;
      }
    }

    return index;
  }
}
