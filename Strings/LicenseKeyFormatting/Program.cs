// Problem 482. License Key Formatting
// Link https://leetcode.com/problems/license-key-formatting/description/
// Difficulty: Easy
using System.Text;
class Solution
{
  static void Main(string[] args)
  {
    string s = "5F3Z-2e-9-w";
    int k = 4;
    string output = LicenseKeyFormatting(s, k);
    Console.WriteLine(output);
  }
  public static string LicenseKeyFormatting(string s, int k)
  {
    StringBuilder sb = new StringBuilder();
    int count = 0;

    for (int i = s.Length - 1; i >= 0; i--)
    {
      char c = s[i];

      if (c == '-') continue;

      if (count == k)
      {
        sb.Append('-');
        count = 0;
      }

      sb.Append(char.ToUpper(c));
      count++;
    }

    char[] result = sb.ToString().ToCharArray();
    Array.Reverse(result);

    return new string(result);
  }
}
