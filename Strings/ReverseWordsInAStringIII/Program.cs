// Problem 557. Reverse Words in a String III
// Link https://leetcode.com/problems/reverse-words-in-a-string-iii/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "Let's take LeetCode contest";
    string output = OptimizedReverseWords(s);
    Console.WriteLine(output);
  }
  public static string ReverseWords(string s)
  {
    string[] words = s.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
      char[] chars = words[i].ToCharArray();
      Array.Reverse(chars);
      words[i] = new string(chars);
    }

    return string.Join(" ", words);
  }
  public static string OptimizedReverseWords(string s)
  {
    char[] chars = s.ToCharArray();
    int left = 0;

    for (int right = 0; right <= chars.Length; right++)
    {
      if (right == chars.Length || chars[right] == ' ')
      {
        Reverse(chars, left, right - 1);
        left = right + 1;
      }
    }

    return new string(chars);
  }
  private static void Reverse(char[] chars, int l, int r) {
    while (l < r)
    {
      char temp = chars[l];
      chars[l] = chars[r];
      chars[r] = temp;
      l++;
      r--;
    }
  }
}