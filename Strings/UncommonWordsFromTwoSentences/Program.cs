// Problem 884. Uncommon Words from Two Sentences
// Link https://leetcode.com/problems/uncommon-words-from-two-sentences/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s1 = "this apple is sweet", s2 = "this apple is sour";
    string[] output = UncommonFromSentences(s1, s2);
    Console.WriteLine(string.Join(",", output));
  }
  public static string[] UncommonFromSentences(string s1, string s2)
  {
    Dictionary<string, int> wordCount = new Dictionary<string, int>();

    string[] words1 = s1.Split(' ');
    string[] words2 = s2.Split(' ');

    foreach (string word in words1)
    {
      if (wordCount.ContainsKey(word))
        wordCount[word]++;
      else
        wordCount[word] = 1;
    }

    foreach (string word in words2)
    {
      if (wordCount.ContainsKey(word))
        wordCount[word]++;
      else
        wordCount[word] = 1;
    }

    List<string> result = new List<string>();

    foreach (var pair in wordCount)
    {
      if (pair.Value == 1)
      {
        result.Add(pair.Key);
      }
    }

    return result.ToArray();
  }
}
