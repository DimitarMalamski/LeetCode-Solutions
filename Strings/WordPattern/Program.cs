// Problem 290. Word Pattern
// Link https://leetcode.com/problems/word-pattern/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string pattern = "abba";
      string s = "dog cat bla dog";
      bool output = WordPattern(pattern, s);
      Console.WriteLine(output);
   }
   public static bool WordPattern(string pattern, string s)
   {
      string[] words = s.Split(' ');

      if (pattern.Length != words.Length) return false;

      Dictionary<char, string> charToWord = new Dictionary<char, string>();
      Dictionary<string, char> wordToChar = new Dictionary<string, char>();

      for (int i = 0; i < pattern.Length; i++)
      {
         char c = pattern[i];
         string w = words[i];

         if (charToWord.ContainsKey(c))
         {
            if (charToWord[c] != w)
            {
               return false;
            }
         }
         else
         {
            charToWord[c] = w;
         }

         if (wordToChar.ContainsKey(w))
         {
            if (wordToChar[w] != c)
            {
               return false;
            }
         }
         else
         {
            wordToChar[w] = c;
         }
      }

      return true;
   }
}
