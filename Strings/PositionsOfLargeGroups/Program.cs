// Problem 830. Positions of Large Groups
// Link https://leetcode.com/problems/positions-of-large-groups/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "abbxxxxzzy";
    var output = LargeGroupPositions(s);
    Console.WriteLine(string.Join(",", output));
  }
  public static IList<IList<int>> LargeGroupPositions(string s)
  {
    IList<IList<int>> result = new List<IList<int>>();
    int start = 0;

    for (int i = 1; i < s.Length; i++)
    {
      if (s[i] != s[start])
      {
        if (i - start >= 3)
        {
          result.Add(new List<int> { start, i - 1 });
        }

        start = i;
      }
    }

    if (s.Length - start >= 3)
    {
      result.Add(new List<int> { start, s.Length - 1 });
    }

    return result;
  } 
}
