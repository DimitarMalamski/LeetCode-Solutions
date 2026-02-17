// Problem 557. Reverse Words in a String III
// Link https://leetcode.com/problems/reverse-words-in-a-string-iii/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "Let's take LeetCode contest";
    string output = ReverseWords(s);
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
}