// Problem 387. First Unique Character in a String
// Link https://leetcode.com/problems/first-unique-character-in-a-string/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "leetcode";
      int output = FirstUniqChar(s);
      Console.WriteLine(output);
   }
   public static int FirstUniqChar(string s)
   {
      int[] freq = new int[26];

      foreach (char c in s)
      {
         freq[c - 'a']++;
      }

      for (int i = 0; i < s.Length; i++)
      {
         if (freq[s[i] - 'a'] == 1)
         {
            return i;
         }
      }

      return -1;
   }
}
