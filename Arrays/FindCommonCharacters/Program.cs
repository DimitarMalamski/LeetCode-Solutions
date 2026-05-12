// Problem 1002. Find Common Characters
// Link https://leetcode.com/problems/find-common-characters/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    string[] words = {"bella","label","roller"};
    List<string> output = CommonChars(words);
    Console.WriteLine(string.Join(",", output)); 
  }
  public static List<string> CommonChars(string[] words)
  {
    int[] commonCounts = new int[26];

    foreach (char c in words[0])
    {
      commonCounts[c - 'a']++;
    }

    for (int i = 1; i < words.Length; i++)
    {
      int[] currentCounts = new int[26];

      foreach (char c in words[i])
      {
        currentCounts[c - 'a']++;
      }

      for (int j = 0; j < 26; j++)
      {
        commonCounts[j] = Math.Min(commonCounts[j], currentCounts[j]);
      }
    }

    List<string> result = new List<string>();

    for (int i = 0; i < 26; i++)
    {
      while (commonCounts[i] > 0)
      {
        char c = (char)(i + 'a');
        result.Add(c.ToString());
        commonCounts[i]--;
      }
    }

    return result;
  }
}
