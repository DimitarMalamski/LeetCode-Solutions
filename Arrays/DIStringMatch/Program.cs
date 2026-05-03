// Problem 942. DI String Match
// Link https://leetcode.com/problems/di-string-match/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string s = "IDID";
    int[] output = DiStringMatch(s);
    Console.WriteLine(string.Join(", ", output));
  }
  public static int[] DiStringMatch(string s)
  {
    int n = s.Length;
    int[] result = new int[n + 1];

    int low = 0;
    int high = n;

    for (int i = 0; i < n; i++)
    {
      if (s[i] == 'I')
      {
        result[i] = low;
        low++;
      }
      else
      {
        result[i] = high;
        high--;
      }
    }

    result[n] = low;

    return result;
  }
}
