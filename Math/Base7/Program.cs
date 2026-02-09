// Problem 504. Base 7
// Link https://leetcode.com/problems/base-7/description/
// Difficulty: Easy
using System.Text;
class Solution
{
  static void Main(string[] args)
  {
    int num = 100;
    string output = ConvertToBase7(num);
    Console.WriteLine(output);
  }
  public static string ConvertToBase7(int num)
  {
    if (num == 0) return "0";

    bool isNegative = num < 0;
    num = Math.Abs(num);

    StringBuilder sb = new StringBuilder();

    while (num > 0)
    {
      int r = num % 7;
      sb.Append(r);
      num /= 7;
    }

    if (isNegative)
    {
      sb.Append("-");
    }

    char[] result = sb.ToString().ToCharArray();
    Array.Reverse(result);
    return new string(result);
  }
}
