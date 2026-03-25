// Problem 748. Shortest Completing Word
// Link https://leetcode.com/problems/shortest-completing-word/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string licensePlate = "1s3 PSt";
    string[] words = { "step", "steps", "stripe", "stepple" };
    string output = ShortestCompletingWord(licensePlate, words);
    Console.WriteLine(output);
  }
  public static string ShortestCompletingWord(string licensePlate, string[] words)
  {
    int[] needed = GetLetterCount(licensePlate);
    string result = null;

    foreach (string word in words)
    {
      int[] current = GetLetterCount(word);

      if (IsCompletingWord(needed, current))
      {
        if (result == null || word.Length < result.Length) result = word;
      }
    }

    return result;
  }
  private static int[] GetLetterCount(string text)
  {
    int[] count = new int[26];

    foreach (char c in text)
    {
      if (char.IsLetter(c)) count[char.ToLower(c) - 'a']++;
    }

    return count;
  }
  private static bool IsCompletingWord(int[] needed, int[] current)
  {
    for (int i = 0; i < 26; i++)
    {
      if (current[i] < needed[i]) return false;
    }

    return true;
  }
}
