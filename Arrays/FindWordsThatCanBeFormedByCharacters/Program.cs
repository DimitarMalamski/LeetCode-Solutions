// Problem 1160. Find Words That Can Be Formed by Characters
// Link https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string[] words = { "cat", "bt", "hat", "tree" };
    string chars = "atach";
    int output = CountCharacters(words, chars);
    Console.WriteLine(output);
  }
  public static int CountCharacters(string[] words, string chars)
  {
    int[] available = new int[26];

    foreach (char c in chars)
    {
      available[c - 'a']++;
    }

    int totalLength = 0;

    foreach (string word in words)
    {
      int[] needed = new int[26];

      foreach (char c in word)
      {
        needed[c - 'a']++;
      }

      bool canForm = true;

      for (int i = 0; i < 26; i++)
      {
        if (needed[i] > available[i])
        {
          canForm = false;
          break;
        }
      }

      if (canForm)
      {
        totalLength += word.Length;
      }
    }

    return totalLength;
  } 
}
