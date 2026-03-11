// Problem 680. Valid Palindrome II
// Link https://leetcode.com/problems/valid-palindrome-ii/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "aba";
    bool output = ValidPalindrome(s);
    Console.WriteLine(output);
  }
  public static bool ValidPalindrome(string s)
  {
    int l = 0;
    int r = s.Length - 1;

    while (l < r)
    {
      if (s[l] != s[r])
      {
        return IsPalindrome(s, l + 1, r) || IsPalindrome(s, l, r - 1);
      }

      l++;
      r--;
    }

    return true;
  }
  private static bool IsPalindrome(string s, int l, int r)
  {
    while (l < r)
    {
      if (s[l] != s[r]) return false;

      l++;
      r--;
    }

    return true;
  }
}
