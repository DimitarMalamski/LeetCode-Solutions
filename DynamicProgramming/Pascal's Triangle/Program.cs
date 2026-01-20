// Problem 118. Pascal's Triangle
// Link https://leetcode.com/problems/pascals-triangle/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int numRows = 5;
      List<IList<int>> output = Generate(numRows);
      PrintTriangle(output);
   }  

   public static List<IList<int>> Generate(int numRows)
   {
      var result = new List<IList<int>>();

      for (int i = 0; i < numRows; i++)
      {
         var row = new List<int>();
         row.Add(1);

         for (int j = 1; j < i; j++)
         {
            int value = result[i - 1][j - 1] + result[i - 1][j];
            row.Add(value);
         }

         if (i > 0)
         {
            row.Add(1);
         }

         result.Add(row);
      }

      return result;
   }

   static void PrintTriangle(IList<IList<int>> triangle)
   {
      foreach (var row in triangle)
      {
        Console.Write("[");
        Console.Write(string.Join(", ", row));
        Console.WriteLine("]");
      }
   }
}
