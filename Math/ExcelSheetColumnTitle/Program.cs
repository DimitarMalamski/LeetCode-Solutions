// Problem 168. Excel Sheet Column Title
// Link https://leetcode.com/problems/excel-sheet-column-title/description/
// Difficulty: Easy

using System.Text;
class Solution
{
   static void Main(string[] args)
   {
      int columnNumber = 28;
      string output = ConvertToTitle(columnNumber);
      Console.WriteLine(output);
   }
   static string ConvertToTitle(int columnNumber)
   {
      StringBuilder result = new StringBuilder();

      while (columnNumber > 0)
      {
         columnNumber--;
         int remainder = columnNumber % 26;
         char letter = (char)('A' + remainder);
         result.Append(letter);
         columnNumber /= 26;
      }

      return new string(result.ToString().Reverse().ToArray());
   }
}
