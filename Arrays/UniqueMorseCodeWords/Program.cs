// Problem 804. Unique Morse Code Words
// Link https://leetcode.com/problems/unique-morse-code-words/description/
// Difficulty: Easy
using System.Text;
class Solution
{
  static void Main(string[] args)
  {
    string[] words = { "gin", "zen", "gig", "msg" };
    int output = UniqueMorseRepresentations(words);
    Console.WriteLine(output);
  }
  public static int UniqueMorseRepresentations(string[] words)
  {
    string[] morse = {
      ".-","-...","-.-.","-..",".","..-.","--.","....","..",
      ".---","-.-",".-..","--","-.","---",".--.","--.-",".-.",
      "...","-","..-","...-",".--","-..-","-.--","--.."
    };

    HashSet<string> transformations = new HashSet<string>();

    foreach (string word in words)
    {
      StringBuilder transformedWord = new StringBuilder();

      foreach (char c in word)
      {
        transformedWord.Append(morse[c - 'a']);
      }

      transformations.Add(transformedWord.ToString());
    }

    return transformations.Count;
  }
}
