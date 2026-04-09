// Problem 819. Most Common Word
// Link https://leetcode.com/problems/most-common-word/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
    string[] banned = { "hit" };
    string output = MostCommonWord(paragraph, banned);
    Console.WriteLine(output);
  }
  public static string MostCommonWord(string paragraph, string[] banned)
  {
    HashSet<string> bannedWords = new HashSet<string>(banned);
    Dictionary<string, int> wordCount = new Dictionary<string, int>();

    paragraph = paragraph.ToLower();

    char[] chars = paragraph.ToCharArray();

    for (int i = 0; i < chars.Length; i++)
    {
      if (!char.IsLetter(chars[i])) chars[i] = ' ';
    }

    string[] words = new string(chars).Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string mostCommon = "";
    int maxCount = 0;

    foreach (string word in words)
    {
      if (bannedWords.Contains(word)) continue;

      if (!wordCount.ContainsKey(word)) wordCount[word] = 0;

      wordCount[word]++;

      if (wordCount[word] > maxCount)
      {
        maxCount = wordCount[word];
        mostCommon = word;
      }
    }

    return mostCommon;
  }
}
