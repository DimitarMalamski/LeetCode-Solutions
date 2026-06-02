// Problem 1189. Maximum Number of Balloons
// Link https://leetcode.com/problems/maximum-number-of-balloons/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string text = "nlaebolko";
    int output = MaxNumberOfBalloons(text);
    Console.WriteLine(output);
  }
  public static int MaxNumberOfBalloons(string text)
  {
    int b = 0, a = 0, l = 0, o = 0, n = 0;

    foreach (char c in text)
    {
      if (c == 'b') b++;
      else if (c == 'a') a++;
      else if (c == 'l') l++;
      else if (c == 'o') o++;
      else if (c == 'n') n++;
    }

    return Math.Min(
      Math.Min(b, a),
      Math.Min(Math.Min(l / 2, o / 2), n)
    );
  }
}