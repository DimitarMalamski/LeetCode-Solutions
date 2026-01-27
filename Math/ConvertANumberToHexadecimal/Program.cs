// Problem 404. Convert a Number to Hexadecimal
// Link https://leetcode.com/problems/convert-a-number-to-hexadecimal/description/
// Difficulty: Easy

using System.Text;
class Solution
{
  static void Main(string[] args)
  {
    int num = 26;
    string output = ToHex(num);
    Console.WriteLine(output);
  }

  public static string ToHex(int num)
  {
    if (num == 0) return "0";

    const string hex = "0123456789abcdef";
    StringBuilder sb = new StringBuilder();

    uint n = (uint)num;

    while (n > 0)
    {
      sb.Append(hex[(int)(n % 16)]);
      n /= 16;
    }

    char[] arr = sb.ToString().ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
  }
}
