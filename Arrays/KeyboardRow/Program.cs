// Problem 500. Keyboard Row
// Link https://leetcode.com/problems/keyboard-row/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string[] words = { "Hello", "Alaska", "Dad", "Peace" };
    string[] output = FindWords(words);
    Console.WriteLine(string.Join(",", output));
  }
  public static string[] FindWords(string[] words)
  {
    HashSet<char> row1 = new HashSet<char>("qwertyuiop");
    HashSet<char> row2 = new HashSet<char>("asdfghjkl");
    HashSet<char> row3 = new HashSet<char>("zxcvbnm");

    List<string> result = new List<string>();


    foreach (string word in words)
    {
      string lower = word.ToLower();

      HashSet<char> row;
      char firstChar = lower[0];

      if (row1.Contains(firstChar))
      {
        row = row1;
      }
      else if (row2.Contains(firstChar))
      {
        row = row2;
      }
      else
      {
        row = row3;
      }

      bool valid = true;

      foreach (char c in lower)
      {
        if (!row.Contains(c))
        {
          valid = false;
          break;
        }
      }

      if (valid)
      {
        result.Add(word);
      }
    }

    return result.ToArray();
  }
}
