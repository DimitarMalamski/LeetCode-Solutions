// Problem 824. Goat Latin
// Link https://leetcode.com/problems/goat-latin/description/
// Difficulty: Easy
using System.Text;
class Solution
{
  static void Main(string[] args)
  {
    string sentence = "I speak Goat Latin";
    string output = ToGoatLatin(sentence);
    Console.WriteLine(output);
  }
  public static string ToGoatLatin(string sentence)
  {
    string[] words = sentence.Split(' ');
    StringBuilder result = new StringBuilder();
    string vowels = "aeiouAEIOU";

    for (int i = 0; i < words.Length; i++)
    {
      string word = words[i];
      StringBuilder current = new StringBuilder();

      if (vowels.Contains(word[0]))
      {
        current.Append(word);
      }
      else
      {
        current.Append(word.Substring(1));
        current.Append(word[0]);
      }

      current.Append("ma");
      current.Append(new string('a', i + 1));

      if (i > 0)
      {
        result.Append(' ');
      }

      result.Append(current);
    }

    return result.ToString();
  }
}
