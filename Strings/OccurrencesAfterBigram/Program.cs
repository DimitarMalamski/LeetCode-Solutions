// Problem 1078. Occurrences After Bigram
// Link https://leetcode.com/problems/occurrences-after-bigram/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string text = "alice is a good girl she is a good student", first = "a", second = "good";
    string[] output = FindOcurrences(text, first, second);
    Console.WriteLine(string.Join(",", output));
  }
  public static string[] FindOcurrences(string text, string first, string second)
  {
    string[] words = text.Split(' ');
    List<string> result = new List<string>();

    for (int i = 0; i < words.Length - 2; i++)
    {
      if (words[i] == first && words[i + 1] == second)
      {
        result.Add(words[i + 2]);
      }
    }

    return result.ToArray();
  }
}
