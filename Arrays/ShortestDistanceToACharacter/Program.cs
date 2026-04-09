// Problem 821. Shortest Distance to a Character
// Link https://leetcode.com/problems/shortest-distance-to-a-character/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "loveleetcode";
    char c = 'e';
    int[] output = ShortestToChar(s, c);
    Console.WriteLine(string.Join(" ", output));
  }
  public static int[] ShortestToChar(string s, char c)
  {
    int n = s.Length;
    int[] answer = new int[n];

    int prev = -n;

    for (int i = 0; i < n; i++)
    {
      if (s[i] == c)
      {
        prev = i;
      }

      answer[i] = i - prev;
    }

    prev = 2 * n;

    for (int i = n - 1; i >= 0; i--)
    {
      if (s[i] == c)
      {
        prev = i;
      }

      answer[i] = Math.Min(answer[i], prev - i);
    }

    return answer;
  }
}
