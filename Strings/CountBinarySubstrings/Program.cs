// Problem 696. Count Binary Substrings
// Link https://leetcode.com/problems/count-binary-substrings/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    string s = "00110011";
    int output = CountBinarySubstrings(s);
    Console.WriteLine(output);
  }
  public static int CountBinarySubstrings(string s) {
    int prevGroup = 0;
    int currGroup = 1;
    int result = 0;

    for (int i = 1; i < s.Length; i++)
    {
      if (s[i] == s[i - 1]) {
        currGroup++;
      }
      else {
        result += Math.Min(prevGroup, currGroup);
        prevGroup = currGroup;
        currGroup = 1;
      }
    }

    result += Math.Min(prevGroup, currGroup);

    return result;
  }
}
