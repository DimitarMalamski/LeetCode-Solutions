// Problem 806. Number of Lines To Write String
// Link https://leetcode.com/problems/number-of-lines-to-write-string/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] widths = {
      10,10,10,10,10,10,10,10,10,10,10,10,10,
      10,10,10,10,10,10,10,10,10,10,10,10,10
    };
    string s = "abcdefghijklmnopqrstuvwxyz";

    int[] result = NumberOfLines(widths, s);

    Console.WriteLine($"[{result[0]}, {result[1]}]");
  }
  public static int[] NumberOfLines(int[] widths, string s)
  {
    int lines = 1;
    int currentWidth = 0;

    foreach (char c in s)
    {
        int charWidth = widths[c - 'a'];

        if (currentWidth + charWidth > 100)
        {
            lines++;
            currentWidth = charWidth;
        }
        else
        {
            currentWidth += charWidth;
        }
    }

    return [lines, currentWidth];
  }
}
