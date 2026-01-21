// Problem 171. Excel Sheet Column Number
// Link https://leetcode.com/problems/excel-sheet-column-number/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string columnTitle = "A";
      int output = TitleToNumber(columnTitle);
      Console.WriteLine(output);
   }
   static int TitleToNumber(string columnTitle)
   {
      int result = 0;

      foreach (char c in columnTitle)
      {
         int value = c - 'A' + 1;
         result = result * 26 + value;
      }

      return result;
   }
}
