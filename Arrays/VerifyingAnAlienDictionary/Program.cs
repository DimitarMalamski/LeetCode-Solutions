// Problem 953. Verifying an Alien Dictionary
// Link https://leetcode.com/problems/verifying-an-alien-dictionary/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    Solution solution = new Solution();

    string[] words1 = { "hello", "leetcode" };
    string order1 = "hlabcdefgijkmnopqrstuvwxyz";

    string[] words2 = { "word", "world", "row" };
    string order2 = "worldabcefghijkmnpqstuvxyz";

    string[] words3 = { "apple", "app" };
    string order3 = "abcdefghijklmnopqrstuvwxyz";

    Console.WriteLine(solution.IsAlienSorted(words1, order1));
    Console.WriteLine(solution.IsAlienSorted(words2, order2));
    Console.WriteLine(solution.IsAlienSorted(words3, order3));
  }
  public bool IsAlienSorted(string[] words, string order)
  {
    int[] rank = new int[26];

    for (int i = 0; i < order.Length; i++)
    {
      char c = order[i];
      rank[c - 'a'] = i;
    }

    for (int i = 0; i < words.Length - 1; i++)
    {
      if (!IsInCorrectOrder(words[i], words[i + 1], rank))
      {
        return false;
      }
    }

    return true;
  }
  private bool IsInCorrectOrder(string word1, string word2, int[] rank)
  {
    int minLength = Math.Min(word1.Length, word2.Length);

    for (int i = 0; i < minLength; i++)
    {
      char c1 = word1[i];
      char c2 = word2[i];

      if (c1 != c2)
      {
        return rank[c1 - 'a'] < rank[c2 - 'a'];
      }
    }

    return word1.Length <= word2.Length;
  }
}
