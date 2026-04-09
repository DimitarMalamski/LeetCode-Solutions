// Problem 859. Buddy Strings
// Link https://leetcode.com/problems/buddy-strings/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "ab", goal = "ba";
    bool output = BuddyStrings(s, goal);
    Console.WriteLine(output);
  }
  public static bool BuddyStrings(string s, string goal)
  {
    if (s.Length != goal.Length) return false;

    if (s == goal)
    {
      HashSet<char> seen = new HashSet<char>();

      foreach (char ch in s)
      {
        if (seen.Contains(ch)) return true;
        seen.Add(ch);
      }

      return false;
    }

    List<int> diff = new List<int>();

    for (int i = 0; i < s.Length; i++)
    {
      if (s[i] != goal[i])
      {
        diff.Add(i);
      }
    }

    if (diff.Count != 2) return false;

    return s[diff[0]] == goal[diff[1]] &&
            s[diff[1]] == goal[diff[0]]; 
  }
}
