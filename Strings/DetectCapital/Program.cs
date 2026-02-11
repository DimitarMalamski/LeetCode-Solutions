// Problem 520. Detect Capital
// Link https://leetcode.com/problems/detect-capital/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string word = "FlaG";
    bool output = DetectCapitalUse(word);
    Console.WriteLine(output);
  }
  public static bool DetectCapitalUse(string word)
  {
    return word == word.ToUpper() ||
          word == word.ToLower() ||
          word == char.ToUpper(word[0]) + word.Substring(1).ToLower();
  }
}
